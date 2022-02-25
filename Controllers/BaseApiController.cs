namespace MegaventoryProject.Controllers
{
    [Route("v2017a/[controller]")]
    public class BaseApiController : Controller
    {
        public async void MegaventoryApiConnection()
        {
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage();
            request.RequestUri = new Uri("https://api.megaventory.com/");
            request.Headers.Add("3674e13b10686b1f@m128193", "1234");
            HttpResponseMessage response = await httpClient.SendAsync(request);
        }
    }
}
