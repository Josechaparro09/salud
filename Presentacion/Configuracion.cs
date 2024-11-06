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
using System.Xml.Serialization;

namespace Gui
{
    public partial class Configuracion : Form
    {
        Usuario _usuario;
        PacienteBLL _pacienteBLL = new PacienteBLL();
        DoctorBLL _doctorBLL = new DoctorBLL();
        Paciente _pacienteActual;
        Doctor _doctorActual;

        public Configuracion(Usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();
            InitializeErrorProvider();
            ConfigurarEventosValidacion();
            CargarTbpSegunRol();
        }

        private void InitializeErrorProvider()
        {
            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void ConfigurarEventosValidacion()
        {
            // Paciente
            txtCedula.TextChanged += ValidacionEnTiempoReal;
            txtNombrePaciente.TextChanged += ValidacionEnTiempoReal;
            txtApellidoPaciente.TextChanged += ValidacionEnTiempoReal;
            txtTelefonoPaciente.TextChanged += ValidacionEnTiempoReal;
            txtDireccionPaciente.TextChanged += ValidacionEnTiempoReal;
            dtpFechaNacimiento.ValueChanged += ValidacionEnTiempoReal;

            // Doctor
            txtCedulaDoctor.TextChanged += ValidacionEnTiempoReal;
            txtNombreDoctor.TextChanged += ValidacionEnTiempoReal;
            txtTelefonoDoctor.TextChanged += ValidacionEnTiempoReal;
        }

        private void ValidacionEnTiempoReal(object sender, EventArgs e)
        {
            if (_usuario.Rol.NombreRol == "doctor")
            {
                ValidarDoctor();
            }
            else if (_usuario.Rol.NombreRol == "paciente")
            {
                ValidarPaciente();
            }
        }

        void CargarTbpSegunRol()
        {
            try
            {
                if (_usuario.Rol.NombreRol == "doctor")
                {
                    tbpConfig.SelectedIndex = 1;
                    _doctorActual = _doctorBLL.ObtenerDoctorPorIdUsuario(_usuario.IdUsuario);
                    if (_doctorActual != null)
                    {
                        CargarDoctor();
                    }
                }
                else if (_usuario.Rol.NombreRol == "paciente")
                {
                    tbpConfig.SelectedIndex = 0;
                    _pacienteActual = _pacienteBLL.ObtenerPacientePorIdUsuario(_usuario.IdUsuario);
                    if (_pacienteActual != null)
                    {
                        CargarPaciente();
                    }
                }
                else { tbpConfig.SelectedIndex = 2;}
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CargarDoctor()
        {
            if (_doctorActual == null) return;

            txtCedulaDoctor.Text = _doctorActual.Cedula;
            txtNombreDoctor.Text = _doctorActual.Nombre;
            txtTelefonoDoctor.Text = _doctorActual.Telefono;
        }

        void CargarPaciente()
        {
            if (_pacienteActual == null) return;

            txtCedula.Text = _pacienteActual.Cedula;
            txtNombrePaciente.Text = _pacienteActual.Nombre;
            txtApellidoPaciente.Text = _pacienteActual.Apellido;
            txtTelefonoPaciente.Text = _pacienteActual.Telefono;
            txtDireccionPaciente.Text = _pacienteActual.Direccion;
            dtpFechaNacimiento.Value = _pacienteActual.FechaNacimiento;
        }

        private bool ValidarPaciente()
        {
            bool isValid = true;
            errorProvider.Clear();

            // Validar Cédula
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                errorProvider.SetError(txtCedula, "La cédula es obligatoria");
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtCedula.Text, @"^\d{8}$"))
            {
                errorProvider.SetError(txtCedula, "La cédula debe tener 8 dígitos");
                isValid = false;
            }

            // Validar Nombre
            if (string.IsNullOrWhiteSpace(txtNombrePaciente.Text))
            {
                errorProvider.SetError(txtNombrePaciente, "El nombre es obligatorio");
                isValid = false;
            }
            else if (txtNombrePaciente.Text.Length < 2)
            {
                errorProvider.SetError(txtNombrePaciente, "El nombre debe tener al menos 2 caracteres");
                isValid = false;
            }

            // Validar Apellido
            if (string.IsNullOrWhiteSpace(txtApellidoPaciente.Text))
            {
                errorProvider.SetError(txtApellidoPaciente, "El apellido es obligatorio");
                isValid = false;
            }
            else if (txtApellidoPaciente.Text.Length < 2)
            {
                errorProvider.SetError(txtApellidoPaciente, "El apellido debe tener al menos 2 caracteres");
                isValid = false;
            }

            // Validar Teléfono
            if (!string.IsNullOrWhiteSpace(txtTelefonoPaciente.Text) &&
                !System.Text.RegularExpressions.Regex.IsMatch(txtTelefonoPaciente.Text, @"^\d{10}$"))
            {
                errorProvider.SetError(txtTelefonoPaciente, "El teléfono debe tener 10 dígitos");
                isValid = false;
            }

            // Validar Dirección

            // Validar Fecha de Nacimiento
            if (dtpFechaNacimiento.Value > DateTime.Now)
            {
                errorProvider.SetError(dtpFechaNacimiento, "La fecha de nacimiento no puede ser futura");
                isValid = false;
            }

            return isValid;
        }

        private bool ValidarDoctor()
        {
            bool isValid = true;
            errorProvider.Clear();

            // Validar Cédula
            if (string.IsNullOrWhiteSpace(txtCedulaDoctor.Text))
            {
                errorProvider.SetError(txtCedulaDoctor, "La cédula es obligatoria");
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtCedulaDoctor.Text, @"^\d{8}$"))
            {
                errorProvider.SetError(txtCedulaDoctor, "La cédula debe tener 8 dígitos");
                isValid = false;
            }

            // Validar Nombre
            if (string.IsNullOrWhiteSpace(txtNombreDoctor.Text))
            {
                errorProvider.SetError(txtNombreDoctor, "El nombre es obligatorio");
                isValid = false;
            }
            else if (txtNombreDoctor.Text.Length < 2)
            {
                errorProvider.SetError(txtNombreDoctor, "El nombre debe tener al menos 2 caracteres");
                isValid = false;
            }

            // Validar Teléfono
            if (!string.IsNullOrWhiteSpace(txtTelefonoDoctor.Text) &&
                !System.Text.RegularExpressions.Regex.IsMatch(txtTelefonoDoctor.Text, @"^\d{10}$"))
            {
                errorProvider.SetError(txtTelefonoDoctor, "El teléfono debe tener 10 dígitos");
                isValid = false;
            }

            return isValid;
        }

