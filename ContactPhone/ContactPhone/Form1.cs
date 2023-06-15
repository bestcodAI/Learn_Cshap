using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace ContactPhone
{
    public partial class Form1 : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        void GetData()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\database_Acc\\db_database.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT * FROM userData",conn);
            conn.Open();
            adapter.Fill(dt);
            //dgwUsers.DataSource = dt;
            conn.Close();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO userData(Name,KhmerMoney,DollarMoney,address,date) VALUES" + "(@name,@khmermoney,@dollarmoney,@address,@date)";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@khmermoney", txtKhmer.Text);
            cmd.Parameters.AddWithValue("@dollarmoney", txtTotalDollar.Text);
            cmd.Parameters.AddWithValue("@address", comPlace.Text);
            cmd.Parameters.AddWithValue("@date", dateTime.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Customer instead");
            GetData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_databaseDataSet2.userData' table. You can move, or remove it, as needed.
            this.userDataTableAdapter1.Fill(this.db_databaseDataSet2.userData);

            GetData();
        }
    }
}
