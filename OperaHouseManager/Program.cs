using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaHouseManager
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //   Singer LeeSteiner = new Singer { Name = "Lee Steiner", Age = 31, Type = "Tenor" };
            Singer LeeSteiner = new Singer("Lee Steiner", 31, SingerType.Tenor);
            LeeSteiner.DisplayStats();

            for (int i = 0;i<10;i++) {
                Singer joe = new Singer("Joe");
                joe.DisplayStats();
            }
            
        }

        
    }
}
