using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public enum lightOnOff
    {
        on,
        off
    }

    abstract public class Building
    {
        public bool hasElevator;
        public lightOnOff switchLight { get; set; }

        protected string address { get; }
        protected int dateOfBuilding { get; }
        protected int floorCount;
        protected int maxPeople;
        protected int currentPeople;



        public Building(string address, int maxPeopleCount):this(address,DateTime.Now.Year,1,false,maxPeopleCount)
        {
            
        }

        public Building(string address, int dateOfBuilding, int floor, bool hasElevator, int maxPeopleCount)
        {
            this.address = address;
            this.floor = floor;
            this.hasElevator = hasElevator;
            this.maxPeopleCount = maxPeopleCount;
            this.dateOfBuilding = dateOfBuilding;

            
        }

        public int floor
        {
            get { return floorCount; }
            set
            {
                if (value > floorCount)
                    floorCount = value;
                else
                    Console.WriteLine("Error:you set little or negative floor count");
            }

        }

        public int maxPeopleCount
        {
            get { return maxPeople; }
            set
            {
                if (value > maxPeople)
                    maxPeople = value;
                else
                    Console.WriteLine("You can't decrease the people count");
            }

        }
        private int currentPeopleCount
        {
            get { return currentPeople; }
            set
            {
                if (value <= maxPeople)
                    currentPeople = value;
                else
                    Console.WriteLine("This Building hasn't enough space for people");
            }

        }


        protected bool addPeople(int count)
        {
            if (currentPeople + count > maxPeopleCount)
            {
                Console.WriteLine("This Building hasn't enough space for people");
                return false;
            }
            else
            {
                
                currentPeople += count;
                return true;
            }

        }

        protected bool deletePeople(int count)
        {
            if (currentPeople - count < 0)
            {
                Console.WriteLine("This Building hasn't enough people to delete");
                return false;
            }
            else
            {
                currentPeople -= count;
                return true;
            }

        }
    }
}
