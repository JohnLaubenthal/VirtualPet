using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Pet
    {
        //declaring fields
        private string name;
        private int hunger;
        private int thirst;
        private int boredom;
        private int tiredness;
        private bool thirstAlert;
        private bool hungerAlert;
        private bool boredomAlert;
        private bool tiredAlert;

        //declaring properties

        public string Name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
        public int Boredom
        {
            get { return this.Boredom; }
            set { this.Boredom = value; }
        }
        public int Thirst
        {
            get { return this.Thirst; }
            set { this.Thirst = value; }
        }
        public int Hunger
        {
            get { return this.Hunger; }
            set { this.Hunger = value; }
        }
        public int Tiredness
        {
            get { return this.Tiredness; }
            set { this.Tiredness = value; }
        }

        public bool TiredAlert
        {
            get { return this.TiredAlert; }
            set { this.TiredAlert = value; }
        }

        public bool BoredomAlert
        {
            get { return this.BoredomAlert; }
            set { this.BoredomAlert = value; }
        }

        public bool HungerAlert
        {
            get { return this.HungerAlert; }
            set { this.HungerAlert = value; }
        }

        public bool ThirstAlert
        {
            get { return this.ThirstAlert; }
            set { this.ThirstAlert = value; }
        }

        public Pet()
        {
            //default constructor
        }

        //loaded constructor
        public Pet(string name, int hunger, int thirst, int boredom, int tiredness)
        {
            this.Name = name;
            this.Hunger = hunger;
            this.Thirst = thirst;
            this.Boredom = boredom;
            this.Tiredness = tiredness;
        }

        public void GetTick()
        {
            Hunger++;
            if (Hunger > 25)
            {
                Hungeralert(true);
            }
            else
            {
                Hungeralert(false);
            }
            Thirst++;
            if (Thirst > 5)
            {
                Thirstalert(true);
            }
            else
            {
                Thirstalert(false);
            }
            Boredom++;
            if (Boredom > 25)
            {
                Boredomalert(true);
            }
            else
            {
                Boredomalert(false);
            }
            Tiredness++;
            if (Tiredness > 5)
            {
                Tiredalert(true);
            }
            else
            {
                Tiredalert(false);
            }

        }//Tick end

        public bool Thirstalert(bool Status)
        {
            ThirstAlert = Status;
            return ThirstAlert;
        }
        public bool Hungeralert(bool Status)
        {
            HungerAlert = Status;
            return HungerAlert;
        }
        public bool Boredomalert(bool Status)
        {
            BoredomAlert = Status;
            return BoredomAlert;
        }


        public bool Tiredalert(bool Status)
        {
            TiredAlert = Status;
            return TiredAlert;
        }



        public int SetThirst(int num)
        {
            this.Thirst = num;
            return Thirst;
        }

        public int SetHunger(int num)
        {
            this.Hunger = num;
            return Hunger;
        }

        public int SetTiredness(int num)
        {
            this.Tiredness = num;
            return Tiredness;
        }

        public string SetName(string name)
        {
            this.Name = name;
            return Name;
        }
        public int SetBoredom(int num)
        {
            this.Boredom = num;
            return Boredom;
        }


    }//class end
}//namespace end
