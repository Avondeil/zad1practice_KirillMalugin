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
            tovar.Name = textBox1.Text; tovar.Price = decimal.Parse(textBox2.Text); tovar.Count = int.Parse(textBox4.Text);
            if ( tovar.pricesc)
            {
                pyaterochka.CreateProduct(textBox1.Text, decimal.Parse(textBox2.Text), tovar.Count);
                listBox1.Items.Clear();
                foreach (var n in pyaterochka.GetAllProduct())
                    listBox1.Items.Add(n.GetInfo());
                MessageBox.Show("Товар добавлен!");
            }
        }

        private void listBox1_SelectedIndexChanged (object sender, EventArgs e)
        {
            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            pyaterochka.Sell(textBox3.Text, int.Parse(textBox5.Text));
            listBox1.Items.Clear();
            foreach (var n in pyaterochka.GetAllProduct())
                listBox1.Items.Add(n.GetInfo());
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pyaterochka.Profit == 0)
                MessageBox.Show("Магазин ничего не заработал");
            else MessageBox.Show($"Прибыль магазина: {pyaterochka.Profit} Р");
        }
    }
}
