using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Presentacion {
    public class NumeroDialogo
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Text = text, Width = 250 };
            TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 250 };
            Button confirmation = new Button() { Text = "Aceptar", Left = 20, Width = 100, Top = 100, DialogResult = DialogResult.OK };
            Button cancel = new Button() { Text = "Cancelar", Left = 130, Width = 100, Top = 100, DialogResult = DialogResult.Cancel };

            confirmation.Click += (sender, e) =>
            {
                if (IsValidPhoneNumber(inputBox.Text))
                {
                    prompt.DialogResult = DialogResult.OK;
                    prompt.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número de teléfono válido.", "Número de teléfono no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancel;

            return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : null;
        }

        private static bool IsValidPhoneNumber(string phoneNumber)
        {
            // Simple regex for phone number validation
            return Regex.IsMatch(phoneNumber, @"^\+?\d{10,15}$");
        }
    }
}

