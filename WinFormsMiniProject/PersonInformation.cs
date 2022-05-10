using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DemoLibrary;

namespace WinFormsMiniProject
{
    public partial class personInformationForm : Form, ISaveAddress
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();
        public personInformationForm()
        {
            InitializeComponent();
            addressList.DataSource = addresses;
            addressList.DisplayMember = nameof(AddressModel.AddressValue);
        }

        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address);
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            AddressInformationForm addressForm = new AddressInformationForm(this);
            addressForm.Show(); 
        }

        private void submitPersonalInformationButton_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text,
                IsActive = isActiveCheck.Checked,
                Addresses = addresses.ToList()
            };

            Save.ToTextFile(person);

            firstNameText.Text = "";
            lastNameText.Text = "";
            emailText.Text = "";
            isActiveCheck.Checked = false;
            addresses.Clear();
        }
    }
}
