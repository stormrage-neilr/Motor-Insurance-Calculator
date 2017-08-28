using System;
using System.Collections.Generic;

public class Driver
{
    private string name;
    private string occupation;
    private DateTime dob;
    public List<DateTime> claims;

    public Driver(string name, string occupation, DateTime dob, List<DateTime> claims)
    {
        this.name = name;
        this.occupation = occupation;
        this.dob = dob;
        this.claims = claims;
    }

    public string Name { get => name; }
    public string Occupation { get => occupation; }
    public DateTime Dob { get => dob; }
	public List<DateTime> Claims { get => claims; }

	public override string ToString()
    {
        string result = "Name: " + name +
            "\nOccupation: " + occupation +
            "\nDate of Birth: " + dob.ToShortDateString() +
            "\nNo. of Claims: " + claims.Count;
        if (claims.Count > 0){
            result += "\nDate of Claims: ";
			for (int i = 0; i < claims.Count; i++)
			{
				result += "\n  " + claims[i].ToShortDateString();
			}
        }
        return result;
    }
}