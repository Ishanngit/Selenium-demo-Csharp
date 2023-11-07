using RestSharp;
using NUnit.Framework;
using System.Net;

public class Api
{
    private RestClient client;
    private RestResponse response;

    [SetUp]
    public void SetUp()
    {
        client = new RestClient("https://reqres.in/api/users");
    }


    public void ApiTestExample()
    {
        var request = new RestRequest("/endpoint", Method.Get);
        response = client.Execute(request);

        // Assert on the API response
        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        // Additional assertions
    }
}
