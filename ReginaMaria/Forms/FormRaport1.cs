using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ReginaMaria
{
    public partial class FormRaport1 : Form
    {
        public FormRaport1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SMDODIV;Initial Catalog=ReginaMaria;Integrated Security=True");

        private void List_Click(object sender, System.EventArgs e)
        {
            DateTime startDateDrug = DateTime.Parse(startDate.Text);
            DateTime endDateDrug = DateTime.Parse(endDate.Text);
            SqlCommand c = new SqlCommand("exec GetDrugReport '" + startDateDrug + "', '" + endDateDrug + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void FormRaport1_Load(object sender, EventArgs e)
        {

        }
    }
}
