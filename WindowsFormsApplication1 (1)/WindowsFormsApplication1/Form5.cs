using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        private string _routePath = "Route.txt";
        private Date _date;
        private Random _random;

        public Form5()
        {
            InitializeComponent();
            _random = new Random();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Elector elector = new Elector(listFromBox, listToBox);

            if (!File.Exists(_routePath))
                File.CreateText(_routePath).Close();

            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listToBox.GetItemText(listToBox.SelectedItem) != listFromBox.GetItemText(listFromBox.SelectedItem))
                labelInfo.Text = $"Вы поедите маршрутом: {listFromBox.GetItemText(listFromBox.SelectedItem)} ----> {listToBox.GetItemText(listToBox.SelectedItem)}";
            else
                labelInfo.Text = "Нет маршрутов в один город";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listToBox.GetItemText(listToBox.SelectedItem) != listFromBox.GetItemText(listFromBox.SelectedItem))
            {
                if (listView1.Items.Count > 0)
                {
                    Base baseRoute = new Base();
                    baseRoute.AddRoute(_routePath,listFromBox.GetItemText(listFromBox.SelectedItem), listToBox.GetItemText(listToBox.SelectedItem));
                    Form4 choseTrain = new Form4(this._date);
                    choseTrain.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Выберете дату");
                }
            }
            else
            {
                MessageBox.Show("не выбран/неправильный маршрут");
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            _date = new Date(dateTimePicker1);
            _date.SetArrivalTime(_random);
            _date.LoadDates(listView1);
        }
    }

    class Base
    {

        public Base()
        {
        }

        public void AddRoute(string path,string from, string to)
        {
            File.WriteAllText(path,$"Маршрут: {from} --> {to}");
        }
    }

    class Elector
    {
        private List<Country> _countries;
        private string[] _names;

        public Elector(ListBox from, ListBox to)
        {
            _countries = new List<Country>();
            _names = new string[] { "Братск","Москва","Иркутск","Казань","Санкт-Питербург","Крым"};
            from.Items.Clear();
            to.Items.Clear();
            from.Items.AddRange(_names);
            to.Items.AddRange(_names);
        }
    }

    class Country
    {
        private string _name;

        public Country(string name)
        {
            _name = name;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Название города: {_name}");
        }
    }

    public class Date
    {
        private DateTimePicker _dispatchTime;
        private DateTimePicker _arrivalTime;
        private Random _random;

        public DateTimePicker DispatchTime => _dispatchTime;
        public DateTimePicker ArrivalTime => _arrivalTime;

        public Date(DateTimePicker date)
        {
            _random = new Random();
            _dispatchTime = new DateTimePicker();
            _arrivalTime = new DateTimePicker();
            _dispatchTime.Value = date.Value;
            _dispatchTime.Value = new DateTime(
                date.Value.Year,
                date.Value.Month,
                _random.Next(date.Value.Day,DateTime.DaysInMonth(date.Value.Year,date.Value.Month)),
                _random.Next(date.Value.Hour, date.MaxDate.Hour),
                _random.Next(date.Value.Minute, date.MaxDate.Minute),
                _random.Next(date.Value.Second, date.MaxDate.Second));
            _arrivalTime.Value = date.Value;
        }

        public void SetArrivalTime(Random random)
        {
            _arrivalTime.Value = _dispatchTime.Value.AddDays(random.Next(1,6));
            _arrivalTime.Value = _arrivalTime.Value.AddHours(random.Next(-5,5));
        }

        public void LoadDates(ListView listView)
        {
            ListViewItem items = null;

            items = new ListViewItem(new string[]
            {
                _dispatchTime.Value.ToString(),
                _arrivalTime.Value.ToString()
            });

            listView.Items.Add(items);
        }
    }
}
