using System;
using System.Collections.Generic;
using Gtk;

// This class deals with the user interface functionality displaying and retrieving information to and from the user.
public partial class MainWindow : Gtk.Window
{
    private List<DateTime> claimDates = new List<DateTime>();
    private List<Driver> drivers = new List<Driver>();

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    // Adding a claim to a driver on button click.
    protected void btnAddClaim_Clicked(object sender, EventArgs e)
    {
        if (claimDates.Count>4){
			lblClaimError.Text = "No more than 5 claims are allowed per driver!";
			lblClaimError.Visible = true; 
        }
        else if (cldClaim.GetDate() > DateTime.Now)
		{
            lblClaimError.Text = "Claim date can not be in the future!";
			lblClaimError.Visible = true;
		}
		else 
        {
			lblClaimError.Visible = false;
            claimDates.Add(cldClaim.GetDate());
            SetCurrentClaimsText();
		}
    }

    // This method updated the display so the user can see claims already entered.
    private void SetCurrentClaimsText()
    {
        if (claimDates.Count == 0)
        {
			lblCurrentClaims.Text = "No claims currently listed.";
		}
        else
        {

            string claimText = "";
            for (int i = 0; i < claimDates.Count; i++)
            {
                claimText += claimDates[i].ToShortDateString();
                if (i + 1 < claimDates.Count)
                {
                    claimText += "\n";
                }
            }
            lblCurrentClaims.Text = claimText;
        }
    }

    // Adding a driver to the policy on click.
    protected void btnAddDriver_Clicked(object sender, EventArgs e)
    {
        if (drivers.Count > 4){
			lblDriverError.Text = "A maximum of 5 drivers are allowed on a policy!";
			lblDriverError.Visible = true;
        }
        else if (etyName.Text.Trim() == ""){
            lblDriverError.Text = "The driver name field cannot be empty!";
            lblDriverError.Visible = true;
        }
        else if (cbOccupation.Active == 0){
            lblDriverError.Text = "The driver occupation cannot be empty!";
            lblDriverError.Visible = true;
        }
        else if (cldDateOfBirth.GetDate() > DateTime.Now.AddYears(-17)){
			lblDriverError.Text = "The driver must be at least 17 years old!";
			lblDriverError.Visible = true;
        }
        else {
			lblDriverError.Visible = false;
			drivers.Add(new Driver(etyName.Text, cbOccupation.ActiveText, cldDateOfBirth.GetDate(), claimDates));
            ClearDriverInfo();
            SetPolicySummary(); 
		}
    }

    // Concatinating policy summary.
    private void SetPolicySummary()
    {
        if (drivers.Count == 0){
            lblPolicySummary.Text = "Please add at least one driver to generate details.";
        }
        else {
            string policySummaryString = "This policy is due to start on " + cldStartDate.GetDate().ToShortDateString() + 
                                            ".\nDrivers included on the policy are as follows:";
            for (int i = 0; i < drivers.Count; i++)
            {
                policySummaryString += "\n\n" + drivers[i];
            }
            lblPolicySummary.Text = policySummaryString;
        }
    }

    // Clearing all driver information.
    private void ClearDriverInfo()
    {
        frmQuoteResults.Visible = false;
		etyName.Text = "";
        cbOccupation.Active = 0;
        resetCalendar(cldDateOfBirth);
        resetCalendar(cldClaim);
        claimDates = new List<DateTime>();
        SetCurrentClaimsText();
		SetPolicySummary();
	}

    // Updating policy summary on policy start date selection.
    protected void cldStartDate_DaySelected(object sender, EventArgs e)
    {
        SetPolicySummary();
    }

    // Clearing all information.
    private void ClearForm(object sender, EventArgs e)
    {
		drivers = new List<Driver>();
		resetCalendar(cldStartDate);
		ClearDriverInfo();
    }

    // Setting a calendar to the current date.
    private void resetCalendar(Calendar cld)
    {
		cld.SelectDay((uint)DateTime.Now.Day);
		cld.SelectMonth((uint)DateTime.Now.Month-1, (uint)DateTime.Now.Year);
    }

    // Quit appliction from the menu functionality.
    protected void atnExit_Activated(object sender, EventArgs e)
    {
        Gtk.Application.Quit();
    }

    // Retrievin a quote using entered information.
    protected void btnGetQuote_Clicked(object sender, EventArgs e)
    {
        lblQuoteResults.Text = QuoteCalculator.GetQuote(cldStartDate.GetDate(), drivers);
        frmQuoteResults.Visible = true;
    }
}
