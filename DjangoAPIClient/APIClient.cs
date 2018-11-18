using System;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;
using RestSharp.Deserializers;
using System.Net;

namespace DjangoAPIClient
{


    static class APIClient
    {
        public const string DATE_FORMAT = "yyyy-MM-dd";
        const string BASEURL = "http://127.0.0.1:8000/";
        const string SUBJECTS = "subjects/";
        const string IDTYPES = "idtypes/";
        const string FORMAT = "?format=json";
        const string PARAM_FORMAT = "application/json";
        const string CONTENT_TYPE = "content-Type";

        #region SUBJECTS
        /** CREATE METHODS **/
        public static ResponseWrapper<Subject> CreateSubject(Subject subject)
        {
            var request = new RestRequest(SUBJECTS + FORMAT, Method.POST);
            request.AddHeader(CONTENT_TYPE, PARAM_FORMAT);
            request.OnBeforeDeserialization = resp => { resp.ContentType = PARAM_FORMAT; };
            request.AddParameter(PARAM_FORMAT, Serialize(subject), ParameterType.RequestBody);

            return Execute<Subject>(request);
        }

        /** UPDATE METHODS **/
        public static ResponseWrapper<Subject> UpdateSubject(int id, Subject subject)
        {
            var request = new RestRequest(SUBJECTS + "{ID}/" + FORMAT, Method.PUT);
            request.AddHeader(CONTENT_TYPE, PARAM_FORMAT);
            request.AddParameter("ID", id, ParameterType.UrlSegment);
            request.OnBeforeDeserialization = resp => { resp.ContentType = PARAM_FORMAT; };
            request.AddParameter(PARAM_FORMAT, Serialize(subject), ParameterType.RequestBody);
            
            return Execute<Subject>(request);
        }

        /** DELETE METHODS **/
        public static ResponseWrapper<Subject> DeleteSubject(int id)
        {
            var request = new RestRequest(SUBJECTS + "{ID}/" + FORMAT, Method.DELETE);
            request.AddHeader(CONTENT_TYPE, PARAM_FORMAT);
            request.OnBeforeDeserialization = resp => { resp.ContentType = PARAM_FORMAT; };
            request.AddParameter("ID", id, ParameterType.UrlSegment);
            
            return Execute<Subject>(request);
        }

        /** GET METHODS **/
        public static ResponseWrapper<Subject> GetSubject(int id)
        {           
            var request = new RestRequest(SUBJECTS + "{ID}/", Method.GET);

            request.AddHeader(CONTENT_TYPE, PARAM_FORMAT);
           // request.OnBeforeDeserialization = resp => { resp.ContentType = PARAM_FORMAT; };
            request.AddParameter("ID", id, ParameterType.UrlSegment);
            request.RequestFormat = DataFormat.Json;
            request.DateFormat = DATE_FORMAT;

            return Execute<Subject>(request);

        }

        public static ResponseWrapper<List<Subject>> GetSubjectList()
        {
            var request = new RestRequest(SUBJECTS, Method.GET);
            request.AddHeader(CONTENT_TYPE, PARAM_FORMAT);
            request.RequestFormat = DataFormat.Json;
            request.DateFormat = DATE_FORMAT;
            // request.OnBeforeDeserialization = resp => { resp.ContentType = PARAM_FORMAT; };

            return Execute<List<Subject>>(request);
        }

        public static ResponseWrapper<List<Subject>> GetSubjectByIdCard(string idcard)
        {
            var request = new RestRequest("subjectbyidcard/" + FORMAT, Method.GET);
            request.AddHeader(CONTENT_TYPE, PARAM_FORMAT);
            request.OnBeforeDeserialization = resp => { resp.ContentType = PARAM_FORMAT; };
            request.AddParameter("idcard", idcard, ParameterType.QueryString);
         
            return Execute<List<Subject>>(request);
        }


        public static ResponseWrapper<List<Subject>> GetSubjectByRegDate(string start_date, string end_date)
        {
            var request = new RestRequest("subjectbyregdate/" + FORMAT, Method.GET);
            request.AddHeader(CONTENT_TYPE, PARAM_FORMAT);
            request.AddParameter("start_date", start_date, ParameterType.QueryString);
            request.AddParameter("end_date", end_date, ParameterType.QueryString);
           
            return Execute<List<Subject>>(request);
        }

