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

            #endregion
        }

    }
    
}
