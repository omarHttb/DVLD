﻿using BusinessLayerDVLD;
using DVLD.Users;
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
    public partial class UcSearchForPerson : UserControl
    {
        clsPeople _People;
        clsCountries _Countries;
        public int PersonID = -1;
        public  bool EditMode = false;
        public int Age { get; set; }
        
            public UcSearchForPerson()
        {
            InitializeComponent();
        }

        private void frmAddUpdatePerson_Databack(object sender,int PersonID)
        {
            if(PersonID != -1)
            {
                CbSearchFilter.SelectedIndex = 2;
            }
            txtSearch.Text = PersonID.ToString();
            
        }
        

        public void UpdateMode()
        {
            CbSearchFilter.Enabled = false;
            txtSearch.Enabled = false;
            btnAddPerson.Enabled = false;
            btnSearch.Enabled = false;
        }
        
        private void _LoadByFilter()
        {
            switch (EditMode)
            {
                case false:
                    if (CbSearchFilter.SelectedIndex == 2)
                    {
                        lblPersonId.Text = txtSearch.Text;
                        _People = clsPeople.FindPersonById(Convert.ToInt32(txtSearch.Text));
                        _Countries = clsCountries.FindCountryPerson(Convert.ToInt32(txtSearch.Text));

                    }
                    else if (CbSearchFilter.SelectedIndex == 1)
                    {
                        _People = clsPeople.FindPersonByNationalNumber(txtSearch.Text);
                        lblPersonId.Text = _People.ID.ToString();
                        _Countries = clsCountries.FindCountryPerson(_People.ID);

                    }
                    break;
                    case true:
                    _People = clsPeople.FindPersonById(PersonID);
                    _Countries = clsCountries.FindCountryPerson(PersonID);
                    break;
            }
            
                

        }

        private void UcSearchForPerson_Load(object sender, EventArgs e)
        {
            CbSearchFilter.SelectedIndex = 0;
            LlEdit.Visible = false;
            
        }

        // add button
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddUpdatePerson frm = new FrmAddUpdatePerson(true);

                frm.DataBack += frmAddUpdatePerson_Databack;

                frm.ShowDialog();
                if (txtSearch.Text != "")
                {
                    LoadPersonInfo();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        
       private bool IsNationalNoExist()
        {
            if (clsPeople.IsNationalNoFound(txtSearch.Text))
            {
                return true;
            }
            else
            {
                return false; 
            }
        }

       private bool isPersonIdExist()
        {
            if (clsPeople.IsPersonIDFound(txtSearch.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                switch (CbSearchFilter.SelectedIndex)
                {
                    case 0:

                        break;
                    case 2:

                        if (isPersonIdExist())
                        {
                            LoadPersonInfo();
                            LlEdit.Visible=true;
                        }
                        else
                        {
                            MessageBox.Show("Not found");
                        }
                        break;

                    case 1:
                        if (IsNationalNoExist())
                        {
                            LoadPersonInfo();
                        }
                        else
                        {
                            MessageBox.Show("not found");
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadPersonInfo()
        {

            try
            {
                
                
                _LoadByFilter();
                
                


                lblFullName.Text = _People.FirstName + " " + _People.SecondName+ " " + _People.ThirdName + 
                    " " + _People.LastName;

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

                Age = Convert.ToInt32(DateTime.Now.Year) -  Convert.ToInt32(DtpDateOfBirth.Value.Year) ;

                if (_People.ImagePath != "")
                {
                    PbPerson.Image = new Bitmap("C:\\Users\\omar hattab\\Pictures\\DVLD Images\\" + _People.ImagePath);

                }


                LblCountry.Text = _Countries.CountryName;
                PersonID = _People.ID;

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CbSearchFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CbSearchFilter.SelectedIndex == 0) 
            {
                txtSearch.Enabled = false;
            }
            else
            {
                txtSearch.Enabled = true;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CbSearchFilter.SelectedIndex == 2)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void LlEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAddUpdatePerson form = new FrmAddUpdatePerson(Convert.ToInt32(lblPersonId.Text));

            form.ShowDialog();
            LoadPersonInfo();
        }
    }
}
