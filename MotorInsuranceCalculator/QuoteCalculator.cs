using System;
using System.Collections.Generic;

// This class manages the back end motor insurance assessment.
public static class QuoteCalculator
{
    public static decimal startingPremium = 500m;

    // Retrieving quote message based on given parameters.
    public static string GetQuote(DateTime startDate, List<Driver> drivers){
        string result = GetValidationMessage(startDate, drivers);
        if (!result.Equals("Valid")){
            result = "Policy Declined:\n  " + result;
		}
        else{
            decimal premium = AdjustForOccupation(startingPremium, drivers);
            premium = AdjustForAge(premium, drivers, startDate);
            premium = AdjustForClaims(premium, drivers, startDate);
            result = "Your calculated premium is £" + premium;
        }
        return result;
    }

    private static decimal AdjustForClaims(decimal premium, List<Driver> drivers, DateTime startDate)
    {
        int oneYearClaims = 0;
		int fiveYearClaims = 0;
		for (int i = 0; i < drivers.Count; i++)
		{
            for  (int j = 0; j < drivers[i].Claims.Count; j++)
			{
                int claimAge = GetAge(drivers[i].Claims[j], startDate);
                if (claimAge < 1){
                    oneYearClaims++;
                }
                else if (claimAge < 5){
                    fiveYearClaims++;
                }
			}
		}
        for (int i = 0; i < oneYearClaims; i++){
            premium = premium * 120 / 100;
        }
		for (int i = 0; i < fiveYearClaims; i++)
		{
			premium = premium * 110 / 100;
		}
        return premium;
    }

    private static decimal AdjustForAge(decimal premium, List<Driver> drivers, DateTime startDate)
    {
        int youngestDriverAge = GetAgeOfYoungestDriver(drivers, startDate);
        if (youngestDriverAge < 26) {
            return premium * 120 / 100;
        }
        else{
            return premium * 90 / 100;
        }
    }

    private static decimal AdjustForOccupation(decimal premium, List<Driver> drivers)
    {
        decimal result = premium;
		if (ContainsOccupation(drivers, "Chauffeur"))
		{
            result = result * 110 / 100;
		}
		if (ContainsOccupation(drivers, "Accountant"))
		{
			result = result * 90 / 100;
		}
        return result;
    }

    // Checking to see if a list of drivers contains a driver with a certain occupation.
    private static bool ContainsOccupation(List<Driver> drivers, string occupation)
    {
		for (int i = 0; i < drivers.Count; i++)
		{
            if (drivers[i].Occupation.Equals(occupation)){
                return true;
            }
		}
        return false;
    }

    // Checking if a policy is valid and returning relevant messages.
    private static string GetValidationMessage(DateTime startDate, List<Driver> drivers)
    {
        if (Convert.ToDateTime(startDate.ToShortDateString()) < Convert.ToDateTime(DateTime.Now.ToShortDateString())){
            return "Start Date of Policy";
        }
        else if (drivers.Count < 1)
		{
			return "There are no drivers on the policy";
		}
        else if (GetAgeOfYoungestDriver(drivers, startDate) < 21){
            return "Age of Youngest Driver";
        }
        else if (GetAgeOfOldestDriver(drivers, startDate) > 75){
            return "Age of Oldest Driver";
        }
        else {
            List<string> names = GetDriversWithOverTwoClaims(drivers);
            if (names.Count>0){
                string result =  "Driver has more than 2 claims (";
                for (int i = 0; i < names.Count; i++){
                    result += names[i];
                    if (i + 1< names.Count){
                        result += ", ";
                    }
                }
                result += ")";
                return result;
            }
            else if (GetSumOfClaims(drivers) > 3){
                return "Policy has more than 3 claims";
            }
            else{
                return "Valid";
            }
        }
    }

    private static int GetSumOfClaims(List<Driver> drivers)
    {
        int result = 0;
		for (int i = 0; i < drivers.Count; i++)
		{
            result += drivers[i].Claims.Count;
		}
        return result;
    }

    private static List<string> GetDriversWithOverTwoClaims(List<Driver> drivers)
    {
        List<string> result = new List<string>();
		for (int i = 0; i < drivers.Count; i++)
		{
            if (drivers[i].Claims.Count > 2)
			{
                result.Add(drivers[i].Name);
			}
		}
        return result;
    }

    private static int GetAgeOfYoungestDriver(List<Driver> drivers, DateTime onDate)
    {
        int result = GetAge(drivers[0].Dob, onDate);
        for (int i = 1; i < drivers.Count; i++){
            if (result > GetAge(drivers[i].Dob, onDate)){
                result = GetAge(drivers[i].Dob, onDate); 
            }
        }
        return result;
    }

    private static int GetAgeOfOldestDriver(List<Driver> drivers, DateTime onDate)
	{
        int result = GetAge(drivers[0].Dob, onDate);
		for (int i = 1; i < drivers.Count; i++)
		{
			if (result < GetAge(drivers[i].Dob, onDate))
			{
				result = GetAge(drivers[i].Dob, onDate);
			}
		}
		return result;
	}

    // This method is used to get an age on a given date given a date of birth.
	private static int GetAge(DateTime dob, DateTime onDate)
	{
		int result = onDate.Year - dob.Year;
		if (onDate.Month < dob.Month)
		{
			result--;
		}
		else if (onDate.Month == dob.Month && onDate.Day < dob.Day)
		{
			result--;
		}
		return result;
	}
}