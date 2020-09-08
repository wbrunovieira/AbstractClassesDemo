using System;
namespace ConsoleUI
{
    public class Motorcicle : Vehicle
    {
        public Motorcicle()
        {
        }

        public bool HasSideCart { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine("This motorcicle is in drive! ");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name}  virtually in drive");
        }
    }
}
