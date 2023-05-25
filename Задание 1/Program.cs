using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Program
    {
        static void Main (string [ ] args)
        {
            try
            {
                Cat murzik = new Cat("Мурзик");
                Cat barsik = new Cat("Барсег");
                murzik.Meow( );
                barsik.Meow( );
                barsik.Name = "Барсик";
                barsik.Weight = 1.3;
                murzik.Weight = 2.0;
                murzik.WeightWrite( );
                barsik.WeightWrite( );
                barsik.Meow( );
                barsik.Meow( );
            }
            catch {
                Console.WriteLine("Некорректный ввод данных!" );
            }
            Console.ReadKey( );
        }
    }
}
