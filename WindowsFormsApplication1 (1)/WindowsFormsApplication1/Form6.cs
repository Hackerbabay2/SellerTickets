using System;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form6 : Form
    {
        private string _ticketsPath = "Tickets.txt";
        private string _routePath = "Route.txt";
        private string _countTicketsPath = "CountTicket.txt";
        private Form4 _form4;
        private int _price;

        public Form6(Form4 form4, int price)
        {
            if (form4 != null)
                _form4 = form4;

            _price = price;
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            BaseInfo baseInfo = new BaseInfo(_routePath,_ticketsPath,richTextBox1, label1);
            Random random = new Random();
            int count;

            if (int.TryParse(File.ReadAllText(_countTicketsPath), out count))
            {
                label2.Text = $"Цена за билет(ы): {_price * count} рублей";
                label3.Text = $"Цена за один билет: {_price}";
                label8.Text = $"Время отправки --> время прибытия: {_form4.Date.DispatchTime.Value} --> {_form4.Date.ArrivalTime.Value}";
            }
            else
            {
                label2.Text = "None";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _form4.Visible = true;   
            Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (maskedTextBox2.Text != "" && maskedTextBox1.Text != "" && NameSecondName.Text != "" && maskedTextBox3.Text != "")
            {
                Buy buyForm = new Buy();
                buyForm.Show();
                Hide();
            }else
            {
                MessageBox.Show("Введите все данные карты");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CardNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameSecondName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }

    class BaseInfo
    {

        public BaseInfo(string routePath,string ticketsPath,RichTextBox richTextBox, Label label)
        {
            label.Text = File.ReadAllText(routePath);
            richTextBox.Text = File.ReadAllText(ticketsPath);
        }
    }
}
