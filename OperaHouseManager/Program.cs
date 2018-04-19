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
            Singer LeeSteiner = new Singer("Lee Steiner", 31, VoiceType.Tenor);
            LeeSteiner.DisplayStats();

            for (int i = 0;i<10;i++) {
                Singer joe = new Singer("Joe");
                joe.DisplayStats();
            }

            Opera MagicFlute = new Opera("Magic Flute", Language.German, 100, true, 20, new List<Role>());
            MagicFlute.DisplayStats();
            Console.WriteLine("Adding in three roles: ");
            MagicFlute.AddRole("Tamino", VoiceType.Tenor, RoleClass.Leading);
            MagicFlute.AddRole("Pamina", VoiceType.Soprano, RoleClass.Leading);
            MagicFlute.AddRole("Queen of the Night", VoiceType.Soprano, RoleClass.Featured);
            MagicFlute.DisplayStats();
            for (int i = 0; i<200;i++)
            {
                MagicFlute.IncreasePopularity();
            }

            MagicFlute.DisplayStats();
        }

        
    }
}
