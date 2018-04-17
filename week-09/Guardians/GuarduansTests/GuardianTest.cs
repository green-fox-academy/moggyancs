using Guardians;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace GuardiansTests
{
    public class GuardianTest
    {
        private HttpClient Client;
        private TestServer Server;

        public GuardianTest()
        {
            //arrange
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task IndexShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("/");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GrootShouldReturnError()
        {
            //act
            var response = await Client.GetAsync("/groot");
            MessageDTO grootmessage = JsonConvert.DeserializeObject<MessageDTO>(response.Content.ReadAsStringAsync().Result);
            string responseMSG = grootmessage.Message;
            string errorMSG = "{\"error\":\"I am Groot!\"}";

            //assert
            Assert.Equal(errorMSG, response.Content.ReadAsStringAsync().Result);
        }

        [Fact]
        public async Task GrootMsgRespondsForNullMsg()
        {
            //act
            var response = await Client.GetAsync("/groot");
            MessageDTO grootmessage = JsonConvert.DeserializeObject<MessageDTO>(response.Content.ReadAsStringAsync().Result);
            string responseMSG = grootmessage.Message;

            //assert
            Assert.Null(responseMSG);
        }

        [Fact]
        public async Task GrootNoMsgShouldReturnBadRequest()
        {
            //act
            var response = await Client.GetAsync("/groot");

            //assert
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        public async Task GrootWithParameterShouldReturnOK()
        {
            //act
            var response = await Client.GetAsync("/groot?message=somemessage");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GrootShouldTranslateMsg()
        {
            //act
            var response = await Client.GetAsync("/groot?message=somemessage");
            MessageDTO grootmessage = JsonConvert.DeserializeObject<MessageDTO>(response.Content.ReadAsStringAsync().Result);
            string responseMSG = grootmessage.Translated;
            string grootMsg = "I am Groot!";

            //assert
            Assert.Equal(responseMSG, grootMsg);
        }
    }
}
