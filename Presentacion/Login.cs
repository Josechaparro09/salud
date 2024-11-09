
using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Gui
{
    public partial class Login : Form
    {
        private UsuarioBLL usuarioBLL = new UsuarioBLL();
        private ErrorProvider errorProvider;

        public Login()
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
            textBox_usuario.Validating += ValidarUsuario;
            textBox_contrasena.Validating += ValidarContrasena;
        }

        private void ValidarUsuario(object sender, CancelEventArgs e)
        {
            string usuario = textBox_usuario.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuario) || usuario == "USUARIO")
            {
                e.Cancel = true;
                errorProvider.SetError(textBox_usuario, "Ingrese un usuario");
            }else
            {
                errorProvider.SetError(textBox_usuario, "");
            }
        }

        private void ValidarContrasena(object sender, CancelEventArgs e)
        {
            string contrasena = textBox_contrasena.Text;

            if (string.IsNullOrWhiteSpace(contrasena) || contrasena == "CONTRASEÑA")
            {
                e.Cancel = true;
                errorProvider.SetError(textBox_contrasena, "Ingrese una contraseña");
            }else
            {
                errorProvider.SetError(textBox_contrasena, "");
            }
        }

        private bool ValidarFormulario()
        {
            bool isValid = true;
            errorProvider.Clear();

            // Validar campos
            CancelEventArgs e = new CancelEventArgs();

            ValidarUsuario(textBox_usuario, e);
            if (e.Cancel) isValid = false;

            e = new CancelEventArgs();
            ValidarContrasena(textBox_contrasena, e);
            if (e.Cancel) isValid = false;

            return isValid;
        }

        private void Iniciodesesion()
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

                string usuario = textBox_usuario.Text.Trim();
                string contrasena = textBox_contrasena.Text;

                Usuario usuarioValidado = usuarioBLL.IniciarSesion(usuario, contrasena);

                if (usuarioValidado != null)
                {
                    LimpiarCampos();
                    Menu menu = new Menu(usuarioValidado);
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    errorProvider.SetError(textBox_usuario, "Usuario o contraseña incorrectos");
                    errorProvider.SetError(textBox_contrasena, "Usuario o contraseña incorrectos");
                    MessageBox.Show("Usuario o contraseña incorrectos.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            textBox_usuario.Text = "USUARIO";
            textBox_usuario.ForeColor = Color.DimGray;
            textBox_contrasena.Text = "CONTRASEÑA";
            textBox_contrasena.ForeColor = Color.DimGray;
            textBox_contrasena.UseSystemPasswordChar = false;
            errorProvider.Clear();
        }



        // Singleton pattern
        private static Login instance;
        public static Login GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Login();
            }
            return instance;
        }

        // Window dragging functionality
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Agregar validación al presionar Enter en los campos



        private void btn_cerrar_login_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_login_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_registrar_usuario_Click_1(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;

            try
            {
                Registrarse registro = new Registrarse();
                registro.Show();
                this.Hide();
            }
            finally
            {
                // Restaurar la validación
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            }
        }

        private void textBox_usuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox_contrasena_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btn_ingresar_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.AutoValidate = AutoValidate.Disable;
                Iniciodesesion();
            }
            finally { this.AutoValidate = AutoValidate.EnableAllowFocusChange; }
        }

        private void textBox_contrasena_Leave_1(object sender, EventArgs e)
        {
            if (textBox_contrasena.Text == "")
            {
                textBox_contrasena.Text = "CONTRASEÑA";
                textBox_contrasena.ForeColor = Color.DimGray;
                textBox_contrasena.UseSystemPasswordChar = false;
            }
        }

        private void textBox_contrasena_Enter(object sender, EventArgs e)
        {
            if (textBox_contrasena.Text == "CONTRASEÑA")
            {
                textBox_contrasena.Text = "";
                textBox_contrasena.ForeColor = Color.DarkBlue;
                textBox_contrasena.UseSystemPasswordChar = true;
            }
            errorProvider.SetError(textBox_contrasena, "");
        }

        private void textBox_usuario_Leave(object sender, EventArgs e)
        {
            if (textBox_usuario.Text == "")
            {
                textBox_usuario.Text = "USUARIO";
                textBox_usuario.ForeColor = Color.DimGray;
            }
        }

        private void textBox_usuario_Enter(object sender, EventArgs e)
        {
            if (textBox_usuario.Text == "USUARIO")
            {
                textBox_usuario.Text = "";
                textBox_usuario.ForeColor = Color.DarkBlue;
            }
            errorProvider.SetError(textBox_usuario, "");
        }

        private async void btnTest_Click(object sender, EventArgs e)
        {
            var whatsappCliente = new ClienteWhatsApp();
            bool prueba;
            //prueba = await whatsappCliente.EnviarMensajePlantillaSimpleAsync("573107214943", "hello_world","en_US");

            var variables = new Dictionary<string, string>
            {
                { "1", "Jose Chaparro" },
                { "2", "Pediatria" },
                { "3", "02/04/2025" },
                { "4", "11:00 am" },
                { "5", "Elver Galarga" }
            };

            prueba = await whatsappCliente.EnviarMensajePlantillaConVariablesAsync("573216228430", "enviarinfocita", variables);
            MessageBox.Show(prueba.ToString());
        }
    }
}
