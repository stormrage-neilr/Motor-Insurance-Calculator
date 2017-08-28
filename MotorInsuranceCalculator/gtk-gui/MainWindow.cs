
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action FileAction;

	private global::Gtk.Action ClearAction;

	private global::Gtk.Action ExitAction;

	private global::Gtk.Action atnClear;

	private global::Gtk.Action atnExit;

	private global::Gtk.VBox vbox3;

	private global::Gtk.MenuBar menubar2;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Frame driverFrame;

	private global::Gtk.Alignment GtkAlignment;

	private global::Gtk.VBox vbox9;

	private global::Gtk.Label nameLabel2;

	private global::Gtk.Entry etyName;

	private global::Gtk.Label occupationLabel2;

	private global::Gtk.ComboBox cbOccupation;

	private global::Gtk.Label dateOfBirthLable2;

	private global::Gtk.Calendar cldDateOfBirth;

	private global::Gtk.Frame frame9;

	private global::Gtk.Alignment GtkAlignment3;

	private global::Gtk.VBox vbox10;

	private global::Gtk.Label dateOfClaimLabel;

	private global::Gtk.Calendar cldClaim;

	private global::Gtk.Button btnAddClaim;

	private global::Gtk.Label lblClaimError;

	private global::Gtk.Label lblCurrentClaims1;

	private global::Gtk.Label lblCurrentClaims;

	private global::Gtk.Label claimsLabel;

	private global::Gtk.Button btnAddDriver;

	private global::Gtk.Label lblDriverError;

	private global::Gtk.Label driverLabel;

	private global::Gtk.VBox vbox1;

	private global::Gtk.Frame startDateFrame;

	private global::Gtk.Alignment GtkAlignment2;

	private global::Gtk.Calendar cldStartDate;

	private global::Gtk.Label startDateLabel;

	private global::Gtk.Frame frame10;

	private global::Gtk.Alignment GtkAlignment1;

	private global::Gtk.Label lblPolicySummary;

	private global::Gtk.Label summaryGroupLabel;

	private global::Gtk.HBox hbox11;

	private global::Gtk.Button btnClear;

	private global::Gtk.Button getQuoteButton1;

	private global::Gtk.Frame frmQuoteResults;

	private global::Gtk.Alignment GtkAlignment4;

	private global::Gtk.Label lblQuoteResults;

	private global::Gtk.Label GtkLabel5;

	private global::Gtk.Label resultsLabel;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.FileAction = new global::Gtk.Action("FileAction", global::Mono.Unix.Catalog.GetString("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString("File");
		w1.Add(this.FileAction, null);
		this.ClearAction = new global::Gtk.Action("ClearAction", global::Mono.Unix.Catalog.GetString("Clear"), null, null);
		this.ClearAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Clear");
		w1.Add(this.ClearAction, null);
		this.ExitAction = new global::Gtk.Action("ExitAction", global::Mono.Unix.Catalog.GetString("Exit"), null, null);
		this.ExitAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Exit");
		w1.Add(this.ExitAction, null);
		this.atnClear = new global::Gtk.Action("atnClear", global::Mono.Unix.Catalog.GetString("Clear"), null, null);
		this.atnClear.ShortLabel = global::Mono.Unix.Catalog.GetString("Clear");
		w1.Add(this.atnClear, null);
		this.atnExit = new global::Gtk.Action("atnExit", global::Mono.Unix.Catalog.GetString("Exit"), null, null);
		this.atnExit.ShortLabel = global::Mono.Unix.Catalog.GetString("Exit");
		w1.Add(this.atnExit, null);
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("Motor Insurance Calculator");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.BorderWidth = ((uint)(5));
		this.DefaultHeight = 600;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox3 = new global::Gtk.VBox();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString("<ui><menubar name=\'menubar2\'><menu name=\'FileAction\' action=\'FileAction\'><menuite" +
				"m name=\'atnClear\' action=\'atnClear\'/><menuitem name=\'atnExit\' action=\'atnExit\'/>" +
				"</menu></menubar></ui>");
		this.menubar2 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar2")));
		this.menubar2.Name = "menubar2";
		this.vbox3.Add(this.menubar2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.menubar2]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.driverFrame = new global::Gtk.Frame();
		this.driverFrame.WidthRequest = 300;
		this.driverFrame.Name = "driverFrame";
		this.driverFrame.ShadowType = ((global::Gtk.ShadowType)(1));
		this.driverFrame.BorderWidth = ((uint)(1));
		// Container child driverFrame.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(12));
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		this.vbox9 = new global::Gtk.VBox();
		this.vbox9.Name = "vbox9";
		this.vbox9.Spacing = 6;
		// Container child vbox9.Gtk.Box+BoxChild
		this.nameLabel2 = new global::Gtk.Label();
		this.nameLabel2.Name = "nameLabel2";
		this.nameLabel2.Xalign = 0F;
		this.nameLabel2.LabelProp = global::Mono.Unix.Catalog.GetString("Full Name");
		this.vbox9.Add(this.nameLabel2);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.nameLabel2]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox9.Gtk.Box+BoxChild
		this.etyName = new global::Gtk.Entry();
		this.etyName.CanFocus = true;
		this.etyName.Name = "etyName";
		this.etyName.IsEditable = true;
		this.etyName.InvisibleChar = '●';
		this.vbox9.Add(this.etyName);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.etyName]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox9.Gtk.Box+BoxChild
		this.occupationLabel2 = new global::Gtk.Label();
		this.occupationLabel2.Name = "occupationLabel2";
		this.occupationLabel2.Xalign = 0F;
		this.occupationLabel2.LabelProp = global::Mono.Unix.Catalog.GetString("Occupation");
		this.vbox9.Add(this.occupationLabel2);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.occupationLabel2]));
		w5.Position = 2;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox9.Gtk.Box+BoxChild
		this.cbOccupation = global::Gtk.ComboBox.NewText();
		this.cbOccupation.AppendText(global::Mono.Unix.Catalog.GetString("Select an occupation"));
		this.cbOccupation.AppendText(global::Mono.Unix.Catalog.GetString("Chauffeur"));
		this.cbOccupation.AppendText(global::Mono.Unix.Catalog.GetString("Accountant"));
		this.cbOccupation.Name = "cbOccupation";
		this.cbOccupation.Active = 0;
		this.vbox9.Add(this.cbOccupation);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.cbOccupation]));
		w6.Position = 3;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox9.Gtk.Box+BoxChild
		this.dateOfBirthLable2 = new global::Gtk.Label();
		this.dateOfBirthLable2.Name = "dateOfBirthLable2";
		this.dateOfBirthLable2.Xalign = 0F;
		this.dateOfBirthLable2.LabelProp = global::Mono.Unix.Catalog.GetString("Date of Birth");
		this.vbox9.Add(this.dateOfBirthLable2);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.dateOfBirthLable2]));
		w7.Position = 4;
		w7.Expand = false;
		w7.Fill = false;
		// Container child vbox9.Gtk.Box+BoxChild
		this.cldDateOfBirth = new global::Gtk.Calendar();
		this.cldDateOfBirth.CanFocus = true;
		this.cldDateOfBirth.Name = "cldDateOfBirth";
		this.cldDateOfBirth.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
		this.vbox9.Add(this.cldDateOfBirth);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.cldDateOfBirth]));
		w8.Position = 5;
		w8.Expand = false;
		w8.Fill = false;
		// Container child vbox9.Gtk.Box+BoxChild
		this.frame9 = new global::Gtk.Frame();
		this.frame9.Name = "frame9";
		this.frame9.ShadowType = ((global::Gtk.ShadowType)(1));
		this.frame9.BorderWidth = ((uint)(1));
		// Container child frame9.Gtk.Container+ContainerChild
		this.GtkAlignment3 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment3.Name = "GtkAlignment3";
		this.GtkAlignment3.LeftPadding = ((uint)(12));
		// Container child GtkAlignment3.Gtk.Container+ContainerChild
		this.vbox10 = new global::Gtk.VBox();
		this.vbox10.Name = "vbox10";
		this.vbox10.Spacing = 6;
		// Container child vbox10.Gtk.Box+BoxChild
		this.dateOfClaimLabel = new global::Gtk.Label();
		this.dateOfClaimLabel.Name = "dateOfClaimLabel";
		this.dateOfClaimLabel.Xalign = 0F;
		this.dateOfClaimLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Date of Claim");
		this.vbox10.Add(this.dateOfClaimLabel);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.dateOfClaimLabel]));
		w9.Position = 0;
		w9.Expand = false;
		w9.Fill = false;
		// Container child vbox10.Gtk.Box+BoxChild
		this.cldClaim = new global::Gtk.Calendar();
		this.cldClaim.CanFocus = true;
		this.cldClaim.Name = "cldClaim";
		this.cldClaim.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
		this.vbox10.Add(this.cldClaim);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.cldClaim]));
		w10.Position = 1;
		w10.Expand = false;
		w10.Fill = false;
		// Container child vbox10.Gtk.Box+BoxChild
		this.btnAddClaim = new global::Gtk.Button();
		this.btnAddClaim.CanFocus = true;
		this.btnAddClaim.Name = "btnAddClaim";
		this.btnAddClaim.UseUnderline = true;
		this.btnAddClaim.Label = global::Mono.Unix.Catalog.GetString("Add Claim");
		this.vbox10.Add(this.btnAddClaim);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.btnAddClaim]));
		w11.Position = 2;
		w11.Expand = false;
		w11.Fill = false;
		// Container child vbox10.Gtk.Box+BoxChild
		this.lblClaimError = new global::Gtk.Label();
		this.lblClaimError.Name = "lblClaimError";
		this.lblClaimError.LabelProp = global::Mono.Unix.Catalog.GetString("Claim date can not be in the future!");
		this.vbox10.Add(this.lblClaimError);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.lblClaimError]));
		w12.Position = 3;
		w12.Expand = false;
		w12.Fill = false;
		// Container child vbox10.Gtk.Box+BoxChild
		this.lblCurrentClaims1 = new global::Gtk.Label();
		this.lblCurrentClaims1.Name = "lblCurrentClaims1";
		this.lblCurrentClaims1.Xalign = 0F;
		this.lblCurrentClaims1.LabelProp = global::Mono.Unix.Catalog.GetString("Current Claims Listed:");
		this.vbox10.Add(this.lblCurrentClaims1);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.lblCurrentClaims1]));
		w13.Position = 4;
		w13.Expand = false;
		w13.Fill = false;
		// Container child vbox10.Gtk.Box+BoxChild
		this.lblCurrentClaims = new global::Gtk.Label();
		this.lblCurrentClaims.Name = "lblCurrentClaims";
		this.lblCurrentClaims.LabelProp = global::Mono.Unix.Catalog.GetString("No claims currently listed.");
		this.vbox10.Add(this.lblCurrentClaims);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.lblCurrentClaims]));
		w14.Position = 5;
		w14.Expand = false;
		w14.Fill = false;
		this.GtkAlignment3.Add(this.vbox10);
		this.frame9.Add(this.GtkAlignment3);
		this.claimsLabel = new global::Gtk.Label();
		this.claimsLabel.Name = "claimsLabel";
		this.claimsLabel.Ypad = 5;
		this.claimsLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Claim(s)</b>");
		this.claimsLabel.UseMarkup = true;
		this.frame9.LabelWidget = this.claimsLabel;
		this.vbox9.Add(this.frame9);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.frame9]));
		w17.Position = 6;
		w17.Expand = false;
		w17.Fill = false;
		// Container child vbox9.Gtk.Box+BoxChild
		this.btnAddDriver = new global::Gtk.Button();
		this.btnAddDriver.CanFocus = true;
		this.btnAddDriver.Name = "btnAddDriver";
		this.btnAddDriver.UseUnderline = true;
		this.btnAddDriver.Label = global::Mono.Unix.Catalog.GetString("Add Driver");
		this.vbox9.Add(this.btnAddDriver);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.btnAddDriver]));
		w18.Position = 7;
		w18.Expand = false;
		w18.Fill = false;
		// Container child vbox9.Gtk.Box+BoxChild
		this.lblDriverError = new global::Gtk.Label();
		this.lblDriverError.Name = "lblDriverError";
		this.lblDriverError.LabelProp = global::Mono.Unix.Catalog.GetString("The name field cannot be blank!");
		this.vbox9.Add(this.lblDriverError);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.lblDriverError]));
		w19.Position = 8;
		w19.Expand = false;
		w19.Fill = false;
		this.GtkAlignment.Add(this.vbox9);
		this.driverFrame.Add(this.GtkAlignment);
		this.driverLabel = new global::Gtk.Label();
		this.driverLabel.Name = "driverLabel";
		this.driverLabel.Ypad = 6;
		this.driverLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Driver(s)</b>");
		this.driverLabel.UseMarkup = true;
		this.driverFrame.LabelWidget = this.driverLabel;
		this.hbox1.Add(this.driverFrame);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.driverFrame]));
		w22.Position = 0;
		w22.Expand = false;
		w22.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.WidthRequest = 300;
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.startDateFrame = new global::Gtk.Frame();
		this.startDateFrame.Name = "startDateFrame";
		this.startDateFrame.ShadowType = ((global::Gtk.ShadowType)(1));
		this.startDateFrame.BorderWidth = ((uint)(1));
		// Container child startDateFrame.Gtk.Container+ContainerChild
		this.GtkAlignment2 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment2.Name = "GtkAlignment2";
		this.GtkAlignment2.LeftPadding = ((uint)(12));
		// Container child GtkAlignment2.Gtk.Container+ContainerChild
		this.cldStartDate = new global::Gtk.Calendar();
		this.cldStartDate.CanFocus = true;
		this.cldStartDate.Name = "cldStartDate";
		this.cldStartDate.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
		this.GtkAlignment2.Add(this.cldStartDate);
		this.startDateFrame.Add(this.GtkAlignment2);
		this.startDateLabel = new global::Gtk.Label();
		this.startDateLabel.Name = "startDateLabel";
		this.startDateLabel.Ypad = 6;
		this.startDateLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Policy Start Date</b>");
		this.startDateLabel.UseMarkup = true;
		this.startDateFrame.LabelWidget = this.startDateLabel;
		this.vbox1.Add(this.startDateFrame);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.startDateFrame]));
		w25.Position = 0;
		w25.Expand = false;
		w25.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.frame10 = new global::Gtk.Frame();
		this.frame10.Name = "frame10";
		this.frame10.ShadowType = ((global::Gtk.ShadowType)(1));
		this.frame10.BorderWidth = ((uint)(1));
		// Container child frame10.Gtk.Container+ContainerChild
		this.GtkAlignment1 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment1.Name = "GtkAlignment1";
		this.GtkAlignment1.LeftPadding = ((uint)(12));
		// Container child GtkAlignment1.Gtk.Container+ContainerChild
		this.lblPolicySummary = new global::Gtk.Label();
		this.lblPolicySummary.Name = "lblPolicySummary";
		this.lblPolicySummary.Xalign = 0F;
		this.lblPolicySummary.LabelProp = global::Mono.Unix.Catalog.GetString("Please add at least one driver to generate details.");
		this.GtkAlignment1.Add(this.lblPolicySummary);
		this.frame10.Add(this.GtkAlignment1);
		this.summaryGroupLabel = new global::Gtk.Label();
		this.summaryGroupLabel.Name = "summaryGroupLabel";
		this.summaryGroupLabel.Ypad = 6;
		this.summaryGroupLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Policy Summary</b>");
		this.summaryGroupLabel.UseMarkup = true;
		this.frame10.LabelWidget = this.summaryGroupLabel;
		this.vbox1.Add(this.frame10);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.frame10]));
		w28.Position = 1;
		w28.Expand = false;
		w28.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox11 = new global::Gtk.HBox();
		this.hbox11.Name = "hbox11";
		this.hbox11.Spacing = 6;
		// Container child hbox11.Gtk.Box+BoxChild
		this.btnClear = new global::Gtk.Button();
		this.btnClear.CanFocus = true;
		this.btnClear.Name = "btnClear";
		this.btnClear.UseUnderline = true;
		this.btnClear.Label = global::Mono.Unix.Catalog.GetString("Clear");
		this.hbox11.Add(this.btnClear);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.btnClear]));
		w29.Position = 0;
		w29.Fill = false;
		// Container child hbox11.Gtk.Box+BoxChild
		this.getQuoteButton1 = new global::Gtk.Button();
		this.getQuoteButton1.CanFocus = true;
		this.getQuoteButton1.Name = "getQuoteButton1";
		this.getQuoteButton1.UseUnderline = true;
		this.getQuoteButton1.Label = global::Mono.Unix.Catalog.GetString("Get Quote");
		this.hbox11.Add(this.getQuoteButton1);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.getQuoteButton1]));
		w30.Position = 1;
		w30.Fill = false;
		this.vbox1.Add(this.hbox11);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox11]));
		w31.Position = 2;
		w31.Expand = false;
		w31.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.frmQuoteResults = new global::Gtk.Frame();
		this.frmQuoteResults.Name = "frmQuoteResults";
		this.frmQuoteResults.ShadowType = ((global::Gtk.ShadowType)(1));
		this.frmQuoteResults.BorderWidth = ((uint)(1));
		// Container child frmQuoteResults.Gtk.Container+ContainerChild
		this.GtkAlignment4 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment4.Name = "GtkAlignment4";
		this.GtkAlignment4.LeftPadding = ((uint)(12));
		// Container child GtkAlignment4.Gtk.Container+ContainerChild
		this.lblQuoteResults = new global::Gtk.Label();
		this.lblQuoteResults.Name = "lblQuoteResults";
		this.lblQuoteResults.Xalign = 0F;
		this.GtkAlignment4.Add(this.lblQuoteResults);
		this.frmQuoteResults.Add(this.GtkAlignment4);
		this.GtkLabel5 = new global::Gtk.Label();
		this.GtkLabel5.Name = "GtkLabel5";
		this.GtkLabel5.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Quote Results</b>");
		this.GtkLabel5.UseMarkup = true;
		this.frmQuoteResults.LabelWidget = this.GtkLabel5;
		this.vbox1.Add(this.frmQuoteResults);
		global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.frmQuoteResults]));
		w34.Position = 3;
		w34.Expand = false;
		w34.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.resultsLabel = new global::Gtk.Label();
		this.resultsLabel.Name = "resultsLabel";
		this.vbox1.Add(this.resultsLabel);
		global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.resultsLabel]));
		w35.Position = 4;
		w35.Expand = false;
		w35.Fill = false;
		this.hbox1.Add(this.vbox1);
		global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox1]));
		w36.Position = 1;
		w36.Expand = false;
		w36.Fill = false;
		this.vbox3.Add(this.hbox1);
		global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox1]));
		w37.Position = 1;
		w37.Expand = false;
		w37.Fill = false;
		this.Add(this.vbox3);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 616;
		this.lblClaimError.Hide();
		this.lblDriverError.Hide();
		this.frmQuoteResults.Hide();
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.atnClear.Activated += new global::System.EventHandler(this.ClearForm);
		this.atnExit.Activated += new global::System.EventHandler(this.atnExit_Activated);
		this.btnAddClaim.Clicked += new global::System.EventHandler(this.btnAddClaim_Clicked);
		this.btnAddDriver.Clicked += new global::System.EventHandler(this.btnAddDriver_Clicked);
		this.cldStartDate.DaySelected += new global::System.EventHandler(this.cldStartDate_DaySelected);
		this.btnClear.Clicked += new global::System.EventHandler(this.ClearForm);
		this.getQuoteButton1.Clicked += new global::System.EventHandler(this.btnGetQuote_Clicked);
	}
}