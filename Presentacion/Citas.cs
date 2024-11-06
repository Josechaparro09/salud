using Datos;
using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui
{
    
    public partial class Citas : Form
    {
        private PacienteBLL _pacienteBLL;
        private HistoriaClinicaBLL _historiaClinicaBLL;
        private EspecialidadBLL _especialidadBLL;
        private DoctorBLL _doctorBLL;
        private CitaBLL _citaBLL;
        private Paciente _pacienteSeleccionado;
        private int? _idPaciente;
        private Doctor doctorActual;
        private Usuario usuarioActual;
        private Paciente _pacienteActual;
        private Cita citaActual;
        private bool ver;
        public Citas(Paciente paciente, string role, Usuario usuario)
        {
            InitializeComponent();
            _pacienteBLL = new PacienteBLL();
            _especialidadBLL = new EspecialidadBLL();
            _doctorBLL = new DoctorBLL();
            _citaBLL = new CitaBLL();
            _historiaClinicaBLL = new HistoriaClinicaBLL();
            usuarioActual = usuario;
            _pacienteActual = paciente;
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;

            ConfigurarDataGridViewDoctor();  
            ConfigurarDataGridView();
            ConfigurarDataGridViewCita();

            if (usuario.Rol.IdRol==2)
            {
                ObtenerDoctor();
                CargarCitasDoctor();
            }
            CargarEspecialidades();
            ConfigurarControles();
            ConfigurarEventosValidacion();

            CargarCitas();
            

            if (paciente != null)
            {
                _idPaciente = paciente.IdPaciente;
            }

            if (role == "paciente")
            {
                tbpCitas.SelectedIndex = 6;
                CargarCitasPaciente(_idPaciente);
            }
            else if (role == "doctor")
            {
                tbpCitas.SelectedIndex = 4;
            }
            else
            {
                tbpCitas.SelectedIndex = 0;
            }
        }
        private void ObtenerDoctor()
        {
            doctorActual=_doctorBLL.ObtenerDoctorPorIdUsuario(usuarioActual.IdUsuario);
            
        }
        public void modoVistaHistoriaClinica()
        {
            var historiaClinica = _historiaClinicaBLL.ObtenerHistoriaClinicaPorIdCita(citaActual.IdCita);
            
            txtDiagnostico.Text=historiaClinica.Diagnostico;
            txtTratamiento.Text=historiaClinica.Tratamiento;
            txtNotasAdicionales.Text=historiaClinica.NotasAdicionales;
            txtDiagnostico.ReadOnly=true;
            txtTratamiento.ReadOnly = true;
            txtNotasAdicionales.ReadOnly=true;

            btnGuardarHistoria.Visible = false;
            tbpCitas.SelectedIndex = 5;
            txtCedulaCita.Text = _pacienteActual.Cedula;
            txtDireccionCita.Text = historiaClinica.Paciente.Direccion;
            txtTelefonoCita.Text = historiaClinica.Paciente.Telefono;
            txtNombreCita.Text = historiaClinica.Paciente.Nombre;
        }

        private void ConfigurarControles()
        {
            txtBuscarCita.Clear();
            dtpFecha.MinDate = DateTime.Today;
            dtpFecha.MaxDate = DateTime.Today.AddMonths(3);

            cbxEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxHorario.DropDownStyle = ComboBoxStyle.DropDownList;

            cbxEspecialidad.Enabled = false;
            cbxDoctor.Enabled = false;
            dtpFecha.Enabled = false;
            cbxHorario.Enabled = false;
        }
        private void FiltrarCitas()
        {
            try
            {
                string filtro = txtBuscarCita.Text.Trim().ToLower();
                var todasLasCitas = _citaBLL.ObtenerCitas();

                var citasFiltradas = todasLasCitas.Where(c =>
                    c.Paciente != null && 
                    (
                        (!string.IsNullOrEmpty(c.Paciente.Nombre) &&
                         !string.IsNullOrEmpty(c.Paciente.Apellido) &&
                         (c.Paciente.Nombre + " " + c.Paciente.Apellido).ToLower().Contains(filtro)) ||
                        (!string.IsNullOrEmpty(c.Paciente.Cedula) &&
                         c.Paciente.Cedula.ToLower().Contains(filtro))
                    )
                ).ToList();

                dtgCitas.Rows.Clear();

                foreach (var cita in citasFiltradas)
                {
                    string nombreCompleto = cita.Paciente != null ?
                        $"{cita.Paciente.Nombre ?? ""} {cita.Paciente.Apellido ?? ""}".Trim() : "";

                    string cedula = cita.Paciente?.Cedula ?? "";

                    string nombreDoctor = cita.Doctor != null ?
                        cita.Doctor.Nombre ?? "" : "";

                    string especialidad = cita.Doctor?.Especialidad?.NombreEspecialidad ?? "";

                    dtgCitas.Rows.Add(
                        cita.FechaCita.ToShortDateString(),
                        cita.HoraCita.ToString(@"hh\:mm"),
                        nombreCompleto,
                        cedula,
                        nombreDoctor,
                        especialidad,
                        cita.Estado ?? "Pendiente"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar las citas: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarEspecialidades()
        {
            try
            {
                var especialidades = _especialidadBLL.ObtenerEspecialidades();

                foreach (var esp in especialidades)
                {
                    Console.WriteLine($"Especialidad: ID={esp.IdEspecialidad}, Nombre={esp.NombreEspecialidad}");
                }

                cbxEspecialidad.DisplayMember = "NombreEspecialidad";
                cbxEspecialidad.ValueMember = "IdEspecialidad";
                cbxEspecialidad.DataSource = especialidades;
                cbxEspecialidad.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar especialidades: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_agregar_citas_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();

            tbpCitas.SelectedIndex = 1;
        }
        private void CargarHorariosDisponibles()
        {
            if (cbxDoctor.SelectedValue != null)
            {
                int idDoctor = (int)cbxDoctor.SelectedValue;
                var horarios = _citaBLL.ObtenerHorariosDisponibles(idDoctor, dtpFecha.Value);
                cbxHorario.DataSource = horarios;
            }
        }
        private void cbxEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(cbxEspecialidad, "");

            if (cbxEspecialidad.SelectedItem == null || cbxEspecialidad.SelectedIndex == -1)
            {
                cbxDoctor.DataSource = null;
                cbxDoctor.Enabled = false;
                return;
            }

            try
            {
                var especialidad = cbxEspecialidad.SelectedItem as Especialidad;
                if (especialidad == null || !especialidad.IdEspecialidad.HasValue)
                {
                    errorProvider.SetError(cbxEspecialidad, "Especialidad no válida");
                    return;
                }

                var idEspecialidad = especialidad.IdEspecialidad.Value;
                var doctores = _doctorBLL.ObtenerDoctoresPorEspecialidad(idEspecialidad);

                Console.WriteLine($"Especialidad seleccionada: ID={idEspecialidad}, Nombre={especialidad.NombreEspecialidad}");
                Console.WriteLine($"Doctores encontrados: {doctores.Count}");

                if (doctores.Count == 0)
                {
                    errorProvider.SetError(cbxEspecialidad, "No hay doctores disponibles para esta especialidad");
                    cbxDoctor.DataSource = null;
                    cbxDoctor.Enabled = false;
                    return;
                }

                cbxDoctor.DataSource = null;
                cbxDoctor.DisplayMember = "Nombre";
                cbxDoctor.ValueMember = "IdDoctor";
                cbxDoctor.DataSource = doctores;
                cbxDoctor.SelectedIndex = -1;
                cbxDoctor.Enabled = true;
                dtpFecha.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error detallado: {ex}");
                errorProvider.SetError(cbxEspecialidad, "Error al cargar doctores");
                MessageBox.Show($"Error al cargar doctores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarFormularioCompleto()
        {
            errorProvider.Clear();
            bool esValido = true;

            if (_pacienteSeleccionado == null)
            {
                errorProvider.SetError(txtBuscarPaciente, "Debe seleccionar un paciente");
                esValido = false;
            }

            if (cbxEspecialidad.SelectedIndex == -1)
            {
                errorProvider.SetError(cbxEspecialidad, "Debe seleccionar una especialidad");
                esValido = false;
            }

            if (cbxDoctor.SelectedIndex == -1)
            {
                errorProvider.SetError(cbxDoctor, "Debe seleccionar un doctor");
                esValido = false;
            }

            if (dtpFecha.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                errorProvider.SetError(dtpFecha, "No se pueden agendar citas los domingos");
                esValido = false;
            }

            if (cbxHorario.SelectedIndex == -1)
            {
                errorProvider.SetError(cbxHorario, "Debe seleccionar un horario");
                esValido = false;
            }

            return esValido;
        }
        private void ValidarHorario(object sender, CancelEventArgs e)
        {
            if (cbxHorario.Enabled && cbxHorario.SelectedIndex == -1)
            {
                errorProvider.SetError(cbxHorario, "Debe seleccionar un horario");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cbxHorario, "");
            }
        }
        private void ValidarDoctor(object sender, CancelEventArgs e)
        {
            if (cbxDoctor.Enabled && cbxDoctor.SelectedIndex == -1)
            {
                errorProvider.SetError(cbxDoctor, "Debe seleccionar un doctor");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cbxDoctor, "");
            }
        }

        private void ValidarFecha(object sender, CancelEventArgs e)
        {
            if (dtpFecha.Enabled)
            {
                if (dtpFecha.Value.Date < DateTime.Today)
                {
                    errorProvider.SetError(dtpFecha, "No se pueden seleccionar fechas pasadas");
                    e.Cancel = true;
                }
                else if (dtpFecha.Value.DayOfWeek == DayOfWeek.Sunday)
                {
                    errorProvider.SetError(dtpFecha, "No se pueden agendar citas los domingos");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(dtpFecha, "");
                }
            }
        }
        private void ConfigurarEventosValidacion()
        {
            txtBuscarPaciente.Validating += ValidarBusqueda;
            cbxEspecialidad.Validating += ValidarEspecialidad;
            cbxDoctor.Validating += ValidarDoctor;
            dtpFecha.Validating += ValidarFecha;
            cbxHorario.Validating += ValidarHorario;

            txtDiagnostico.Validating += (s, e) =>
            {
                if (!string.IsNullOrWhiteSpace(txtDiagnostico.Text))
                {
                    errorProvider.SetError(txtDiagnostico, "");
                }
            };

            txtTratamiento.Validating += (s, e) =>
            {
                if (!string.IsNullOrWhiteSpace(txtTratamiento.Text))
                {
                    errorProvider.SetError(txtTratamiento, "");
                }
            };
        }

        private void ValidarBusqueda(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarPaciente.Text))
            {
                errorProvider.SetError(txtBuscarPaciente, "Ingrese un criterio de búsqueda");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtBuscarPaciente, "");
            }
        }

        private void ValidarEspecialidad(object sender, CancelEventArgs e)
        {
            if (cbxEspecialidad.Enabled && cbxEspecialidad.SelectedIndex == -1)
            {
                errorProvider.SetError(cbxEspecialidad, "Debe seleccionar una especialidad");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cbxEspecialidad, "");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            try
            {
                var pacientes = _pacienteBLL.BuscarPacientes(txtBuscarPaciente.Text);

                if (pacientes.Count == 0)
                {
                    errorProvider.SetError(txtBuscarPaciente, "No se encontraron pacientes");
                    return;
                }

                if (pacientes.Count == 1)
                {
                    _pacienteSeleccionado = pacientes[0];
                    MostrarDatosPaciente(_pacienteSeleccionado);
                }
                else
                {
                    MessageBox.Show("Se encontraron múltiples pacientes. Por favor, sea más específico en la búsqueda.",
                        "Múltiples resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe seleccionar un paciente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbxEspecialidad.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una especialidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbxDoctor.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un doctor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbxHorario.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un horario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void MostrarDatosPaciente(Paciente paciente)
        {
            if (usuarioActual.Rol.NombreRol=="paciente")
            {
                lblBuscar.Visible = false;
                txtBuscarPaciente.Visible = false;
                btnBuscar.Visible = false;
            }
            else
            {
                lblBuscar.Visible = true;
                txtBuscarPaciente.Visible = true;
                btnBuscar.Visible = true;
            }
            txtCedula.Text = paciente.Cedula;
            txtNombre.Text = $"{paciente.Nombre} {paciente.Apellido}";
            txtTelefono.Text = paciente.Telefono;
            txtDireccion.Text = paciente.Direccion;

            cbxEspecialidad.Enabled = true;
        }
        private void LimpiarFormulario()
        {
            errorProvider.Clear();
            _pacienteSeleccionado = null;
            txtBuscarPaciente.Clear();
            txtCedula.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();

            cbxEspecialidad.DataSource = null;
            cbxDoctor.DataSource = null;
            cbxHorario.DataSource = null;

            CargarEspecialidades();

            dtpFecha.Value = DateTime.Today;

            cbxEspecialidad.Enabled = false;
            cbxDoctor.Enabled = false;
            dtpFecha.Enabled = false;
            cbxHorario.Enabled = false;
        }

        private void RegistrarCita()
        {
            try
            {
                if (!ValidarCampos()) return;
                if (usuarioActual.Rol.IdRol==21)
                {
                    _pacienteSeleccionado = _pacienteActual;
                }
                var cita = new Cita
                {
                    PacienteId = _pacienteSeleccionado.IdPaciente,
                    DoctorId = (int)cbxDoctor.SelectedValue,
                    FechaCita = dtpFecha.Value,
                    HoraCita = (TimeSpan)cbxHorario.SelectedItem,
                    Estado = "Pendiente",
                    Paciente = _pacienteActual
                };

                var resultado = _citaBLL.RegistrarCita(cita);
                MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnApartar_Click(object sender, EventArgs e)
        {
            RegistrarCita();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
             if (cbxDoctor.SelectedIndex == -1) return;

        try
        {
            if (dtpFecha.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("No se pueden agendar citas los domingos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var idDoctor = (int)cbxDoctor.SelectedValue;
            var horariosDisponibles = _citaBLL.ObtenerHorariosDisponibles(idDoctor, dtpFecha.Value);
            
            cbxHorario.DataSource = horariosDisponibles;
            cbxHorario.Enabled = true;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al cargar horarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        }
        private void ConfigurarDataGridView()
        {
            dtgCitas.AutoGenerateColumns = false;
            dtgCitas.AllowUserToAddRows = false;
            dtgCitas.AllowUserToDeleteRows = false;
            dtgCitas.ReadOnly = true;
            dtgCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCitas.MultiSelect = false;

            dtgCitas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FechaCita",
                HeaderText = "Fecha",
                DataPropertyName = "FechaCita"
            });

            dtgCitas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "HoraCita",
                HeaderText = "Hora",
                DataPropertyName = "HoraCita"
            });

            dtgCitas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Paciente",
                HeaderText = "Paciente",
                DataPropertyName = "NombrePaciente"
            });

            dtgCitas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cedula",
                HeaderText = "Cédula",
                DataPropertyName = "CedulaPaciente"
            });

            dtgCitas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Doctor",
                HeaderText = "Doctor",
                DataPropertyName = "NombreDoctor"
            });

            dtgCitas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Especialidad",
                HeaderText = "Especialidad",
                DataPropertyName = "NombreEspecialidad"
            });

            dtgCitas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Estado",
                HeaderText = "Estado",
                DataPropertyName = "Estado"
            });
        }
        private void CargarCitas()
        {
            try
            {
                var citas = _citaBLL.ObtenerCitas();
                dtgCitas.Rows.Clear();

                foreach (var cita in citas)
                {
                    dtgCitas.Rows.Add(
                        cita.FechaCita.ToShortDateString(),
                        cita.HoraCita.ToString(@"hh\:mm"),
                        $"{cita.Paciente.Nombre} {cita.Paciente.Apellido}",
                        cita.Paciente.Cedula,
                        cita.Doctor.Nombre,
                        cita.Doctor.Especialidad.NombreEspecialidad,
                        cita.Estado
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las citas: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DtgCitas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dtgCitas.Rows[e.RowIndex];
            string estado = row.Cells["Estado"].Value?.ToString();

            switch (estado?.ToLower())
            {
                case "pendiente":
                    row.DefaultCellStyle.BackColor = Color.LightYellow;
                    break;
                case "completada":
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                    break;
                case "cancelada":
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                    break;
            }
        }

        private void dtgCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        

        private void dtgCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscarCita_TextChanged(object sender, EventArgs e)
        {
            FiltrarCitas();
        }
        private void ConfigurarDataGridViewCita()
        {
            dtgCitasPaciente.AutoGenerateColumns = false;
            dtgCitasPaciente.AllowUserToAddRows = false;
            dtgCitasPaciente.Columns.Clear();

            dtgCitasPaciente.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FechaCita",
                HeaderText = "Fecha",
                Width = 100
            });

            dtgCitasPaciente.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "HoraCita",
                HeaderText = "Hora",
                Width = 80
            });

            dtgCitasPaciente.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Doctor",
                HeaderText = "Doctor",
                Width = 150
            });

            dtgCitasPaciente.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Especialidad",
                HeaderText = "Especialidad",
                Width = 150
            });

            dtgCitasPaciente.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Estado",
                HeaderText = "Estado",
                Width = 100
            });

            DataGridViewButtonColumn btnCancelar = new DataGridViewButtonColumn
            {
                Name = "Cancelar",
                HeaderText = "Acción",
                UseColumnTextForButtonValue = false,
                Width = 80
            };
            dtgCitasPaciente.Columns.Add(btnCancelar);

            DataGridViewButtonColumn verColumn = new DataGridViewButtonColumn
            {
                Name = "Ver",
                HeaderText = "Ver Historia",
                UseColumnTextForButtonValue = false,
                Width = 80
            };
            dtgCitasPaciente.Columns.Add(verColumn);
        }

        private void CargarCitasPaciente(int? idPaciente)
        {
            try
            {
                if (!idPaciente.HasValue)
                {
                    MessageBox.Show("No hay un paciente seleccionado.");
                    return;
                }

                CitaDAL citaDAL = new CitaDAL();
                var citas = citaDAL.ObtenerCitasPorPaciente(idPaciente.Value);

                dtgCitasPaciente.Rows.Clear();

                foreach (var cita in citas)
                {
                    int rowIndex = dtgCitasPaciente.Rows.Add(
                        cita.FechaCita.ToShortDateString(),
                        cita.HoraCita.ToString(@"hh\:mm"),
                        cita.Doctor?.Nombre ?? "No asignado",
                        cita.Doctor?.Especialidad?.NombreEspecialidad ?? "No asignada",
                        cita.Estado
                    );

                    var row = dtgCitasPaciente.Rows[rowIndex];
                    row.Tag = cita;

                    // Configurar botones según el estado
                    var cancelarCell = row.Cells["Cancelar"] as DataGridViewButtonCell;
                    var verCell = row.Cells["Ver"] as DataGridViewButtonCell;

                    switch (cita.Estado.ToUpper())
                    {
                        case "ATENDIDA":
                            cancelarCell.Value = "";
                            verCell.Value = "Ver Historia";
                            cancelarCell.Style.BackColor = Color.LightGray;
                            verCell.Style.BackColor = Color.LightBlue;
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            break;

                        case "CANCELADA":
                            cancelarCell.Value = "Cancelada";
                            verCell.Value = "";
                            cancelarCell.Style.BackColor = Color.Red;
                            verCell.Style.BackColor = Color.LightGray;
                            row.DefaultCellStyle.BackColor = Color.LightPink;
                            break;

                        case "EN_ATENCION":
                            cancelarCell.Value = "Cancelar";
                            verCell.Value = "Ver Historia";
                            cancelarCell.Style.BackColor = Color.LightCoral;
                            verCell.Style.BackColor = Color.LightBlue;
                            row.DefaultCellStyle.BackColor = Color.LightYellow;
                            break;

                        default: // PENDIENTE
                            cancelarCell.Value = "Cancelar";
                            verCell.Value = "";
                            cancelarCell.Style.BackColor = Color.LightCoral;
                            verCell.Style.BackColor = Color.LightGray;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las citas: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgCitasPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var cita = (Cita)dtgCitasPaciente.Rows[e.RowIndex].Tag;
            if (cita == null) return;

            if (e.ColumnIndex == dtgCitasPaciente.Columns["Cancelar"].Index)
            {
                var cancelarCell = dtgCitasPaciente.Rows[e.RowIndex].Cells["Cancelar"] as DataGridViewButtonCell;
                if (string.IsNullOrEmpty(cancelarCell.Value?.ToString()) ||
                    cancelarCell.Style.BackColor == Color.LightGray) return;

                try
                {
                    string estadoActual = dtgCitasPaciente.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
                    if (estadoActual.ToUpper() == "CANCELADA")
                    {
                        MessageBox.Show("Esta cita ya está cancelada.",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (MessageBox.Show("¿Está seguro de que desea cancelar esta cita?",
                        "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cita.Estado = "CANCELADA";
                        _citaBLL.ActualizarCita(cita);
                        CargarCitasPaciente(_idPaciente);
                        MessageBox.Show("Cita cancelada exitosamente.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cancelar la cita: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.ColumnIndex == dtgCitasPaciente.Columns["Ver"].Index)
            {
                var verCell = dtgCitasPaciente.Rows[e.RowIndex].Cells["Ver"] as DataGridViewButtonCell;
                if (string.IsNullOrEmpty(verCell.Value?.ToString()) ||
                    verCell.Style.BackColor == Color.LightGray) return;

                try
                {
                    ver = true;
                    var historiaClinica = _historiaClinicaBLL.ObtenerHistoriaClinicaPorIdCita(cita.IdCita);

                    if (historiaClinica == null)
                    {
                        MessageBox.Show("No existe historia clínica para esta cita.",
                                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    citaActual = cita;
                    doctorActual = cita.Doctor;
                    _pacienteActual = historiaClinica.Paciente;
                    if (_pacienteActual == null)
                    {
                        MessageBox.Show("No se pudo obtener la información del paciente.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    modoVistaHistoriaClinica();
                    tbpCitas.SelectedIndex = 5;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la historia clínica: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            CargarCitasPaciente(_idPaciente);
        }
        private void ConfigurarDataGridViewDoctor()
        {
            if (dtgCitasDoctores.Columns.Count > 0)
                return;

            dtgCitasDoctores.AutoGenerateColumns = false;
            dtgCitasDoctores.AllowUserToAddRows = false;
            dtgCitasDoctores.Columns.Clear();

            dtgCitasDoctores.Columns.AddRange(new DataGridViewColumn[]
            {
        new DataGridViewTextBoxColumn
        {
            Name = "IdCita",
            HeaderText = "ID",
            Visible = false
        },
        new DataGridViewTextBoxColumn
        {
            Name = "FechaCita",
            HeaderText = "Fecha",
            Width = 100
        },
        new DataGridViewTextBoxColumn
        {
            Name = "HoraCita",
            HeaderText = "Hora",
            Width = 80
        },
        new DataGridViewTextBoxColumn
        {
            Name = "NombrePaciente",
            HeaderText = "Paciente",
            Width = 150
        },
        new DataGridViewTextBoxColumn
        {
            Name = "Estado",
            HeaderText = "Estado",
            Width = 100
        },
        new DataGridViewButtonColumn
        {
            Name = "Accion",
            HeaderText = "Acción",
            Width = 80,
            UseColumnTextForButtonValue = false
        },
        new DataGridViewButtonColumn
        {
            Name = "Cancelar",
            HeaderText = "Cancelar",
            Width = 80,
            UseColumnTextForButtonValue = false
        },
        new DataGridViewButtonColumn
        {
            Name = "Ver",
            HeaderText = "Ver Historia",
            Width = 80,
            UseColumnTextForButtonValue = false
        }
            });
        }

        private void CargarCitasDoctor()
        {
            try
            {
                if (doctorActual == null)
                {
                    MessageBox.Show("No se ha cargado la información del doctor actual.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var todasLasCitas = _citaBLL.ObtenerCitas();
                var citasDoctor = todasLasCitas
                    .Where(c => c.Doctor.IdDoctor == doctorActual.IdDoctor)
                    .ToList();

                dtgCitasDoctores.Rows.Clear();

                foreach (var cita in citasDoctor)
                {
                    int rowIndex = dtgCitasDoctores.Rows.Add(
                        cita.IdCita,
                        cita.FechaCita.ToShortDateString(),
                        cita.HoraCita.ToString(@"hh\:mm"),
                        $"{cita.Paciente.Nombre} {cita.Paciente.Apellido}",
                        cita.Estado
                    );

                    var row = dtgCitasDoctores.Rows[rowIndex];
                    row.Tag = cita;

                    var accionCell = row.Cells["Accion"] as DataGridViewButtonCell;
                    var cancelarCell = row.Cells["Cancelar"] as DataGridViewButtonCell;
                    var verCell = row.Cells["Ver"] as DataGridViewButtonCell;

                    switch (cita.Estado.ToUpper())
                    {
                        case "ATENDIDA":
                            accionCell.Value = "";
                            cancelarCell.Value = "";
                            verCell.Value = "Ver Historia";
                            accionCell.Style.BackColor = Color.LightGray;
                            cancelarCell.Style.BackColor = Color.LightGray;
                            verCell.Style.BackColor = Color.LightBlue;
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            break;

                        case "CANCELADA":
                            accionCell.Value = "";
                            cancelarCell.Value = "";
                            verCell.Value = "";
                            accionCell.Style.BackColor = Color.LightGray;
                            cancelarCell.Style.BackColor = Color.LightGray;
                            verCell.Style.BackColor = Color.LightGray;
                            row.DefaultCellStyle.BackColor = Color.LightPink;
                            break;

                        case "EN_ATENCION":
                            accionCell.Value = "Atender";
                            cancelarCell.Value = "Cancelar";
                            verCell.Value = "Ver Historia";
                            accionCell.Style.BackColor = Color.LightGreen;
                            cancelarCell.Style.BackColor = Color.LightCoral;
                            verCell.Style.BackColor = Color.LightBlue;
                            row.DefaultCellStyle.BackColor = Color.LightYellow;
                            break;

                        default: // PENDIENTE
                            accionCell.Value = "Atender";
                            cancelarCell.Value = "Cancelar";
                            verCell.Value = "";
                            accionCell.Style.BackColor = Color.LightGreen;
                            cancelarCell.Style.BackColor = Color.LightCoral;
                            verCell.Style.BackColor = Color.LightGray;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las citas: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ProcesarCita(Cita cita, string nuevoEstado)
        {
            try
            {
                cita.Estado = nuevoEstado;
                _citaBLL.ActualizarCita(cita);
                CargarCitasDoctor();
                MessageBox.Show($"Cita {nuevoEstado.ToLower()} exitosamente", "Éxito",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar la cita: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ProcesarCitaId(Cita cita, string nuevoEstado)
        {
            try
            {
                cita.Estado = nuevoEstado;
                _citaBLL.ActualizarCita(cita);
                CargarCitasDoctor();
                MessageBox.Show($"Cita {nuevoEstado.ToLower()} exitosamente", "Éxito",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar la cita: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DtgCitasDoctores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var cita = (Cita)dtgCitasDoctores.Rows[e.RowIndex].Tag;
            citaActual = cita;
            if (cita == null) return;

            if (e.ColumnIndex == dtgCitasDoctores.Columns["Accion"].Index)
            {
                var accionCell = dtgCitasDoctores.Rows[e.RowIndex].Cells["Accion"] as DataGridViewButtonCell;
                if (string.IsNullOrEmpty(accionCell.Value?.ToString()) ||
                    accionCell.Style.BackColor == Color.LightGray) return;

                if (MessageBox.Show("¿Desea atender esta cita?",
                                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        _pacienteActual = _pacienteBLL.ObtenerPacientePorId(cita.Paciente.IdPaciente);

                        if (_pacienteActual == null)
                        {
                            MessageBox.Show("No se pudo obtener la información del paciente.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        tbpCitas.SelectedIndex = 5;
                        ver = false;
                        ProcesarCita(cita, "EN_ATENCION");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar los datos del paciente: {ex.Message}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (e.ColumnIndex == dtgCitasDoctores.Columns["Cancelar"].Index)
            {
                var cancelarCell = dtgCitasDoctores.Rows[e.RowIndex].Cells["Cancelar"] as DataGridViewButtonCell;
                if (string.IsNullOrEmpty(cancelarCell.Value?.ToString()) ||
                    cancelarCell.Style.BackColor == Color.LightGray) return;

                if (MessageBox.Show("¿Está seguro de que desea cancelar esta cita?",
                                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ProcesarCita(cita, "CANCELADA");
                }
            }
            else if (e.ColumnIndex == dtgCitasDoctores.Columns["Ver"].Index)
            {
                var verCell = dtgCitasDoctores.Rows[e.RowIndex].Cells["Ver"] as DataGridViewButtonCell;
                if (string.IsNullOrEmpty(verCell.Value?.ToString()) ||
                    verCell.Style.BackColor == Color.LightGray) return;

                try
                {
                    ver = true;
                    var historiaClinica = _historiaClinicaBLL.ObtenerHistoriaClinicaPorIdCita(cita.IdCita);

                    if (historiaClinica == null)
                    {
                        MessageBox.Show("No existe historia clínica para esta cita.",
                                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    _pacienteActual = historiaClinica.Paciente;
                    if (_pacienteActual == null)
                    {
                        MessageBox.Show("No se pudo obtener la información del paciente.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    modoVistaHistoriaClinica();
                    tbpCitas.SelectedIndex = 5;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la historia clínica: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CargarHistoriaClinicaParaEdicion(HistoriaClinica historia)
        {
            txtDiagnostico.Text = historia.Diagnostico;
            txtTratamiento.Text = historia.Tratamiento;
            txtNotasAdicionales.Text = historia.NotasAdicionales;

            btnGuardarHistoria.Tag = historia.IdHistoriaClinica;
        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {
            CargarCitasDoctor();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void ConfigurarFormulario()
        {
            errorProvider.Clear();

            
            txtCedulaCita.Text = _pacienteActual.Cedula;
            txtNombreCita.Text = $"{_pacienteActual.Nombre} {_pacienteActual.Apellido}";
            txtTelefonoCita.Text = _pacienteActual.Telefono;
            txtDireccionCita.Text = _pacienteActual.Direccion;

            lblDoctor.Text = $"Dr. {doctorActual.Nombre} - {doctorActual.Especialidad.NombreEspecialidad}";
            lblFecha.Text = DateTime.Now.ToShortDateString();
            if (!ver)
            {
                txtDiagnostico.ReadOnly = false;
                txtTratamiento.ReadOnly = false;
                txtNotasAdicionales.ReadOnly = false;
                txtDiagnostico.Text = string.Empty;
                txtTratamiento.Text = string.Empty;
                txtNotasAdicionales.Text = string.Empty;
                btnGuardarHistoria.Visible = true;
            }
            



            btnGuardarHistoria.Click -= btnGuardarHistoria_Click;
            btnGuardarHistoria.Click += btnGuardarHistoria_Click;
        }
        private void ValidarCampoRequerido(Control control, string mensaje, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(control, mensaje);
            }
            else
            {
                errorProvider.SetError(control, "");
            }
        }

        private void btnGuardarHistoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarFormulario()) return;

                var historiaClinica = new HistoriaClinica
                {
                    Paciente = _pacienteActual,
                    Doctor = doctorActual,
                    FechaCreacion = DateTime.Now,
                    Diagnostico = txtDiagnostico.Text.Trim(),
                    Tratamiento = txtTratamiento.Text.Trim(),
                    NotasAdicionales = txtNotasAdicionales.Text.Trim(),
                    IdCita=citaActual.IdCita,
                    Cita=citaActual,
                };

                bool guardado;
                if (btnGuardarHistoria.Tag != null)
                {
                    historiaClinica.IdHistoriaClinica = (int)btnGuardarHistoria.Tag;
                    guardado = _historiaClinicaBLL.ActualizarHistoriaClinica(historiaClinica);
                }
                else
                {
                    guardado = _historiaClinicaBLL.GuardarHistoriaClinica(historiaClinica);
                    ProcesarCita(citaActual,"ATENDIDA");
                }

                if (guardado)
                {
                    MessageBox.Show("Historia clínica guardada exitosamente",
                                  "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    tbpCitas.SelectedIndex = 4;
                    CargarCitasDoctor();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la historia clínica: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool ValidarFormulario()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtDiagnostico.Text))
            {
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtTratamiento.Text))
            {
                isValid = false;
            }

            return isValid;
        }

        private void LimpiarCampos()
        {
            this.AutoValidate = AutoValidate.Disable;

            txtDiagnostico.Clear();
            txtTratamiento.Clear();
            txtNotasAdicionales.Clear();
            errorProvider.Clear();

            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void CargarHistorialPaciente()
        {
            try
            {
                var historias = _historiaClinicaBLL.ObtenerHistoriasClinicasPorPaciente(_pacienteActual.IdPaciente);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el historial: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPage6_Enter(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
            ConfigurarFormulario();
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void btn_citas_existentes_Click(object sender, EventArgs e)
        {
            tbpCitas.SelectedIndex = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbpCitas.SelectedIndex = 1;
            MostrarDatosPaciente(_pacienteActual);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMisCitas_Click(object sender, EventArgs e)
        {
            tbpCitas.SelectedIndex = 3;
        }
    }
}
