namespace StudentDay
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblTickNum = new System.Windows.Forms.Label();
            this.lblTicketsNumForPrint = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTotPriceForPrint = new System.Windows.Forms.Label();
            this.lblTicketTotPrice = new System.Windows.Forms.Label();
            this.lblTimeForPrint = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lstOrderDetails = new System.Windows.Forms.ListBox();
            this.lblSeeYou = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTickNum
            // 
            this.lblTickNum.AutoSize = true;
            this.lblTickNum.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTickNum.Location = new System.Drawing.Point(96, 162);
            this.lblTickNum.Name = "lblTickNum";
            this.lblTickNum.Size = new System.Drawing.Size(103, 21);
            this.lblTickNum.TabIndex = 0;
            this.lblTickNum.Text = "סה\"כ כרטיסים";
            // 
            // lblTicketsNumForPrint
            // 
            this.lblTicketsNumForPrint.AutoSize = true;
            this.lblTicketsNumForPrint.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTicketsNumForPrint.Location = new System.Drawing.Point(176, 187);
            this.lblTicketsNumForPrint.Name = "lblTicketsNumForPrint";
            this.lblTicketsNumForPrint.Size = new System.Drawing.Size(21, 21);
            this.lblTicketsNumForPrint.TabIndex = 1;
            this.lblTicketsNumForPrint.Text = "N";
            this.lblTicketsNumForPrint.Click += new System.EventHandler(this.lblTicketsNumForPrint_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitle.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblTitle.Location = new System.Drawing.Point(253, 43);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(162, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = ":סיכום ההזמנה שלך";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblTotPriceForPrint
            // 
            this.lblTotPriceForPrint.AutoSize = true;
            this.lblTotPriceForPrint.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTotPriceForPrint.Location = new System.Drawing.Point(171, 299);
            this.lblTotPriceForPrint.Name = "lblTotPriceForPrint";
            this.lblTotPriceForPrint.Size = new System.Drawing.Size(28, 21);
            this.lblTotPriceForPrint.TabIndex = 4;
            this.lblTotPriceForPrint.Text = "PC";
            // 
            // lblTicketTotPrice
            // 
            this.lblTicketTotPrice.AutoSize = true;
            this.lblTicketTotPrice.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTicketTotPrice.Location = new System.Drawing.Point(100, 274);
            this.lblTicketTotPrice.Name = "lblTicketTotPrice";
            this.lblTicketTotPrice.Size = new System.Drawing.Size(99, 21);
            this.lblTicketTotPrice.TabIndex = 3;
            this.lblTicketTotPrice.Text = "סה\"כ לתשלום";
            // 
            // lblTimeForPrint
            // 
            this.lblTimeForPrint.AutoSize = true;
            this.lblTimeForPrint.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTimeForPrint.Location = new System.Drawing.Point(527, 189);
            this.lblTimeForPrint.Name = "lblTimeForPrint";
            this.lblTimeForPrint.Size = new System.Drawing.Size(74, 21);
            this.lblTimeForPrint.TabIndex = 6;
            this.lblTimeForPrint.Text = "00:00:00";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTime.Location = new System.Drawing.Point(480, 162);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(122, 21);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "זמן ביצוע ההזמנה";
            // 
            // lstOrderDetails
            // 
            this.lstOrderDetails.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lstOrderDetails.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lstOrderDetails.FormattingEnabled = true;
            this.lstOrderDetails.ItemHeight = 21;
            this.lstOrderDetails.Location = new System.Drawing.Point(219, 159);
            this.lstOrderDetails.Name = "lstOrderDetails";
            this.lstOrderDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstOrderDetails.Size = new System.Drawing.Size(238, 172);
            this.lstOrderDetails.TabIndex = 9;
            this.lstOrderDetails.SelectedIndexChanged += new System.EventHandler(this.lstOrderDetails_SelectedIndexChanged);
            // 
            // lblSeeYou
            // 
            this.lblSeeYou.AutoSize = true;
            this.lblSeeYou.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeeYou.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSeeYou.Location = new System.Drawing.Point(242, 372);
            this.lblSeeYou.Name = "lblSeeYou";
            this.lblSeeYou.Size = new System.Drawing.Size(193, 31);
            this.lblSeeYou.TabIndex = 14;
            this.lblSeeYou.Text = "!מחכים לראותכם";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.lblSeeYou);
            this.Controls.Add(this.lstOrderDetails);
            this.Controls.Add(this.lblTimeForPrint);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTotPriceForPrint);
            this.Controls.Add(this.lblTicketTotPrice);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTicketsNumForPrint);
            this.Controls.Add(this.lblTickNum);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTickNum;
        private System.Windows.Forms.Label lblTicketsNumForPrint;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTotPriceForPrint;
        private System.Windows.Forms.Label lblTicketTotPrice;
        private System.Windows.Forms.Label lblTimeForPrint;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ListBox lstOrderDetails;
        private System.Windows.Forms.Label lblSeeYou;
    }
}