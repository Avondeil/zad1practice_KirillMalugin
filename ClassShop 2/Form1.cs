using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassShop
{
    public partial class Form1 :Form
    {
        Product tovar=new Product();
        Shop pyaterochka = new Shop( );
        public Form1 ()
        {
            InitializeComponent( );
        }

        private void button1_Click (object sender, EventArgs e)
        {
            //Добавление нового товара и вывод его в listbox
            tovar.Name = textBox1.Text; tovar.Price = decimal.Parse(textBox2.Text);
            if ( tovar.pricesc)
            {
                pyaterochka.CreateProduct(textBox1.Text, decimal.Parse(textBox2.Text), 0);
            }
        }

        private void listBox1_SelectedIndexChanged (object sender, EventArgs e)
        {
            
        }

        private void button2_Click (object sender, EventArgs e)
        {
            listBox1.Items.Clear( );
            foreach ( var n in pyaterochka.GetAllProduct( ))
            listBox1.Items.Add(n.GetInfo());
        }
    }
}
