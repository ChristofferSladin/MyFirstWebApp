using Newtonsoft.Json;

namespace MyFirstWebApp.Services
{
    public class KrisInfoService : IKrisInfoService
    {
        public KrisInfoService()
        {
        }
        public class Test
        {
            public List<KrisInfo> ThemeList { get; set; } = new List<KrisInfo>();
        }
        public List<KrisInfo> GetAllKrisInformation()
        {
            var client = new HttpClient();
            string result = client.GetStringAsync("https://api.krisinformation.se/v1/themes?format=json").Result;

            var listan = JsonConvert.DeserializeObject<Test>(result);
            return listan.ThemeList;
        }

        public List<KrisInfo> GetEmergencies()
        {
            throw new System.NotImplementedException();
        }

        public KrisInfo GetKrisInformation(string id)
        {
            return GetAllKrisInformation().FirstOrDefault(r => r.Id == id);
        }
    }
}
