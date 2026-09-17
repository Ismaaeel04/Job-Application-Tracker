

public enum ApplicationStatus
{
    Applied,
    Interview,

    Offer,

    Rejected


}

public class JobApplication
{

    int id;
    public String enterpriseName;

    string jobPosition;

    ApplicationStatus status;

    DateTime applicationDate;

    string? offerURL;


    public JobApplication(string enterpriseName, string jobPosition, ApplicationStatus status, DateTime applicationDate, string? offerURL = null)
    {


        
        this.enterpriseName = enterpriseName;
        this.jobPosition = jobPosition;
        this.status = status;
        this.applicationDate = applicationDate;
        this.offerURL = offerURL;


    }


    


    








}