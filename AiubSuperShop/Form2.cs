using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient.SqlDataReader;
//using System.InvalidOperationException;

namespace AiubSuperShop
{
    public partial class Form2 : Form
    
    {
        ShopQDataContext pd;
        public Form2()
        {
            InitializeComponent();
            //gridview setting
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Barcode" ;
            dataGridView1.Columns[1].Name = "Product Description";
            dataGridView1.Columns[2].Name = "Rate";
            dataGridView1.Columns[3].Name = "Quantity";
            dataGridView1.Columns[4].Name = "Amount";
        
        
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           // pd = new ShopQDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Documents\Informatio.mdf;Integrated Security=True;Connect Timeout=30");

          //  var x = from Barcode in pd.ProductLists select Barcode;
            //dataGridView1.DataSource = x;
        }
        public AutoCompleteStringCollection ClientListDropDown()
        {
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            pd = new ShopQDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Documents\Informatio.mdf;Integrated Security=True;Connect Timeout=30");

            return auto;

        }
        

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            pd = new ShopQDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Documents\Informatio.mdf;Integrated Security=True;Connect Timeout=30");
            if(e.ColumnIndex == 0)
            {
                String newvalu;
                newvalu = this.dataGridView1.Rows[0].Cells[1].Value.ToString();
               // int a = int.Parse(newvalu);
                var x = from Rate in pd.ProductLists
                        where Rate.Barcode == int.Parse(newvalu)
                        select Rate;
                dataGridView1.DataSource = x;
            }
            
            //multiplication
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[dataGridView1.Columns[4].Index].Value=(Convert.ToDouble(row.Cells[dataGridView1.Columns[2].Index].Value)*Convert.ToDouble(row.Cells[dataGridView1.Columns[3].Index].Value));
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void valueChanged(object sender, DataGridViewCellEventArgs e)
        {
            pd = new ShopQDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Documents\Informatio.mdf;Integrated Security=True;Connect Timeout=30");
  
                String newvalu;
                newvalu = this.dataGridView1.Rows[0].Cells[1].Value.ToString();
                // int a = int.Parse(newvalu);
                var x = from Rate in pd.ProductLists
                        where Rate.Barcode == int.Parse(newvalu)
                        select Rate;
                dataGridView1.DataSource = x;
        }
        
    }

       
}
