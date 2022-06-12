using GKH_kurs.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GKH_kurs
{
    public partial class Form1 : Form
    {
        HousesQueue houses = new HousesQueue();
        void UpdateHouseTable()
        {
            HouseGrid.AutoGenerateColumns = true;
            HouseGrid.DataSource = houses.GetEnumerator().ToList();
        }
        public Form1()
        {
            InitializeComponent();

            houses.AddHouse("Улица пушкина, дом колотушкина", 228);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateHouseTable();
        }

        private void AddHouse_Click(object sender, EventArgs e)
        {
            houses.AddHouse(Street.Text, int.Parse(HouseNum.Text));
            UpdateHouseTable();
        }

        private void DeleteHouse_Click(object sender, EventArgs e)
        {
            houses.DeleteHouse();
            UpdateHouseTable();
        }

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
                    MessageBox.Show("НАЧАЛЬНИК БЛЯТЬ!");
                }
            }
            catch
            {
                MessageBox.Show("УБЕРИТЕ ЭТОГО ГОВНОЕДА ОТ МЕНЯ НАХУЙ!");
            }
        }

        private void HouseGrid_Click(object sender, EventArgs e)
        {
            try
            {
                ApartGrip.DataSource = houses.GetHouse(Convert.ToInt32(HouseGrid.Rows[HouseGrid.SelectedCells[0].RowIndex].Cells[0].Value)).Apartments.Where(x => x != null).ToList();
            }
            catch
            {
                MessageBox.Show("УБЕРИТЕ ЭТОГО ГОВНОЕДА ОТ МЕНЯ НАХУЙ!");
            }
        }

        private void DelApar_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(ApartGrip.CurrentRow.Index.ToString());
            houses.GetHouse(Convert.ToInt32(HouseGrid.Rows[HouseGrid.SelectedCells[0].RowIndex].Cells[0].Value)).DeleteApartment(a);
            UpdateHouseTable();
            ApartGrip.DataSource = houses.GetHouse(Convert.ToInt32(HouseGrid.Rows[HouseGrid.SelectedCells[0].RowIndex].Cells[0].Value)).Apartments.Where(x => x != null).ToList();
        }
    }
}
