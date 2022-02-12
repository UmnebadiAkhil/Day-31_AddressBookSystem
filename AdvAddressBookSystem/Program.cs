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

            addressBookManagement.DataBaseConnection(); //UC1

            addressBookManagement.GetAllContact(); //UC1




            Console.ReadLine();
        }
        /* UC3:- Ability to insert new Contacts to Address Book */
        public static void AddNewContactDetails()
        {
            AddressBookManagement repository = new AddressBookManagement();
            AddressBookModel model = new AddressBookModel();
            model.FirstName = "Akhil";
            model.LastName = "Umnebadi";
            model.Address = "Sirugapuram";
            model.City = "Kurnool";
            model.State = "Andhra Pradesh";
            model.Zip = "518348";
            model.PhoneNumber = "1234567891";
            model.EmailId = "akhil@gmail.com";
            model.AddressBookType = "Friend";
            model.AddressBookName = "UmnebadiAkhil";

            Console.WriteLine(repository.AddDataToTable(model) ? "Record inserted successfully\n" : "Record inserted Failed");
        }
    }
}