using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassShop
{
    class Shop
    {
        private Dictionary<Product, int> products;

        public Shop ()
        {
            products = new Dictionary<Product, int>( );
        }


        public void CreateProduct (string name, decimal price, int count)
        {
            products.Add(new Product(name, price, count), count);
        }
        public void Sell (string productName)
        {
            foreach ( var product in products.Keys )
            {
                if ( product.Name == productName )
                {
                    if ( products [ product ] > 0 )
                    {
                        products [ product ]--;
                    }
                    else
                    {
                        MessageBox.Show("Товар закончился!");
                    }
                    return;
                }
            }
            MessageBox.Show("Товар не найден");
        }
        public List<Product> GetAllProduct ()
        {
            return new List<Product>(products.Keys);
        }
    }
}
