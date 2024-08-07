using BusinessLayerDVLD;
using DVLD.textFormatValidation;
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
using DVLD.Properties;

namespace DVLD
{
    public partial class FrmAddUpdatePerson : Form
    {
        enum enIsValidated { IsValidated, NotValidated }
        enum enAddOrUpdate { AddNew = 0, Update = 1 }
        private enAddOrUpdate AddOrUpdate;
        enIsValidated IsValidated = enIsValidated.NotValidated;
        int _PersonId;
        private static string _FilePath { get; set; }
        private static string _FileName { get; set; }
        private static string _FileExtension { get; set; }
        bool MarkForImageDelete = false;

        clsPeople _people;
        public FrmAddUpdatePerson(int personId, bool UpdateMode)
        {
            InitializeComponent();
            _PersonId = personId;

            if (personId != -1) 
            {
                lblId.Text = personId.ToString();
            }
            if (lblId.Text == "N/A")
                AddOrUpdate = enAddOrUpdate.AddNew;
            else
            {
                AddOrUpdate = enAddOrUpdate.Update;
            }

            if(UpdateMode)
            {
                IsValidated = enIsValidated.IsValidated;
            }
        }
        public FrmAddUpdatePerson()
        {
            InitializeComponent();

        }

        private bool ImageExist()
        {
            if (_people.ImagePath != "")
            {
                LlRemoveImage.Visible = true;
                return true;
            }
            else
                LlRemoveImage.Visible = false;
            return false;
        }

        private void FrmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _loadCountriesInComboBox();
            _LoadUpdateData();
            if (AddOrUpdate == enAddOrUpdate.AddNew)
            {
                _LoadMaxLegalAgeDateTime();
                cbCountry.SelectedIndex = 89;

            }

            // imageFunciton
            ImageExist();

        }

        private void _LoadMaxLegalAgeDateTime()
        {
            DtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
        }


        private void _loadCountriesInComboBox()
        {


            DataTable dt = clsCountries.GetAllCountries();

            foreach (DataRow dr in dt.Rows)
            {
                cbCountry.Items.Add(dr["CountryName"]);
            }

        }


        private short _ValidateMaleOrFemale()
        {
            if (RbFemale.Checked)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        private void _LoadUpdateData()
        {
            if (AddOrUpdate == enAddOrUpdate.AddNew)
            {
                lblId.Text = "N/A";
                _people = new clsPeople();
                return;
            }

            _people = clsPeople.FindPerson(Convert.ToInt16(lblId.Text));

            if (_people == null)
            {
                MessageBox.Show("Person not found");

            }

            lblId.Text = _people.ID.ToString();
            txtFirstName.Text = _people.FirstName;
            txtSecondName.Text = _people.SecondName;
            txtThirdName.Text = _people.ThirdName;
            txtLastName.Text = _people.LastName;
            txtNationalNo.Text = _people.NationalNo;
            txtPhone.Text = _people.Phone;
            if (_people.Email != "")
            {
                TxtEmail.Text = _people.Email;
            }
            txtAddress.Text = _people.Address;
            DtpDateOfBirth.Value = _people.DateOfBirth;
            if (_people.Gender == 0)
            {
                RbMale.Checked = true;
            }
            else
                RbFemale.Checked = true;
            
            if(ImageExist()) 
            { 
            PbPerson.Image = new Bitmap ("C:\\Users\\omar hattab\\Pictures\\DVLD Images\\" + _people.ImagePath);    
            }

            cbCountry.SelectedIndex = _people.NationalityCountryId - 1;

        }


     


        // This Entire Code Is FOR Validating ALL INPUTS!!
        //------------------------------------------------------------------------------------------------------------------------------------
        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {

                EpAddUpdate.SetError(txtFirstName, "Field is empty");
                IsValidated = enIsValidated.NotValidated;
            }
            else
            {
                EpAddUpdate.SetError(txtFirstName, "");
                IsValidated = enIsValidated.IsValidated;
            }
        }

