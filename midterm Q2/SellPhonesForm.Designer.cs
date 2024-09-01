namespace midterm_Q2
{
    partial class SellPhonesForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyPhonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellPhonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhoneModel = new System.Windows.Forms.TextBox();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.comboBoxCondition = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtSellerContact = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(388, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(294, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.buyPhonesToolStripMenuItem,
            this.sellPhonesToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(982, 28);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // buyPhonesToolStripMenuItem
            // 
            this.buyPhonesToolStripMenuItem.Name = "buyPhonesToolStripMenuItem";
            this.buyPhonesToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.buyPhonesToolStripMenuItem.Text = "Buy Phones";
            this.buyPhonesToolStripMenuItem.Click += new System.EventHandler(this.buyPhonesToolStripMenuItem_Click);
            // 
            // sellPhonesToolStripMenuItem
            // 
            this.sellPhonesToolStripMenuItem.Name = "sellPhonesToolStripMenuItem";
            this.sellPhonesToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.sellPhonesToolStripMenuItem.Text = "Sell Phones";
            this.sellPhonesToolStripMenuItem.Click += new System.EventHandler(this.sellPhonesToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 60);
            this.label1.TabIndex = 6;
            this.label1.Text = "List a Phone";
            // 
            // txtPhoneModel
            // 
            this.txtPhoneModel.Location = new System.Drawing.Point(235, 42);
            this.txtPhoneModel.Name = "txtPhoneModel";
            this.txtPhoneModel.Size = new System.Drawing.Size(183, 22);
            this.txtPhoneModel.TabIndex = 7;
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Items.AddRange(new object[] {
            "Samsung",
            "Huawei",
            "Apple",
            "OnePlus",
            "Nokia",
            "Motorola",
            "Lenova"});
            this.comboBoxBrand.Location = new System.Drawing.Point(235, 87);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(183, 24);
            this.comboBoxBrand.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.AccessibleDescription = "";
            this.txtPrice.Location = new System.Drawing.Point(235, 136);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.Tag = "";
            // 
            // comboBoxCondition
            // 
            this.comboBoxCondition.FormattingEnabled = true;
            this.comboBoxCondition.Items.AddRange(new object[] {
            "New",
            "Used (Like New)",
            "Used",
            "Damaged"});
            this.comboBoxCondition.Location = new System.Drawing.Point(235, 188);
            this.comboBoxCondition.Name = "comboBoxCondition";
            this.comboBoxCondition.Size = new System.Drawing.Size(183, 24);
            this.comboBoxCondition.TabIndex = 10;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(235, 289);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(183, 156);
            this.txtDescription.TabIndex = 11;
            this.txtDescription.Text = "(Discription)";
            // 
            // txtSellerContact
            // 
            this.txtSellerContact.Location = new System.Drawing.Point(235, 239);
            this.txtSellerContact.Name = "txtSellerContact";
            this.txtSellerContact.Size = new System.Drawing.Size(183, 22);
            this.txtSellerContact.TabIndex = 12;
            this.txtSellerContact.Text = "(Cotact Info)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gabriola", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Phone Model";
            // 
            // SellPhonesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 559);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSellerContact);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.comboBoxCondition);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.txtPhoneModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "SellPhonesForm";
            this.Text = "SellPhonesForm";
            this.Load += new System.EventHandler(this.SellPhonesForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyPhonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellPhonesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhoneModel;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox comboBoxCondition;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtSellerContact;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}