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
    public partial class Form1 : Form
    {
        ShopQDataContext pd;
        public Form1()
        {
            InitializeComponent();
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            //AdminForm a = new AdminForm();
            a.ShowDialog();
            pd = new ShopQDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Documents\Informatio.mdf;Integrated Security=True;Connect Timeout=30");
            
            String username =textBox1.Text;
            String password = textBox2.Text;
            
            if (username =="")
            {
                MessageBox.Show("UserName must be filled ! "); 

            }
            else if (password == "")
            {
                MessageBox.Show("Password must be filled ! ");

            }
            else
            {
                var x = from UserId in pd.Employes
                        where UserId.Name == username && UserId.Password == password
                        select UserId;

                if (x.Count() != 1)
                {
                    MessageBox.Show("Account not Found !");
                }
                else
                {
                    this.Hide();
                    //MessageBox.Show("Succesfully Logged in !");
                    Form2 r = new Form2();
                    r.ShowDialog();
                  
                }

                
            
            }
        }
    }
}
