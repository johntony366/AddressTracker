namespace WinFormsMiniProject
{
    partial class AddressInformationForm
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
            this.addressInformationLabel = new System.Windows.Forms.Label();
            this.houseNumberLabel = new System.Windows.Forms.Label();
            this.zipcodeLabel = new System.Windows.Forms.Label();
            this.districtLabel = new System.Windows.Forms.Label();
            this.houseNumberText = new System.Windows.Forms.TextBox();
            this.zipcodeText = new System.Windows.Forms.TextBox();
            this.districtText = new System.Windows.Forms.TextBox();
            this.submitAddressInformationButton = new System.Windows.Forms.Button();
            this.stateLabel = new System.Windows.Forms.Label();
            this.stateText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addressInformationLabel
            // 
            this.addressInformationLabel.AutoSize = true;
            this.addressInformationLabel.Location = new System.Drawing.Point(454, 131);
            this.addressInformationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressInformationLabel.Name = "addressInformationLabel";
            this.addressInformationLabel.Size = new System.Drawing.Size(186, 25);
            this.addressInformationLabel.TabIndex = 0;
            this.addressInformationLabel.Text = "Address Information";
            // 
            // houseNumberLabel
            // 
            this.houseNumberLabel.AutoSize = true;
            this.houseNumberLabel.Location = new System.Drawing.Point(388, 188);
            this.houseNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.houseNumberLabel.Name = "houseNumberLabel";
            this.houseNumberLabel.Size = new System.Drawing.Size(143, 25);
            this.houseNumberLabel.TabIndex = 1;
            this.houseNumberLabel.Text = "House Number";
            // 
            // zipcodeLabel
            // 
            this.zipcodeLabel.AutoSize = true;
            this.zipcodeLabel.Location = new System.Drawing.Point(388, 238);
            this.zipcodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zipcodeLabel.Name = "zipcodeLabel";
            this.zipcodeLabel.Size = new System.Drawing.Size(82, 25);
            this.zipcodeLabel.TabIndex = 1;
            this.zipcodeLabel.Text = "Zipcode";
            // 
            // districtLabel
            // 
            this.districtLabel.AutoSize = true;
            this.districtLabel.Location = new System.Drawing.Point(388, 291);
            this.districtLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.districtLabel.Name = "districtLabel";
            this.districtLabel.Size = new System.Drawing.Size(70, 25);
            this.districtLabel.TabIndex = 1;
            this.districtLabel.Text = "District";
            // 
            // houseNumberText
            // 
            this.houseNumberText.Location = new System.Drawing.Point(562, 183);
            this.houseNumberText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.houseNumberText.Name = "houseNumberText";
            this.houseNumberText.Size = new System.Drawing.Size(148, 30);
            this.houseNumberText.TabIndex = 1;
            // 
            // zipcodeText
            // 
            this.zipcodeText.Location = new System.Drawing.Point(562, 233);
            this.zipcodeText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zipcodeText.Name = "zipcodeText";
            this.zipcodeText.Size = new System.Drawing.Size(148, 30);
            this.zipcodeText.TabIndex = 2;
            // 
            // districtText
            // 
            this.districtText.Location = new System.Drawing.Point(562, 286);
            this.districtText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.districtText.Name = "districtText";
            this.districtText.Size = new System.Drawing.Size(148, 30);
            this.districtText.TabIndex = 3;
            // 
            // submitAddressInformationButton
            // 
            this.submitAddressInformationButton.Location = new System.Drawing.Point(393, 403);
            this.submitAddressInformationButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submitAddressInformationButton.Name = "submitAddressInformationButton";
            this.submitAddressInformationButton.Size = new System.Drawing.Size(320, 36);
            this.submitAddressInformationButton.TabIndex = 5;
            this.submitAddressInformationButton.Text = "Submit";
            this.submitAddressInformationButton.UseVisualStyleBackColor = true;
            this.submitAddressInformationButton.Click += new System.EventHandler(this.submitAddressInformationButton_Click);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(388, 345);
            this.stateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(58, 25);
            this.stateLabel.TabIndex = 1;
            this.stateLabel.Text = "State";
            // 
            // stateText
            // 
            this.stateText.Location = new System.Drawing.Point(562, 340);
            this.stateText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(148, 30);
            this.stateText.TabIndex = 4;
            // 
            // AddressInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 736);
            this.Controls.Add(this.submitAddressInformationButton);
            this.Controls.Add(this.stateText);
            this.Controls.Add(this.districtText);
            this.Controls.Add(this.zipcodeText);
            this.Controls.Add(this.houseNumberText);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.districtLabel);
            this.Controls.Add(this.zipcodeLabel);
            this.Controls.Add(this.houseNumberLabel);
            this.Controls.Add(this.addressInformationLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddressInformationForm";
            this.Text = "AddressInformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addressInformationLabel;
        private System.Windows.Forms.Label houseNumberLabel;
        private System.Windows.Forms.Label zipcodeLabel;
        private System.Windows.Forms.Label districtLabel;
        private System.Windows.Forms.TextBox houseNumberText;
        private System.Windows.Forms.TextBox zipcodeText;
        private System.Windows.Forms.TextBox districtText;
        private System.Windows.Forms.Button submitAddressInformationButton;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox stateText;
    }
}