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
        public VoiceType Type { get; set; }
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

                if (value <1)
                {
                    SingerHappiness = 1;
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
            : this(name, 0, VoiceType.Undefined, 0, 0, SingerTier.Undefined) { }
        public Singer(string name, byte age, VoiceType type)
        : this(name, age, type, 0, 0, SingerTier.Undefined) { }

        public Singer(string name, byte age, VoiceType type, sbyte loyalty, byte happiness, SingerTier tier)
        {
            Name = name;

            if (age == 0)
            {
                byte newAge = (byte)Util.GetRandomNumber(20, 70);
                Age = newAge;
            }
            else { Age = age; }

            if (type == VoiceType.Undefined)
            {
                byte newType = (byte)Util.GetRandomNumber(1, Enum.GetNames(typeof(VoiceType)).Length);
                Type = (VoiceType)newType;
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

        public void IncreaseLoyalty()
        {
            if (SingerLoyalty >= 125) { SingerLoyalty = 125; }
            else SingerLoyalty++;
        }

        public void DecreaseLoyalty()
        {
            if (SingerLoyalty <= -125) { SingerLoyalty = -125; }
            else SingerLoyalty--;
        }

        public void IncreaseHappiness()
        {
            if (SingerHappiness >= 250) { SingerHappiness = 250; }
            else SingerHappiness++;
        }

        public void DecreaseHappiness()
        {
            if (SingerHappiness <= 1) { SingerHappiness = 1; }
            else SingerHappiness--;
        }

        public void IncreaseAge() {Age++;}

        public void DecreaseAge() {Age--;}

        public void IncreaseTier()
        {
            if (Tier >= SingerTier.International)
            {
                Tier = SingerTier.International;
            }

            else Tier++;
        }

        public void DecreaseTier()
        {
            if (Tier <= SingerTier.Unmanaged)
            {
                Tier = SingerTier.Unmanaged;
            }
            else Tier--;
        }

        

    }





    /* Loyalty = (sbyte)(rnd.Next(0, 50)-25);
 SingerHappiness = (byte)rnd.Next(50, 200);
 byte tier = (byte)rnd.Next(0, Enum.GetNames(typeof(SingerTier)).Length);
 Tier = (SingerTier)tier;
  */

}
