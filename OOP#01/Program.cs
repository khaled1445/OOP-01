namespace OOP_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OOP 01 - Smart Delivery Management System 
            #region Part 01 : Theoretical Questions

            #region Question 1 
            //a- DeliveryAddress variable:
            //first DeliveryAddress is a struct (value type) so when you take a copy in another value it makes
            //a new seprate stackframe in the stack put in the new data and the old variable doesn't affected

            //b- Customer variable:
            // Customer is a class (Refrence Type) so when you take a copy you just take the refrence in the stack and
            // it leads you to the same object in Heap so you'll OverWrite the old variable so the two variables will have
            // the same refreance so tthe old one will change to whe new var

            #endregion

            #region Question02
            //a) 1- all fields are public so it's not prevented and anyone can modify it
            //2- there is no validation so the value can be negative 
            //3- the input in description var can bee null 

            //b) if you used private keywork instead of public now the code outside the struct canno't be acssessed outside the 
            // struct so you can put the setters and getters to validate all fields  
            #endregion

            #endregion


            #region Part 02 : Practical (Smart Delivery Management System)

            static void Main(string[] args)
            {
                DeliveryCenter center = new DeliveryCenter();

                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine($"Enter Shipment {i} Data");

                    Console.Write("Tracking Code: ");
                    string trackingCode = Console.ReadLine();

                    Console.Write("Description: ");
                    string description = Console.ReadLine();

                    Console.Write("Weight: ");
                    double weight = double.Parse(Console.ReadLine());

                    Console.Write("Delivery Fee: ");
                    decimal deliveryFee = decimal.Parse(Console.ReadLine());

                    Console.Write("City: ");
                    string city = Console.ReadLine();

                    Console.Write("Street: ");
                    string street = Console.ReadLine();

                    Console.Write("Building Number: ");
                    int buildingNumber = int.Parse(Console.ReadLine());

                    DeliveryAddress address = new DeliveryAddress(city, street, buildingNumber);
                    Shipment shipment = new Shipment(trackingCode, description, weight, deliveryFee, address);

                    center.AddShipment(shipment);
                    Console.WriteLine();
                }

                for (int i = 0; i < 3; i++)
                {
                    center[i].PrintShipment();
                    Console.WriteLine();
                }

                Console.Write("Enter a tracking code to search: ");
                string searchCode = Console.ReadLine();

                Shipment found = center[searchCode];

                if (found.TrackingCode != null)
                    found.PrintShipment();
                else
                    Console.WriteLine("Shipment not found");

                DeliveryAddress original = new DeliveryAddress("Beni suef", "ElEmam ElShafie", 15);
                DeliveryAddress copy = original;
                copy.Street = "ElBosta";

                Console.WriteLine($"Original Address: {original.GetFullAddress()}");
                Console.WriteLine($"Copied Address: {copy.GetFullAddress()}");
            }
            #endregion
        }

    }
    
}
