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
    public partial class Pacientes : Form
    {
        PacienteBLL pacienteBLL = new PacienteBLL();
        private int? pacienteIdEdicion = null;
        public Pacientes()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void ConfigurarValidaciones()
        {
            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            // Configurar eventos de validación
            txtNombrePaciente.Validating += ValidarNombre;
            txtApellidoPaciente.Validating += ValidarApellido;
            txtDireccionPaciente.Validating += ValidarDireccion;
            txtTelefonoPaciente.Validating += ValidarTelefono;
            txtCedula.Validating += ValidarCedula;
            dtpFechaNacimiento.Validating += ValidarFechaNacimiento;
        }

        private void ValidarNombre(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombrePaciente.Text) || txtNombrePaciente.Text == "NOMBRE")
            {
                e.Cancel = true;
                errorProvider.SetError(txtNombrePaciente, "El nombre es requerido");
            }
            else if (!txtNombrePaciente.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNombrePaciente, "El nombre solo debe contener letras");
            }
            else
            {
                errorProvider.SetError(txtNombrePaciente, "");
            }
        }

        private void ValidarApellido(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtApellidoPaciente.Text) || txtApellidoPaciente.Text == "APELLIDO")
            {
                e.Cancel = true;
                errorProvider.SetError(txtApellidoPaciente, "El apellido es requerido");
            }
            else if (!txtApellidoPaciente.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                e.Cancel = true;
                errorProvider.SetError(txtApellidoPaciente, "El apellido solo debe contener letras");
            }
            else
            {
                errorProvider.SetError(txtApellidoPaciente, "");
            }
        }

        private void ValidarDireccion(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDireccionPaciente.Text) || txtDireccionPaciente.Text == "DIRECCION")
            {
                e.Cancel = true;
                errorProvider.SetError(txtDireccionPaciente, "La dirección es requerida");
            }
            else
            {
                errorProvider.SetError(txtDireccionPaciente, "");
            }
        }

        private void ValidarTelefono(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefonoPaciente.Text) || txtTelefonoPaciente.Text == "TELEFONO")
            {
                e.Cancel = true;
                errorProvider.SetError(txtTelefonoPaciente, "El teléfono es requerido");
            }
            else if (!txtTelefonoPaciente.Text.All(char.IsDigit))
            {
                e.Cancel = true;
                errorProvider.SetError(txtTelefonoPaciente, "El teléfono solo debe contener números");
            }
            else if (txtTelefonoPaciente.Text.Length != 10)
            {
                e.Cancel = true;
                errorProvider.SetError(txtTelefonoPaciente, "El teléfono debe tener 10 dígitos");
            }
            else
            {
                errorProvider.SetError(txtTelefonoPaciente, "");
            }
        }

        private void ValidarCedula(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtCedula, "La cédula es requerida");
            }
            else if (!txtCedula.Text.All(char.IsDigit))
            {
                e.Cancel = true;
                errorProvider.SetError(txtCedula, "La cédula solo debe contener números");
            }
            else if (txtCedula.Text.Length != 8)
            {
                e.Cancel = true;
                errorProvider.SetError(txtCedula, "La cédula debe tener 8 dígitos");
            }
            else
            {
                errorProvider.SetError(txtCedula, "");
            }
        }

        private void ValidarFechaNacimiento(object sender, CancelEventArgs e)
        {
            if (dtpFechaNacimiento.Value > DateTime.Now)
            {
                e.Cancel = true;
                errorProvider.SetError(dtpFechaNacimiento, "La fecha no puede ser futura");
            }else
            {
                errorProvider.SetError(dtpFechaNacimiento, "");
            }
        }

        private bool ValidarFormulario()
        {
            bool isValid = true;
            errorProvider.Clear();

            // Validar cada campo manualmente
            CancelEventArgs e = new CancelEventArgs();

            // Validar nombre
            ValidarNombre(txtNombrePaciente, e);
            if (e.Cancel) isValid = false;

            // Validar apellido
            e = new CancelEventArgs();
            ValidarApellido(txtApellidoPaciente, e);
            if (e.Cancel) isValid = false;

            // Validar dirección
            e = new CancelEventArgs();
            ValidarDireccion(txtDireccionPaciente, e);
            if (e.Cancel) isValid = false;

            // Validar teléfono
            e = new CancelEventArgs();
            ValidarTelefono(txtTelefonoPaciente, e);
            if (e.Cancel) isValid = false;

            // Validar cédula
            e = new CancelEventArgs();
            ValidarCedula(txtCedula, e);
            if (e.Cancel) isValid = false;

            // Validar fecha de nacimiento
            e = new CancelEventArgs();
            ValidarFechaNacimiento(dtpFechaNacimiento, e);
            if (e.Cancel) isValid = false;

            return isValid;
        }


        void agregarPaciente()
        {
            try
            {
                if (!ValidarFormulario())
                {
                    MessageBox.Show("Por favor, corrija los errores antes de continuar.",
                                  "Validación",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }

                string nombre = txtNombrePaciente.Text.Trim();
                string apellido = txtApellidoPaciente.Text.Trim();
                string direccion = txtDireccionPaciente.Text.Trim();
                string telefono = txtTelefonoPaciente.Text.Trim();
                string cedula = txtCedula.Text.Trim();
                DateTime fechaNacimiento = dtpFechaNacimiento.Value;

                string resultado;
                if (pacienteIdEdicion.HasValue)
                {
                    resultado = pacienteBLL.ActualizarPaciente(pacienteIdEdicion.Value,
                        nombre, apellido, direccion, telefono, fechaNacimiento, cedula);
                    btnAgregarPaciente.Text = "Agregar Paciente";
                    pacienteIdEdicion = null;
                    tbpPaciente.SelectedIndex = 2;
                }
                else
                {
                    resultado = pacienteBLL.RegistrarPaciente(nombre, apellido,
                        direccion, telefono, fechaNacimiento, cedula);
                    tbpPaciente.SelectedIndex = 2;
                }

                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarPacientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtNombrePaciente.Text = "NOMBRE";
            txtApellidoPaciente.Text = "APELLIDO";
            txtDireccionPaciente.Text = "DIRECCION";
            txtTelefonoPaciente.Text = "TELEFONO";
            txtCedula.Clear();
            dtpFechaNacimiento.Value = DateTime.Now;
            errorProvider.Clear();

            txtNombrePaciente.ForeColor = Color.DimGray;
            txtApellidoPaciente.ForeColor = Color.DimGray;
            txtDireccionPaciente.ForeColor = Color.DimGray;
            txtTelefonoPaciente.ForeColor = Color.DimGray;
        }
        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            agregarPaciente();
        }

        void CargarPacientes()
        {
            try
            {
                var pacientes = pacienteBLL.ObtenerPacientes();
                dtgPacientes.Rows.Clear();

                foreach (var paciente in pacientes)
                {
                    dtgPacientes.Rows.Add(paciente.IdPaciente, paciente.Nombre, paciente.Apellido, paciente.Direccion, paciente.Telefono);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los pacientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            CargarPacientes();

        }
        bool editar;

        private void dtgPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgPacientes.Rows[e.RowIndex];

                if (e.ColumnIndex == dtgPacientes.Columns["Edit"].Index)
                {
                    pacienteIdEdicion = Convert.ToInt32(row.Cells["Id"].Value);
                    txtNombrePaciente.Text = row.Cells["Nombre"].Value.ToString();
                    txtApellidoPaciente.Text = row.Cells["Apellido"].Value.ToString();
                    txtDireccionPaciente.Text = row.Cells["Direccion"].Value.ToString();
                    txtTelefonoPaciente.Text = row.Cells["Telefono"].Value.ToString();
                    dtpFechaNacimiento.Value = DateTime.Now; 

                    btnAgregarPaciente.Text = "Editar Paciente";

                    tbpPaciente.SelectedIndex = 1;
                }
                else if (e.ColumnIndex == dtgPacientes.Columns["Eliminar"].Index)
                {
                    int idPaciente = Convert.ToInt32(row.Cells["Id"].Value);
                    var confirmResult = MessageBox.Show("¿Está seguro de eliminar este paciente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            string resultado = pacienteBLL.EliminarPaciente(idPaciente);
                            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarPacientes();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btn_agregar_eliminar_pacientes_Click(object sender, EventArgs e)
        {
            tbpPaciente.SelectedIndex=1;
        }

        private void btn_pacientes_existentes_Click(object sender, EventArgs e)
        {
            tbpPaciente.SelectedIndex = 2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtBuscarPaciente.Text.Trim().ToLower();
                var pacientes = pacienteBLL.ObtenerPacientes();
                var pacientesFiltrados = pacientes.Where(p => p.Nombre.ToLower().Contains(filtro)).ToList();

                dtgPacientes.Rows.Clear();

                foreach (var paciente in pacientesFiltrados)
                {
                    dtgPacientes.Rows.Add(paciente.IdPaciente, paciente.Nombre, paciente.Apellido, paciente.Direccion, paciente.Telefono);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar los pacientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarPaciente_Enter(object sender, EventArgs e)
        {
            txtBuscarPaciente.ForeColor = Color.DarkBlue;
        }

        private void txtNombrePaciente_Enter(object sender, EventArgs e)
        {
            txtNombrePaciente.ForeColor = Color.DarkBlue;
        }

        private void txtApellidoPaciente_Enter(object sender, EventArgs e)
        {
            txtApellidoPaciente.ForeColor = Color.DarkBlue;
        }

        private void txtDireccionPaciente_Enter(object sender, EventArgs e)
        {
            txtDireccionPaciente.ForeColor = Color.DarkBlue;
        }

        private void txtTelefonoPaciente_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtTelefonoPaciente_Enter(object sender, EventArgs e)
        {
            txtTelefonoPaciente.ForeColor = Color.DarkBlue;
        }

        private void txtNombrePaciente_Leave(object sender, EventArgs e)
        {
            txtNombrePaciente.ForeColor = Color.DimGray;
        }

        private void txtTelefonoPaciente_Leave(object sender, EventArgs e)
        {
            txtTelefonoPaciente.ForeColor = Color.DimGray;
        }

        private void txtApellidoPaciente_Leave(object sender, EventArgs e)
        {
            txtApellidoPaciente.ForeColor = Color.DimGray;
        }

        private void txtDireccionPaciente_Leave(object sender, EventArgs e)
        {
            txtDireccionPaciente.ForeColor = Color.DimGray;
        }
    }
}