        public static ResponseWrapper<List<Subject>> GetSubjectByBirthDate(string start_date, string end_date)
        {
            var request = new RestRequest("subjectbybirthdate/" + FORMAT, Method.GET);
            request.AddHeader(CONTENT_TYPE, PARAM_FORMAT);
            request.AddParameter("start_date", start_date, ParameterType.QueryString);
            request.AddParameter("end_date", end_date, ParameterType.QueryString);
            
            return Execute<List<Subject>>(request);
        }

        public static ResponseWrapper<List<Subject>> GetSubjectByCountry(string country_code)
        {
            var request = new RestRequest("subjectbycountry/" + FORMAT, Method.GET);
            request.AddHeader(CONTENT_TYPE, PARAM_FORMAT);
            request.AddParameter("start_date", country_code, ParameterType.QueryString);
            
            return Execute<List<Subject>>(request);
        }

        public static ResponseWrapper<List<Subject>> GetSubjectByGender(string gender)
        {
            var request = new RestRequest("subjectbygender/" + FORMAT, Method.GET);
            request.AddHeader(CONTENT_TYPE, PARAM_FORMAT);
            request.AddParameter("start_date", gender, ParameterType.QueryString);
            
            return Execute<List<Subject>>(request);
        }

        public static ResponseWrapper<List<Subject>> GetSubjectByEmail(string email)
        {
            var request = new RestRequest("subjectbyemail/" + FORMAT, Method.GET);
            request.AddHeader(CONTENT_TYPE, PARAM_FORMAT);
            request.AddParameter("email", email, ParameterType.QueryString);
           
            return Execute<List<Subject>>(request);
        }

        public static ResponseWrapper<List<Subject>> GetSubjectByFullName(string name, string surname, string secondsurname)
        {
            var request = new RestRequest("subjectbyfullname/" + FORMAT, Method.GET);
            request.AddHeader(CONTENT_TYPE, PARAM_FORMAT);
            if (name!=null && name.Length>0) request.AddParameter("name", name, ParameterType.QueryString);
            if (surname != null && surname.Length>0) request.AddParameter("surname", surname, ParameterType.QueryString);
            if (secondsurname != null && secondsurname.Length>0) request.AddParameter("secondsurname", secondsurname, ParameterType.QueryString);

            return Execute<List<Subject>>(request);
        }

        public static ResponseWrapper<List<Subject>> GetSubjectByPhone(int phone)
        {
            var request = new RestRequest("subjectbyphone/" + FORMAT, Method.GET);
            request.AddHeader(CONTENT_TYPE, PARAM_FORMAT);
            request.AddParameter("phone", phone, ParameterType.QueryString);
            
            return Execute<List<Subject>>(request);
        }

        public static ResponseWrapper<List<Subject>> GetSubjectByIdCardType(int idcardtype)
        {
            var request = new RestRequest("subjectbyidcardtype/" + FORMAT, Method.GET);
            request.AddHeader(CONTENT_TYPE, PARAM_FORMAT);
            request.AddParameter("idcardtype", idcardtype, ParameterType.QueryString);
           
            return Execute<List<Subject>>(request);
        }

        #endregion

        #region IDTYPES

        /** CREATE METHODS **/
        public static ResponseWrapper<IdType> CreateIdType(IdType type)
        {
            var request = new RestRequest(IDTYPES + FORMAT, Method.POST);
            request.AddHeader(CONTENT_TYPE, PARAM_FORMAT);
            request.AddParameter(PARAM_FORMAT, Serialize(type), ParameterType.RequestBody);

            return Execute<IdType>(request);
        }

        /** UPDATE METHODS **/
        public static ResponseWrapper<IdType> UpdateIdType(int id, IdType type)
        {
            var request = new RestRequest(IDTYPES + "{ID}/" + FORMAT, Method.PUT);
            request.AddHeader(CONTENT_TYPE, PARAM_FORMAT);
            request.AddParameter("ID", id, ParameterType.UrlSegment);
            request.AddParameter(PARAM_FORMAT, Serialize(type), ParameterType.RequestBody);
           
            return Execute<IdType>(request);
        }

