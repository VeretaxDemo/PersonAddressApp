namespace AddressForms
{
    partial class AddPerson
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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.savePersonButton = new System.Windows.Forms.Button();
            this.goBackAddPersonButton = new System.Windows.Forms.Button();
            this.addressButton = new System.Windows.Forms.Button();
            this.addressesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(187, 99);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(287, 27);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(187, 155);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(287, 27);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(187, 208);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(287, 27);
            this.emailTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Addresses";
            // 
            // savePersonButton
            // 
            this.savePersonButton.Location = new System.Drawing.Point(187, 63);
            this.savePersonButton.Name = "savePersonButton";
            this.savePersonButton.Size = new System.Drawing.Size(87, 27);
            this.savePersonButton.TabIndex = 5;
            this.savePersonButton.Text = "Save";
            this.savePersonButton.UseVisualStyleBackColor = true;
            this.savePersonButton.Click += new System.EventHandler(this.savePersonButton_Click);
            // 
            // goBackAddPersonButton
            // 
            this.goBackAddPersonButton.Location = new System.Drawing.Point(75, 63);
            this.goBackAddPersonButton.Name = "goBackAddPersonButton";
            this.goBackAddPersonButton.Size = new System.Drawing.Size(87, 27);
            this.goBackAddPersonButton.TabIndex = 6;
            this.goBackAddPersonButton.Text = "Back";
            this.goBackAddPersonButton.UseVisualStyleBackColor = true;
            this.goBackAddPersonButton.Click += new System.EventHandler(this.GoBackAddPersonButton_Click);
            // 
            // addressButton
            // 
            this.addressButton.Location = new System.Drawing.Point(187, 254);
            this.addressButton.Name = "addressButton";
            this.addressButton.Size = new System.Drawing.Size(174, 27);
            this.addressButton.TabIndex = 4;
            this.addressButton.Text = "Add Address";
            this.addressButton.UseVisualStyleBackColor = true;
            this.addressButton.Click += new System.EventHandler(this.AddressButton_Click);
            // 
            // addressesListBox
            // 
            this.addressesListBox.FormattingEnabled = true;
            this.addressesListBox.ItemHeight = 20;
            this.addressesListBox.Location = new System.Drawing.Point(187, 310);
            this.addressesListBox.Name = "addressesListBox";
            this.addressesListBox.Size = new System.Drawing.Size(801, 224);
            this.addressesListBox.TabIndex = 7;
            this.addressesListBox.SelectedIndexChanged += new System.EventHandler(this.addressesListBox_SelectedIndexChanged);
            // 
            // AddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.addressesListBox);
            this.Controls.Add(this.addressButton);
            this.Controls.Add(this.goBackAddPersonButton);
            this.Controls.Add(this.savePersonButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddPerson";
            this.Text = "Add Person";
            this.Load += new System.EventHandler(this.AddPerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button savePersonButton;
        private System.Windows.Forms.Button goBackAddPersonButton;
        private System.Windows.Forms.Button addressButton;
        public System.Windows.Forms.TextBox firstNameTextBox;
        public System.Windows.Forms.TextBox lastNameTextBox;
        public System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ListBox addressesListBox;
    }
}