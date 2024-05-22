using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StudentDay
{
    internal class Client
    {
        string firstName;
        string lastName;
        string id;
        bool isMember;
        int paymentMethod;

        public Client(string FirstName, string LastName, string ID, bool IsMember) // constructor
        {
            this.FirstName = FirstName;
            this.LastName= LastName;
            this.ID= ID;
            this.IsMember = IsMember;
            paymentMethod = 0;
        }
        public string FirstName 
        {
            get { return firstName; }
            set       
            {
                if (value == null || value == "") 
                {
                    throw new Exception("No value was entered in the required field");
                }
                
                firstName = value; // checking if first name is correct
            }
        }
        public string LastName 
        {
            get { return lastName; }
            set 
            {
                if (value == null || value == "")
                {
                    throw new Exception("No value was entered in the required field");
                }
                
                lastName = value; // checking if last name is correct
            }
        }
       
        public string ID 
        {
            get { return id; }
            set
            {
                if (value == null)
                {
                    throw new Exception("No value was entered in the required field");
                }

                if (value.Length != 9)
                {
                    throw new Exception("ID must have exactly 9 digits.");
                }
                id = value; // checking if id is correct - with 9 digit
            }
        }
        public bool IsMember 
        {
            get { return isMember; }
            set
            {
                isMember = value; // checking if membership exist
            }
        }

        public int PaymentMethod
        {
            get { return paymentMethod; }
            set
            {
                if (!this.isMember)
                {
                   paymentMethod = value; // 1-Bit, 2-PayInPlace, in adjust to the clicked button

                }
            }
        }
    }
}