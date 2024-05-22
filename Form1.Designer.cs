namespace StudentDay
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnPayInPlace = new System.Windows.Forms.Button();
            this.btnBit = new System.Windows.Forms.Button();
            this.btnPaymentMethod = new System.Windows.Forms.Button();
            this.btnAcceptOrder = new System.Windows.Forms.Button();
            this.txtBusTickPrice = new System.Windows.Forms.TextBox();
            this.lblBusTickPrice = new System.Windows.Forms.Label();
            this.txtPartyTickPrice = new System.Windows.Forms.TextBox();
            this.lblPartyTickPrice = new System.Windows.Forms.Label();
            this.cmbIsMember = new System.Windows.Forms.ComboBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.chkBoxBus = new System.Windows.Forms.CheckBox();
            this.chkBoxParty = new System.Windows.Forms.CheckBox();
            this.lblTicketToBuy = new System.Windows.Forms.Label();
            this.lblIsAMember = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblPrivateDetails = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFinishOrder = new System.Windows.Forms.Button();
            this.lblCounting = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(21, 142);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(50, 16);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "CLOCK";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(169, 14);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.splitContainer1.Panel1.Controls.Add(this.btnPayInPlace);
            this.splitContainer1.Panel1.Controls.Add(this.btnBit);
            this.splitContainer1.Panel1.Controls.Add(this.btnPaymentMethod);
            this.splitContainer1.Panel1.Controls.Add(this.btnAcceptOrder);
            this.splitContainer1.Panel1.Controls.Add(this.txtBusTickPrice);
            this.splitContainer1.Panel1.Controls.Add(this.lblBusTickPrice);
            this.splitContainer1.Panel1.Controls.Add(this.txtPartyTickPrice);
            this.splitContainer1.Panel1.Controls.Add(this.lblPartyTickPrice);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.YellowGreen;
            this.splitContainer1.Panel2.Controls.Add(this.cmbIsMember);
            this.splitContainer1.Panel2.Controls.Add(this.btnContinue);
            this.splitContainer1.Panel2.Controls.Add(this.txtID);
            this.splitContainer1.Panel2.Controls.Add(this.txtLastName);
            this.splitContainer1.Panel2.Controls.Add(this.txtFirstName);
            this.splitContainer1.Panel2.Controls.Add(this.chkBoxBus);
            this.splitContainer1.Panel2.Controls.Add(this.chkBoxParty);
            this.splitContainer1.Panel2.Controls.Add(this.lblTicketToBuy);
            this.splitContainer1.Panel2.Controls.Add(this.lblIsAMember);
            this.splitContainer1.Panel2.Controls.Add(this.lblID);
            this.splitContainer1.Panel2.Controls.Add(this.lblLastName);
            this.splitContainer1.Panel2.Controls.Add(this.lblFirstName);
            this.splitContainer1.Panel2.Controls.Add(this.lblPrivateDetails);
            this.splitContainer1.Size = new System.Drawing.Size(619, 389);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnPayInPlace
            // 
            this.btnPayInPlace.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnPayInPlace.Location = new System.Drawing.Point(17, 300);
            this.btnPayInPlace.Name = "btnPayInPlace";
            this.btnPayInPlace.Size = new System.Drawing.Size(127, 56);
            this.btnPayInPlace.TabIndex = 19;
            this.btnPayInPlace.Text = "תשלום בכניסה לאירוע";
            this.btnPayInPlace.UseVisualStyleBackColor = true;
            this.btnPayInPlace.Visible = false;
            this.btnPayInPlace.Click += new System.EventHandler(this.btnPayInPlace_Click);
            // 
            // btnBit
            // 
            this.btnBit.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBit.Location = new System.Drawing.Point(154, 300);
            this.btnBit.Name = "btnBit";
            this.btnBit.Size = new System.Drawing.Size(120, 56);
            this.btnBit.TabIndex = 18;
            this.btnBit.Text = "Bit תשלום דרך";
            this.btnBit.UseVisualStyleBackColor = true;
            this.btnBit.Visible = false;
            this.btnBit.Click += new System.EventHandler(this.btnBit_Click);
            // 
            // btnPaymentMethod
            // 
            this.btnPaymentMethod.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnPaymentMethod.Location = new System.Drawing.Point(72, 216);
            this.btnPaymentMethod.Name = "btnPaymentMethod";
            this.btnPaymentMethod.Size = new System.Drawing.Size(151, 40);
            this.btnPaymentMethod.TabIndex = 17;
            this.btnPaymentMethod.Text = "בחירת אופן תשלום";
            this.btnPaymentMethod.UseVisualStyleBackColor = true;
            this.btnPaymentMethod.Visible = false;
            this.btnPaymentMethod.Click += new System.EventHandler(this.btnPaymentMethod_Click);
            // 
            // btnAcceptOrder
            // 
            this.btnAcceptOrder.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAcceptOrder.Location = new System.Drawing.Point(72, 216);
            this.btnAcceptOrder.Name = "btnAcceptOrder";
            this.btnAcceptOrder.Size = new System.Drawing.Size(151, 51);
            this.btnAcceptOrder.TabIndex = 16;
            this.btnAcceptOrder.Text = "אשר פרטים והזמן";
            this.btnAcceptOrder.UseVisualStyleBackColor = true;
            this.btnAcceptOrder.Visible = false;
            this.btnAcceptOrder.Click += new System.EventHandler(this.btnAcceptOrder_Click);
            // 
            // txtBusTickPrice
            // 
            this.txtBusTickPrice.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBusTickPrice.Location = new System.Drawing.Point(43, 128);
            this.txtBusTickPrice.Name = "txtBusTickPrice";
            this.txtBusTickPrice.Size = new System.Drawing.Size(65, 22);
            this.txtBusTickPrice.TabIndex = 15;
            this.txtBusTickPrice.Visible = false;
            this.txtBusTickPrice.TextChanged += new System.EventHandler(this.txtBusTickPrice_TextChanged);
            // 
            // lblBusTickPrice
            // 
            this.lblBusTickPrice.AutoSize = true;
            this.lblBusTickPrice.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBusTickPrice.Location = new System.Drawing.Point(114, 128);
            this.lblBusTickPrice.Name = "lblBusTickPrice";
            this.lblBusTickPrice.Size = new System.Drawing.Size(139, 21);
            this.lblBusTickPrice.TabIndex = 14;
            this.lblBusTickPrice.Text = ":מחיר כרטיס להסעה";
            this.lblBusTickPrice.Visible = false;
            // 
            // txtPartyTickPrice
            // 
            this.txtPartyTickPrice.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPartyTickPrice.Location = new System.Drawing.Point(43, 62);
            this.txtPartyTickPrice.Name = "txtPartyTickPrice";
            this.txtPartyTickPrice.Size = new System.Drawing.Size(62, 22);
            this.txtPartyTickPrice.TabIndex = 13;
            this.txtPartyTickPrice.Visible = false;
            this.txtPartyTickPrice.TextChanged += new System.EventHandler(this.txtPartyTickPrice_TextChanged);
            // 
            // lblPartyTickPrice
            // 
            this.lblPartyTickPrice.AutoSize = true;
            this.lblPartyTickPrice.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPartyTickPrice.Location = new System.Drawing.Point(111, 62);
            this.lblPartyTickPrice.Name = "lblPartyTickPrice";
            this.lblPartyTickPrice.Size = new System.Drawing.Size(142, 21);
            this.lblPartyTickPrice.TabIndex = 12;
            this.lblPartyTickPrice.Text = ":מחיר כרטיס למסיבה";
            this.lblPartyTickPrice.Visible = false;
            this.lblPartyTickPrice.Click += new System.EventHandler(this.lblPartyTickPrice_Click);
            // 
            // cmbIsMember
            // 
            this.cmbIsMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbIsMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsMember.FormattingEnabled = true;
            this.cmbIsMember.Items.AddRange(new object[] {
            "",
            "כן",
            "לא"});
            this.cmbIsMember.Location = new System.Drawing.Point(4, 213);
            this.cmbIsMember.Name = "cmbIsMember";
            this.cmbIsMember.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbIsMember.Size = new System.Drawing.Size(82, 24);
            this.cmbIsMember.TabIndex = 10;
            this.cmbIsMember.SelectedIndexChanged += new System.EventHandler(this.cmbIsMember_SelectedIndexChanged);
            // 
            // btnContinue
            // 
            this.btnContinue.Enabled = false;
            this.btnContinue.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnContinue.Location = new System.Drawing.Point(23, 339);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnContinue.Size = new System.Drawing.Size(86, 33);
            this.btnContinue.TabIndex = 11;
            this.btnContinue.Text = "המשך";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(36, 135);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtID.Size = new System.Drawing.Size(131, 28);
            this.txtID.TabIndex = 9;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(36, 57);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLastName.Size = new System.Drawing.Size(131, 28);
            this.txtLastName.TabIndex = 8;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(36, 96);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFirstName.Size = new System.Drawing.Size(131, 28);
            this.txtFirstName.TabIndex = 7;
            // 
            // chkBoxBus
            // 
            this.chkBoxBus.AutoSize = true;
            this.chkBoxBus.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chkBoxBus.Location = new System.Drawing.Point(175, 313);
            this.chkBoxBus.Name = "chkBoxBus";
            this.chkBoxBus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkBoxBus.Size = new System.Drawing.Size(108, 22);
            this.chkBoxBus.TabIndex = 6;
            this.chkBoxBus.Text = "כרטיס להסעה";
            this.chkBoxBus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBoxBus.UseVisualStyleBackColor = true;
            this.chkBoxBus.Visible = false;
            this.chkBoxBus.CheckedChanged += new System.EventHandler(this.chkBoxBus_CheckedChanged);
            // 
            // chkBoxParty
            // 
            this.chkBoxParty.AutoSize = true;
            this.chkBoxParty.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chkBoxParty.Location = new System.Drawing.Point(172, 285);
            this.chkBoxParty.Name = "chkBoxParty";
            this.chkBoxParty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkBoxParty.Size = new System.Drawing.Size(111, 22);
            this.chkBoxParty.TabIndex = 0;
            this.chkBoxParty.Text = "כרטיס למסיבה";
            this.chkBoxParty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBoxParty.UseVisualStyleBackColor = true;
            this.chkBoxParty.Visible = false;
            this.chkBoxParty.CheckedChanged += new System.EventHandler(this.chkBoxParty_CheckedChanged);
            // 
            // lblTicketToBuy
            // 
            this.lblTicketToBuy.AutoSize = true;
            this.lblTicketToBuy.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTicketToBuy.Location = new System.Drawing.Point(190, 256);
            this.lblTicketToBuy.Name = "lblTicketToBuy";
            this.lblTicketToBuy.Size = new System.Drawing.Size(100, 21);
            this.lblTicketToBuy.TabIndex = 5;
            this.lblTicketToBuy.Text = ":כרטיס לקנייה";
            this.lblTicketToBuy.Visible = false;
            // 
            // lblIsAMember
            // 
            this.lblIsAMember.AutoSize = true;
            this.lblIsAMember.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblIsAMember.Location = new System.Drawing.Point(140, 185);
            this.lblIsAMember.Name = "lblIsAMember";
            this.lblIsAMember.Size = new System.Drawing.Size(150, 21);
            this.lblIsAMember.TabIndex = 4;
            this.lblIsAMember.Text = "?האם אתה חבר אגודה";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblID.Location = new System.Drawing.Point(207, 142);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(83, 21);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "תעודת זהות";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblLastName.Location = new System.Drawing.Point(203, 103);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(87, 21);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "שם משפחה";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblFirstName.Location = new System.Drawing.Point(220, 61);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(66, 21);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "שם פרטי";
            // 
            // lblPrivateDetails
            // 
            this.lblPrivateDetails.AutoSize = true;
            this.lblPrivateDetails.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPrivateDetails.Location = new System.Drawing.Point(187, 24);
            this.lblPrivateDetails.Name = "lblPrivateDetails";
            this.lblPrivateDetails.Size = new System.Drawing.Size(103, 21);
            this.lblPrivateDetails.TabIndex = 0;
            this.lblPrivateDetails.Text = ":פרטים אישיים";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(374, 409);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(220, 22);
            this.progressBar1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnFinishOrder
            // 
            this.btnFinishOrder.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnFinishOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnFinishOrder.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnFinishOrder.Location = new System.Drawing.Point(24, 377);
            this.btnFinishOrder.Name = "btnFinishOrder";
            this.btnFinishOrder.Size = new System.Drawing.Size(116, 51);
            this.btnFinishOrder.TabIndex = 4;
            this.btnFinishOrder.Text = "סיום הזמנה";
            this.btnFinishOrder.UseVisualStyleBackColor = false;
            this.btnFinishOrder.Visible = false;
            this.btnFinishOrder.Click += new System.EventHandler(this.btnFinishOrder_Click);
            // 
            // lblCounting
            // 
            this.lblCounting.AutoSize = true;
            this.lblCounting.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCounting.Location = new System.Drawing.Point(21, 122);
            this.lblCounting.Name = "lblCounting";
            this.lblCounting.Size = new System.Drawing.Size(119, 18);
            this.lblCounting.TabIndex = 5;
            this.lblCounting.Text = "זמן מתחילת ההזמנה";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 192);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 162);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblCounting);
            this.Controls.Add(this.btnFinishOrder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTicketToBuy;
        private System.Windows.Forms.Label lblIsAMember;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblPrivateDetails;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.CheckBox chkBoxBus;
        private System.Windows.Forms.CheckBox chkBoxParty;
        private System.Windows.Forms.ComboBox cmbIsMember;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblPartyTickPrice;
        private System.Windows.Forms.TextBox txtBusTickPrice;
        private System.Windows.Forms.Label lblBusTickPrice;
        private System.Windows.Forms.TextBox txtPartyTickPrice;
        private System.Windows.Forms.Button btnPaymentMethod;
        private System.Windows.Forms.Button btnAcceptOrder;
        private System.Windows.Forms.Button btnPayInPlace;
        private System.Windows.Forms.Button btnBit;
        private System.Windows.Forms.Button btnFinishOrder;
        private System.Windows.Forms.Label lblCounting;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

