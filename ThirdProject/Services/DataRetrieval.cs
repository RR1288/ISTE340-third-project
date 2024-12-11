using System.Net.Http.Headers;

namespace ThirdProject.Services
{
    public class DataRetrieval
    {
        public async Task<string> GetData(string d)
        {
            using (var client = new HttpClient())
            {
                // setup
                client.BaseAddress = new Uri("https://ischool.gccis.rit.edu/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("applicatioin/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync(d,
                        HttpCompletionOption.ResponseHeadersRead);
                    // Assert that it returns OK, if not throw an exception
                    response.EnsureSuccessStatusCode();

                    // if everything ok -> wait until it reads line by line the whole file
                    var data = await response.Content.ReadAsStringAsync();

                    return data;
                }
                catch (HttpRequestException hre)
                {
                    return ("msg: " + hre.Message);
                }
                catch (Exception ex)
                {
                    return ("msg: " + ex.Message);

                }

            }
        }
    }
}
