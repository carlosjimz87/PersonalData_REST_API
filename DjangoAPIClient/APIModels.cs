using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Net;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DjangoAPIClient
{
    public enum ResponseType { OBJECT, DECISION, ERROR};
    public enum GenderType { MALE=0, FEMALE=1};

    public class ResponseWrapper<T>
    {
        [JsonProperty("URL")]
        public string URL { get; set; }
        [JsonProperty("DataObject")]
        public T DataObject { get; set; }
        [JsonProperty("Method")]
        public string Method { get; set; }
        [JsonProperty("Type")]
        public ResponseType Type { get; set; }
        [JsonProperty("Error")]
        public Error Error { get; set; }
    }

    public class Error
    {
        [JsonProperty("ServerMessage")]
        public string ServerMessage { get; set; }
        [JsonProperty("HTTPStatusCode")]
        public string HTTPStatusCode { get; set; }
        [JsonProperty("HTTPErrorMessage")]
        public string HTTPErrorMessage { get; set; }
    }

    public class Country
    {
        [JsonProperty("Code")]
        public string Code { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
    }


    public class Subject
    {
        [JsonProperty("IdCard")]
        public string IdCard { get; set; }
        [JsonProperty("IdCardType")]
        public int IdCardType { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Surname")]
        public string Surname { get; set; }
        [JsonProperty("SecondSurname")]
        public string SecondSurname { get; set; }
        [JsonProperty("Email")]
        public string Email { get; set; }
        [JsonProperty("Phone")]
        public int Phone { get; set; }
        [JsonProperty("Country")]
        public string Country { get; set; }
        [JsonProperty("Gender")]
        public string Gender { get; set; }
        [JsonProperty("BirthDate"), JsonConverter(typeof(CustomDateTimeConverter))]
        //[JsonProperty("BirthDate")]
        public DateTime BirthDate { get; set; }
        [JsonProperty("RegistrationDate"), JsonConverter(typeof(CustomDateTimeConverter))]
        //[JsonProperty("RegistrationDate")]
        public DateTime RegistrationDate { get; set; }
        [JsonProperty("ContactPermission")]
        public bool ContactPermission { get; set; }
        [JsonProperty("ConsentFilename")]
        public string ConsentFilename { get; set; }

    }

    public class IdType
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Regex")]
        public string Regex { get; set; }
        [JsonProperty("ID")]
        public int ID { get; set; }

    }

    class CustomDateTimeConverter : IsoDateTimeConverter
    {
        public CustomDateTimeConverter()
        {
            base.DateTimeFormat = APIClient.DATE_FORMAT;
        }
    }
}
