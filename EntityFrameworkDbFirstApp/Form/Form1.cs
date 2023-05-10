using EntityFrameWorkApplication.Entities;
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

namespace EntityFrameWorkApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbStudentEntities studentEntities = new DbStudentEntities();

        private void button1_Click(object sender, EventArgs e)  //Entity FrameWork 
        {
            
            dataGridView1.DataSource = studentEntities.TBLSTUDENT.ToList(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idtextbox.Text);
            var x = studentEntities.TBLSTUDENT.Find(id);
            studentEntities.TBLSTUDENT.Remove(x);
            studentEntities.SaveChanges();  
            MessageBox.Show("Student deleted.");
        }

        private void button6_Click(object sender, EventArgs e)   // Basic SQL Connection
        {
            SqlConnection connection = new SqlConnection(@"data source=DESKTOP-RRK5C45\SQLEXPRESS;initial catalog=DbStudent;User ID=admin;Password=1234;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
            SqlCommand cmd = new SqlCommand("Select * From TBLLESSON",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable(); 
            adapter.Fill(dt);   
            dataGridView1.DataSource = dt;  
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void list_not_Click(object sender, EventArgs e)
        {
            var query = from item in studentEntities.TBLNOTES 
                        select new { item.NOTID, item.STUDENT, item.LESSON, item.TEST1 };

            dataGridView1.DataSource = query.ToList(); 
        }

        private void save_Click(object sender, EventArgs e)
        {
            TBLSTUDENT tBLSTUDENT = new TBLSTUDENT();   
            tBLSTUDENT.NAME = nametextbox.Text;
            tBLSTUDENT.SURNAME = surnametextbox.Text;
            studentEntities.TBLSTUDENT.Add(tBLSTUDENT);
            studentEntities.SaveChanges();
            MessageBox.Show("Student added");
        }

        private void idtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void upgrade_Click(object sender, EventArgs e)          
        {
            int id = Convert.ToInt32(idtextbox.Text);
            var x = studentEntities.TBLSTUDENT.Find(id);
            x.NAME = nametextbox.Text;
            x.SURNAME = surnametextbox.Text;    
            x.IMAGE = imagetextbox.Text;
            studentEntities.SaveChanges();
            MessageBox.Show("Student updated");
        }

        private void search_Click(object sender, EventArgs e)  // with Lambda
        {
            dataGridView1.DataSource = studentEntities.TBLSTUDENT.Where(x => x.NAME == nametextbox.Text).ToList();  
        }

        private void nametextbox_TextChanged(object sender, EventArgs e)  // with Contains
        {
            string searchValue = nametextbox.Text;
            var values = from item in studentEntities.TBLSTUDENT
                         where item.NAME.Contains(searchValue) 
                         select item;
            dataGridView1.DataSource = values.ToList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if(radioButton1.Checked ==  true)
            {
                List<TBLSTUDENT> list = studentEntities.TBLSTUDENT.OrderBy(x => x.NAME).ToList();
                dataGridView1.DataSource = list;
            }
            if(radioButton2.Checked == true) { 
                List<TBLSTUDENT> list2 = studentEntities.TBLSTUDENT.OrderByDescending(x => x.NAME).ToList();        
                dataGridView1.DataSource=list2;
            }
                
        }
    }
}
