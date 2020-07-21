using Systems;

namespace JobBoard.Models
{
  public class JobOpening
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string ContactInfoName { get; set; }
    public string ContactInfoEmail { get; set; }
    public string ContactInfoPhone { get; set; }

    public JobOpening (string title, string description, string contactInfoName, string contactInfoEmail, string contactInfoPhone)
    {
      Title = title;
      Description = description;
      ContactInfoName = contactInfoName;
      ContactInfoEmail = contactInfoEmail;
      ContactInfoPhone = contactInfoPhone;
    }
  }
}