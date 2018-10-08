using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiubSuperShop
{
    public partial class AdminForm : Form
    {

        ShopQDataContext pd;


                public AdminForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String id = textBox2.Text;
            String section = comboBox2.Text;

            if (name == "")
            {

                MessageBox.Show("Name field is empty");

            }


            else if (id == "")
            {

                MessageBox.Show("Id field is empty");

            }
            else if (section == "")
            {

                MessageBox.Show("Section field is empty");

            }
            else 
            
            { 
                //create a new form
            
            
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            String s="Salesman";
            String a="All employee";
            String pList = "Product";
            String section = comboBox2.Text;

             pd = new ShopQDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Documents\Informatio.mdf;Integrated Security=True;Connect Timeout=30");
             ProductList p = new ProductList();
            if (section.Equals(pList))
            {
                var x = from  Barcode in pd.ProductLists select Barcode;

                dataGridView1.DataSource = x;
                //comboBox2.DataSource = x.Distinct();
                //var y = from  Barcode in pd.ProductLists select Barcode;
               // comboBox1.DataSource = y.Distinct();
                //comboBox1.DisplayMember = "Product Name";

            }
            else if (section.Equals(s))
            {
                var x = from Id in pd.Salesmans select Id;

                dataGridView1.DataSource = x;


            }
            else if (section.Equals(a))
            {
                var x = from Barcode in pd.Employes select Barcode;

                dataGridView1.DataSource = x;


            }
            else
            {
                MessageBox.Show("Selec section first !!");
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            String s = "Salesman";
            String a = "All employee";
            String pList = "Product";
            String section = comboBox2.Text;

            pd = new ShopQDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Documents\Informatio.mdf;Integrated Security=True;Connect Timeout=30");
            ProductList p = new ProductList();
            if (section.Equals(pList))
            {
                var x = from Barcode in pd.ProductLists select Barcode;

                dataGridView1.DataSource = x;

            }
            else if (section.Equals(s))
            {
                var x = from Id in pd.Salesmans select Id;

                dataGridView1.DataSource = x;


            }
            else if (section.Equals(a))
            {


                MessageBox.Show("uncomplete due to lact of Time !!");
                
                //var x = from UserId in pd.Employes select UserId;

                //dataGridView1.DataSource = x;


            }
            else
            {
                MessageBox.Show("Selec section first !!");
            }
        }

    }
}
