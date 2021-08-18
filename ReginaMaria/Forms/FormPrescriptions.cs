﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ReginaMaria
{
    public partial class FormPrescriptions : Form
    {
        public FormPrescriptions()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SMDODIV;Initial Catalog=ReginaMaria;Integrated Security=True");

        private void addPrescription_Click(object sender, System.EventArgs e)
        {
            int prescriptionId = int.Parse(prescriptionID.Text);
            string prescriptionSeries = series.Text;
            int prescriptionNumber = int.Parse(number.Text);
            DateTime prescriptionReleaseDate = DateTime.Parse(releaseDate.Text);
            int patientId = int.Parse(patientID.Text);
            con.Open();
            SqlCommand c = new SqlCommand(" exec InsertPrescription '" + prescriptionId + "', '" + prescriptionSeries + "', '" + prescriptionNumber + "', '" + prescriptionReleaseDate + "', '" + patientId + "'", con);
            c.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Inserted ...");
            GetPrescriptions();
        }
        void GetPrescriptions()
        {
            SqlCommand c = new SqlCommand("exec ListPrescriptions", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void FormPrescriptions_Load(object sender, EventArgs e)
        {
            GetPrescriptions();
        }
    }
}
