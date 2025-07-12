Xyclone Designs SAPS API Wrapper
===

A simple wrapper to the [Xyclone Designs Afrobarometer API](https://api.xyclonedesigns.co.za/afrobarometer). 

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

Visit [api.xyclonedesigns.co.za/afrobarometer/rest](https://api.xyclonedesigns.co.za/afrobarometer/rest) for a more comprehensive swagger documentation in regards to the API.

### General Request
Base From [XycloneDesigns.Apis.General](https://github.com/xyclone-designs/packages.apis.general).
<pre>
public class Request 
{
	public int Page { get; set; } = 1;
	public int PageSize { get; set; } = 10;
	public string[] OrderBy { get; set; } = [];
	public int[] Pk { get; set; } = [];
	public bool Reverse { get; set; } = false;

	// Interviews...
	public int[]? PkLanguage { get; set; }
	public int[]? PkSurvey { get; set; }
	public int[]? PkVariable { get; set; }
	public string[]? Round { get; set; }

	// Questions...
	public string[]? Id { get; set; }
	public int[]? PkSurvey { get; set; }
	public int[]? PkLanguage { get; set; }
	public int[]? PkVariable { get; set; }

	// Surveys...
	public int[]? PkCountry { get; set; }
	public int[]? PkLanguage { get; set; }
	public int[]? PkQuestion { get; set; }
	public int[]? PkVariable { get; set; }
	public string[]? Round { get; set; }

	// Variables...
	public string[]? Id { get; set; }
}
</pre>

### General Response
Base From [XycloneDesigns.Apis.General](https://github.com/xyclone-designs/packages.apis.general).
<pre>
public class Reponse
{
	public int Count { get; set; } = 1;
	public int Page { get; set; } = 1;
	public int Pages { get; set; } = 1;
	public IEnumerable<T> Items { get; set; } = Enumerable.Empty<T>();
}
</pre>