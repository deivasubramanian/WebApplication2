namespace DataLibrary.Queries
{
  public class EmployeeQuery
  {
    public int? Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int? Age { get; set; }
    public Range<int?> AgeRange { get; set; }
    public int? Role { get; set; }
  }
}