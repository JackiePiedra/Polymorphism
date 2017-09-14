using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Boat : Vehicle //reference the parent class
    {
        private double waterDrag;

        public Boat(int seats, int carryingCapacity, string color, double movementSpeed, double waterDrag)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
            this.waterDrag = waterDrag;
        }

        //only override the methods we think will change
        public override void Move() //override only to give it the chance to override, only possible because of virtual
        {
            distanceTraveled += movementSpeed * waterDrag; //how a BOAT moves, derived from vehicle class -- only applies to boat
        }
    }
}
