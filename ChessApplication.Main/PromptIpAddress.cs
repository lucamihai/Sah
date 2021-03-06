﻿using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace ChessApplication.Main
{
    [ExcludeFromCodeCoverage]
    public static class PromptIpAddress
    {
        public static string ShowDialog()
        {
            var prompt = new Form
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "IP address",
                StartPosition = FormStartPosition.CenterScreen
            };
            var textLabel = new Label
            {
                Left = 50,
                Top = 20,
                Text = "Enter IP address"
            };
            var textBox = new TextBox
            {
                Left = 50,
                Top = 50,
                Width = 400,
                Text = "127.0.0.1"
            };
            var confirmation = new Button
            {
                Text = "Ok",
                Left = 350,
                Width = 100,
                Top = 70,
                DialogResult = DialogResult.OK
            };
            confirmation.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
