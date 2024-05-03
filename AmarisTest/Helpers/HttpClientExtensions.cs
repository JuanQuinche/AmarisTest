using System.Text.Json;

namespace AmarisTest.Helpers
{
    public static class HttpClientExtensions
    {
        public static async Task<T> ReadContentAsync<T>(this HttpResponseMessage responseMessage)
        {
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new InvalidOperationException($"Something went wrong calling the API: : {responseMessage.ReasonPhrase}");
            }

            var stringData = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

            var result = JsonSerializer.Deserialize<T>(
                stringData,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            return result;

        }
    }
}