        private void btnGuardarDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                if (_doctorActual == null) return;

                if (!ValidarDoctor())
                {
                    MessageBox.Show("Por favor, corrija los errores antes de guardar.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _doctorActual.Cedula = txtCedulaDoctor.Text;
                _doctorActual.Nombre = txtNombreDoctor.Text;
                _doctorActual.Telefono = txtTelefonoDoctor.Text;

                if (_doctorActual.Especialidad == null)
                {
                    _doctorActual.Especialidad = new Especialidad();
                }

                var resultado = _doctorBLL.ActualizarDoctor(_doctorActual);
                if (resultado == "Doctor actualizado exitosamente.")
                {
                    MessageBox.Show("Datos actualizados correctamente",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbpConfig.SelectedIndex = 2;
                }
                else
                {
                    throw new Exception(resultado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (_pacienteActual == null) return;

                if (!ValidarPaciente())
                {
                    MessageBox.Show("Por favor, corrija los errores antes de guardar.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _pacienteActual.Cedula = txtCedula.Text;
                _pacienteActual.Nombre = txtNombrePaciente.Text;
                _pacienteActual.Apellido = txtApellidoPaciente.Text;
                _pacienteActual.Telefono = txtTelefonoPaciente.Text;
                _pacienteActual.Direccion = txtDireccionPaciente.Text;
                _pacienteActual.FechaNacimiento = dtpFechaNacimiento.Value;

                var resultado = _pacienteBLL.ActualizarPaciente(_pacienteActual);

                if (resultado == "Actualización exitosa.")
                {
                    MessageBox.Show("Datos actualizados correctamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbpConfig.SelectedIndex = 2;
                }
                else
                {
                    throw new Exception(resultado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void horafecha_Tick_1(object sender, EventArgs e)
        {
            label_hora.Text = DateTime.Now.ToString("hh:mm:ss");
            label_fecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}