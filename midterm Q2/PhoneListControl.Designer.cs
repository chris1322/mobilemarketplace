namespace midterm_Q2
{
    partial class PhoneListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbcondition = new System.Windows.Forms.ComboBox();
            this.lblcondition = new System.Windows.Forms.Label();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.lblmodel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbpreview2 = new System.Windows.Forms.PictureBox();
            this.pbpreview5 = new System.Windows.Forms.PictureBox();
            this.pbpreview1 = new System.Windows.Forms.PictureBox();
            this.pbpreview3 = new System.Windows.Forms.PictureBox();
            this.pbpreview4 = new System.Windows.Forms.PictureBox();
            this.btnImageUpload = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbOSVersion = new System.Windows.Forms.ComboBox();
            this.cmbbrand = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblOSVersion = new System.Windows.Forms.Label();
            this.btnIOS = new System.Windows.Forms.Button();
            this.btnAndroid = new System.Windows.Forms.Button();
            this.lblOS = new System.Windows.Forms.Label();
            this.lblbrand = new System.Windows.Forms.Label();
            this.btnChangeOS = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.des = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpreview2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpreview5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpreview1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpreview3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpreview4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbcondition
            // 
            this.cmbcondition.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcondition.FormattingEnabled = true;
            this.cmbcondition.Items.AddRange(new object[] {
            "Please Select Condition",
            "New (Never Used)",
            "Used (Good Condition)",
            "Used (Fair Condition)",
            "Refurbished",
            "Damaged ",
            "Non-Functional (For Parts)"});
            this.cmbcondition.Location = new System.Drawing.Point(480, 754);
            this.cmbcondition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 15);
            this.cmbcondition.Name = "cmbcondition";
            this.cmbcondition.Size = new System.Drawing.Size(350, 25);
            this.cmbcondition.TabIndex = 184;
            this.cmbcondition.SelectedIndexChanged += new System.EventHandler(this.cmbcondition_SelectedIndexChanged);
            // 
            // lblcondition
            // 
            this.lblcondition.AutoSize = true;
            this.lblcondition.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcondition.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcondition.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcondition.Location = new System.Drawing.Point(480, 736);
            this.lblcondition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcondition.Name = "lblcondition";
            this.lblcondition.Size = new System.Drawing.Size(75, 19);
            this.lblcondition.TabIndex = 183;
            this.lblcondition.Text = "Condition*";
            // 
            // txtmodel
            // 
            this.txtmodel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmodel.Location = new System.Drawing.Point(479, 670);
            this.txtmodel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmodel.Multiline = true;
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(350, 26);
            this.txtmodel.TabIndex = 180;
            this.txtmodel.TextChanged += new System.EventHandler(this.txtmodel_TextChanged);
            this.txtmodel.Leave += new System.EventHandler(this.txtmodel_Leave);
            // 
            // lblmodel
            // 
            this.lblmodel.AutoSize = true;
            this.lblmodel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmodel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblmodel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblmodel.Location = new System.Drawing.Point(480, 652);
            this.lblmodel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmodel.Name = "lblmodel";
            this.lblmodel.Size = new System.Drawing.Size(54, 19);
            this.lblmodel.TabIndex = 179;
            this.lblmodel.Text = "Model*";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pbpreview2);
            this.panel1.Controls.Add(this.pbpreview5);
            this.panel1.Controls.Add(this.pbpreview1);
            this.panel1.Controls.Add(this.pbpreview3);
            this.panel1.Controls.Add(this.pbpreview4);
            this.panel1.Location = new System.Drawing.Point(94, 302);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 257);
            this.panel1.TabIndex = 178;
            // 
            // pbpreview2
            // 
            this.pbpreview2.Location = new System.Drawing.Point(510, 21);
            this.pbpreview2.Margin = new System.Windows.Forms.Padding(4, 5, 75, 5);
            this.pbpreview2.Name = "pbpreview2";
            this.pbpreview2.Size = new System.Drawing.Size(100, 95);
            this.pbpreview2.TabIndex = 85;
            this.pbpreview2.TabStop = false;
            // 
            // pbpreview5
            // 
            this.pbpreview5.Location = new System.Drawing.Point(640, 121);
            this.pbpreview5.Margin = new System.Windows.Forms.Padding(4, 5, 75, 5);
            this.pbpreview5.Name = "pbpreview5";
            this.pbpreview5.Size = new System.Drawing.Size(100, 95);
            this.pbpreview5.TabIndex = 87;
            this.pbpreview5.TabStop = false;
            // 
            // pbpreview1
            // 
            this.pbpreview1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbpreview1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbpreview1.Location = new System.Drawing.Point(4, 21);
            this.pbpreview1.Margin = new System.Windows.Forms.Padding(4, 5, 75, 5);
            this.pbpreview1.Name = "pbpreview1";
            this.pbpreview1.Size = new System.Drawing.Size(200, 200);
            this.pbpreview1.TabIndex = 67;
            this.pbpreview1.TabStop = false;
            // 
            // pbpreview3
            // 
            this.pbpreview3.Location = new System.Drawing.Point(640, 21);
            this.pbpreview3.Margin = new System.Windows.Forms.Padding(4, 5, 75, 5);
            this.pbpreview3.Name = "pbpreview3";
            this.pbpreview3.Size = new System.Drawing.Size(100, 95);
            this.pbpreview3.TabIndex = 86;
            this.pbpreview3.TabStop = false;
            // 
            // pbpreview4
            // 
            this.pbpreview4.Location = new System.Drawing.Point(510, 121);
            this.pbpreview4.Margin = new System.Windows.Forms.Padding(4, 5, 75, 5);
            this.pbpreview4.Name = "pbpreview4";
            this.pbpreview4.Size = new System.Drawing.Size(100, 95);
            this.pbpreview4.TabIndex = 89;
            this.pbpreview4.TabStop = false;
            // 
            // btnImageUpload
            // 
            this.btnImageUpload.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImageUpload.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnImageUpload.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImageUpload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageUpload.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnImageUpload.Location = new System.Drawing.Point(93, 257);
            this.btnImageUpload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImageUpload.Name = "btnImageUpload";
            this.btnImageUpload.Size = new System.Drawing.Size(750, 40);
            this.btnImageUpload.TabIndex = 177;
            this.btnImageUpload.Text = "Click To Upload Phone Images";
            this.btnImageUpload.UseVisualStyleBackColor = false;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.Location = new System.Drawing.Point(96, 752);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 15);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrice.Size = new System.Drawing.Size(350, 26);
            this.txtPrice.TabIndex = 176;
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // cmbOSVersion
            // 
            this.cmbOSVersion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOSVersion.FormattingEnabled = true;
            this.cmbOSVersion.Location = new System.Drawing.Point(96, 592);
            this.cmbOSVersion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 15);
            this.cmbOSVersion.Name = "cmbOSVersion";
            this.cmbOSVersion.Size = new System.Drawing.Size(345, 25);
            this.cmbOSVersion.TabIndex = 175;
            this.cmbOSVersion.Visible = false;
            this.cmbOSVersion.SelectedIndexChanged += new System.EventHandler(this.cmbOSVersion_SelectedIndexChanged);
            // 
            // cmbbrand
            // 
            this.cmbbrand.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbrand.FormattingEnabled = true;
            this.cmbbrand.Items.AddRange(new object[] {
            "Please Select a Brand",
            "Samsung",
            "Apple",
            "Google",
            "OnePlus",
            "Lenovo",
            "Motorola",
            "Huawei",
            "Sony",
            "Realme",
            "Other"});
            this.cmbbrand.Location = new System.Drawing.Point(96, 671);
            this.cmbbrand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 15);
            this.cmbbrand.Name = "cmbbrand";
            this.cmbbrand.Size = new System.Drawing.Size(350, 25);
            this.cmbbrand.TabIndex = 174;
            this.cmbbrand.SelectedIndexChanged += new System.EventHandler(this.cmbbrand_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(480, 924);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(350, 62);
            this.btnSubmit.TabIndex = 173;
            this.btnSubmit.Text = "Next";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(95, 924);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(350, 62);
            this.btnCancel.TabIndex = 172;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(96, 239);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 19);
            this.label8.TabIndex = 171;
            this.label8.Text = "Image Upload";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblprice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblprice.Location = new System.Drawing.Point(96, 734);
            this.lblprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(45, 19);
            this.lblprice.TabIndex = 170;
            this.lblprice.Text = "Price*";
            // 
            // lblOSVersion
            // 
            this.lblOSVersion.AutoSize = true;
            this.lblOSVersion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOSVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOSVersion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOSVersion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOSVersion.Location = new System.Drawing.Point(98, 572);
            this.lblOSVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOSVersion.Name = "lblOSVersion";
            this.lblOSVersion.Size = new System.Drawing.Size(81, 19);
            this.lblOSVersion.TabIndex = 169;
            this.lblOSVersion.Text = "OS Version*";
            this.lblOSVersion.Visible = false;
            // 
            // btnIOS
            // 
            this.btnIOS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIOS.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIOS.Location = new System.Drawing.Point(479, 588);
            this.btnIOS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIOS.Name = "btnIOS";
            this.btnIOS.Size = new System.Drawing.Size(350, 40);
            this.btnIOS.TabIndex = 168;
            this.btnIOS.Text = "IOS";
            this.btnIOS.UseVisualStyleBackColor = false;
            // 
            // btnAndroid
            // 
            this.btnAndroid.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAndroid.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAndroid.Location = new System.Drawing.Point(95, 588);
            this.btnAndroid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 15);
            this.btnAndroid.Name = "btnAndroid";
            this.btnAndroid.Size = new System.Drawing.Size(350, 40);
            this.btnAndroid.TabIndex = 167;
            this.btnAndroid.Text = "Android";
            this.btnAndroid.UseVisualStyleBackColor = false;
            this.btnAndroid.Click += new System.EventHandler(this.btnAndroid_Click);
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOS.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOS.Location = new System.Drawing.Point(96, 572);
            this.lblOS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(33, 19);
            this.lblOS.TabIndex = 166;
            this.lblOS.Text = "OS*";
            // 
            // lblbrand
            // 
            this.lblbrand.AutoSize = true;
            this.lblbrand.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblbrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbrand.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbrand.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblbrand.Location = new System.Drawing.Point(96, 652);
            this.lblbrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbrand.Name = "lblbrand";
            this.lblbrand.Size = new System.Drawing.Size(52, 19);
            this.lblbrand.TabIndex = 165;
            this.lblbrand.Text = "Brand*";
            // 
            // btnChangeOS
            // 
            this.btnChangeOS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChangeOS.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeOS.Location = new System.Drawing.Point(480, 588);
            this.btnChangeOS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChangeOS.Name = "btnChangeOS";
            this.btnChangeOS.Size = new System.Drawing.Size(350, 40);
            this.btnChangeOS.TabIndex = 185;
            this.btnChangeOS.Text = "Change OS ";
            this.btnChangeOS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChangeOS.UseVisualStyleBackColor = false;
            this.btnChangeOS.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::midterm_Q2.Properties.Resources.logo_icon;
            this.pictureBox1.Location = new System.Drawing.Point(414, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 150);
            this.pictureBox1.TabIndex = 186;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(96, 793);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 187;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(96, 852);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 188;
            this.label2.Text = "Phone";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(96, 870);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(350, 26);
            this.textBox1.TabIndex = 190;
            // 
            // cemail
            // 
            this.cemail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cemail.ForeColor = System.Drawing.Color.Black;
            this.cemail.Location = new System.Drawing.Point(96, 811);
            this.cemail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 15);
            this.cemail.Name = "cemail";
            this.cemail.ReadOnly = true;
            this.cemail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cemail.Size = new System.Drawing.Size(350, 26);
            this.cemail.TabIndex = 191;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(480, 793);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 192;
            this.label3.Text = "Description";
            // 
            // des
            // 
            this.des.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.des.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.des.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.des.ForeColor = System.Drawing.Color.Black;
            this.des.Location = new System.Drawing.Point(480, 811);
            this.des.Margin = new System.Windows.Forms.Padding(4, 5, 4, 15);
            this.des.Multiline = true;
            this.des.Name = "des";
            this.des.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.des.Size = new System.Drawing.Size(350, 85);
            this.des.TabIndex = 193;
            // 
            // PhoneListControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.des);
            this.Controls.Add(this.cemail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblcondition);
            this.Controls.Add(this.lblmodel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnImageUpload);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblOS);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblbrand);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblOSVersion);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cmbcondition);
            this.Controls.Add(this.txtmodel);
            this.Controls.Add(this.cmbbrand);
            this.Controls.Add(this.btnIOS);
            this.Controls.Add(this.btnChangeOS);
            this.Controls.Add(this.btnAndroid);
            this.Controls.Add(this.cmbOSVersion);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PhoneListControl";
            this.Size = new System.Drawing.Size(1200, 1000);
            this.Load += new System.EventHandler(this.PhoneListControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbpreview2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpreview5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpreview1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpreview3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpreview4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbcondition;
        private System.Windows.Forms.Label lblcondition;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.Label lblmodel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImageUpload;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbOSVersion;
        private System.Windows.Forms.ComboBox cmbbrand;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblOSVersion;
        private System.Windows.Forms.Button btnIOS;
        private System.Windows.Forms.Button btnAndroid;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Label lblbrand;
        private System.Windows.Forms.Button btnChangeOS;
        private System.Windows.Forms.PictureBox pbpreview1;
        private System.Windows.Forms.PictureBox pbpreview2;
        private System.Windows.Forms.PictureBox pbpreview5;
        private System.Windows.Forms.PictureBox pbpreview3;
        private System.Windows.Forms.PictureBox pbpreview4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox cemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox des;
    }
}
