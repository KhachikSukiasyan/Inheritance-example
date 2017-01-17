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
        public string address;
        public int dateOfBuilding;
        public bool hasElevator;
        int floorCount;

        
        int maxPeople;
        protected int currentPeople;


        public lightOnOff switchLight { get; set; }

        public Building(string address, int maxPeopleCount):this(address,-1,-1,false,maxPeopleCount)
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
                if (value > 0)
                    floorCount = value;
                else
                    Console.WriteLine("negative floor count");
            }

        }

        public int maxPeopleCount
        {
            get { return maxPeople; }
            set
            {
                if (value > 100)
                    maxPeople = value;
                else
                    Console.WriteLine("Very little count of people for Building");
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
                Console.WriteLine("This Building hasn't enough people");
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
