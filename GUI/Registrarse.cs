using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using Entidades;


namespace Gui
{
    public partial class Registrarse : Form
    {
        private UsuarioBLL usuarioBLL = new UsuarioBLL();

        public Registrarse()
        {
            InitializeComponent();
        }

        private void btn_minimizar_registro_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btn_atras_registro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = Login.GetInstance();
            login.Show();
        }

        private void textbox_registrar_nombres_Enter(object sender, EventArgs e)
        {
            if (textbox_registrar_nombres.Text == "NOMBRES")
            {
                textbox_registrar_nombres.Text = "";
                textbox_registrar_nombres.ForeColor = Color.DarkBlue;
            }
        }

        private void textbox_registrar_nombres_Leave(object sender, EventArgs e)
        {
            if (textbox_registrar_nombres.Text == "")
            {
                textbox_registrar_nombres.Text = "NOMBRES";
                textbox_registrar_nombres.ForeColor = Color.DimGray;
            }
        }

        private void textbox_registrar_apellidos_Enter(object sender, EventArgs e)
        {
            if (textbox_registrar_apellidos.Text == "APELLIDOS")
            {
                textbox_registrar_apellidos.Text = "";
                textbox_registrar_apellidos.ForeColor = Color.DarkBlue;
            }
        }

        private void textbox_registrar_apellidos_Leave(object sender, EventArgs e)
        {
            if (textbox_registrar_nombres.Text == "")
            {
                textbox_registrar_nombres.Text = "APELLIDOS";
                textbox_registrar_nombres.ForeColor = Color.DimGray;
            }
        }

        private void textbox_registrar_usuario_Enter(object sender, EventArgs e)
        {
            if (textbox_registrar_usuario.Text == "USUARIO")
            {
                textbox_registrar_usuario.Text = "";
                textbox_registrar_usuario.ForeColor = Color.DarkBlue;
            }
        }

        private void textbox_registrar_usuario_Leave(object sender, EventArgs e)
        {
            if (textbox_registrar_usuario.Text == "")
            {
                textbox_registrar_usuario.Text = "USUARIO";
                textbox_registrar_usuario.ForeColor = Color.DimGray;
            }
        }

        private void textbox_registrar_contrasena_Enter(object sender, EventArgs e)
        {
            if (textbox_registrar_contrasena.Text == "CONTRASEÑA")
            {
                textbox_registrar_contrasena.Text = "";
                textbox_registrar_contrasena.ForeColor = Color.DarkBlue;
            }
        }

        private void textbox_registrar_contrasena_Leave(object sender, EventArgs e)
        {
            if (textbox_registrar_usuario.Text == "")
            {
                textbox_registrar_usuario.Text = "CONTRASEÑA";
                textbox_registrar_usuario.ForeColor = Color.DimGray;
            }
        }

        private void btn_registrar_persona_Click(object sender, EventArgs e)
        {
            RegistrarPersona();
        }

        private void RegistrarPersona()
        {
            string nombres = textbox_registrar_nombres.Text;
            string apellidos = textbox_registrar_apellidos.Text;
            string usuario = textbox_registrar_usuario.Text;
            string contrasena = textbox_registrar_contrasena.Text;

            string resultado = usuarioBLL.RegistrarUsuario(nombres, apellidos, usuario, contrasena,1);

            MessageBox.Show(resultado);

            if (resultado == "Registro exitoso.")
            {
                this.Hide();
                Login.GetInstance().Show();
            }
        }
    }
}
