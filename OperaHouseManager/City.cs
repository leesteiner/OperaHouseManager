using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaHouseManager
{
    class City
    {

        public string CityName { get; set; }
        public PlayerCity CityEnum { get; set; }

        public int StartingMoney { get; set; }
        public int StartingPopulation { get; set; }

        public City() { }
        public City(string name, PlayerCity cityEnum, int money, int pop)
        {
            CityName = name;
            CityEnum = cityEnum;
            StartingMoney = money;
            StartingPopulation = pop;
        }
    }
}
