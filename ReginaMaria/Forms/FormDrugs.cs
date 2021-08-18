using System;
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
        }
    }
}
