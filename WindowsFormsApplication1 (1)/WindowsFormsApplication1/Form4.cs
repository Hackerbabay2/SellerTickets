using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        TrainStation station = new TrainStation();
        Basket basket = new Basket();

        private string _path = "Tickets.txt";
        private int _price;
        private Random _random;
        public Date Date { get; private set; }

        public Form4(Date date)
        {
            Date = date;
            InitializeComponent();
            _random = new Random();
            _price = _random.Next(3000,7000);
        }

        private void TrainNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FastetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ReservedSeatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (!File.Exists(_path))
                File.CreateText(_path).Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowPlaceInCarriages_Click(object sender, EventArgs e)
        {
            CarriageListInfo.Text = "";
            station.ShowPlaceInCarriageByIndex(NumberTrainNumeric,NumberCarriageNumeric,CarriageListInfo);
        }

        private void ShowAllTrain_Click(object sender, EventArgs e)
        {
            TrainsList.Text = "";
            station.ShowTrains(TrainsList);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowCarriagesButton_Click(object sender, EventArgs e)
        {
            CarriagesInfoTextBox.Text = "";
            station.ShowInfoCarriagesByindexTrain(NumberTrainNumeric, CarriagesInfoTextBox);
        }

        private void ShowTrain_Click(object sender, EventArgs e)
        {
            station.ShowInfoTrainByIndex(NumberTrainNumeric, TrainInfoTextBox);
        }

        private void ShowFreePlaceButton_Click(object sender, EventArgs e)
        {
            CarriageListInfo.Text = "";
            station.ShowFreePlaceInCarriageByIndex(NumberTrainNumeric,NumberCarriageNumeric,CarriageListInfo);
        }

        private void AddTicketButton(object sender, EventArgs e)
        {
            BasketTextBox.Text = "";
            basket.TryAddTicket(NumberTrainNumeric,NumberCarriageNumeric,NumberPlaceNumeric,station);
            basket.WriteInfo(BasketTextBox);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (basket.TicketCount > 0)
            {
                if (!File.Exists("CountTicket.txt"))
                    File.CreateText("CountTicket.txt").Close();
                
                File.WriteAllText("CountTicket.txt", $"{basket.TicketCount}");
                File.WriteAllText(_path,"");
                basket.LoadData(_path, Date);

                Form6 Final = new Form6(this,_price);
                Final.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Выберите билет");
            }
        }
    }

    class Basket
    {
        private List<Ticket> _tickets;

        public int TicketCount => _tickets.Count;

        public Basket()
        {
            _tickets = new List<Ticket>();
        }

        public void TryAddTicket(NumericUpDown numberTrain, NumericUpDown numberCarriage, NumericUpDown numberPlace, TrainStation station)
        {
            try
            {
                if (station.GetBoolPlace((int)numberTrain.Value - 1,(int)numberCarriage.Value - 1,(int)numberPlace.Value - 1))
                {
                    Train train = station.GetTrainByIndex((int)numberTrain.Value - 1);
                    Carriage carriage = train.GetCarriageByIndex((int)numberCarriage.Value - 1);
                    Place place = carriage.GetPlaceByIndex((int)numberPlace.Value - 1);
                    _tickets.Add(new Ticket(train,carriage,place));
                    carriage.SetBoolPlace((int)numberPlace.Value -1,false);
                }
                else
                {
                    MessageBox.Show("Билет на это место уже занят");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте введенные данные");
            }
        }

        public void WriteInfo(RichTextBox textbox)
        {
            textbox.Text = GetInfo();
        }

        public void LoadData(string path, Date date)
        {
            File.WriteAllText(path,"");
            string text = "";

            foreach (Ticket ticket in _tickets)
                text += ticket.GetInfo() + "\n";

            File.WriteAllText(path,text + $"{date.DispatchTime.Value} --> {date.ArrivalTime.Value}");
        }

        private string GetInfo()
        {
            string info = "";

            foreach (Ticket ticket in _tickets)
                info += ticket.GetInfo();

            return info;
        }
    }

    class Ticket
    {
        private Train _train;
        private Carriage _carriage;
        private Place _place;

        public Ticket(Train train,Carriage carriage,Place place)
        {
            _train = train;
            _carriage = carriage;
            _place = place;
        }

        public string GetInfo()
        {
            string info = $"Номер поезда - {_train.Number} Тип поезда - {_train.TypeTrain}\nНомер вагона - {_carriage.Number} Тип вагона - {_carriage.TypeCarriage}\nМесто - {_place.Number}\n\n";
            return info;
        }
    }

    class TrainStation
    {
        private List<Train> _trains;
        private const int CountTrains = 10;
        private Random random;

        public List<Train> Trains => _trains;

        public TrainStation()
        {
            random = new Random();
            _trains = new List<Train>();

            for (int i = 0; i < CountTrains; i++)
                _trains.Add(new Train(i + 1, ref random));
        }

        public Train GetTrainByIndex(int index)
        {
            return _trains[index];
        }

        public void ShowTrains(RichTextBox trainsList)
        {
            foreach (Train train in _trains)
                trainsList.Text += train.ShowInfo();
        }

        public void ShowInfoTrainByIndex(NumericUpDown trainsNumber, RichTextBox trainInfo)
        {
            try
            {
                trainInfo.Text = _trains[(int)trainsNumber.Value - 1].ShowInfo();
            }
            catch (Exception)
            {
                MessageBox.Show("Такого поезда нет!");
            }
        }

        public void ShowInfoCarriagesByindexTrain(NumericUpDown trainsNumber, RichTextBox carriagesInfo)
        {
            try
            {
                _trains[(int)trainsNumber.Value - 1].SowInfoCarriages(carriagesInfo);
            }
            catch (Exception)
            {
                MessageBox.Show("Указан не вернный поезд");
            }
        }

        public void ShowPlaceInCarriageByIndex(NumericUpDown trainNumber, NumericUpDown carriageNumber, RichTextBox carriagePlacesTextBox)
        {
            try
            {
                _trains[(int)trainNumber.Value-1].OnShowAllPlace((int)carriageNumber.Value-1,carriagePlacesTextBox);
            }
            catch (Exception)
            {
                MessageBox.Show("Нету такого вагона!");
            }
        }

        public void ShowFreePlaceInCarriageByIndex(NumericUpDown trainNumber, NumericUpDown carriageNumber, RichTextBox carriageFreePlacesTextBox)
        {
            try
            {
                _trains[(int)trainNumber.Value-1].OnShowFreePlace((int)carriageNumber.Value-1, carriageFreePlacesTextBox);
            }
            catch (Exception)
            {
                MessageBox.Show("Нету такого вагона!");
            }
        }

        public bool GetBoolPlace(int numberTrain, int numberCarriage,int numberPlace)
        {
            return _trains[numberTrain].Carriages[numberCarriage].Places[numberPlace].GetInfo();
        }
    }

    class Train
    {
        private int _number;
        private List<Carriage> _carriages;
        private string _typeTrain;
        private int _minCountCarriages = 15;
        private int _maxCountCarriages = 20;
        private List<string> _exampleType;

        public List<Carriage> Carriages => _carriages;
        public int Number => _number;
        public string TypeTrain => _typeTrain;

        public Train(int number,ref Random random)
        {
            _number = number;
            _carriages = new List<Carriage>();
            _exampleType = new List<string>() { "Пассажирский", "Скоростной"};
            _typeTrain = _exampleType[random.Next(0,_exampleType.Count)];
            int count = random.Next(_minCountCarriages,_maxCountCarriages);

            for (int i = 0; i < count; i++)
                _carriages.Add(new Carriage(i + 1, ref random));
        }

        public Carriage GetCarriageByIndex(int index)
        {
            return _carriages[index];
        }

        public void SowInfoCarriages(RichTextBox textBox)
        {
            foreach (Carriage carriage in _carriages)
                textBox.Text += carriage.ShowInfo();
        }

        public string ShowInfo()
        {
            string info = $"Номер поезда - {_number}\nКоличество вогонов - {_carriages.Count}\nТип поезда - {_typeTrain}\n\n";
            return info;
        }

        public void OnShowAllPlace(int numberCarriage, RichTextBox carriagePlaces)
        {
            _carriages[numberCarriage].ShowAllPlace(carriagePlaces);
        }

        public void OnShowFreePlace(int numberCarriage, RichTextBox carriageFreePlaces)
        {
            _carriages[numberCarriage].ShowFreePlace(carriageFreePlaces);
        }
    }

    class Carriage
    {
        private List<Place> _places;
        private int _number;
        private int _countFreePlace = 54;
        private string _typeCarriage;
        private List<string> _exampleType;

        public int Number => _number;
        public string TypeCarriage => _typeCarriage;
        public List<Place> Places => _places;

        public Carriage(int number, ref Random random)
        {
            _number = number;
            _places = new List<Place>();
            _exampleType = new List<string> { "Плацкарт", "Купе"};
            _typeCarriage = _exampleType[random.Next(0,_exampleType.Count)];

            if (_typeCarriage == "Купе")
                _countFreePlace = 36;

            for (int i = 0; i < _countFreePlace; i++)
                _places.Add(new Place(i + 1,ref random));
        }

        public Place GetPlaceByIndex(int index)
        {
            return _places[index];
        }

        public void ShowAllPlace(RichTextBox textBox)
        {
            for (int i = 0; i < _places.Count; i++)
                textBox.Text += $"{i + 1}.Место - {_places[i].GetInfo()}\n";
        }

        public string ShowInfo()
        {
            string info = $"Номер вагона - {_number}, Мест - {_places.Count} Тип - {_typeCarriage}\n";
            return info;
        }

        public void ShowFreePlace(RichTextBox textBox)
        {
            for (int i = 0; i < _places.Count; i++)
            {
                if (_places[i].GetInfo())
                    textBox.Text += $"{i + 1}.Место - {_places[i].GetInfo()}\n";
            }
        }

        public void SetBoolPlace(int index, bool free)
        {
            _places[index].SetIsFree(free);
        }
    }

    class Place
    {
        private bool _isFree;
        private int _number;

        public int Number => _number;

        public Place(int number,ref Random random)
        {
            _number = number;
            _isFree = random.Next(0,2) > 0;
        }

        public void SetIsFree(bool free)
        {
            _isFree = free;
        }

        public bool GetInfo()
        {
            return _isFree;
        }
    }
}