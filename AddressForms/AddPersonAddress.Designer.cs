namespace AddressForms
{
    partial class AddPersonAddress
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
            this.label2 = new System.Windows.Forms.Label();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addressTypeComboBox = new System.Windows.Forms.ComboBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.saveAddressButton = new System.Windows.Forms.Button();
            this.cancelAddressButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address Type";
            // 
            // address1TextBox
            // 
            this.address1TextBox.Location = new System.Drawing.Point(210, 143);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(395, 27);
            this.address1TextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address1";
            // 
            // address2TextBox
            // 
            this.address2TextBox.Location = new System.Drawing.Point(210, 199);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(395, 27);
            this.address2TextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address2";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(210, 256);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(395, 27);
            this.cityTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "State";
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(210, 359);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(395, 27);
            this.zipCodeTextBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Zip Code";
            // 
            // addressTypeComboBox
            // 
            this.addressTypeComboBox.FormattingEnabled = true;
            this.addressTypeComboBox.Location = new System.Drawing.Point(210, 79);
            this.addressTypeComboBox.Name = "addressTypeComboBox";
            this.addressTypeComboBox.Size = new System.Drawing.Size(254, 28);
            this.addressTypeComboBox.TabIndex = 1;
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(210, 308);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(254, 28);
            this.stateComboBox.TabIndex = 5;
            // 
            // saveAddressButton
            // 
            this.saveAddressButton.Location = new System.Drawing.Point(210, 443);
            this.saveAddressButton.Name = "saveAddressButton";
            this.saveAddressButton.Size = new System.Drawing.Size(96, 34);
            this.saveAddressButton.TabIndex = 7;
            this.saveAddressButton.Text = "Save";
            this.saveAddressButton.UseVisualStyleBackColor = true;
            this.saveAddressButton.Click += new System.EventHandler(this.saveAddressButton_Click);
            // 
            // cancelAddressButton
            // 
            this.cancelAddressButton.Location = new System.Drawing.Point(340, 443);
            this.cancelAddressButton.Name = "cancelAddressButton";
            this.cancelAddressButton.Size = new System.Drawing.Size(96, 34);
            this.cancelAddressButton.TabIndex = 8;
            this.cancelAddressButton.Text = "Cancel";
            this.cancelAddressButton.UseVisualStyleBackColor = true;
            this.cancelAddressButton.Click += new System.EventHandler(this.CancelAddressButton_Click);
            // 
            // AddPersonAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.cancelAddressButton);
            this.Controls.Add(this.saveAddressButton);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.addressTypeComboBox);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddPersonAddress";
            this.Text = "Add Person Address";
            this.Load += new System.EventHandler(this.AddPersonAddress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button saveAddressButton;
        private System.Windows.Forms.Button cancelAddressButton;
        public System.Windows.Forms.TextBox cityTextBox;
        public System.Windows.Forms.TextBox zipCodeTextBox;
        public System.Windows.Forms.ComboBox addressTypeComboBox;
        public System.Windows.Forms.ComboBox stateComboBox;
        public System.Windows.Forms.TextBox address2TextBox;
        public System.Windows.Forms.TextBox address1TextBox;
    }
}