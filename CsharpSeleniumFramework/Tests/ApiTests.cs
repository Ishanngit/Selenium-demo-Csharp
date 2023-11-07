using Newtonsoft.Json.Linq;
using RestSharp;

namespace CsharpSeleniumFramework.Tests
{
    public class ApiTests
    {
        private RestClient client;
        private string authToken;

        [SetUp]
        public void SetUp()
        {
            client = new RestClient("https://reqres.in");
        }

        [Test]
        public void GetUserList()
        {
            var request = new RestRequest("/api/users", Method.Get);

            RestResponse response = client.Execute(request);

            Assert.AreEqual(200, (int)response.StatusCode);

            JObject jsonResponse = JObject.Parse(response.Content);
            Assert.IsNotNull(jsonResponse["data"]);
            Assert.IsNotEmpty(jsonResponse["data"]);

            Assert.IsNotNull(jsonResponse["data"][0]["id"]);
            Assert.IsNotNull(jsonResponse["data"][0]["email"]);
            Assert.IsNotNull(jsonResponse["data"][0]["first_name"]);
            Assert.IsNotNull(jsonResponse["data"][0]["last_name"]);
        }

        [Test]
        public void GetUserDetails()
        {
            var request = new RestRequest("/api/users/1", Method.Get);

            RestResponse response = client.Execute(request);

            Assert.AreEqual(200, (int)response.StatusCode);

            JObject jsonResponse = JObject.Parse(response.Content);
            Assert.IsNotNull(jsonResponse["data"]);
            Assert.AreEqual(1, (int)jsonResponse["data"]["id"]);
            Assert.AreEqual("George", jsonResponse["data"]["first_name"].ToString());
            Assert.AreEqual("Bluth", jsonResponse["data"]["last_name"].ToString());
            Assert.AreEqual("george.bluth@reqres.in", jsonResponse["data"]["email"].ToString());
        }

        [Test]
        public void RegisterUser()
        {
            var request = new RestRequest("/api/register", Method.Post);

            var registrationData = new
            {
                email = "a",
                password = "pistol"
            };
            request.AddJsonBody(registrationData);

            RestResponse response = client.Execute(request);

            Assert.AreEqual(200, (int)response.StatusCode);

            JObject jsonResponse = JObject.Parse(response.Content);
            Assert.IsNotNull(jsonResponse["id"]);

            Assert.AreEqual("eve.holt@reqres.in", jsonResponse["token"].ToString());
        }


        [Test]
        public void AuthenticateAndGetToken()
        { 
             client = new RestClient("https://api.cogmento.com/api/1");
        
            var request = new RestRequest("/auth/", Method.Post);

           
            var authData = new
            {
                email = "ishan.n@simformsolutions.com",
                password = "Ishan@123"
            };
            request.AddJsonBody(authData);

            RestResponse response = client.Execute(request);
            Assert.AreEqual(201, (int)response.StatusCode);
            JObject jsonResponse = JObject.Parse(response.Content);          
           Assert.IsNotNull(jsonResponse["response"]["token"]);           
            authToken = jsonResponse["response"]["token"].ToString();            
            Console.WriteLine("Authentication Token: " + authToken);
        }

        

    }
}