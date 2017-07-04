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

namespace XmlProject_DataSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Server=DESKTOP-JR14CHH\\SQLEXPRESS; Database=NORTHWND;Integrated Security=true;");
            SqlDataAdapter adp = new SqlDataAdapter("select * from [Order Details]", baglanti);
            DataSet ds = new DataSet();
            adp.Fill(ds,"SiparisDetay");
            ds.WriteXml("siparisdetay.xml");
            MessageBox.Show("XML oluşturuldu ve kayıt edildi.", "XmlProject_DataSet", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("siparisdetay.xml");
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
