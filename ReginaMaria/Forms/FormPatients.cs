﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ReginaMaria
{
    public partial class FormPatients : Form
    {
        public FormPatients()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SMDODIV;Initial Catalog=ReginaMaria;Integrated Security=True");
        private void button1_Click(object sender, System.EventArgs e)
        {
            int patientId = int.Parse(patientID.Text);
            string patientFirstName = firstName.Text;
            string patientLastName = lastName.Text;
            DateTime patientBirthDate = DateTime.Parse(birthDate.Text);
            con.Open();
            SqlCommand c = new SqlCommand(" exec InsertPatient '" + patientId + "', '"+ patientFirstName + "', '" + patientLastName + "', '" + patientBirthDate + "', '" + null + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted ...");
            GetPatients(); 
        }


        private void FormPatients_Load(object sender, System.EventArgs e)
        {
            GetPatients();
        }
    }
}
