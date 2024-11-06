using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
using Logica;


namespace Gui
{
    public partial class Registrarse : Form
    {
        private UsuarioBLL usuarioBLL = new UsuarioBLL();
        private PacienteBLL pacienteBLL = new PacienteBLL();
        private ErrorProvider errorProvider;

        public Registrarse()
        {
            InitializeComponent();
            ConfigurarValidaciones();
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void ConfigurarValidaciones()
        {
            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            // Configurar eventos de validación
            textbox_registrar_nombres.Validating += ValidarNombres;
            textbox_registrar_apellidos.Validating += ValidarApellidos;
            textbox_registrar_usuario.Validating += ValidarUsuario;
            textbox_registrar_contrasena.Validating += ValidarContrasena;
        }

        private void ValidarNombres(object sender, CancelEventArgs e)
        {
            string nombres = textbox_registrar_nombres.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombres))
            {
                e.Cancel = true;
                errorProvider.SetError(textbox_registrar_nombres, "El nombre es requerido");
            }
            else if (nombres.Length < 2)
            {
                e.Cancel = true;
                errorProvider.SetError(textbox_registrar_nombres, "El nombre debe tener al menos 2 caracteres");
            }
            else if (!nombres.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                e.Cancel = true;
                errorProvider.SetError(textbox_registrar_nombres, "El nombre solo debe contener letras");
            }
            else
            {
                errorProvider.SetError(textbox_registrar_nombres, "");
            }
        }

        private void ValidarApellidos(object sender, CancelEventArgs e)
        {
            string apellidos = textbox_registrar_apellidos.Text.Trim();

            if (string.IsNullOrWhiteSpace(apellidos))
            {
                e.Cancel = true;
                errorProvider.SetError(textbox_registrar_apellidos, "El apellido es requerido");
            }
            else if (apellidos.Length < 2)
            {
                e.Cancel = true;
                errorProvider.SetError(textbox_registrar_apellidos, "El apellido debe tener al menos 2 caracteres");
            }
            else if (!apellidos.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                e.Cancel = true;
                errorProvider.SetError(textbox_registrar_apellidos, "El apellido solo debe contener letras");
            }
            else
            {
                errorProvider.SetError(textbox_registrar_apellidos, "");
            }
        }

        private void ValidarUsuario(object sender, CancelEventArgs e)
        {
            string usuario = textbox_registrar_usuario.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuario))
            {
                e.Cancel = true;
                errorProvider.SetError(textbox_registrar_usuario, "El usuario es requerido");
            }
            else if (usuario.Length < 4)
            {
                e.Cancel = true;
                errorProvider.SetError(textbox_registrar_usuario, "El usuario debe tener al menos 4 caracteres");
            }
            else if (usuario.Contains(" "))
            {
                e.Cancel = true;
                errorProvider.SetError(textbox_registrar_usuario, "El usuario no puede contener espacios");
            }
            else
            {
                // Aquí podrías agregar una validación para verificar si el usuario ya existe
                errorProvider.SetError(textbox_registrar_usuario, "");
            }
        }

        private void ValidarContrasena(object sender, CancelEventArgs e)
        {
            string contrasena = textbox_registrar_contrasena.Text;

            if (string.IsNullOrWhiteSpace(contrasena))
            {
                e.Cancel = true;
                errorProvider.SetError(textbox_registrar_contrasena, "La contraseña es requerida");
            }else
            {
                errorProvider.SetError(textbox_registrar_contrasena, "");
            }
        }

        private bool ValidarFormulario()
        {
            bool isValid = true;
            errorProvider.Clear();

            // Validar cada campo
            CancelEventArgs e = new CancelEventArgs();

            ValidarNombres(textbox_registrar_nombres, e);
            if (e.Cancel) isValid = false;

            e = new CancelEventArgs();
            ValidarApellidos(textbox_registrar_apellidos, e);
            if (e.Cancel) isValid = false;

            e = new CancelEventArgs();
            ValidarUsuario(textbox_registrar_usuario, e);
            if (e.Cancel) isValid = false;

            e = new CancelEventArgs();
            ValidarContrasena(textbox_registrar_contrasena, e);
            if (e.Cancel) isValid = false;

            return isValid;
        }

        private void RegistrarPersona()
        {
            try
            {
                if (!ValidarFormulario())
                {
                    MessageBox.Show("Por favor corrija los errores antes de continuar.",
                                  "Validación",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }

                string nombres = textbox_registrar_nombres.Text.Trim();
                string apellidos = textbox_registrar_apellidos.Text.Trim();
                string usuario = textbox_registrar_usuario.Text.Trim();
                string contrasena = textbox_registrar_contrasena.Text;

                var resultado = usuarioBLL.RegistrarNuevoUsuarioPaciente(nombres, apellidos, usuario, contrasena);

                if (resultado != null)
                {
                    MessageBox.Show("Registro exitoso", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    this.Hide();
                    Login.GetInstance().Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            textbox_registrar_nombres.Clear();
            textbox_registrar_apellidos.Clear();
            textbox_registrar_usuario.Clear();
            textbox_registrar_contrasena.Clear();
            errorProvider.Clear();
        }

        private void btn_registrar_persona_Click_1(object sender, EventArgs e)
        {
            RegistrarPersona();
        }

        private void btn_atras_registro_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login login = Login.GetInstance();
            login.Show();
        }

        private void btn_minimizar_registro_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
