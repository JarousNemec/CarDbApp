using CarDbApp.Models;
using CarDbApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDbApp.Controls
{
    public partial class CarRecordControl : UserControl
    {
        public delegate void VerifyCarDelegate(CarModel car);

        public event VerifyCarDelegate VerifyCar;
        
        public delegate void DeleteCarDelegate(CarModel car);

        public event DeleteCarDelegate DeleteCar;
        private DbService _db;
        private CarModel _currentCarRecord;
        private bool IsAvailable = false;

        public CarRecordControl()
        {
            InitializeComponent();
        }

        private void CarRecordControl_Load(object sender, EventArgs e)
        {
        }

        public void LoadData(CarModel car, DbService db)
        {
            _db = db;
            _currentCarRecord = car;
            _lblCarId.Text = car.CarId.ToString();
            _cmbState.SelectedIndex = car.State;
            _txtSpz.Text = car.Spz;
            _txtModel.Text = car.Model;
            _dtpLastUpdate.Value = car.LastUpdate;
            _txtFirstDriver.Text = car.FirstDriver;
            IsAvailable = true;
            BackColor = Color.Lime;
            if (!car.Exists)
                BackColor = Color.Yellow;
            if (car.Error)
                BackColor = Color.Red;
            if (car.Exists && car.Error)
                BackColor = Color.Orange;
        }

        private void _btnVerify_Click(object sender, EventArgs e)
        {
            var data = new string[]
            {
                _lblCarId.Text, _cmbState.SelectedIndex.ToString(), _txtSpz.Text, _txtModel.Text,
                _dtpLastUpdate.Value.ToString(), _txtFirstDriver.Text
            };
            var car = MapCarProperties(data, _currentCarRecord.Line);
            VerifyCar?.Invoke(car);
        }

        private void _ValueChanged(object sender, EventArgs e)
        {
            if (IsAvailable)
                _btnVerify.Enabled = true;
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

            car.Error = !int.TryParse(data[0], out int id);
            car.CarId = id;
            car.Error = !int.TryParse(data[1], out int state);
            car.State = state;
            car.Error = !DateTime.TryParse(data[4], out DateTime update);
            car.LastUpdate = update;
            car.FirstDriver = data[5];
            car.Spz = data[2];
            car.Model = data[3];
            car.Exists = _db.CarExists(_currentCarRecord.CarId);
            return car;
        }

        private void _btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCar?.Invoke(_currentCarRecord);
        }
    }
}