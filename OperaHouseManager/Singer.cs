using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaHouseManager
{
    class Singer
    {
        public string Name { get; set; }
        public byte Age { get; set; }
        public SingerType Type { get; set; }
        public SingerTier Tier { get; set; }
        private byte SingerHappiness;
        private sbyte SingerLoyalty;

        public byte Happiness
        {
            get
            {return SingerHappiness;}
            set
            {
                if (value >=250)
                {
                    SingerHappiness = 250;
                }
                else
                {
                    SingerHappiness = value;
                }
            }

        }
        public sbyte Loyalty
        {
            get { return SingerLoyalty; }
            set
            {
                if (value <= -125)
                {
                    SingerLoyalty = -125;
                }
                if (value >= 125)
                {
                    SingerLoyalty = 125;
                }
                else SingerLoyalty = value;
            }
        }

        public Singer() { }
        public Singer(string name)
            : this(name, 0, SingerType.Undefined, 0, 0, SingerTier.Undefined) { }
        public Singer(string name, byte age, SingerType type)
        : this(name, age, type, 0, 0, SingerTier.Undefined) { }

        public Singer(string name, byte age, SingerType type, sbyte loyalty, byte happiness, SingerTier tier)
        {
            Name = name;

            if (age == 0)
            {
                byte newAge = (byte)Util.GetRandomNumber(20, 70);
                Age = newAge;
            }
            else { Age = age; }

            if (type == SingerType.Undefined)
            {
                byte newType = (byte)Util.GetRandomNumber(1, Enum.GetNames(typeof(SingerType)).Length);
                Type = (SingerType)newType;
            }
            else { Type = type; }

            if (loyalty == 0)
            {
                sbyte newLoyalty = (sbyte)(Util.GetRandomNumber(0, 50) - 25);
                SingerLoyalty = newLoyalty;
            }
            else { SingerLoyalty = loyalty; }

            if (happiness == 0)
            {
                byte newHappiness = (byte)Util.GetRandomNumber(50, 150);
                SingerHappiness = newHappiness;
            }
            else { SingerHappiness = happiness; }

            if (tier == SingerTier.Undefined)
            {
                if (age >= 35)
                {
                    byte newTier = (byte)Util.GetRandomNumber(2, Enum.GetNames(typeof(SingerTier)).Length);
                    Tier = (SingerTier)newTier;
                }
                else {
                    byte newTier = (byte)Util.GetRandomNumber(1, Enum.GetNames(typeof(SingerTier)).Length);
                    Tier = (SingerTier)newTier;
                }
                
            }
            else { Tier = tier; }

        }
        public void DisplayStats()
        {
            Console.WriteLine("Singer Name: {0}\r", Name);
            Console.WriteLine("Age: {0}\r", Age);
            Console.WriteLine("Voice Type: {0}\r", Type);
            Console.WriteLine("Happiness: {0}\r", Happiness);
            Console.WriteLine("Loyalty: {0}\r", Loyalty);
            Console.WriteLine("Tier: {0}\n", Tier);
        }

    }


    enum SingerTier
    {
        Undefined, YoungArtist, Unmanaged, Managed, Regional, National, International
    }

    enum SingerType
    {
        Undefined, Bass, BassBaritone,Baritone,Tenor,Countertenor,Contralto,Mezzo,Soprano
    }
    /* Loyalty = (sbyte)(rnd.Next(0, 50)-25);
 SingerHappiness = (byte)rnd.Next(50, 200);
 byte tier = (byte)rnd.Next(0, Enum.GetNames(typeof(SingerTier)).Length);
 Tier = (SingerTier)tier;
  */

}
