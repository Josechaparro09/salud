
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Gui
{
    public partial class Login : Form
    {
        private UsuarioBLL usuarioBLL = new UsuarioBLL();

        public Login()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_usuario_Enter(object sender, EventArgs e)
        {
            if (textBox_usuario.Text == "USUARIO")
            {
                textBox_usuario.Text = "";
                textBox_usuario.ForeColor = Color.DarkBlue;
            }
        }

        private void textBox_usuario_Leave(object sender, EventArgs e)
        {
            if (textBox_usuario.Text == "")
            {
                textBox_usuario.Text = "USUARIO";
                textBox_usuario.ForeColor = Color.DimGray;
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

        }

        private void textBox_contrasena_Leave(object sender, EventArgs e)
        {
            if (textBox_contrasena.Text == "")
            {
                textBox_contrasena.Text = "CONTRASEÑA";
                textBox_contrasena.ForeColor = Color.DimGray;
                textBox_contrasena.UseSystemPasswordChar = false;

            }
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Iniciodesesion();

        }

        private void Iniciodesesion()
        {

            string usuario = textBox_usuario.Text;
            string contrasena = textBox_contrasena.Text;

            bool loginExitoso = usuarioBLL.IniciarSesion(usuario, contrasena);

            if (loginExitoso)
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void btn_registrar_usuario_Click(object sender, EventArgs e)
        {
            Registrarse registro = new Registrarse(); 
            registro.Show();
            this.Hide();
        }

        private static Login instance;
        public static Login GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Login();
            }
            return instance;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
