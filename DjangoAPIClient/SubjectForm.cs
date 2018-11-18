using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DjangoAPIClient
{
    
    public partial class SubjectForm : Form
    {
        public Subject subjectCreated { get; set; }

        public SubjectForm(string title, Subject subject)
        {            
            InitializeComponent();
            subjectCreated = subject;
            InitForm(title);
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            if (subjectCreated == null)
                ResetForm();
            else
                SetForm();
        }

        private void clearBT_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void InitForm(string title)
        {
            phoneTB.MaxLength = 9;
            titleLB.Text = title.ToUpperInvariant();
            this.Text = title.ToUpperInvariant();
            genderCB.DataSource = Enum.GetValues(typeof(GenderType));
            LoadCountries();
            LoadIdTypes();
            // "INJECT" subject obj for this Form
            birthdateDP.Format = DateTimePickerFormat.Custom;
            registrationdateDP.Format = DateTimePickerFormat.Custom;
            birthdateDP.CustomFormat = APIClient.DATE_FORMAT;
            registrationdateDP.CustomFormat = APIClient.DATE_FORMAT;



        }

        private void LoadIdTypes()
        {
            ResponseWrapper<List<IdType>> response = APIClient.GetIdTypeList();

            if (response.DataObject != null && ((List<IdType>)response.DataObject).Count > 0)
            {
                idtypeCB.DataSource = (List<IdType>)response.DataObject;
                idtypeCB.DisplayMember = "Name";
                idtypeCB.ValueMember = "ID";
            }

        }

        private void LoadCountries()
        {
            var str = File.ReadAllText(@"C:\Users\carlosjimz\source\repos\DjangoAPIClient\DjangoAPIClient\countries.json");
            List<Country> countries = APIClient.Deserialize<List<Country>>(str);

            countryCB.DataSource = countries;
            countryCB.DisplayMember = "Name";
            countryCB.ValueMember = "Code";

        }

        private void SetForm()
        {
            nameTB.Text = subjectCreated.Name;
            surnameTB.Text = subjectCreated.Surname;
            secondsurnameTB.Text = subjectCreated.SecondSurname;
            idTB.Text = subjectCreated.IdCard;
            phoneTB.Text = subjectCreated.Phone.ToString();
            genderCB.SelectedItem = subjectCreated.Gender;
            birthdateDP.Value = subjectCreated.BirthDate;
            registrationdateDP.Value = subjectCreated.RegistrationDate;
            contactpermissionKB.Checked = subjectCreated.ContactPermission;
        }

        private void ResetForm()
        {
            Properties.Settings.Default.Reset();
            LoadForm();
        }


        private void acceptBT_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                UpdateSubject();
                SaveForm();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool ValidateForm()
        {
            bool name = ValidateName();
            bool surname = ValidateSurname();
            bool ssurname = ValidateSecondSurname();
            bool id = ValidateID();
            bool email = ValidateEmail();
            bool phone = ValidatePhone();

            return name & surname & ssurname & id & email & phone;
        }

        private void UpdateSubject()
        {
            if (subjectCreated == null)
                subjectCreated = new Subject();

            subjectCreated.Name = nameTB.Text;
            subjectCreated.Surname = surnameTB.Text;
            subjectCreated.SecondSurname = secondsurnameTB.Text;
            subjectCreated.IdCard = idTB.Text;
            subjectCreated.Email = emailTB.Text;

            Country selectedCountry = (Country)countryCB.SelectedItem;
            subjectCreated.Country = selectedCountry.Code;

            GenderType type;
            Enum.TryParse<GenderType>(genderCB.SelectedValue.ToString(), out type);
            subjectCreated.Gender = type.ToString();

            subjectCreated.Phone = Int32.Parse(phoneTB.Text);
            subjectCreated.BirthDate = birthdateDP.Value;            
            subjectCreated.RegistrationDate = registrationdateDP.Value;
            subjectCreated.ContactPermission =  contactpermissionKB.Checked;
            IdType selectedType = (IdType)idtypeCB.SelectedItem;
            subjectCreated.IdCardType = selectedType.ID;
        }

        private void SaveForm()
        {
            Properties.Settings.Default.Name = subjectCreated.Name;
            Properties.Settings.Default.Surname = subjectCreated.Surname;
            Properties.Settings.Default.Secondsurname = subjectCreated.SecondSurname;
            Properties.Settings.Default.ID = subjectCreated.IdCard;
            Properties.Settings.Default.Email = subjectCreated.Email;
            Properties.Settings.Default.CountryCode = countryCB.SelectedIndex.ToString();
            Properties.Settings.Default.GenderCode = (subjectCreated.Gender).ToString();
            Properties.Settings.Default.Phone = subjectCreated.Phone.ToString();
            Properties.Settings.Default.BirthDate = subjectCreated.BirthDate;
            Properties.Settings.Default.RegistrationDate = subjectCreated.RegistrationDate;
            Properties.Settings.Default.ContactPermission = subjectCreated.ContactPermission;
            Properties.Settings.Default.IdTypeCode = idtypeCB.SelectedIndex.ToString();

            Properties.Settings.Default.Save();
        }
        private void LoadForm()
        {
            nameTB.Text = Properties.Settings.Default.Name;
            surnameTB.Text = Properties.Settings.Default.Surname;
            secondsurnameTB.Text = Properties.Settings.Default.Secondsurname;
            idTB.Text = Properties.Settings.Default.ID;
            phoneTB.Text = Properties.Settings.Default.Phone;
            emailTB.Text = Properties.Settings.Default.Email;
            birthdateDP.Value = Properties.Settings.Default.BirthDate;
            registrationdateDP.Value = Properties.Settings.Default.RegistrationDate;
            contactpermissionKB.Checked = Properties.Settings.Default.ContactPermission;
            string aa = Properties.Settings.Default.GenderCode;
            genderCB.SelectedIndex = (Properties.Settings.Default.GenderCode.Length > 0) ? Int32.Parse(Properties.Settings.Default.GenderCode) : 0;
            idtypeCB.SelectedIndex = (Properties.Settings.Default.IdTypeCode.Length > 0) ? Int32.Parse(Properties.Settings.Default.IdTypeCode) : 0;
            countryCB.SelectedIndex = (Properties.Settings.Default.CountryCode.Length > 0) ? Int32.Parse(Properties.Settings.Default.CountryCode) : 0;

        }

        #region UI

        private bool ValidateID()
        {
            if (idTB.Text.Length == 0)
                return SetError(false, idTB, "Field is required", idEP);

            return SetError(Utils.IsID(idTB.Text), idTB, "Invalid value.", idEP);
        }

        private bool ValidateEmail()
        {
            if (emailTB.Text.Length == 0)
                return SetError(false, emailTB, "Field is required", emailEP);

            return SetError(Utils.IsEmail(emailTB.Text), emailTB, "Invalid value.", emailEP);
        }

        private bool ValidateName()
        {
            if (nameTB.Text.Length == 0)
                return SetError(false, nameTB, "Field is required", nameEP);
            
            return SetError(Utils.IsName(nameTB.Text), nameTB, "Invalid value.",nameEP);
        }

        private bool ValidateSurname()
        {
            if (surnameTB.Text.Length == 0)
                return SetError(false, surnameTB, "Field is required", surnameEP);

            return SetError(Utils.IsName(surnameTB.Text), surnameTB, "Invalid value.", surnameEP);
        }

        private bool ValidateSecondSurname()
        {
            if (secondsurnameTB.Text.Length == 0)
                return SetError(false, secondsurnameTB, "Field is required", secondsurnameEP);

            return SetError(Utils.IsName(secondsurnameTB.Text), secondsurnameTB, "Invalid value.", secondsurnameEP);
        }

        private bool ValidatePhone()
        {
            if (phoneTB.Text.Length == 0)
                return SetError(false, phoneTB, "Field is required", phoneEP);

            return SetError(Utils.IsPhone(phoneTB.Text), phoneTB, "Invalid value.", phoneEP);
        }
        
        private bool SetError(bool error, Control control, string message, ErrorProvider provider)
        {
            if (error)
                provider.Clear();
            else
                provider.SetError(control, message);

            return error;
        }

        private void nameTB_Leave(object sender, EventArgs e)
        {
            
            ValidateName();
        }

        private void surnameTB_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length > 0)
                nameEP.Clear();
            else
                nameEP.SetError(((TextBox)sender), "Field is required.");

            ValidateSurname();
        }

        private void secondsurnameTB_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length > 0)
                nameEP.Clear();
            else
                nameEP.SetError(((TextBox)sender), "Field is required.");

            ValidateSecondSurname();
        }

        private void idTB_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length > 0)
                nameEP.Clear();
            else
                nameEP.SetError(((TextBox)sender), "Field is required.");
            
            ValidateID();
        }

        private void phoneTB_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length > 0)
                nameEP.Clear();
            else
                nameEP.SetError(((TextBox)sender), "Field is required.");

            ValidatePhone();
        }

        private void emailTB_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length > 0)
                nameEP.Clear();
            else
                nameEP.SetError(((TextBox)sender), "Field is required.");

            ValidateEmail();
        }


        private void phoneTB_TextChanged(object sender, EventArgs e)
        {
            AllowText(!Utils.OnlyNumbers(((TextBox)sender).Text), (TextBox)sender);
        }

        private void emailTB_TextChanged(object sender, EventArgs e)
        {
            AllowText(!Utils.OnlyEmailLetters(((TextBox)sender).Text),(TextBox)sender);
            SetUpperOrLower(false, (TextBox)sender);
        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {

            AllowText(!Utils.OnlyLettersWSpace(((TextBox)sender).Text), (TextBox)sender);
            //SetUpperOrLower(false, (TextBox)sender);
        }
        
        private void surnameTB_TextChanged(object sender, EventArgs e)
        {
            AllowText(!Utils.OnlyLetters(((TextBox)sender).Text), (TextBox)sender);
            //SetUpperOrLower(false, (TextBox)sender);
        }

        private void secondsurnameTB_TextChanged(object sender, EventArgs e)
        {
            AllowText(!Utils.OnlyLetters(((TextBox)sender).Text), (TextBox)sender);
            //SetUpperOrLower(false, (TextBox)sender);
        }

        private void idTB_TextChanged(object sender, EventArgs e)
        {
            AllowText(!Utils.OnlyNumbersAndLetters(((TextBox)sender).Text), (TextBox)sender);
            SetUpperOrLower(true,(TextBox)sender);
        }
#endregion

        #region UTILS
        private void AllowText(bool dontallow, TextBox textBox)
        {
            if (textBox.Text.Length == 0)
                return;

            if (dontallow)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                textBox.Focus();
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void SetUpperOrLower(bool upper, TextBox textbox)
        {
            if (upper)
            {
                textbox.Text = textbox.Text.ToUpper();
            }
            else
            {
                textbox.Text = textbox.Text.ToLower();

            }
            textbox.Focus();
            textbox.SelectionStart = textbox.Text.Length;
        }

        #endregion

        private void consentfileBT_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                consentfileTB.Text = openFileDialog.FileName;
            }
        }
    }
}
