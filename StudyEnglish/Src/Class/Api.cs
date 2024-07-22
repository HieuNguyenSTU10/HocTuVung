using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace StudyEnglish.Src.Class
{
    internal class Api
    {

        string pronun;
        string key = "da11ef9b45mshc5e081752cf7c8bp1243ecjsnefa4381ac7aa";
        string host = "wordsapiv1.p.rapidapi.com";

        public string Pronun { get => pronun; set => pronun = value; }
        public Api() { }

        public async Task<string> GetPronun(string word)
        {
            string apiUrl = $"https://wordsapiv1.p.rapidapi.com/words/{word}/pronunciation";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("X-RapidAPI-Key", key);
                    client.DefaultRequestHeaders.Add("X-RapidAPI-Host", host);
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();
                        return responseData;
                    }
                    else
                    {
                        return "Request false ";
                    }

                }
                catch (Exception ex)
                {
                    return "Lỗi khi gửi yêu cầu đến API: " + ex.Message;
                }
            }
        }

    }
}
