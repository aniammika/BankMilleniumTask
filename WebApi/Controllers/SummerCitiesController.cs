using BankMilleniumTask.Contracts.Models;
using BankMilleniumTask.Service.REST;
using Microsoft.AspNetCore.Mvc;

namespace BankMilleniumTaskREST.Api.Controllers;

[ApiController]
[Route("summer-city")]
public class SummerCitiesController : ControllerBase
{
    private readonly ILogger<SummerCitiesController> _logger;
    private readonly ISummerCityService _summerCityService;
    private static int _callCount = 0;

    public SummerCitiesController(
            ILogger<SummerCitiesController> logger,
            ISummerCityService summerCityService)
    {
        _logger = logger;
        _summerCityService = summerCityService;
    }

    [HttpGet]
    [ProducesResponseType(typeof(SummerCity), 200)]
    [ProducesErrorResponseType(typeof(NotFoundResult))]
    public ActionResult<SummerCity> GetSummerCities()
    {
        _callCount++;
        if (_callCount % 10 == 0)
        {
            return BadRequest("I'm returning bad request every 10th call");
        }

        var city = _summerCityService.GetSummerCity();
        return Ok(city);

    }
}
