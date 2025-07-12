ETenders API Wrapper
===

A simple wrapper to the [ETenders API]("https://ocds-api.etenders.gov.za/api"). 

Include the library and then make calls to the various API end points.

# Usage

<pre><code class='language-cs'>
[CubeType].Request request = new [CubeType].Request(<args>) { ... };
	
HttpClient httpclient = new HttpClient();
using HttpRequestMessage httprequestmessage = request.ToHttpRequestMessage();
using HttpResponseMessage httpresponsemessage = await httpclient.SendAsync(httprequestmessage);

string json = await httpresponsemessage.Content.ReadAsStringAsync();

// System.Text.Json
[CubeType].Response response = JsonSerializer.Deserialize<[CubeType]>(json);

// Newtonsoft
[CubeType].Response response = JObject.Parse(json).ToObject<[CubeType].Response>();

</code></pre>

# REST

## OCDSReleases
### Request
<pre>
public class OCDSReleases.MultipleRequest 
{
	public DateTime? DateFrom { get; set; }
	public DateTime? DateTo { get; set; }
	public int? PageNumber { get; set; }
	public int? PageSize { get; set; }
}
</pre>
### Response
<pre>
public class OCDSReleases.MultipleResponse
{
	public string? License { get; set; }
	public Link? Links { get; set; }
	public Publisher? Publisher { get; set; }
	public DateTime? PublishedDate { get; set; }
	public string? PublicationPolicy { get; set; }
	public List<Release>? Releases { get; set; }
	public string? Uri { get; set; }
	public string? Version { get; set; }
}
</pre>

## OCDSRelease
### Request
<pre>
public class OCDSReleases.MultipleRequest 
{
	public MultipleRequest(string ocid);

	public string Ocid { get; set; }
}
</pre>
### Response
<pre>
public class OCDSReleases.MultipleResponse
{
	public Release? Release { get; set; }
}
</pre>