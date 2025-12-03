public class LocalCalcService
{
    public CalcResponse Calculate(CalcRequest req)
    {
        double tco = req.Capex + req.Opex * req.PeriodYears + req.TrainingCosts;
        double benefits = (req.ExpectedSavingsPerYear + req.ExpectedRevenueGrowthPerYear) * req.PeriodYears;
        double roi = ((benefits - tco) / tco) * 100;
        double payback = tco / (req.ExpectedSavingsPerYear + req.ExpectedRevenueGrowthPerYear);

        return new CalcResponse(req.ProjectName, tco, roi, payback);
    }
}