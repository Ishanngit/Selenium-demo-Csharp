using Newtonsoft.Json.Linq;
using System;


namespace CsharpSeleniumFramework.TestData
{
    
    public class JsonReader 
    {
        
        public JsonReader()
        {

        }
        public String extractData(String tokenName)
        {
          String myJsonString =  File.ReadAllText("TestData/TestData.json");
            
            var jsonObject = JToken.Parse(myJsonString);

          return jsonObject.SelectToken(tokenName).Value<string>();
        }
    }
}