        /** DELETE METHODS **/
        public static ResponseWrapper<IdType> DeleteIdType(int id)
        {
            var request = new RestRequest(IDTYPES + "{ID}/" + FORMAT, Method.DELETE);
            request.AddHeader(CONTENT_TYPE, PARAM_FORMAT);
            request.AddParameter("ID", id, ParameterType.UrlSegment);
            
            return Execute<IdType>(request);
        }

        /** GET METHODS **/
        public static ResponseWrapper<IdType> GetIdType(int id)
        {
            var request = new RestRequest(IDTYPES + "{ID}/", Method.GET);
            request.AddHeader(CONTENT_TYPE, PARAM_FORMAT);
            request.AddParameter("ID", id, ParameterType.UrlSegment);
            request.RequestFormat = DataFormat.Json;
            request.DateFormat = DATE_FORMAT;

            return Execute<IdType>(request);
        }

        public static ResponseWrapper<List<IdType>> GetIdTypeList()
        {
            var request = new RestRequest(IDTYPES, Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader(CONTENT_TYPE, PARAM_FORMAT);
            request.DateFormat = DATE_FORMAT;
            // request.OnBeforeDeserialization = resp => { resp.ContentType = PARAM_FORMAT; };

            return Execute<List<IdType>>(request);
        }

        #endregion

        #region GENERICS
        public static ResponseWrapper<T> Execute<T>(RestRequest request) where T : new()
        {
            var client = new RestClient();
            client.BaseUrl = new Uri(BASEURL);
            ResponseWrapper<T> responseObj = null;
            IRestResponse<T> response;
            #region Auth
            /** if auth **/
            // client.Authenticator = new HttpBasicAuthenticator(_accountSid, _secretKey);
            // request.AddParameter("AccountSid", _accountSid, ParameterType.UrlSegment); // used on every request
            #endregion

            try
            {
                response = client.Execute<T>(request);

                if (IsSuccessful(response) && response.Content=="[]")
                {
                    responseObj = new ResponseWrapper<T>
                    {
                        Type = ResponseType.DECISION,
                        DataObject = default(T),
                    };
                }
                else if (IsSuccessful(response) && response.Content != "[]")
                {
                    responseObj = new ResponseWrapper<T>
                    {
                        Type = ResponseType.OBJECT,
                        DataObject = response.Data,
                    };
                }
                else
                {
                    responseObj = new ResponseWrapper<T>
                    {
                        Type = ResponseType.ERROR,
                        DataObject = default(T),
                        Error = new Error
                        {
                            HTTPStatusCode = response.StatusCode.ToString(),
                            HTTPErrorMessage = response.ErrorMessage.ToString(),
                        }
                    };
                }
            }
            catch(Exception ex)
            {
                responseObj = new ResponseWrapper<T>
                {
                    Type = ResponseType.ERROR,
                    Error = new Error
                    {
                        HTTPErrorMessage = ex.Message,
                    }
                };
            }
            finally
            {
                responseObj.Method = request.Method.ToString();
                responseObj.URL = client.BuildUri(request).ToString();
                if (responseObj.Error != null)
                {
                  //  responseObj.Error.ServerMessage = response.Content;
                 //   responseObj.Error.HTTPStatusCode = response.StatusCode.ToString();
                }
            }

            return responseObj;
        }

        #endregion

        #region UTILS

        public static bool IsScuccessStatusCode(this HttpStatusCode responseCode)
        {
            var numericResponse = (int)responseCode;

            const int statusCodeOk = (int)HttpStatusCode.OK;

            const int statusCodeBadRequest = (int)HttpStatusCode.BadRequest;

            return numericResponse >= statusCodeOk &&
                   numericResponse < statusCodeBadRequest;
        }

        public static bool IsSuccessful(this IRestResponse response)
        {
            //return response.StatusCode.IsScuccessStatusCode() && response.ResponseStatus == ResponseStatus.Completed;
            return response.StatusCode.IsScuccessStatusCode() && response.ErrorException==null;
        }

        public static T Deserialize<T>(string json) where T : new()
        {            
            return JsonConvert.DeserializeObject<T> (json);
        }

        public static string Serialize<T>(T obj) where T : new()
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);

        }
        #endregion
    }


}
