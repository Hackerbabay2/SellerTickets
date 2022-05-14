using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SecondName.Text != "" && FirstName.Text != "" && LastName.Text != "")
            {
                ResetAlerts();

                if (SecondName.Text.Length > 35)
                    ShowAlert(SecondNameAlert, Color.Red);
                else if (FirstName.Text.Length > 35)
                    ShowAlert(FirstNameAlert, Color.Red);
                else if (LastName.Text.Length > 35)
                    ShowAlert(LastNameAlert, Color.Red);
                else
                {
                    Form3 ContactAdressUserForm = new Form3();
                    ContactAdressUserForm.Show();
                    Hide();
                }
            }else
            {
                ShowAlert(Alert, Color.Red);
            }
        }

        private void ShowAlert(Label label, Color color)
        {
            label.BackColor = color;
            label.Show();
        }

        private void ResetAlerts()
        {
            List<Label> labels = new List<Label> { FirstNameAlert, SecondNameAlert, LastNameAlert, Alert };

            foreach (var alert in labels)
            {
                alert.BackColor = Color.White;
                alert.Hide();
            }
        }

        private void SecondName_KeyPress(object sender, KeyPressEventArgs e)
        {
            AbortNumbers(e);
        }

        private void FirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            AbortNumbers(e);
        }

        private void LastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            AbortNumbers(e);
        }

        private void AbortNumbers(KeyPressEventArgs e)
        {
            char input = e.KeyChar;

            if (Char.IsDigit(input))
                e.Handled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}