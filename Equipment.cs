using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_equipment_system
{
    public class Equipment
    {
        protected string Name;
        protected string description;
        protected int distanceMovedTillDate;
        protected int maintainanceCost;

        public Equipment()
        {
            this.Name = "";
            this.description = "";
            this.distanceMovedTillDate = 0;
            this.maintainanceCost = 0;
        }

        public Equipment(string Name, string description, int distanceMovedTillDate, int maintainanceCost)
        {
            this.Name = Name;
            this.description = description;
            this.distanceMovedTillDate = distanceMovedTillDate;
            this.maintainanceCost = maintainanceCost;
        }

        public void MoveBy(int distanceMoved, int x)
        {
            this.maintainanceCost += distanceMoved * x;
        }

        public String getName()
        {
            return this.Name;
        }

        public String getDespription()
        {
            return this.description;
        }

        public int getDistanceTillDate()
        {
            return this.distanceMovedTillDate;
        }

        public int getMaintainaceCost()
        {
            return this.maintainanceCost;
        }
    }
}
