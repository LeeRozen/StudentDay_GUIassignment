using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDay
{
    public partial class Form2 : Form
    {
        Ticket[] TicketsList;
        public Form2(object[] arrOfTickets, string numOfTicket)
        {
            InitializeComponent();
            this.Text = "אגודת הסטודנטים רופין- מסך סיכום הזמנה";

            TicketsList = (Ticket[])arrOfTickets;

            // printing details:

            lstOrderDetails.Items.Add("שם מלא:" + " " + TicketsList[0].Client.FirstName.ToString() + " " + TicketsList[0].Client.LastName.ToString());
            lstOrderDetails.Items.Add("תעודת זהות: " + TicketsList[0].Client.ID.ToString());
            
            foreach (Ticket ticket in TicketsList) 
            {
                lstOrderDetails.Items.Add("סוג כרטיס: " + ticket.GetTypeOfTicket().ToString());
                lstOrderDetails.Items.Add("מחיר: " + ticket.GetPrice().ToString());

                if (ticket.Client.PaymentMethod == 1)
                {
                    lstOrderDetails.Items.Add("תשלום דרך אתר \"ביט\"");
                }
                if (ticket.Client.PaymentMethod == 2)
                {
                    lstOrderDetails.Items.Add("תשלום במקום האירוע במזומן/באשראי");
                }
            }

            double dTotalPrice = 0;
            foreach (Ticket ticket in TicketsList)
            {
                dTotalPrice += ticket.GetPrice();
            }
            lblTotPriceForPrint.Text = dTotalPrice.ToString();

            lblTicketsNumForPrint.Text = numOfTicket;
            
            lblTimeForPrint.Text = DateTime.Now.ToLongTimeString(); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            
        }

        private void lstOrderDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTicketsNumForPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
