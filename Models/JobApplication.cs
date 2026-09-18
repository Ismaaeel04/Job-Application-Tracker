

public enum ApplicationStatus
{
    Applied,
    Interview,

    Offer,

    Rejected


}

public class JobApplication
{

    public int Id {get; set;}
    public string EnterpriseName {get; set;}

    public string JobPosition {get; set;}

    public ApplicationStatus Status {get; set;}

    public DateTime ApplicationDate {get; set;}
    public string? OfferURL {get; set;}


    public JobApplication(string enterpriseName, string jobPosition, ApplicationStatus status, DateTime applicationDate, string? offerURL = null)
    {


        this.EnterpriseName = enterpriseName;
        this.JobPosition = jobPosition;
        this.Status = status;
        this.ApplicationDate = applicationDate;
        this.OfferURL = offerURL;

    }


}




    


    








