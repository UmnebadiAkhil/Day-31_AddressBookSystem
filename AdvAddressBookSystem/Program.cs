using AdvAddressBookSystem;

namespace AddressBookADO.Net
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to AddressBookADO.Net!");

            AddressBookManagement addressBookManagement = new AddressBookManagement();

            // addressBookManagement.DataBaseConnection(); //UC1

            addressBookManagement.GetAllContact(); //UC1




            Console.ReadLine();
        }
    }
}