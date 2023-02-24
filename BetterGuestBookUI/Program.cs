using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookLibrary.Models;

//*************REQUIREMENTS***************
// capture the info about each guest (assumption: at least 1 guest, and unknown maximum)
// info to capture: first name, last name, and message to the host
// loop through each guest and pring their info
//****************************************



namespace BetterGuestBookUI
{
    class Program
    {

        private static List<GuestModel> guests = new List<GuestModel>();

        //list of guests, plural because it holds multiple guests 
        //use a list so we can keep adding data to it
        //make this a global variable so it can be accessed by all methods by moving it outside of all the other scoped methods
        // make it private static so it can be accessed by all methods



        static void Main(string[] args)
        {
            GetGuestInformation(); //call the method to get the guest information

            PrintGuestInformation(); //call the method to print the guest information

            Console.ReadLine();
        }

        private static void GetGuestInformation()
        {
            //loop through each guest

            string moreGuestsComing = ""; // variable to hold the guests information

            do
            {
                GuestModel guest = new GuestModel(); // create a new instance of the guest model / singular bc it holds one guest


                guest.FirstName = GetInformationFromConsole("What is your first name?"); //assign the first name to the guest model
                guest.LastName = GetInformationFromConsole("What is your last name?"); //assign the last name to the guest model
                guest.MessageToHost = GetInformationFromConsole("What is your message to the host?"); //assign the message to the guest model
                moreGuestsComing = GetInformationFromConsole("Are there more guests coming? (yes/no)"); //assign the answer to the variable

                guests.Add(guest); //add the guest to the list of guests

                Console.Clear(); //clear the console


            } while (moreGuestsComing.ToLower() == "yes");
        }

        private static void PrintGuestInformation()
        {
            foreach (GuestModel guest in guests) //loop through each guest in the list of guests
            {
                Console.WriteLine(guest.GuestInfo); //print the guest info
            }
        }

        private static string GetInformationFromConsole(string message)
        {
            string output = "";

            Console.WriteLine(message);
            output = Console.ReadLine();

            return output;
        }
    }
}


//once you have the app working, how can I make it better? REFACTOR YOUR CODE
