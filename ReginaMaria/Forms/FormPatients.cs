using System;
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
        void GetPatients()
        {
            SqlCommand c = new SqlCommand("exec GetPatients", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void FormPatients_Load(object sender, System.EventArgs e)
        {
            GetPatients();
        }

        private void updatePatient_Click(object sender, EventArgs e)
        {
            int patientId = int.Parse(patientID.Text);
            string patientFirstName = firstName.Text;
            string patientLastName = lastName.Text;
            DateTime patientBirthDate = DateTime.Parse(birthDate.Text);
            con.Open();
            SqlCommand c = new SqlCommand(" exec UpdatePatient '" + patientId + "', '" + patientFirstName + "', '" + patientLastName + "', '" + patientBirthDate + "', '" + null + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated ...");
            GetPatients();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int patientId = int.Parse(patientID.Text);
            con.Open();
            SqlCommand c = new SqlCommand(" exec DeletePatient '" + patientId + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Successfully Deleted ...");
            GetPatients();
        }
    }
}
