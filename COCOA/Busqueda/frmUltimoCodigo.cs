using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COCOA.Busqueda
{
    public partial class frmUltimoCodigo : Form
    {
        public frmUltimoCodigo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string CodigoProducto = null;

            string mainconn = ConfigurationManager.ConnectionStrings["COCOA.Properties.Settings.COCOAConnectionString"].ConnectionString;
            SqlConnection Conn = new SqlConnection(mainconn);

            string sql = "select MAX(CodigoProducto) as CodigoProducto from Productos where CodigoProducto like'" + prefijoTextBox.Text + "%'";

            SqlCommand cmd = new SqlCommand(sql, Conn);
            Conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                if (reader.Read() == true)
                {
                    codigoTextBox.Text = reader["CodigoProducto"].ToString();
                    codigoTextBox.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un prefijo válido");
            }
            Conn.Close();
        }
    }
}
