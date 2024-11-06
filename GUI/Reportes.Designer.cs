using System.Drawing;
using System.Windows.Forms;

namespace Gui
{
    partial class Reportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_reportes_diarios = new Button();
            btn_facturasdentro = new Button();
            SuspendLayout();
            // 
            // btn_reportes_diarios
            // 
            btn_reportes_diarios.Anchor = AnchorStyles.Top;
            btn_reportes_diarios.BackColor = Color.FromArgb(49, 66, 82);
            btn_reportes_diarios.BackgroundImage = Properties.Resources.Diseño_sin_título__9_1;
            btn_reportes_diarios.BackgroundImageLayout = ImageLayout.Stretch;
            btn_reportes_diarios.Cursor = Cursors.Hand;
            btn_reportes_diarios.FlatStyle = FlatStyle.Flat;
            btn_reportes_diarios.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_reportes_diarios.ForeColor = Color.FromArgb(237, 237, 235);
            btn_reportes_diarios.Location = new Point(608, 145);
            btn_reportes_diarios.Name = "btn_reportes_diarios";
            btn_reportes_diarios.Size = new Size(332, 231);
            btn_reportes_diarios.TabIndex = 8;
            btn_reportes_diarios.Text = "REPORTES\r\n DIARIOS";
            btn_reportes_diarios.UseVisualStyleBackColor = false;
            // 
            // btn_facturasdentro
            // 
            btn_facturasdentro.Anchor = AnchorStyles.Top;
            btn_facturasdentro.BackColor = Color.FromArgb(49, 66, 82);
            btn_facturasdentro.BackgroundImage = Properties.Resources.Diseño_sin_título__8_2;
            btn_facturasdentro.BackgroundImageLayout = ImageLayout.Stretch;
            btn_facturasdentro.Cursor = Cursors.Hand;
            btn_facturasdentro.FlatStyle = FlatStyle.Flat;
            btn_facturasdentro.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_facturasdentro.ForeColor = Color.FromArgb(237, 237, 235);
            btn_facturasdentro.Location = new Point(240, 145);
            btn_facturasdentro.Name = "btn_facturasdentro";
            btn_facturasdentro.Size = new Size(332, 231);
            btn_facturasdentro.TabIndex = 7;
            btn_facturasdentro.Text = "FACTURAS";
            btn_facturasdentro.UseVisualStyleBackColor = false;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 237, 235);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1080, 615);
            Controls.Add(btn_reportes_diarios);
            Controls.Add(btn_facturasdentro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reportes";
            Text = "Reportes";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_reportes_diarios;
        private Button btn_facturasdentro;
    }
}