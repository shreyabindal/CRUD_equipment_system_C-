using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_equipment_system
{
    public class Immobile : Equipment
    {
        private int weight;
        public static List<Immobile> immobiles = new List<Immobile>();

        public int getWeight()
        {
            return this.weight;
        }

        public Immobile() : base()
        {
            this.weight = 0;
            immobiles.Add(this);
        }

        public Immobile(String Name, String description, int distanceMovedTillDate, int maintainanceCost, int weight) : base(Name, description, distanceMovedTillDate, maintainanceCost)
        {
            this.weight = weight;
            immobiles.Add(this);
        }

        public void MoveBy(int distanceMoved)
        {
            base.MoveBy(distanceMoved, this.weight);
        }

        public override string ToString()
        {
            return "Name : " + this.Name + "\nDescription : " + this.description + "\nDistance Moved Till Date : "
                    + this.distanceMovedTillDate + "\nMaintainance Cost : " + this.maintainanceCost + "\nWeight : "
                    + this.weight + "\n********************";
        }
    }
}