using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaHouseManager
{
    class Util
    {

        //Function to get a random number 
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int GetRandomNumber(int min, int max)
        {
            
            int number = random.Next(min, max);

            lock (syncLock)
            { // synchronize
                return number;
            }

        }


    }
}
