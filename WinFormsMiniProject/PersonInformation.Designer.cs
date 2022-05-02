namespace WinFormsMiniProject
{
    partial class personInformationForm
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.personalInformationLabel = new System.Windows.Forms.Label();
            this.submitPersonalInformationButton = new System.Windows.Forms.Button();
            this.addressesLabel = new System.Windows.Forms.Label();
            this.addressButton = new System.Windows.Forms.Button();
            this.isActiveCheck = new System.Windows.Forms.CheckBox();
            this.isActiveLabel = new System.Windows.Forms.Label();
            this.addressList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(189, 132);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(92, 20);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(328, 122);
            this.firstNameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(330, 27);
            this.firstNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(189, 184);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(91, 20);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(328, 176);
            this.lastNameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(330, 27);
            this.lastNameText.TabIndex = 2;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(192, 235);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(51, 20);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(328, 235);
            this.emailText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(330, 27);
            this.emailText.TabIndex = 3;
            // 
            // personalInformationLabel
            // 
            this.personalInformationLabel.AutoSize = true;
            this.personalInformationLabel.Location = new System.Drawing.Point(240, 59);
            this.personalInformationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.personalInformationLabel.Name = "personalInformationLabel";
            this.personalInformationLabel.Size = new System.Drawing.Size(163, 20);
            this.personalInformationLabel.TabIndex = 6;
            this.personalInformationLabel.Text = "Personal Information";
            // 
            // submitPersonalInformationButton
            // 
            this.submitPersonalInformationButton.Location = new System.Drawing.Point(196, 625);
            this.submitPersonalInformationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submitPersonalInformationButton.Name = "submitPersonalInformationButton";
            this.submitPersonalInformationButton.Size = new System.Drawing.Size(462, 38);
            this.submitPersonalInformationButton.TabIndex = 6;
            this.submitPersonalInformationButton.Text = "Save";
            this.submitPersonalInformationButton.UseVisualStyleBackColor = true;
            this.submitPersonalInformationButton.Click += new System.EventHandler(this.submitPersonalInformationButton_Click);
            // 
            // addressesLabel
            // 
            this.addressesLabel.AutoSize = true;
            this.addressesLabel.Location = new System.Drawing.Point(192, 320);
            this.addressesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressesLabel.Name = "addressesLabel";
            this.addressesLabel.Size = new System.Drawing.Size(89, 20);
            this.addressesLabel.TabIndex = 8;
            this.addressesLabel.Text = "Addresses";
            // 
            // addressButton
            // 
            this.addressButton.Location = new System.Drawing.Point(535, 320);
            this.addressButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addressButton.Name = "addressButton";
            this.addressButton.Size = new System.Drawing.Size(124, 28);
            this.addressButton.TabIndex = 5;
            this.addressButton.Text = "Add";
            this.addressButton.UseVisualStyleBackColor = true;
            this.addressButton.Click += new System.EventHandler(this.addressButton_Click);
            // 
            // isActiveCheck
            // 
            this.isActiveCheck.AutoSize = true;
            this.isActiveCheck.Location = new System.Drawing.Point(328, 276);
            this.isActiveCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isActiveCheck.Name = "isActiveCheck";
            this.isActiveCheck.Size = new System.Drawing.Size(18, 17);
            this.isActiveCheck.TabIndex = 4;
            this.isActiveCheck.UseVisualStyleBackColor = true;
            // 
            // isActiveLabel
            // 
            this.isActiveLabel.AutoSize = true;
            this.isActiveLabel.Location = new System.Drawing.Point(192, 275);
            this.isActiveLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.isActiveLabel.Name = "isActiveLabel";
            this.isActiveLabel.Size = new System.Drawing.Size(55, 20);
            this.isActiveLabel.TabIndex = 11;
            this.isActiveLabel.Text = "Active";
            // 
            // addressList
            // 
            this.addressList.FormattingEnabled = true;
            this.addressList.ItemHeight = 20;
            this.addressList.Location = new System.Drawing.Point(192, 369);
            this.addressList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addressList.Name = "addressList";
            this.addressList.Size = new System.Drawing.Size(465, 224);
            this.addressList.TabIndex = 12;
            // 
            // personInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 712);
            this.Controls.Add(this.addressList);
            this.Controls.Add(this.isActiveLabel);
            this.Controls.Add(this.isActiveCheck);
            this.Controls.Add(this.addressButton);
            this.Controls.Add(this.addressesLabel);
            this.Controls.Add(this.submitPersonalInformationButton);
            this.Controls.Add(this.personalInformationLabel);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.firstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "personInformationForm";
            this.Text = "PersonInfomation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label personalInformationLabel;
        private System.Windows.Forms.Button submitPersonalInformationButton;
        private System.Windows.Forms.Label addressesLabel;
        private System.Windows.Forms.Button addressButton;
        private System.Windows.Forms.CheckBox isActiveCheck;
        private System.Windows.Forms.Label isActiveLabel;
        private System.Windows.Forms.ListBox addressList;
    }
}

