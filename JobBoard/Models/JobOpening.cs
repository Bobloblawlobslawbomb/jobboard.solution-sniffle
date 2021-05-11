using System.Collections.Generic;

namespace JobBoard.Models
{
  public class JobOpening
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public Contact ContactInfo { get; set; }

    private static List<JobOpening> _instances = new List<JobOpening> { };

    public JobOpening(string title, string description, Contact contact)
    {
      Title = title;
      Description = description;
      ContactInfo = contact;
      _instances.Add(this);
    }
  }
  public class Contact
  {
    public Dictionary<string, string> ContactInfo { get; set; }

    public Contact()
    {
      ContactInfo = new Dictionary<string, string>() { };
      ContactInfo.Add("name", "");
      ContactInfo.Add("email", "");
      ContactInfo.Add("phoneNumber", "");
    }
  }
}