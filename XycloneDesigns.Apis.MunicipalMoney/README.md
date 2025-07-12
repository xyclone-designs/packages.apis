Municipal Money API Wrapper
===

A simple wrapper to the [Municipal Money API](https://municipaldata.treasury.gov.za/docs). 

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

# Requests

Extra information on additional params found here
- [Filtering](https://municipaldata.treasury.gov.za/docs#cut)
- [Pagination](https://municipaldata.treasury.gov.za/docs#pagination)
- [Sorting](https://municipaldata.treasury.gov.za/docs#sort)

### CubeAggregate.Request

### [List Cubes](https://municipaldata.treasury.gov.za/docs#list-cubes) 
<code>https://municipaldata.treasury.gov.za/api/cubes</code>
<pre>
public class CubeAggregate.Request
{
	public Request (string cubename);

	public string CubeName { get; set; }
	public List<string>? Aggregates { get; set; }
	public Dictionary<string, object>? Cut { get; set; }
	public List<string>? Drilldown { get; set; }
	public string? Format { get; set; }
	public int? Page { get; set; }
	public int? PageSize { get; set; }
	public Dictionary<string, bool>? Order { get; set; }
}
</pre>

### [Cube Model](https://municipaldata.treasury.gov.za/docs#model) 
<code>https://municipaldata.treasury.gov.za/api/cubes/[cubename]/model</code>
<pre>
public class CubeModel.Request
{
	public Request (string cubename);

	public string CubeName { get; set; }
}
</pre>

### [List Facts](https://municipaldata.treasury.gov.za/docs#list-facts) 
<code>https://municipaldata.treasury.gov.za/api/cubes/[cubename]/facts</code>
<pre>
public class CubeFacts.Request
{
	public Request (string cubename);
	
	public string CubeName { get; set; }
	public Dictionary<string, object>? Cut { get; set; }
	public string? Format { get; set; }
	public int? Page { get; set; }
	public int? PageSize { get; set; }
	public Dictionary<string, bool>? Order { get; set; }
}
</pre>

### [List Members](https://municipaldata.treasury.gov.za/docs#list-members) 
<code>https://municipaldata.treasury.gov.za/api/cubes/[cubename]/members/[cubemembername]</code>
<pre>
public class CubeMembersDemarcation.Request
{
	public Request (string cubename, string cubemembername);

	public string CubeName { get; set; }
	public string CubeMemberName { get; set; }
	public Dictionary<string, object>? Cut { get; set; }
	public string? Format { get; set; }
	public int? Page { get; set; }
	public int? PageSize { get; set; }
	public Dictionary<string, bool>? Order { get; set; }
}
</pre>

### [Aggregating Facts](https://municipaldata.treasury.gov.za/docs#aggregate) 
<code>https://municipaldata.treasury.gov.za/api/cubes/[cubename]/aggregate</code>
<pre>
public class CubeAggregate.Request
{
	public Request (string cubename);

	public string CubeName { get; set; }
	public List<string>? Aggregates { get; set; }
	public Dictionary<string, object>? Cut { get; set; }
	public List<string>? Drilldown { get; set; }
	public string? Format { get; set; }
	public int? Page { get; set; }
	public int? PageSize { get; set; }
	public Dictionary<string, bool>? Order { get; set; }
}
</pre>