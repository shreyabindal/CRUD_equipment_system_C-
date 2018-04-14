using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_equipment_system
{
    public class Client
    {
        public static void Main(String[] args)
        {
            Mobile m = new Mobile("Jeep", "Moves on road", 50, 100, 4);
            showAnEquipment(m);
            m.MoveBy(5, m.getNoOfWheels());
            showAnEquipment(m);

            Immobile im = new Immobile("Ladder", "Very useful", 60, 200, 50);
            showAnEquipment(im);
            im.MoveBy(5, im.getWeight());
            showAnEquipment(im);

            listAllEquipments();
            deleteAnEquipment(m);
            listAllEquipments();
        }

        public static void listAllEquipments()
        {
            Console.WriteLine("Mobile Equipments are => ");
            foreach (Mobile m in Mobile.mobiles)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine("Immobile Equipments are => ");
            foreach (Immobile im in Immobile.immobiles)
            {
                Console.WriteLine(im);
            }
        }

        public static void showAnEquipment(Equipment eq)
        {
            Console.WriteLine(eq);
        }

        public static void deleteAnEquipment(Equipment eq)
        {
            if (eq is Mobile)
            {
                Mobile.mobiles.Remove((Mobile)eq);
            }
            else if (eq is Immobile)
            {
                Immobile.immobiles.Remove((Immobile)eq);
            }
            eq = null;
        }

    }
}
