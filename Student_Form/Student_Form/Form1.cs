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

namespace Student_Form
{
    public partial class Form1 : Form
    {
        public string CmdText = "SELECT * FROM [tbstudents]";
        public string ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\database_Acc\\db_students.accdb";
        public Form1()
        {
            InitializeComponent();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, ConnString);
            // creating a dataset object
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[tbstudents]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\database_Acc\\db_students.accdb");
        private void btnSave_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Insert into tbstudents(student_firstname,student_lastname,student_sex,student_dob,student_phone,student_address,student_pob,student_photo)Values('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + cmSex.Text + "','" + dob.Text +"','"  + txtPhone.Text + "','" + cmAddress.Text + "','" + txtpob.Text + "','" + pictur.Image + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Submitted​ to your database", "Congrats");
            txtFirstName.Focus();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtpob.Clear();
            cmAddress.Items.Clear();
            cmSex.Items.Clear();
            pictur.Image = null;
            con.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictur.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_studentsDataSet.tbstudents' table. You can move, or remove it, as needed.
            this.tbstudentsTableAdapter.Fill(this.db_studentsDataSet.tbstudents);

        }
    }
}
