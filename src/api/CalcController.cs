[ApiController]
[Route("calc")]
public class CalcController : ControllerBase
{
    private readonly LocalCalcService _local;

    public CalcController(LocalCalcService local)
    {
        _local = local;
    }

    [HttpPost("local")]
    public IActionResult Local(CalcRequest req)
    {
        var result = _local.Calculate(req);
        return Ok(result);
    }
}