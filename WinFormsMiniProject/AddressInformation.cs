using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMiniProject
{
    public partial class AddressInformationForm : Form
    {
        ISaveAddress _parentForm;
        public AddressInformationForm(ISaveAddress parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void submitAddressInformationButton_Click(object sender, EventArgs e)
        {
            AddressModel address = new AddressModel
            {
                HouseNumber = houseNumberText.Text,
                District = districtText.Text,
                State = stateText.Text,
                ZipCode = zipcodeText.Text
            };
            _parentForm.SaveAddress(address);
            this.Close();
        }
    }
}
