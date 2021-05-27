var client = new HttpClient();
var request = new HttpRequestMessage
{
    Method = HttpMethod.Post,
    RequestUri = new Uri("https://document-scanner.p.rapidapi.com/DetectDocument"),
    Headers =
    {
        { "x-rapidapi-key", "API KEY" },
        { "x-rapidapi-host", "document-scanner.p.rapidapi.com" },
    },
};
using (var response = await client.SendAsync(request))
{
    response.EnsureSuccessStatusCode();
    var body = await response.Content.ReadAsStringAsync();
    Console.WriteLine(body);
}
