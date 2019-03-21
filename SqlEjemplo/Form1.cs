using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SqlEjemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect(object sender, EventArgs e)
        {
            SqlConnection conection = new SqlConnection("server = HGDLAPPEREZLX\\SQLEXPRESS; database = Spotify; integrated security = true");
            try
            {
                conection.Open();
                MessageBox.Show("Conection complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                String query = "Select * from Song";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGrid1.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conection.Close();
        }

        private void btnListDB_Click(object sender, EventArgs e)
        {
            DataBasesSelection form = new DataBasesSelection();
            form.Show();
        }
    }
}
