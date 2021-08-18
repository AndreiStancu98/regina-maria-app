using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ReginaMaria
{
    public partial class FormDrugs : Form
    {
        public FormDrugs()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SMDODIV;Initial Catalog=ReginaMaria;Integrated Security=True");

        private void FormDrugs_Load(object sender, EventArgs e)
        {
            GetDrugs();
        }

        private void addDrugs_Click(object sender, EventArgs e)
        {
            int DrugId = int.Parse(drugID.Text);
            string DrugName = drugName.Text;
            int Quantity = int.Parse(quantity.Text);
            string Dosage = dosage.Text;
            int PrescriptionId = int.Parse(prescriptionID.Text);
            con.Open();
            SqlCommand c = new SqlCommand(" exec InsertDrug '" + DrugId + "', '" + DrugName + "', '" + Quantity + "', '" + Dosage + "', '" + PrescriptionId + "'", con);
            c.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Inserted ...");
            GetDrugs();
        }
        void GetDrugs()
        {
            SqlCommand c = new SqlCommand("exec ListDrugs", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void updateDrugs_Click(object sender, EventArgs e)
        {
            int DrugId = int.Parse(drugID.Text);
            string DrugName = drugName.Text;
            int Quantity = int.Parse(quantity.Text);
            string Dosage = dosage.Text;
            int PrescriptionId = int.Parse(prescriptionID.Text);
            con.Open();
            SqlCommand c = new SqlCommand(" exec UpdateDrug '" + DrugId + "', '" + DrugName + "', '" + Quantity + "', '" + Dosage + "', '" + PrescriptionId + "'", con);
            c.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated ...");
            GetDrugs();
        }

        private void deleteDrug_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete?", "Delete Drugs", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int drugId = int.Parse(drugID.Text);
                con.Open();
                SqlCommand c = new SqlCommand(" exec DeleteDrug '" + drugId + "'", con);
                c.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Deleted ...");
                GetDrugs();
            }
        }
    }
}
