using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace EmailClue
{
    public interface IEmailClue
    {
        // Validation validateEmail(string Email);
        Task<Validation> ValidateEmailAsync(string Email);

        // EmailSend SendEmail(string TemplateKey);
        // Task<EmailSend> sendEmailAsync(string TemplateKey);
    }

    public class EmailClue : IEmailClue, IDisposable
    {

        private readonly string apiToken;
        private readonly HttpClient client;

        public EmailClue(string apiToken)
        {
            this.client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiToken);
            client.BaseAddress = new Uri("https://api.emailclue.com/");
            this.apiToken = apiToken;
        }

        public async Task<Validation> ValidateEmailAsync(string Email)
        {
            // Check encoding works
            HttpResponseMessage response = await client.GetAsync("/v1/email/address/" + Email + "/status");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<Validation>();
        }

        // public EmailSend SendEmail(string TemplateKey)
        // {
        //     var result = new EmailSend();
        //     result.ID = "asdj19";
        //     return result;
        // }

        public void Dispose()
        {
            client.Dispose();
        }
    }
}
