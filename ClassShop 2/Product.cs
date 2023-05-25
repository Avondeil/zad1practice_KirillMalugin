using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassShop
{
    class Product
    {
        private decimal price;
        private string name;
        private int count;
        private bool pricescan = true;
        public Product (string Name, decimal Price, int Count)
        {
            this.name = Name;
            this.price = Price;
            this.count = Count;
        }
        public Product()
            {

}

        public bool pricesc
        {
            get
            {
                return pricescan;
            }
            set
            {
                pricescan = value;
            }
        }
        public decimal Price
        {
            get
            {
                return price;
            }
            set 
            {
                if ( value > 0 && value != 0 )
                {
                    price = value;
                    pricesc = true;
                }
                else
                {
                    MessageBox.Show("Найден некорректный ввод цены, повторите попытку");
                    pricescan = false;
                }
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                if (value >= 0)
                {
                    count = value;
                    pricesc= true;
                }
                else
                {
                    MessageBox.Show("Найден некорректный ввод количества, повторите ввод");
                    pricesc=false;
                }
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if ( value != "")
                {
                    name = value;
                    pricesc = true;
                }
                else
                {
                    MessageBox.Show("Найден некорректный ввод имени (пустота), повторите попытку");
                    pricescan = false;
                }
            }
        }
        public string GetInfo ()
        {
                return $"Наименование товара: {name}; Цена: {price}; Количество: {count}";
        }
    }
}
