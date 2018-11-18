using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;
using System.Text;
using System.Collections;
using System.Reflection;
using System.Collections.ObjectModel;
using System.Linq;

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

            using (SubjectForm subjectForm = new SubjectForm(title,subject))
            {
                if(subjectForm.ShowDialog() == DialogResult.OK)
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
            if (responseType == "Subject")
            {
                responseLW.View = View.Details;
                responseLW.Columns.Add(SUBJECT_IDCARD, SUBJECT_IDCARD, 45, HorizontalAlignment.Center, 0);
                responseLW.Columns.Add(SUBJECT_IDCARDTYPE, SUBJECT_IDCARDTYPE, 70, HorizontalAlignment.Center, 0);
                responseLW.Columns.Add(SUBJECT_NAME, SUBJECT_NAME, 100, HorizontalAlignment.Center, 0);
                responseLW.Columns.Add(SUBJECT_SURNAME, SUBJECT_SURNAME, 100, HorizontalAlignment.Center, 0);
                responseLW.Columns.Add(SECONDSURNAME, SECONDSURNAME, 50, HorizontalAlignment.Center, 0);
                responseLW.Columns.Add(COUNTRY, COUNTRY, 80, HorizontalAlignment.Center, 0);
                responseLW.Columns.Add(GENDER, GENDER, 50, HorizontalAlignment.Center, 0);
                responseLW.Columns.Add(EMAIL, EMAIL, 50, HorizontalAlignment.Center, 0);
                responseLW.Columns.Add(SUBJECT_PHONE, SUBJECT_PHONE, 50, HorizontalAlignment.Center, 0);
                responseLW.Columns.Add(SUBJECT_BIRTHDATE, SUBJECT_BIRTHDATE, 60, HorizontalAlignment.Center, 0);
                responseLW.Columns.Add(SUBJECT_REGISTRATIONDATE, SUBJECT_REGISTRATIONDATE, 60, HorizontalAlignment.Center, 0);
                responseLW.Columns.Add(SUBJECT_CONTACTPERMISSION, SUBJECT_CONTACTPERMISSION, 60, HorizontalAlignment.Center, 0);
                responseLW.Columns.Add(SUBJECT_CONSENTFILE, SUBJECT_CONSENTFILE, 50, HorizontalAlignment.Center, 0);
            }
            else if (responseType == "IdType")
            {
                responseLW.View = View.Details;
                responseLW.Columns.Add(IDCARD_ID, IDCARD_ID, 45, HorizontalAlignment.Center, 0);
                responseLW.Columns.Add(SUBJECT_NAME, SUBJECT_NAME, 100, HorizontalAlignment.Center, 0);
                responseLW.Columns.Add(IDCARD_REGEX, IDCARD_REGEX, 600, HorizontalAlignment.Center, 0);
            }
        }

        private void SetResponseLV(string items)
        {

        }

        private void SetErrorsTB(Error error)
        {
            errorsTB.Text = APIClient.Serialize<Error>(error);
        }

        public void HandleResponse<T> (ResponseWrapper<T> wrapper)
        {
            ResetResponseLV(wrapper.DataObject.GetType().ToString());
            ResetErrorsTB();

            if (wrapper==null)
                throw new Exception("Null response!");

            if (wrapper.DataObject==null){      //

            }
            else if(wrapper.DataObject.Equals(default(T)))
            {

            }            
            else if (!wrapper.DataObject.Equals(default(T)) && IsList(wrapper.DataObject))  
            {
               
             


            }
            else if (!wrapper.DataObject.Equals(default(T)) && !IsList(wrapper.DataObject))  // OBJECT
            {
                if (MatchModel(wrapper.DataObject,new IdType())){

                }
            }
            else  //ERROR
            {
                //SetErrorsTB();
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

        private void SubjectsGET_Click(object sender, EventArgs e)
        {
            var wrapper = APIClient.GetSubjectList();
            List<Subject> list = wrapper.DataObject;
            string items = String.Join(",", list.Select(x => x.Name));
            SetResponseLV(items);
            //HandleResponse();
        }

        private void SubjectGET_Click(object sender, EventArgs e)
        {
            var wrapper = APIClient.GetSubjectList();
            List<Subject> list = wrapper.DataObject;
            string items = String.Join(",", list.Select(x => x.Name));
            SetResponseLV(items);
           // HandleResponse(APIClient.GetSubject(1));       
        }



        private void SubjectCREATE_Click(object sender, EventArgs e)
        {
            var subject = ShowForm("CREATE NEW SUBJECT",(Subject)null);

            if (subject == null)
                return;

            //ShowResponse(APIClient.CreateSubject(subject));            
            
        }

        private void SubjectbyidcardGET_Click(object sender, EventArgs e)
        {
           //     ShowResponse(APIClient.GetSubjectByIdCard("2122321S"));           
        }



        private void SubjectsbyregdateGET_Click(object sender, EventArgs e)
        {
            string start_date = new DateTime(2017, 1, 1).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string end_date = DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

         //   ShowResponse(APIClient.GetSubjectByRegDate(start_date, end_date));
           
        }

        private void SubjectsbybirthdateGET_Click(object sender, EventArgs e)
        {
            string start_date = new DateTime(1985, 1, 1).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string end_date = DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

        //    ShowResponse(APIClient.GetSubjectByRegDate(start_date, end_date));           
           
        }


        private void SubjectsbycountryGET_Click(object sender, EventArgs e)
        {
            
       //     ShowResponse(APIClient.GetSubjectByCountry("ES"));            
        }

        private void SubjectsbygenderGET_Click(object sender, EventArgs e)
        {
        //    ShowResponse(APIClient.GetSubjectByGender("F"));
            
        }

        private void SubjectsbyfullnameGET_Click(object sender, EventArgs e)
        {
        //    ShowResponse(APIClient.GetSubjectByFullName("Carlos", null, null));
        }

        private void SubjectsbyemailGET_Click(object sender, EventArgs e)
        {
        //    ShowResponse(APIClient.GetSubjectByEmail("hotmail"));            
        }


        private void SubjectsbyphoneGET_Click(object sender, EventArgs e)
        {
       //    ShowResponse(APIClient.GetSubjectByPhone(656));           
        }

        private void SubjectsbyidcardtypeGET_Click(object sender, EventArgs e)
        {            
       //     ShowResponse(APIClient.GetSubjectByIdCard("DNI"));          
        }

        private void SubjectUPDATE_Click(object sender, EventArgs e)
        {
            
            var subject = ShowForm("UPDATE SUBJECT", (Subject)null);

            if (subject == null)
                return;

       //     ShowResponse(APIClient.UpdateSubject(1, subject));           
            
        }

        private void SubjectDELETE_Click(object sender, EventArgs e)
        {
            
      //       ShowResponse(APIClient.DeleteSubject(11));
        }

        #endregion

        #region IDTYPE BUTTONS

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

     //       ShowResponse(APIClient.CreateIdType(type));            
        }

        private void IdtypeUPDATE_Click(object sender, EventArgs e)
        {
            var type = new IdType
            {
                Name = "DNIFAG",
                Regex = ""
            };
            
    //         ShowResponse(APIClient.UpdateIdType(3, type));            
        }

        private void IdtypeDELETE_Click(object sender, EventArgs e)
        {           
  //         ShowResponse(APIClient.DeleteIdType(1));            
        }

        private void idtypesGET_Click(object sender, EventArgs e)
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
            InitUI("");
        }

    }
}
