using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaHouseManager
{
    class Opera
    {
        public string Name { get; set; }
        public Language Language { get; set; }
        public byte Popularity { get; set; }
        public bool ChorusNeeded { get; set; }
        public byte ChorusSize { get; set; }
        public List<Role> Roles { get; set; }
        




        public void DisplayStats()
        {
            Console.WriteLine("Opera Name: {0}\r", Name);
            Console.WriteLine("Language: {0}\r", Language);
            Console.WriteLine("Popularity: {0}\r", Popularity);
            Console.WriteLine("Chorus Needed: {0}\r", ChorusNeeded);
            if (ChorusNeeded == true) { Console.WriteLine("Chorus Size: {0}\r", ChorusSize); };
            Console.WriteLine("Roles:\r");
            foreach (Role r in Roles)
            {
                Console.WriteLine($"{r.Name}, {r.voiceType}, {r.roleClass}");
            }
        }


        public Opera() { }
        public Opera(string name)
            : this(name, Language.Undefined, 0, false, 0, new List<Role>) { }
        public Opera(string name, Language language, byte popularity, bool chorusNeeded, byte chorusSize, List<Role> roles)
        {
            Name = name;
            Language = language;
            Popularity = popularity;
            ChorusNeeded = chorusNeeded;
            ChorusSize = chorusSize;
            Roles = roles;
        }
    }
}
