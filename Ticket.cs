using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace StudentDay
{
    internal class Ticket
    {
        public const int PARTY_TIC_PRICE = 80;
        public const int BUS_TIC_PRICE = 10;
        const double DISCOUNT_MEMBER = 0.2;
      
        string typeOfTicket;
        double price;
        Client client;


        public Ticket(Client client, string type) // c'tor 
        {
            this.client = client;
            SetType(type);
            SetPrice(); //client
        }

        public void SetType(string type) 
        {
            // NO NEED: if (type == null || type == "") because in the Form1 its not possible to arrive the c'tor without choosing a type from the options
            
            if (type == "מסיבה")
            {
                typeOfTicket = type;
            }

            if (type == "אוטובוס")
            {
                typeOfTicket = type;
            }
        }
        public string GetTypeOfTicket() { return typeOfTicket; }


        public void SetPrice () 
        {
            if (this.client.IsMember==true)
            {
                double FinalPrice = 0;
                if (typeOfTicket == "מסיבה")
                {
                    FinalPrice = PARTY_TIC_PRICE * (1-DISCOUNT_MEMBER);
                }

                if (typeOfTicket == "אוטובוס")
                {
                    FinalPrice = BUS_TIC_PRICE * (1-DISCOUNT_MEMBER);
                }
                price = FinalPrice;
            }
            else
            {
                if (typeOfTicket == "מסיבה") { price = PARTY_TIC_PRICE;  }
                if (typeOfTicket == "אוטובוס") { price = BUS_TIC_PRICE; }
            }
           
        }
        public double GetPrice() { return price; }

        


        public Client Client
        {
            get { return client; }
            set { client = value; } // the Client class already have setters for itself so its sure its set
        }
    }
}
