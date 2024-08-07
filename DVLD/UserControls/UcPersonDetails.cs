﻿using BusinessLayerDVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.UserControls
{
    public partial class UcPersonDetails : UserControl
    {

        clsPeople _People;
        clsCountries _Countries;
        public UcPersonDetails()
        {
            InitializeComponent();
        }

        public static int Result = -1;

        private void UcPersonDetails_Load(object sender, EventArgs e)
        {

                    lblPersonId.Text = Result.ToString();
                    _LoadPersonInfo();
    
        }
            
        private void _LoadPersonInfo()
        {


                if (Result != -1)
                {
                    _People = clsPeople.FindPerson(Result);



                    lblFullName.Text = _People.FirstName + " " + _People.SecondName
                        + " " + _People.ThirdName + " " + _People.LastName;
                    lblNationalNo.Text = _People.NationalNo;
                    lblPhone.Text = _People.Phone;
                    lblAddress.Text = _People.Address;
                    if (_People.Email != "")
                    {
                        lblEmail.Text = _People.Email;
                    }
                    if (_People.Gender == 0)
                    {
                        lblGender.Text = "Male";
                    }
                    else
                    {
                        lblGender.Text = "Female";
                    }

                    DtpDateOfBirth.Value = _People.DateOfBirth;

                    if (_People.ImagePath != "")
                    {
                        PbPerson.Image = new Bitmap("C:\\Users\\omar hattab\\Pictures\\DVLD Images\\" + _People.ImagePath);

                    }

                    _Countries = clsCountries.FindCountryPerson(Result);

                    LblCountry.Text = _Countries.CountryName;
                }

        }

        private void LlEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAddUpdatePerson form = new FrmAddUpdatePerson(Result,true); 

            form.ShowDialog();

        }

        private void lblPersonId_Click(object sender, EventArgs e)
        {

        }

        private void GbPersonInformation_Enter(object sender, EventArgs e)
        {

        }
    }
}
