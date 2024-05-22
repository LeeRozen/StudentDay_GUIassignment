using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDay
{
    internal static class TicketsList
    {
        public static int numOfTickets;
        public static Ticket[] AddTicket(Ticket ticket, Ticket[] ticketsList)
        {
            if (ticketsList.Length == 0)
            {
                ticketsList = new Ticket[1];
                ticketsList[0] = ticket;
                numOfTickets = 1;
                return ticketsList;
            }

            Array.Resize(ref ticketsList, numOfTickets + 1);
            ticketsList[numOfTickets] = ticket;
            numOfTickets++;
            return ticketsList;
        }

    }
}
