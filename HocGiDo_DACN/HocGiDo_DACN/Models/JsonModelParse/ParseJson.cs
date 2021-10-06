using HocGiDo_DACN.Models.JsonModelParse.User;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace HocGiDo_DACN.Models.JsonModelParse
{
    public class ParseJson
    {
        private static readonly HttpClient client = new HttpClient();
        public async Task<Course> GetCourse()
        {
            var apiUrl = new ApiContain().getUrlApi("course");
            if(apiUrl != null)
            {
                var responseString = await client.GetStringAsync(apiUrl);
                var resp = JsonConvert.DeserializeObject<Course>(responseString);
                return resp;
            }
            else
            {
                return null;
            }
        }
    }
}