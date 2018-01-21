using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The program will now close.");
            this.Close();

        }

        List<string> streets = new List<string>();
        private void BtnAddStreet_Click(object sender, EventArgs e)
        {
            Street addStreet = new Street()
            {
                StreetName = txtStreetName.Text
            };

            try
            {
                if (string.IsNullOrWhiteSpace(txtStreetName.Text))
                {
                    MessageBox.Show("You must enter a street name!");
                    return;
                }
                StreetsDB.AddStreet(addStreet);
                MessageBox.Show("Street Added!");
                PopulateStreetComboBox();
                PopulateStreetList();

                txtStreetName.Clear();
                txtStreetName.Focus();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("We are having server issues, please try again later");
            }
            
        }

        private void lstStreets_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void PopulateStreetList()
        {
            lstStreets.Items.Clear();

            try
            {
                List<Street> streets = StreetsDB.GetAllStreets();

                foreach (Street street in streets)
                {
                    lstStreets.Items.Add(street);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("We are having trouble loading data, try again later");
                Application.Exit();
            }
        }

        private void PopulateStreetComboBox()
        {
            cboStreetName.Items.Clear();

            try
            {
                List<Street> streets = StreetsDB.GetAllStreets();

                foreach (Street street in streets)
                {
                    cboStreetName.Items.Add(street);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("We are having trouble loading data, try again later");
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateStreetComboBox();
            PopulateStreetList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Street delete = new Street();


            delete.StreetName = streets[cboStreetName.SelectedIndex];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PopulateStreetList();
            PopulateStreetComboBox();
        }
    }
}
