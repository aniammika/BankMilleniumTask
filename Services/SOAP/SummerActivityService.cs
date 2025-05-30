namespace BankMilleniumTask.Services.SOAP
{
    public class SummerActivityService: ISummerActivityService
    {
        public GetActivityResponse GetSummerActivity(GetActivityRequest request)
        {
            Thread.Sleep(TimeSpan.FromMinutes(2));
            return new GetActivityResponse
            {
                Result = $"Activity for request Id {request.Id}: Hiking"
            };
        }
    }
}
