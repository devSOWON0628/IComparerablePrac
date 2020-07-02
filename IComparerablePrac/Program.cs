using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparerablePrac
{
    class Product:IComparable
    {
        public int Price { get; set; }
        public string Name { get; set; }

        public int CompareTo(object obj)
        {
            return this.Price.CompareTo((obj as Product).Price);
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return this.Name + ":" + Price;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>()
            {
               
                new Product(){Name="감자",Price=2000 },
                new Product(){Name="옥수수",Price=3000 },
                new Product(){Name="당근",Price=4000 },
                new Product(){Name="토마토",Price=5000 },
                new Product(){Name="망고",Price=6000 },
                new Product(){Name="고구마",Price=1000 },
                new Product(){Name="하얀영재",Price=600000000 }
            };

            list.Sort();

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
