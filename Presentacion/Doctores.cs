using Datos;
using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui
{
    public partial class Doctores : Form
    {
        DoctorBLL DoctorBLL = new DoctorBLL();
        HorarioBLL horarioBLL = new HorarioBLL();
        EspecialidadBLL EspecialidadBLL = new EspecialidadBLL();
        public Doctores()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CargarDoctores();
            CargarDiasSemana();
            cbxDoctor.SelectedIndexChanged += cbxDoctor_SelectedIndexChanged;
        }

        private void btn_agregar_doctores_Click(object sender, EventArgs e)
        {
            tbpDoctores.SelectedIndex = 1;
        }

        private void txtNombrePaciente_Enter(object sender, EventArgs e)
        {

        }

        private void txtNombrePaciente_Leave(object sender, EventArgs e)
        {

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
           
        }

        private void btnAgregarDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                Doctor doctor = new Doctor
                {
                    Cedula = txtCedulaDoctor.Text.Trim(),
                    Nombre = txtNombreDoctor.Text.Trim(),
                    Telefono = txtTelefonoDoctor.Text.Trim(),
                    Especialidad = new Especialidad
                    {
                        NombreEspecialidad = txtEspecialidadDoctor.Text.Trim()
                    }
                };

                DoctorBLL doctorBLL = new DoctorBLL();

                string resultado = doctorBLL.RegistrarDoctorConUsuario(doctor);

                MessageBox.Show(resultado, "Información", MessageBoxButtons.OK,
                               MessageBoxIcon.Information);

                if (resultado.Contains("exitosamente"))
                {
                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el doctor: " + ex.Message,
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private bool ValidarCampos()
        {
            errorProvider.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtCedulaDoctor.Text))
            {
                errorProvider.SetError(txtCedulaDoctor, "La cédula es requerida");
                isValid = false;
            }
            else if (!ValidarFormatoCedula(txtCedulaDoctor.Text.Trim()))
            {
                errorProvider.SetError(txtCedulaDoctor, "Formato de cédula inválido");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtNombreDoctor.Text))
            {
                errorProvider.SetError(txtNombreDoctor, "El nombre es requerido");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefonoDoctor.Text))
            {
                errorProvider.SetError(txtTelefonoDoctor, "El teléfono es requerido");
                isValid = false;
            }
            else if (!ValidarFormatoTelefono(txtTelefonoDoctor.Text.Trim()))
            {
                errorProvider.SetError(txtTelefonoDoctor, "Formato de teléfono inválido");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtEspecialidadDoctor.Text))
            {
                errorProvider.SetError(txtEspecialidadDoctor, "La especialidad es requerida");
                isValid = false;
            }

            return isValid;
        }

        private bool ValidarFormatoCedula(string cedula)
        {
            return cedula.Length >= 8 && cedula.Length <= 10 && cedula.All(char.IsDigit);
        }

        private bool ValidarFormatoTelefono(string telefono)
        {
            return telefono.Length >= 7 && telefono.All(c => char.IsDigit(c) || c == '-' || c == '(' || c == ')' || c == ' ');
        }

        private void LimpiarFormulario()
        {
            txtCedulaDoctor.Clear();
            txtNombreDoctor.Clear();
            txtTelefonoDoctor.Clear();
            txtEspecialidadDoctor.Clear();
            errorProvider.Clear();
            txtCedulaDoctor.Focus();
        }

        private void txtCedulaDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefonoDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '(' && e.KeyChar != ')')
            {
                e.Handled = true;
            }
        }

        private void txtNombreDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        void limpiarCampos()
        {
            txtCedulaDoctor.Text = "";
            txtNombreDoctor.Text = "";
            txtTelefonoDoctor.Text = "";
            txtEspecialidadDoctor.Text = "";
        }
        private void ConfigurarControles()
        {
            txtCedulaDoctor.MaxLength = 10;
            txtNombreDoctor.MaxLength = 100;
            txtTelefonoDoctor.MaxLength = 15;
            txtEspecialidadDoctor.MaxLength = 50;

            txtNombreDoctor.CharacterCasing = CharacterCasing.Upper;
            txtEspecialidadDoctor.CharacterCasing = CharacterCasing.Upper;

            var toolTip = new ToolTip();
            toolTip.SetToolTip(txtCedulaDoctor, "Ingrese la cédula sin guiones ni espacios");
            toolTip.SetToolTip(txtTelefonoDoctor, "Ingrese el teléfono con formato (XXX) XXX-XXXX");
        }

        private void txtCedulaDoctor_Enter(object sender, EventArgs e)
        {
            txtCedulaDoctor.ForeColor = Color.DarkBlue;
        }

        private void txtCedulaDoctor_Leave(object sender, EventArgs e)
        {
            txtCedulaDoctor.ForeColor = Color.DimGray;
        }

        private void txtNombreDoctor_Enter(object sender, EventArgs e)
        {
            txtNombreDoctor.ForeColor = Color.DarkBlue;
        }

        private void txtNombreDoctor_Leave(object sender, EventArgs e)
        {
            txtNombreDoctor.ForeColor = Color.DimGray;
        }

        private void txtTelefonoDoctor_Enter(object sender, EventArgs e)
        {
            txtTelefonoDoctor.ForeColor = Color.DarkBlue;
        }

        private void txtTelefonoDoctor_Leave(object sender, EventArgs e)
        {
            txtTelefonoDoctor.ForeColor = Color.DimGray;
        }

        private void txtEspecialidadDoctor_Enter(object sender, EventArgs e)
        {
            txtEspecialidadDoctor.ForeColor = Color.DarkBlue;
        }

        private void txtEspecialidadDoctor_Leave(object sender, EventArgs e)
        {
            txtEspecialidadDoctor.ForeColor = Color.DimGray;
        }

        private void btn_horarios_doctores_Click(object sender, EventArgs e)
        {
            tbpDoctores.SelectedIndex = 2;
        }

        private void btn_doctores_disponibles_Click(object sender, EventArgs e)
        {
            tbpDoctores.SelectedIndex = 3;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dtpHoraFin.Value.TimeOfDay <= dtpHoraInicio.Value.TimeOfDay)
            {
                errorProvider.SetError(dtpHoraFin, "La hora de fin debe ser mayor a la hora de inicio");
            }
            else
            {
                errorProvider.SetError(dtpHoraFin, "");
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Doctores_Load(object sender, EventArgs e)
        {
            var doctores = DoctorBLL.ObtenerDoctores(); 
            cbxDoctor.DataSource = doctores;
            cbxDoctor.DisplayMember = "NombreCompleto"; 
            cbxDoctor.ValueMember = "IdDoctor";

            
            cbxDia.DataSource = new BindingSource(diasSemana, null);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                
                TimeSpan horaInicio = new TimeSpan(
                    dtpHoraInicio.Value.Hour,
                    dtpHoraInicio.Value.Minute,
                    0); 

                TimeSpan horaFin = new TimeSpan(
                    dtpHoraFin.Value.Hour,
                    dtpHoraFin.Value.Minute,
                    0); 

                var horario = new Horario
                {
                    IdDoctor = (int)cbxDoctor.SelectedValue,
                    DiaSemana = cbxDia.SelectedItem.ToString(),
                    HoraInicio = horaInicio,
                    HoraFin = horaFin
                };

                if (!ValidarHorario(horario))
                {
                    MessageBox.Show("Por favor corrija los errores antes de continuar.",
                                  "Validación",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }

                string resultado;
                if (btnAgregar.Tag != null) 
                {
                    horario.IdHorario = (int)btnAgregar.Tag;
                    resultado = horarioBLL.ActualizarHorario(horario);
                    btnAgregar.Tag = null;
                    btnAgregar.Text = "Agregar";
                }
                else 
                {
                    resultado = horarioBLL.RegistrarHorario(horario);
                }

                MessageBox.Show(resultado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarHorariosPorDoctor(horario.IdDoctor);
                LimpiarControlesHorario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarControlesHorario()
        {
            dtpHoraInicio.Value = DateTime.Today;
            dtpHoraFin.Value = DateTime.Today;
            btnAgregar.Tag = null;
            btnAgregar.Text = "Agregar";
            errorProvider.Clear();
        }
        private void CargarDoctores()
        {
            var doctores = DoctorBLL.ObtenerDoctores(); 

            cbxDoctor.DataSource = doctores;
            cbxDoctor.DisplayMember = "Nombre"; 
            cbxDoctor.ValueMember = "IdDoctor"; 
        }
        List<string> diasSemana = new List<string>
            {
                "Lunes",
                "Martes",
                "Miércoles",
                "Jueves",
                "Viernes",
                "Sábado",
                "Domingo"
            };
        private void CargarDiasSemana()
        {
           
            cbxDia.DataSource = new BindingSource(diasSemana, null);
            cbxDia.DisplayMember = "Value";
        }
        private void ConfigurarDataGridView()
        {
            dtgHorarios.AutoGenerateColumns = false;
            dtgHorarios.Columns.Clear();

            dtgHorarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IdHorario",
                HeaderText = "ID Horario",
                Visible = false
            });

            dtgHorarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DiaSemana",
                HeaderText = "Día"
            });

            dtgHorarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "HoraInicio",
                HeaderText = "Inicio"
            });

            dtgHorarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "HoraFin",
                HeaderText = "Fin"
            });

            DataGridViewImageColumn btnEditar = new DataGridViewImageColumn
            {
                Image = Presentacion.Properties.Resources.btnEditar,
                Name = "btnEditar",
                HeaderText = "Editar",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dtgHorarios.Columns.Add(btnEditar);

            
            DataGridViewImageColumn btnEliminar = new DataGridViewImageColumn
            {
                Image = Presentacion.Properties.Resources.btnEliminar,
                Name = "btnEliminar",
                HeaderText = "Eliminar",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dtgHorarios.Columns.Add(btnEliminar);

            dtgHorarios.CellFormatting += dtgHorarios_CellFormatting;
            dtgHorarios.CellClick += dtgHorarios_CellClick;
        }
        private void CargarHorarios()
        {
            var horarios = horarioBLL.ObtenerHorarios(); 
            dtgHorarios.DataSource = horarios;
        }
        private void CargarHorariosPorDoctor(int idDoctor)
        {
            var horarios = horarioBLL.ObtenerHorariosPorDoctor(idDoctor); 
            dtgHorarios.DataSource = horarios;
        }

        private void cbxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDoctor.SelectedValue != null && cbxDoctor.SelectedValue is int)
            {
                int idDoctor = (int)cbxDoctor.SelectedValue;
                CargarHorariosPorDoctor(idDoctor);
            }
        }
        private bool ValidarHorario(Horario horario)
        {
            errorProvider.Clear();
            bool isValid = true;

            
            if (cbxDoctor.SelectedValue == null)
            {
                errorProvider.SetError(cbxDoctor, "Debe seleccionar un doctor");
                isValid = false;
            }

            
            if (cbxDia.SelectedItem == null)
            {
                errorProvider.SetError(cbxDia, "Debe seleccionar un día");
                isValid = false;
            }

            
            if (horario.HoraFin <= horario.HoraInicio)
            {
                errorProvider.SetError(dtpHoraFin, "La hora de fin debe ser mayor a la hora de inicio");
                isValid = false;
            }
            TimeSpan horaMinima = new TimeSpan(6, 0, 0); 
            TimeSpan horaMaxima = new TimeSpan(22, 0, 0); 

            if (horario.HoraInicio < horaMinima || horario.HoraInicio > horaMaxima)
            {
                errorProvider.SetError(dtpHoraInicio, "La hora de inicio debe estar entre 6:00 AM y 10:00 PM");
                isValid = false;
            }

            if (horario.HoraFin < horaMinima || horario.HoraFin > horaMaxima)
            {
                errorProvider.SetError(dtpHoraFin, "La hora de fin debe estar entre 6:00 AM y 10:00 PM");
                isValid = false;
            }

            var horariosExistentes = horarioBLL.ObtenerHorariosPorDoctor(horario.IdDoctor);
            foreach (var h in horariosExistentes)
            {
                if (btnAgregar.Tag != null && h.IdHorario == (int)btnAgregar.Tag)
                    continue;

                if (h.DiaSemana == horario.DiaSemana &&
                    ((horario.HoraInicio >= h.HoraInicio && horario.HoraInicio < h.HoraFin) ||
                     (horario.HoraFin > h.HoraInicio && horario.HoraFin <= h.HoraFin) ||
                     (horario.HoraInicio <= h.HoraInicio && horario.HoraFin >= h.HoraFin))) 
                {
                    errorProvider.SetError(dtpHoraInicio, "El horario se solapa con otro existente");
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }

        private void dtgHorarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgHorarios.Columns[e.ColumnIndex].DataPropertyName == "HoraInicio" ||
      dtgHorarios.Columns[e.ColumnIndex].DataPropertyName == "HoraFin")
            {
                if (e.Value != null)
                {
                    DateTime dateTime;
                    if (e.Value is TimeSpan timeSpan)
                    {
                        dateTime = DateTime.Today.Add(timeSpan);
                    }
                    else if (e.Value is DateTime dt)
                    {
                        dateTime = dt;
                    }
                    else
                    {
                        return; 
                    }

                    e.Value = dateTime.ToString("hh:mm tt");
                    e.FormattingApplied = true;
                }
            }
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            CargarDoctores();

        }

        private void dtgHorarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void EditarHorario(int rowIndex)
        {
            try
            {
                var horario = (Horario)dtgHorarios.Rows[rowIndex].DataBoundItem;

                cbxDia.SelectedItem = horario.DiaSemana;
                dtpHoraInicio.Value = DateTime.Today.Add(horario.HoraInicio);
                dtpHoraFin.Value = DateTime.Today.Add(horario.HoraFin);

                btnAgregar.Tag = horario.IdHorario;
                btnAgregar.Text = "Actualizar";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el horario: " + ex.Message,
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarHorario(int rowIndex)
        {
            try
            {
                var horario = (Horario)dtgHorarios.Rows[rowIndex].DataBoundItem;

                if (MessageBox.Show("¿Está seguro de eliminar este horario?",
                                  "Confirmar eliminación",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var resultado = horarioBLL.EliminarHorario(horario.IdHorario);
                    MessageBox.Show(resultado);
                    CargarHorariosPorDoctor(horario.IdDoctor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el horario: " + ex.Message,
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgHorarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dtgHorarios.Columns["btnEditar"].Index)
            {
                EditarHorario(e.RowIndex);
            }
            else if (e.ColumnIndex == dtgHorarios.Columns["btnEliminar"].Index)
            {
                EliminarHorario(e.RowIndex);
            }
        }
    }
}
