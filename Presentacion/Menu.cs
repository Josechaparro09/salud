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
using Entidades;
using Logica;

namespace Gui
{
    public partial class Menu : Form
    {
        private Usuario usuarioActual;
        private Paciente pacienteActual;
        private Doctor doctorActual;
        private Configuracion configuracion;

        public Menu(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            ConfigurarPermisos();
            AbrirFormEnPanel(new Inicio());
            pacienteActual = ObtenerPaciente();
            VerificarDatosUsuario();
        }

        private Paciente ObtenerPaciente()
        {

            var pacienteBLL = new PacienteBLL();
            var paciente = pacienteBLL.ObtenerPacientePorIdUsuario(usuarioActual.IdUsuario);
            return paciente;
        }

        private void ConfigurarPermisos()
        {
            try
            {
                if (usuarioActual.Rol.NombreRol.ToLower() == "paciente")
                {
                    btn_doctores.Visible = false;
                    btn_pacientes.Visible = false;
                    btn_reportes.Visible = false;
                    pDoctores.Visible = false;
                    pPacientes.Visible = false;

                    if (lbl_usuario != null)
                        lbl_usuario.Text = $"Paciente: {usuarioActual.Nombres} {usuarioActual.Apellidos}";
                }
                else if (usuarioActual.Rol.NombreRol.ToLower() == "doctor")
                {
                    btn_pacientes.Visible = false;
                    btn_doctores.Visible = false;
                    pPacientes.Visible= false;
                    pDoctores.Visible= false;

                    if (lbl_usuario != null)
                        lbl_usuario.Text = $"Doctor: {usuarioActual.Nombres} {usuarioActual.Apellidos}";
                }
                else if (usuarioActual.Rol.NombreRol.ToLower() == "admin")
                {
                    if (lbl_usuario != null)
                        lbl_usuario.Text = $"Administrador: {usuarioActual.Nombres} {usuarioActual.Apellidos}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al configurar permisos: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AbrirFormEnPanel(object formhija)
        {
            try
            {
                if (this.panel_contenedor.Controls.Count > 0)
                    this.panel_contenedor.Controls.RemoveAt(0);

                Form fh = formhija as Form;

                if (fh is IUsuarioForm usuarioForm)
                {
                    usuarioForm.SetUsuario(usuarioActual);
                }

                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panel_contenedor.Controls.Add(fh);
                this.panel_contenedor.Tag = fh;
                fh.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir formulario: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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



        private void btn_citas_Click(object sender, EventArgs e)
        {
            var role = usuarioActual.Rol.NombreRol;
            
            AbrirFormEnPanel(new Citas(pacienteActual,role,usuarioActual));
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
        private static Menu instance;
        public static Menu GetInstance(Usuario usuario)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Menu(usuario);
            }
            return instance;
        }

        private void btn_cerrar_sesion_menu_Click_1(object sender, EventArgs e)
        {
            CerrarSesion();
        }

        private void btn_reportes_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Reportes());
        }

        private void btn_doctores_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Doctores());
        }

        private void btn_pacientes_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Pacientes());
        }

        private void btn_citas_Click_1(object sender, EventArgs e)
        {
            var role = usuarioActual.Rol.NombreRol;

            AbrirFormEnPanel(new Citas(pacienteActual, role,usuarioActual));
        }

        private void btn_minimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_restaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_restaurar.Visible = false;
            btn_maximizar.Visible = true;
        }

        private void btn_cerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void VerificarDatosUsuario()
        {
            if (pacienteActual.Cedula == ""||pacienteActual.Telefono=="")
            {
                btn_citas.Enabled = false;
                AbrirFormEnPanel(configuracion = new Configuracion(usuarioActual));
                MessageBox.Show("Por favor complete los datos del paciente, Telefono, Cedula");
            }
            else
            {
                btn_citas.Enabled = true;
            }
        }
        private void btnConfig_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Configuracion(usuarioActual));
        }

        private void timerVerificarDatos_Tick(object sender, EventArgs e)
        {
            if (configuracion==null) return;
            pacienteActual = configuracion.Paciente;
            if (pacienteActual==null) return;
            if (pacienteActual.Cedula == "" || pacienteActual.Telefono == "")
            {
                btn_citas.Enabled = false;
                MessageBox.Show("Por favor complete los datos del paciente, Telefono, Cedula");
                AbrirFormEnPanel(new Configuracion(usuarioActual));
            }
            else
            {
                btn_citas.Enabled = true;
            }
        }

        private void Menu_Enter(object sender, EventArgs e)
        {
            
        }
    }

    public interface IUsuarioForm
    {
        void SetUsuario(Usuario usuario);
    }
}

