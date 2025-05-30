using BankMilleniumTask.Contracts.Models;

namespace BankMilleniumTask.Service.REST;

public class SummerCityService: ISummerCityService
{
    private static readonly SummerCity[] SummerCitiesList = new SummerCity[]
    {
    new SummerCity{ Name = "Barcelona" },
    new SummerCity{ Name = "Dubrovnik" },
    new SummerCity{ Name = "Santorini" },
    new SummerCity{ Name = "Mykonos" },
    new SummerCity{ Name = "Nice" },
    new SummerCity{ Name = "Malta" },
    new SummerCity{ Name = "Ibiza" }
    };
    public SummerCity GetSummerCity()
    {
        var random = new Random();
        int index = random.Next(SummerCitiesList.Length);
        return SummerCitiesList[index];
    }
}
