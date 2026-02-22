namespace DTstrap.Utility
{
    internal static class Http
    {
        /// <summary>
        /// Gets and deserializes a JSON API response to the specified object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="JsonException"></exception>
        public static async Task<T> GetJson<T>(string url)
        {
            var request = await App.HttpClient.GetAsync(url);

            request.EnsureSuccessStatusCode();

            string json = await request.Content.ReadAsStringAsync();
            
            var result = JsonSerializer.Deserialize<T>(json);

            if (result is null)
                throw new JsonException($"Deserialization of response from {url} returned null. Response body: {json[..Math.Min(json.Length, 200)]}");

            return result;
        }
    }
}
