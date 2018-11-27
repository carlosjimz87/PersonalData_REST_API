using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace DjangoAPIClient
{
    public partial class MainForm : Form
    {
        private const string COUNTRY = "Country";
        private const string GENDER = "Gender";
        private const string EMAIL = "Email";
        private const string SECONDSURNAME = "SecondSurname";
        private const string SUBJECT_IDCARDTYPE = "IdCardType";
        private const string SUBJECT_IDCARD = "IdCard";
        private const string SUBJECT_SURNAME = "Surname";
        private const string SUBJECT_NAME = "Name";
        private const string SUBJECT_PHONE = "Phone";
        private const string SUBJECT_BIRTHDATE = "BirthDate";
        private const string SUBJECT_REGISTRATIONDATE = "RegistrationDate";
        private const string SUBJECT_CONTACTPERMISSION = "ContactPermission";
        private const string SUBJECT_CONSENTFILE = "ConsentFile";
        private const string IDCARD_ID = "ID";
        private const string IDCARD_REGEX = "Regex";

        public MainForm()
        {
            InitializeComponent();
        }

        #region UTILS

        public Subject ShowForm(string title, Subject subject)
        {                     

            using (SubjectForm subjectForm = new SubjectForm(title, subject))
            {
                if (subjectForm.ShowDialog() == DialogResult.OK)
                {
                    return subjectForm.subjectCreated;
                }
            }

            return null;
        }

        public IdType ShowForm(string title, IdType type)
        {

            using (IdTypeForm idtypeForm = new IdTypeForm(title, type))
            {
                if (idtypeForm.ShowDialog() == DialogResult.OK)
                {
                    return idtypeForm.idtypeCreated;
                }
            }

            return null;
        }

        private void InitUI(string responseType)
        {
            ResetResponseLV(responseType);
            ResetErrorsTB();
        }
        private void ResetErrorsTB()
        {
            errorsTB.Clear();
        }

        private void ResetResponseLV(string responseType)
        {
            responseDGV.BackgroundColor = Color.White;
            responseDGV.RowHeadersVisible = false;

            if (responseType == "Subject")
            {
                responseDGV.ColumnCount = 13;
                responseDGV.Columns.Clear();
                responseDGV.Columns.Add(CreateCol(SUBJECT_IDCARD, SUBJECT_IDCARD, 45));
                responseDGV.Columns.Add(CreateCol(SUBJECT_IDCARDTYPE, SUBJECT_IDCARDTYPE, 70));
                responseDGV.Columns.Add(CreateCol(SUBJECT_NAME, SUBJECT_NAME, 100));
                responseDGV.Columns.Add(CreateCol(SUBJECT_SURNAME, SUBJECT_SURNAME, 100));
                responseDGV.Columns.Add(CreateCol(SECONDSURNAME, SECONDSURNAME, 50));
                responseDGV.Columns.Add(CreateCol(COUNTRY, COUNTRY, 80));
                responseDGV.Columns.Add(CreateCol(GENDER, GENDER, 50));
                responseDGV.Columns.Add(CreateCol(EMAIL, EMAIL, 50));
                responseDGV.Columns.Add(CreateCol(SUBJECT_PHONE, SUBJECT_PHONE, 50));
                responseDGV.Columns.Add(CreateCol(SUBJECT_BIRTHDATE, SUBJECT_BIRTHDATE, 60));
                responseDGV.Columns.Add(CreateCol(SUBJECT_REGISTRATIONDATE, SUBJECT_REGISTRATIONDATE, 60));
                responseDGV.Columns.Add(CreateCol(SUBJECT_CONTACTPERMISSION, SUBJECT_CONTACTPERMISSION, 60));
                responseDGV.Columns.Add(CreateCol(SUBJECT_CONSENTFILE, SUBJECT_CONSENTFILE, 50));
            }
            else if (responseType == "IdType")
            {
                responseDGV.ColumnCount = 3;
                responseDGV.Columns.Clear();
                responseDGV.Columns.Add(CreateCol(IDCARD_ID, IDCARD_ID, 45));
                responseDGV.Columns.Add(CreateCol(SUBJECT_NAME, SUBJECT_NAME, 100));
                responseDGV.Columns.Add(CreateCol(IDCARD_REGEX, IDCARD_REGEX, 600));
            }
        }

        private DataGridViewColumn CreateCol(string header, string text, int width)
        {
            DataGridViewColumn col = new DataGridViewTextBoxColumn();
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.DataPropertyName = header;
            col.HeaderText = header;
            col.Name = text;
            col.Visible = true;
            col.Width = width;
            return col;
        }

        private void SetResponseLV<T>(List<T> items)
        {
            Type itemType = typeof(T);
            if (itemType == typeof(Subject))
                foreach (T item in items)
                {
                   // ListViewItem lvi = new ListViewItem(((Subject)item).Name);
                  //  lvi.SubItems.Add(pet.Type);
                }
        }

        private void SetErrorsTB(Error error)
        {
            errorsTB.Text = APIClient.Serialize<Error>(error);
        }

        public void HandleResponse<T> (ResponseWrapper<T> wrapper)
        {
            ResetResponseLV(wrapper.DataObject.GetType().ToString());
            ResetErrorsTB();

            if (wrapper == null)
                throw new Exception("Null response object!");

            if (wrapper.DataObject == null){      //

            }
            else if (wrapper.DataObject.Equals(default(T)))
            {

            }            
            else if (!wrapper.DataObject.Equals(default(T)) && IsList(wrapper.DataObject))  
            {
               
             


            }
            else if (!wrapper.DataObject.Equals(default(T)) && !IsList(wrapper.DataObject))  // OBJECT
            {
                if (MatchModel(wrapper.DataObject, new IdType())){

                }
            }
            else  // ERROR
            {
                // SetErrorsTB();
            }

        }

        private bool IsList(object o)
        {
            if (o == null) return false;
            return o is IList &&
                   o.GetType().IsGenericType &&
                   o.GetType().GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>));
        }

        private bool MatchModel(object o, object model)
        {
            if (o == null) return false;
            return o.Equals(model.GetType());
        }

        #endregion


        #region SUBJECT BUTTONS



        #endregion

        #region CREATE BUTTONS

        private void IdtypeCREATE_Click(object sender, EventArgs e)
        {
            var type = new IdType
            {
                Name = "DNIFA",
                Regex = ""
            };

            var subject = ShowForm("CREATE NEW SUBJECT", (IdType)null);

            if (subject == null)
                return;

     // ShowResponse(APIClient.CreateIdType(type));            
        }

        private void SubjectCREATE_Click(object sender, EventArgs e)
        {
            var subject = ShowForm("CREATE NEW SUBJECT", (Subject)null);

            if (subject == null)
                return;

            // ShowResponse(APIClient.CreateSubject(subject));            

        }

        #endregion

        #region UPDATE BUTTONS
        private void IdTypeUPDATE_Click(object sender, EventArgs e)
        {
            var type = new IdType
            {
                Name = "DNIFAG",
                Regex = ""
            };

            // ShowResponse(APIClient.UpdateIdType(3, type));            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubjectUPDATE_Click(object sender, EventArgs e)
        {

            var subject = ShowForm("UPDATE SUBJECT", (Subject)null);

            if (subject == null)
                return;

            // ShowResponse(APIClient.UpdateSubject(1, subject));           

        }

        #endregion

        #region DELETE BUTTONS

        private void IdtypeDELETE_Click(object sender, EventArgs e)
        {
            // ShowResponse(APIClient.DeleteIdType(1));            
        }

        private void SubjectDELETE_Click(object sender, EventArgs e)
        {

            //  ShowResponse(APIClient.DeleteSubject(11));
        }

        #endregion

        #region GET BUTTONS

        // ****************** SUBJECT - GET LIST ***************************
        private void SubjectListGET_Click(object sender, EventArgs e)
        {
            var wrapper = APIClient.GetSubjectList();
            List<Subject> list = wrapper.DataObject;

            SetResponseLV(wrapper.DataObject);
            //HandleResponse();
        }

        // ****************** SUBJECT - GET ***************************
        private void SubjectGET_Click(object sender, EventArgs e)
        {
            var wrapper = APIClient.GetSubjectList();
            List<Subject> list = wrapper.DataObject;

            SetResponseLV(list);
            // HandleResponse(APIClient.GetSubject(1));       
        }

               
        private void SubjectByIdCardGET_Click(object sender, EventArgs e)
        {
            //     ShowResponse(APIClient.GetSubjectByIdCard("2122321S"));           
        }



        private void SubjectsByRegdateGET_Click(object sender, EventArgs e)
        {
            string start_date = new DateTime(2017, 1, 1).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string end_date = DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            //   ShowResponse(APIClient.GetSubjectByRegDate(start_date, end_date));

        }

        private void SubjectsByBirthdateGET_Click(object sender, EventArgs e)
        {
            string start_date = new DateTime(1985, 1, 1).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string end_date = DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            //    ShowResponse(APIClient.GetSubjectByRegDate(start_date, end_date));           

        }


        private void SubjectsByCountryGET_Click(object sender, EventArgs e)
        {

            //     ShowResponse(APIClient.GetSubjectByCountry("ES"));            
        }

        private void SubjectsByGenderGET_Click(object sender, EventArgs e)
        {
            //    ShowResponse(APIClient.GetSubjectByGender("F"));

        }

        private void SubjectsByFullNameGET_Click(object sender, EventArgs e)
        {
            //    ShowResponse(APIClient.GetSubjectByFullName("Carlos", null, null));
        }

        private void SubjectsByEmailGET_Click(object sender, EventArgs e)
        {
            //    ShowResponse(APIClient.GetSubjectByEmail("hotmail"));            
        }


        private void SubjectsByPhoneGET_Click(object sender, EventArgs e)
        {
            //    ShowResponse(APIClient.GetSubjectByPhone(656));           
        }

        private void SubjectsByIdCardTypeGET_Click(object sender, EventArgs e)
        {
            //     ShowResponse(APIClient.GetSubjectByIdCard("DNI"));          
        }


        // ****************** IDTYPE ***************************
        private void IdTypesGET_Click(object sender, EventArgs e)
        {
            HandleResponse(APIClient.GetIdTypeList());
        }

        private void IdtypeGET_Click(object sender, EventArgs e)
        {
            HandleResponse(APIClient.GetIdType(2));
        }


        #endregion


        private void MainForm_Load(object sender, EventArgs e)
        {
            InitUI("Subject");
        }

    }
}
