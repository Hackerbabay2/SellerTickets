using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PhoneNumber.Text != "" && EmailAdress.Text != "")
            {
                ResetAlert();

                if (PhoneNumber.Text.Length > 11)
                    ShowAlert(PhoneNumberAlert,Color.Red);
                else if (EmailAdress.Text.Length > 40)
                    ShowAlert(EmailAdressAlert,Color.Red);
                else
                {
                    Form5 choseRoute = new Form5();
                    choseRoute.Show();
                    Hide();
                }
            }
        }

        private void ShowAlert(Label label, Color color)
        {
            label.BackColor = color;
            label.Show();
        }

        private void ResetAlert()
        {
            List<Label> alerts = new List<Label> { PhoneNumberAlert, EmailAdressAlert, Alert};

            foreach (var alert in alerts)
            {
                alert.BackColor = Color.White;
                alert.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}