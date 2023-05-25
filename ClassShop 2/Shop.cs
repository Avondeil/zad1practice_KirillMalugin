using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassShop
{
    class Shop
    {
        private decimal profit=0;
        private Dictionary<Product, int> products;

        public Shop ()
        {
            products = new Dictionary<Product, int>( );
        }

        public decimal Profit
        { 
            get { return profit; }
            set { profit = value; }
        }

        public void CreateProduct (string name, decimal price, int count)
        {
            products.Add(new Product(name, price, count), count);
        }
        public void Sell (string productName, int count)
        {
            foreach ( var product in products.Keys )
            {
                if ( product.Name == productName)
                {
                    if ( products [ product ] > 0 && count<=product.Count)
                    {
                        product.Count=product.Count-count;
                        Profit+= product.Price*count;
                    }
                    else
                    {
                        MessageBox.Show("Товар закончился или его не хватает!");
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
