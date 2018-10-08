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
    public partial class RegistrationForm : Form
    {

        ShopQDataContext pd;
        
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
       
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             pd = new ShopQDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Documents\Informatio.mdf;Integrated Security=True;Connect Timeout=30");

             String Name = textBox2.Text;
             String Email = textBox1.Text;
             String Password = textBox3.Text;
             String Cpassword = textBox4.Text;
             String Gender = comboBox2.Text;
             
             String Number = textBox5.Text;
             String Address = textBox6.Text;
             String Role = comboBox1.Text;


             if (Name == "")
             {

                 MessageBox.Show("Name field is empty");
             
             }


             else if (Email == "")
             {

                 MessageBox.Show("Email field is empty");

             }
             else if (Password == "")
             {

                 MessageBox.Show("Password field is empty");

             }
             else if (Password !=Cpassword)
             {

                 MessageBox.Show("pasword doesnt match");

             }
             else if (Number == "")
             {

                 MessageBox.Show("Number field is empty");

             }
             else if (Address == "")
             {

                 MessageBox.Show("Address field is empty");

             }
             else if (Role == "")
             {

                 MessageBox.Show("Select Role");

             }
             else
             {
                 Employe pr = new Employe()
                 {


                     Name = textBox2.Text,
                     Email = textBox1.Text,
                     Password = Cpassword,
                     Gender = Gender,
                     Phone_Number = int.Parse(Number),
                     Address = Address,
                     Job=Role







                 };
                 

                       pd.Employes.InsertOnSubmit(pr);
            pd.SubmitChanges();



             }
            
          

          


        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();

        }

        
    }
}
