Xyclone Designs General API Wrapper
===

A simple wrapper to the [Xyclone Designs General API](https://api.xyclonedesigns.co.za/general). 

Include the library and then make calls to the various API end points.

# Usage

<pre><code class='language-cs'>
[Type].Request request = new [Type].Request(<args>) { ... };
	
HttpClient httpclient = new HttpClient();
using HttpRequestMessage httprequestmessage = request.ToHttpRequestMessage();
using HttpResponseMessage httpresponsemessage = await httpclient.SendAsync(httprequestmessage);

string json = await httpresponsemessage.Content.ReadAsStringAsync();

// System.Text.Json
[Type].Response response = JsonSerializer.Deserialize<[Type]>(json);

// Newtonsoft
[Type].Response response = JObject.Parse(json).ToObject<[Type].Response>();

</code></pre>

# REST

Visit [api.xyclonedesigns.co.za/general/rest](https://api.xyclonedesigns.co.za/general/rest) for a more comprehensive swagger documentation in regards to the API.

### General Request
<pre>
public class Request
{
	public int Page { get; set; } = 1;
	public int PageSize { get; set; } = 10;
	public string[] OrderBy { get; set; } = [];
	public int[] Pk { get; set; } = [];
	public bool Reverse { get; set; } = false;

	// Countries...
	public string[]? Code { get; set; }

	// Districts...
	public string[]? Code { get; set; }

	// Languages...
	public string[]? Code { get; set; }

	// Municipalities...
	public string[]? GeoCode { get; set; }

	// Provinces...
	public string[]? Code { get; set; }
}
</pre>

### General Response
<pre>
public class Reponse
{
	public int Count { get; set; } = 1;
	public int Page { get; set; } = 1;
	public int Pages { get; set; } = 1;
	public IEnumerable<T> Items { get; set; } = Enumerable.Empty<T>();
}
</pre>