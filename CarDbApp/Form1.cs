using CarDbApp.Controls;
using CarDbApp.Models;
using CarDbApp.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CarDbApp
{
    public partial class Form1 : Form
    {
        DbService _db;


        public Form1()
        {
            InitializeComponent();
            _db = new();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_db.CarExists(1).ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var result = _db.Connect();

            if (!result)
            {
                MessageBox.Show("Nastala chyba v p�ipojen� na Db :(");
                Close();
            }
        }

        private string _filePath = string.Empty;
        private string[] _fileLines;

        private void _btnOpenCsv_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                _filePath = openFileDialog.FileName;
                var lines = File.ReadAllLines(_filePath);
                _fileLines = lines;
                var headers = lines[0].Split(';');
                _cmbCarId.Items.AddRange(headers);
                _cmbFirstDriver.Items.AddRange(headers);
                _cmbLastUpdate.Items.AddRange(headers);
                _cmbModel.Items.AddRange(headers);
                _cmbState.Items.AddRange(headers);
                _cmbSpz.Items.AddRange(headers);
            }

            _btnVerify.Enabled = true;
        }

        private List<CarModel> _cars = new List<CarModel>();

        private void _btnVerify_Click(object sender, EventArgs e)
        {
            List<CarModel> UnmergedCars = new List<CarModel>();
            for (int i = 1; i < _fileLines.Length; i++)
            {
                string[] data = _fileLines[i].Split(';');
                var car = MapCarProperties(data, i);
                UnmergedCars.Add(car);
            }

            AddCarRangeControled(UnmergedCars);

            DisplayCarRecords();
        }

        private void DisplayCarRecords()
        {
            _pnlCarRecords.Controls.Clear();
            for (int i = 0; i < _cars.Count; i++)
            {
                _cars[i].Exists = _db.CarExists(_cars[i].CarId);
                var carRecordControl = new CarRecordControl();
                carRecordControl.LoadData(_cars[i], _db);
                carRecordControl.Location = new Point(0, carRecordControl.Height * (i));
                carRecordControl.VerifyCar += OnControlVerifyCar;
                carRecordControl.DeleteCar += CarRecordControlOnDeleteCar;
                _pnlCarRecords.Controls.Add(carRecordControl);
            }
        }

        private void CarRecordControlOnDeleteCar(CarModel car)
        {
            var record_index = _cars.FindIndex(x => x.CarId == car.CarId);
            _db.DeleteCar(car);
            _cars.RemoveAt(record_index);
            DisplayCarRecords();
        }

        private void OnControlVerifyCar(CarModel car)
        {
            var record_index = _cars.FindIndex(x => x.CarId == car.CarId);
            _cars.RemoveAt(record_index);
            _cars.Insert(record_index, car);

            DisplayCarRecords();
        }

        private CarModel MapCarProperties(string[] data, int line)
        {
            CarModel car = new CarModel();
            car.Line = line;
            if (data.Length != 6)
            {
                car.Error = true;
                return car;
            }

            car.Error = !int.TryParse(data[_cmbCarId.SelectedIndex], out int id);
            car.CarId = id;
            car.Error = !int.TryParse(data[_cmbState.SelectedIndex], out int state);
            car.State = state;
            car.Error = !DateTime.TryParse(data[_cmbLastUpdate.SelectedIndex], out DateTime update);
            car.LastUpdate = update;
            car.FirstDriver = data[_cmbFirstDriver.SelectedIndex];
            car.Spz = data[_cmbSpz.SelectedIndex];
            car.Model = data[_cmbModel.SelectedIndex];
            return car;
        }

        private void _btnUpsert_Click(object sender, EventArgs e)
        {
            foreach (var car in _cars)
            {
                _db.InsertOrUpdate(car);
            }

            DisplayCarRecords();
        }

        private void _btnLoadDb_Click(object sender, EventArgs e)
        {
            AddCarRangeControled(_db.LoadCars(), true);
            DisplayCarRecords();
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            var id = _cars.Count;
            nextTry:
            if (_db.CarExists(id))
            {
                Random r = new Random();
                id = r.Next(0, int.MaxValue);
                goto nextTry;
            }

            _cars.Add(new()
            {
                CarId = id,
                State = 0,
                Error = false,
                Exists = false,
                Spz = "",
                Model = "",
                LastUpdate = DateTime.Now,
                FirstDriver = ""
            });
            DisplayCarRecords();
        }

        private void _btnClear_Click(object sender, EventArgs e)
        {
            _pnlCarRecords.Controls.Clear();
            _cars.Clear();
        }

        private void AddCarRangeControled(List<CarModel> cars, bool IsAddFromDb = false)
        {
            foreach (var car in cars)
            {
                if (!_cars.Exists(x => x.CarId == car.CarId))
                    _cars.Add(car);
                else
                {
                    var id = _cars.Count;
                    nextTry:
                    if (_db.CarExists(id))
                    {
                        Random r = new Random();
                        id = r.Next(0, int.MaxValue);
                        goto nextTry;
                    }

                    if (IsAddFromDb)
                    {
                        var record_index = _cars.FindIndex(x => x.CarId == car.CarId);
                        _cars[record_index].CarId = id;
                    }
                    else
                    {
                        car.CarId = id;
                    }


                    _cars.Add(car);
                }
            }
        }
    }
}