        private void txtSecondName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSecondName.Text))
            {

                EpAddUpdate.SetError(txtSecondName, "Field is empty");
                IsValidated = enIsValidated.NotValidated;

            }
            else
            {
                EpAddUpdate.SetError(txtSecondName, "");
                IsValidated = enIsValidated.IsValidated;

            }
        }

        private void txtThirdName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtThirdName.Text))
            {

                EpAddUpdate.SetError(txtThirdName, "Field is empty");
                IsValidated = enIsValidated.NotValidated;

            }
            else
            {
                EpAddUpdate.SetError(txtThirdName, "");
                IsValidated = enIsValidated.IsValidated;

            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {

                EpAddUpdate.SetError(txtLastName, "Field is empty");
                IsValidated = enIsValidated.NotValidated;

            }
            else
            {
                EpAddUpdate.SetError(txtLastName, "");
                IsValidated = enIsValidated.IsValidated;

            }
        }

        private void txtNationalNo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNationalNo.Text))
            {

                EpAddUpdate.SetError(txtNationalNo, "Field is empty");
                IsValidated = enIsValidated.NotValidated;

            }
            else if (clsPeople.IsNationalNoFound(txtNationalNo.Text))
            {
                EpAddUpdate.SetError(txtNationalNo, "national number is used for another person");
                IsValidated = enIsValidated.NotValidated;

            }
            else
            {
                EpAddUpdate.SetError(txtNationalNo, "");
                IsValidated = enIsValidated.IsValidated;

            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {

                EpAddUpdate.SetError(txtPhone, "Field is empty");
                IsValidated = enIsValidated.NotValidated;

            }
            else
            {
                EpAddUpdate.SetError(txtPhone, "");
                IsValidated = enIsValidated.IsValidated;

            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {

                EpAddUpdate.SetError(txtAddress, "Field is empty");
                IsValidated = enIsValidated.NotValidated;

            }
            else
            {
                EpAddUpdate.SetError(txtAddress, "");
                IsValidated = enIsValidated.IsValidated;

            }
        }

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtEmail.Text))
                if (!TextFormatValidation.IsValidEmail(TxtEmail.Text))
                {

                    EpAddUpdate.SetError(TxtEmail, "Wrong email format");
                    IsValidated = enIsValidated.NotValidated;

                }
                else
                {
                    EpAddUpdate.SetError(TxtEmail, "");
                    IsValidated = enIsValidated.IsValidated;

                }
            else
            {
                EpAddUpdate.SetError(TxtEmail, "");
                IsValidated = enIsValidated.IsValidated;

            }

        }
        //------------------------------------------------------------------------------------------------------------------------------------


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public string SaveImage()
        {
            Guid guid = Guid.NewGuid();

            _FileName = Guid.NewGuid().ToString();
            _FileName = _FileName + _FileExtension;
            File.Copy(_FilePath, "C:\\Users\\omar hattab\\Pictures\\DVLD Images\\" + _FileName);

            return _FileName;
        }



        private void RemoveImage()
        {
            PbPerson.Image.Dispose();
            PbPerson.Image = Resources._360_F_65772719_A1UV5kLi5nCEWI0BNLLiFaBPEkUbv5Fv;
            File.Delete("C:\\Users\\omar hattab\\Pictures\\DVLD Images\\" + _people.ImagePath);
            _people.ImagePath = "";

        }

        private void LlSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();


            openFileDialog.InitialDirectory = "C:\\Users\\omar hattab\\Pictures\\test images";

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";


            openFileDialog.Title = "Select an Image File";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                if(isImageExist())
                {
                    RemoveImage();
                }


                // Get the selected file's path
                _FilePath = openFileDialog.FileName;
                _FileName = Path.GetFileNameWithoutExtension(_FilePath);
                _FileExtension = Path.GetExtension(_FilePath);    
                // Display the selected image in the PictureBox
                PbPerson.Load(_FilePath);
                    
                // Optionally, you can set the PictureBox size mode
                PbPerson.SizeMode = PictureBoxSizeMode.StretchImage;

                MarkForImageDelete = false;
                LlRemoveImage.Visible = true;


            }
        }

        private bool isImageExist()
        {
            return File.Exists("C:\\Users\\omar hattab\\Pictures\\DVLD Images\\" + _people.ImagePath);
        }

        private void ValidateImage()
        {

            // REMOVE 
            // check for image code
            if (MarkForImageDelete == true)
            {
                if (isImageExist())
                {
                    RemoveImage();
                }
            }
            else
            {

                if (_FilePath != null)
                {
                    _people.ImagePath = SaveImage();

                }
                else if (isImageExist())
                {
                    return;
                }
                else
                {
                    _people.ImagePath = "";
                }
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            short SelectedComboBox = (short)(cbCountry.SelectedIndex + 1);


            // load inforamtion to buisness layer
            _people.FirstName = txtFirstName.Text;
            _people.SecondName = txtSecondName.Text;
            _people.ThirdName = txtThirdName.Text;
            _people.LastName = txtLastName.Text;
            _people.NationalNo = txtNationalNo.Text;
            _people.DateOfBirth = DtpDateOfBirth.Value;
            _people.Gender = _ValidateMaleOrFemale();
            _people.Address = txtAddress.Text;
            _people.Phone = txtPhone.Text;
            _people.Email = TxtEmail.Text;
            _people.NationalityCountryId = SelectedComboBox;

            //check for image
            ValidateImage();

            // check if everything is validated
            if (IsValidated == enIsValidated.IsValidated)
            {

                _people.save();

                lblId.Text = _people.ID.ToString();


                MessageBox.Show("Saved Successfully", "Record", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error Saving Record", "Record", MessageBoxButtons.OK);
            }

            AddOrUpdate = enAddOrUpdate.Update;

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LlRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            

            if (MessageBox.Show("Are you sure you want to delete picture?", "Delete Picture", MessageBoxButtons.OKCancel
                ,MessageBoxIcon.Question)
                == DialogResult.OK )
            {

                MarkForImageDelete = true;
                PbPerson.Image.Dispose();

                PbPerson.Image = Resources._360_F_65772719_A1UV5kLi5nCEWI0BNLLiFaBPEkUbv5Fv;
                

            }

        }


    }
}
