using GKH_kurs.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GKH_kurs
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Очередь домов
        /// </summary>
        HousesQueue houses = new HousesQueue();
        /// <summary>
        /// Обновление таблиц с домами
        /// </summary>
        void UpdateHouseTable()
        {
            HouseGrid.AutoGenerateColumns = true;
            HouseGrid.DataSource = houses.GetEnumerator().ToList();
            HouseGrid.Columns.Remove("HouseNext");
        }
        /// <summary>
        /// Инициализация формы
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Действия при отображении формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateHouseTable();
        }
        /// <summary>
        /// Нажатие на кнопку добавления дома
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddHouse_Click(object sender, EventArgs e)
        {
            houses.AddHouse(Street.Text, int.Parse(HouseNum.Text));
            UpdateHouseTable();
        }
        /// <summary>
        /// Нажатие на кнопку удаления дома
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteHouse_Click(object sender, EventArgs e)
        {
            houses.DeleteHouse();
            UpdateHouseTable();
        }
        /// <summary>
        /// Нажатие на кнопку добавления квартиры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddApar_Click(object sender, EventArgs e)
        {
            try
            {
                if (HouseGrid.Rows[HouseGrid.SelectedCells[0].RowIndex].Cells[0].Value != null)
                {
                    houses.GetHouse(Convert.ToInt32(HouseGrid.Rows[HouseGrid.SelectedCells[0].RowIndex].Cells[0].Value)).Add(int.Parse(ApartNum.Text), float.Parse(Payment.Text));
                    UpdateHouseTable();
                    ApartGrip.DataSource = houses.GetHouse(Convert.ToInt32(HouseGrid.Rows[HouseGrid.SelectedCells[0].RowIndex].Cells[0].Value)).Apartments.Where(x => x != null).ToList();
                }
                else
                {
                    MessageBox.Show("Вы не выьрали квратиру!");
                }
            }
            catch
            {
                MessageBox.Show("Вы не выьрали квратиру!");
            }
        }
        /// <summary>
        /// Обработка нажатия на таблицу с домами, подгрузка квартир
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HouseGrid_Click(object sender, EventArgs e)
        {
            try
            {
                ApartGrip.DataSource = houses.GetHouse(Convert.ToInt32(HouseGrid.Rows[HouseGrid.SelectedCells[0].RowIndex].Cells[0].Value)).Apartments.Where(x => x != null).ToList();
            }
            catch
            {
                MessageBox.Show("Вы не выьрали квратиру!");
            }
        }
        /// <summary>
        /// Нажатие на кнопку удаления квартиры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelApar_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(ApartGrip.CurrentRow.Index.ToString());
            houses.GetHouse(Convert.ToInt32(HouseGrid.Rows[HouseGrid.SelectedCells[0].RowIndex].Cells[0].Value)).DeleteApartment(a);
            UpdateHouseTable();
            ApartGrip.DataSource = houses.GetHouse(Convert.ToInt32(HouseGrid.Rows[HouseGrid.SelectedCells[0].RowIndex].Cells[0].Value)).Apartments.Where(x => x != null).ToList();
        }
        /// <summary>
        /// Обработка нажатия на кнопку сохранения данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                using (FileStream fs = (FileStream)saveFileDialog.OpenFile())
                {
                    JsonSerializer.Serialize<HousesQueue>(new Utf8JsonWriter(fs), houses);
                }
        }
        /// <summary>
        /// Обработка нажатия на кнопку загрузки данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Load1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                using (FileStream fs = (FileStream)openFileDialog.OpenFile())
                {
                    houses = await JsonSerializer.DeserializeAsync<HousesQueue>(fs);
                    UpdateHouseTable();
                }
        }
        /// <summary>
        /// Ограничение ввода у номера дома
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HouseNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsDigit(number) && number != 8))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Ограничение ввода у номера квартиры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApartNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Ограничение ввода у оплаты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Payment_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
    }
}
