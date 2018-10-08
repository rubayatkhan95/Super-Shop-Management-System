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
    public partial class InvoiceView : Form
    {

        ShopQDataContext pd = new ShopQDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Documents\Informatio.mdf;Integrated Security=True;Connect Timeout=30");

        
        public InvoiceView()
        {
            InitializeComponent();
            //dataGridView1.ColumnCount = 5;

            //dataGridView1.Columns[0].Name = "Barcode";
           // dataGridView1.Columns[1].Name = "Product Name";
           // dataGridView1.Columns[2].Name = "Rate";
           // dataGridView1.Columns[3].Name = "Quantity";
           // dataGridView1.Columns[4].Name = "Amount";

        }
       // public AutoCompleteStringCollection ClientListDropDown(){
        // AutoCompleteStringCollection c = new AutoCompleteStringCollection();

        // try
        // {
             
          //   var x = from a in pd.ProductList
//where a.Barcode == int.Parse(dataGridView1.Coloumns[0].Text)
                    // select a;
             
//}catch(Exception b)
        // {
//MessageBox.Show(b.Message);
        // }
        
       // }
    }
}
