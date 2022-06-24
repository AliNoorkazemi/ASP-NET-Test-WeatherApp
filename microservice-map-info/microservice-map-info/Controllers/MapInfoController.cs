using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

[Route("[controller]")]
[Route("[controller]/[action]")]
[ApiController]
public class MapInfoController : ControllerBase
{
    public readonly GoogleDistanceApi _googleDistanceApi;
    public MapInfoController(GoogleDistanceApi googleDistanceApi)
    {
        _googleDistanceApi = googleDistanceApi;
    }

    [HttpGet]
    public async Task<GoogleDistanceData> GetDistance(string originCity, string destinationCity)
    {
        return await _googleDistanceApi.GetMapDistance(originCity, destinationCity);
    }
}