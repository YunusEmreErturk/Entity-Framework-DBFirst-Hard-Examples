namespace DBFirst_FaturaIslemlerii
{
    partial class FormSiparisEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Employe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.cmbEmploye = new System.Windows.Forms.ComboBox();
            this.cmbShipVia = new System.Windows.Forms.ComboBox();
            this.dateTimePickerOrder = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerRequired = new System.Windows.Forms.DateTimePicker();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtCountryAndCity = new System.Windows.Forms.TextBox();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // cmb_Employe
            // 
            this.cmb_Employe.AutoSize = true;
            this.cmb_Employe.Location = new System.Drawing.Point(25, 84);
            this.cmb_Employe.Name = "cmb_Employe";
            this.cmb_Employe.Size = new System.Drawing.Size(47, 13);
            this.cmb_Employe.TabIndex = 1;
            this.cmb_Employe.Text = "Employe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Required Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Order Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Freight";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ship Via";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(110, 32);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(83, 21);
            this.cmbCustomer.TabIndex = 6;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // cmbEmploye
            // 
            this.cmbEmploye.FormattingEnabled = true;
            this.cmbEmploye.Location = new System.Drawing.Point(110, 81);
            this.cmbEmploye.Name = "cmbEmploye";
            this.cmbEmploye.Size = new System.Drawing.Size(83, 21);
            this.cmbEmploye.TabIndex = 7;
            this.cmbEmploye.SelectedIndexChanged += new System.EventHandler(this.cmbEmploye_SelectedIndexChanged);
            // 
            // cmbShipVia
            // 
            this.cmbShipVia.FormattingEnabled = true;
            this.cmbShipVia.Location = new System.Drawing.Point(110, 220);
            this.cmbShipVia.Name = "cmbShipVia";
            this.cmbShipVia.Size = new System.Drawing.Size(83, 21);
            this.cmbShipVia.TabIndex = 8;
            this.cmbShipVia.SelectedIndexChanged += new System.EventHandler(this.cmbShipVia_SelectedIndexChanged);
            // 
            // dateTimePickerOrder
            // 
            this.dateTimePickerOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOrder.Location = new System.Drawing.Point(110, 129);
            this.dateTimePickerOrder.Name = "dateTimePickerOrder";
            this.dateTimePickerOrder.Size = new System.Drawing.Size(83, 20);
            this.dateTimePickerOrder.TabIndex = 9;
            // 
            // dateTimePickerRequired
            // 
            this.dateTimePickerRequired.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRequired.Location = new System.Drawing.Point(110, 178);
            this.dateTimePickerRequired.Name = "dateTimePickerRequired";
            this.dateTimePickerRequired.Size = new System.Drawing.Size(83, 20);
            this.dateTimePickerRequired.TabIndex = 10;
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(110, 263);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(83, 20);
            this.txtFreight.TabIndex = 11;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(239, 14);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(91, 88);
            this.txtAdress.TabIndex = 12;
            // 
            // txtCountryAndCity
            // 
            this.txtCountryAndCity.Location = new System.Drawing.Point(353, 33);
            this.txtCountryAndCity.Name = "txtCountryAndCity";
            this.txtCountryAndCity.Size = new System.Drawing.Size(83, 20);
            this.txtCountryAndCity.TabIndex = 13;
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Location = new System.Drawing.Point(110, 319);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(75, 23);
            this.btnSiparisEkle.TabIndex = 14;
            this.btnSiparisEkle.Text = "Siparis Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.txtCountryAndCity);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.dateTimePickerRequired);
            this.Controls.Add(this.dateTimePickerOrder);
            this.Controls.Add(this.cmbShipVia);
            this.Controls.Add(this.cmbEmploye);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Employe);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cmb_Employe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.ComboBox cmbEmploye;
        private System.Windows.Forms.ComboBox cmbShipVia;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrder;
        private System.Windows.Forms.DateTimePicker dateTimePickerRequired;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtCountryAndCity;
        private System.Windows.Forms.Button btnSiparisEkle;
    }
}