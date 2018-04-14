using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_equipment_system
{
    public class Mobile : Equipment
    {
        private int noOfWheels;
        public static List<Mobile> mobiles = new List<Mobile>();

        public int getNoOfWheels()
        {
            return this.noOfWheels;
        }

        public Mobile() : base()
        {
            this.noOfWheels = 0;
            mobiles.Add(this);
        }

        public Mobile(String Name, String description, int distanceMovedTillDate, int maintainanceCost, int noOfWheels) : base(Name, description, distanceMovedTillDate, maintainanceCost)
        {   
            this.noOfWheels = noOfWheels;
            mobiles.Add(this);
        }

        public void MoveBy(int distanceMoved)
        {
            base.MoveBy(distanceMoved, this.noOfWheels);
        }


        public override string ToString()
        {
            return "Name : " + this.Name + "\nDescription : " + this.description + "\nDistance Moved Till Date : "
                    + this.distanceMovedTillDate + "\nMaintainance Cost : " + this.maintainanceCost + "\nNo Of Wheels : "
                    + this.noOfWheels + "\n********************";
        }
    }
}
