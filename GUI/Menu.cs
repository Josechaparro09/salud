using System;
using System.Runtime.InteropServices;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            AbrirFormEnPanel(new Inicio());
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_maximizar.Visible = false;
            btn_restaurar.Visible = true;
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_restaurar.Visible = false;
            btn_maximizar.Visible = true;
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(fh);
            this.panel_contenedor.Tag = fh;
            fh.Show();

        }

        private void btn_citas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Citas());
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Inicio());
        }

        private void btn_pacientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Pacientes());
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Reportes());
        }

        private void btn_doctores_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Doctores());
        }

        private void btn_cerrar_sesion_menu_Click(object sender, EventArgs e)
        {
            CerrarSesion();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel_arriba(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        

        private void CerrarSesion()
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de cerrar sesión?", "Confirmar Cierre de Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Login loginForm = Login.GetInstance();
                loginForm.Show();
                this.Close();
            }
        }
    }
}
