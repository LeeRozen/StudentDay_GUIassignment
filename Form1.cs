using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace StudentDay
{
    public partial class Form1 : Form
    {
        int ticks = 0;
        Ticket[] ticketsList = new Ticket[0];
        public bool member;
        const string URL = "https://www.bitpay.co.il/he";

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            this.Text = "אגודת הסטודנטים רופין- מסך הזמנה";

            progressBar1.Maximum = 5;
            progressBar1.Minimum = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ARE YOU READY TO CELEBRATE ??");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            lblTime.Text = ticks.ToString();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void cmbIsMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            progressBar1.Value = 1;
            if (cmbIsMember.SelectedIndex == 1 || cmbIsMember.SelectedIndex == 2) 
            {
                lblTicketToBuy.Visible = true;
                chkBoxParty.Visible = true;
                chkBoxBus.Visible = true;
            }
            if (cmbIsMember.SelectedIndex == 0)
            {
                MessageBox.Show("Please select your member option","שגיאה במילוי הפרטים",MessageBoxButtons.OK,MessageBoxIcon.Question);
                lblTicketToBuy.Visible = false;
                chkBoxParty.Visible = false;
                chkBoxBus.Visible = false;
            }
        }
        private void chkBoxParty_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxParty.Checked)
            { btnContinue.Enabled = true; }
        }

        private void chkBoxBus_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxBus.Checked)
            { btnContinue.Enabled = true; }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 3;

            bool member = false; //default
            if (cmbIsMember.SelectedIndex == 1)
            {
                member = true;
                btnAcceptOrder.Visible = true;
            }
            if (cmbIsMember.SelectedIndex == 2)
            {
                member = false;
                btnPaymentMethod.Visible = true;
            }

            try
            {
                Client client = new Client(txtFirstName.Text, txtLastName.Text, txtID.Text, member); // adding new client
                
                if (chkBoxParty.Checked)        // adding party ticket
                {
                        Ticket ticketP = new Ticket(client, "מסיבה");
                        ticketsList = TicketsList.AddTicket(ticketP, ticketsList);
                        lblPartyTickPrice.Visible = true;
                        txtPartyTickPrice.Visible = true;
                        foreach (var t in ticketsList)
                        {
                            if (t.GetTypeOfTicket() == "מסיבה" && (t.Client.ID == txtID.Text))
                            {
                                txtPartyTickPrice.Text = (t.GetPrice()).ToString();
                            }
                        }
                }
                if (chkBoxBus.Checked)        // adding bus ticket
                {
                    Ticket ticketB = new Ticket(client, "אוטובוס");
                    ticketsList = TicketsList.AddTicket(ticketB, ticketsList);
                    lblBusTickPrice.Visible = true;
                    txtBusTickPrice.Visible = true;

                    foreach (var t in ticketsList)
                    {
                        if (t.GetTypeOfTicket() == "אוטובוס" && (t.Client.ID == txtID.Text))
                        {
                            txtBusTickPrice.Text = (t.GetPrice()).ToString();
                        }
                    }
                }
            }
            catch(Exception exp) 
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void lblPartyTickPrice_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPartyTickPrice_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtBusTickPrice_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void btnAcceptOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("לידיעתך, התשלום על הרכישה יבוצע מפרטי כרטיס האשראי ששמורים בחשבונך באתר האגודה. \n\r לסיום הזמנה לחץ על כפתור סיום ההזמנה","ביצוע תשלום",MessageBoxButtons.OK,MessageBoxIcon.Information);
            btnFinishOrder.Visible = true;
            progressBar1.Value = 5;
        }

        private void btnPaymentMethod_Click(object sender, EventArgs e)
        {
            btnBit.Visible = true;
            btnPayInPlace.Visible = true;
            progressBar1.Value = 4;
        }

        private void btnBit_Click(object sender, EventArgs e)
        {
            Process.Start(URL); // open Bit website with the organization's payment details 
            foreach (var t in ticketsList)
            {
                if (t.Client.ID == txtID.Text)
                {
                    t.Client.PaymentMethod = 1;
                }
            }
            MessageBox.Show("בחירתך התקבלה בהצלחה!\n\r לסיום הזמנה לחץ על כפתור סיום ההזמנה", "בחירת אופן תשלום: ביט", MessageBoxButtons.OK);
            btnFinishOrder.Visible = true;
            progressBar1.Value = 5;
        }

        private void btnPayInPlace_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("שים לב, כניסתך לאירוע תהיה מותנית בביצוע התשלום בכניסה, ניתן במזומן או באשראי לבחירתך.","בחירת אופן תשלום: תשלום במקום",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                MessageBox.Show("בחירתך התקבלה בהצלחה!\n\r לסיום הזמנה לחץ על כפתור סיום ההזמנה", "בחירת אופן תשלום: תשלום במקום", MessageBoxButtons.OK);
            }

            foreach (var t in ticketsList)
            {
                if (t.Client.ID == txtID.Text)
                {
                    t.Client.PaymentMethod = 2;
                }
            }
            btnFinishOrder.Visible = true;
            progressBar1.Value = 5;
        }

        private void btnFinishOrder_Click(object sender, EventArgs e)
        {
            string NumOfTicket = TicketsList.numOfTickets.ToString();
            timer1.Stop();
            Form2 frm2 = new Form2(ticketsList, NumOfTicket);
            frm2.ShowDialog();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
    }
}
