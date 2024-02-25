namespace BaseLibrary.Entities;

public class Employee
{
    public string Id { get; set; }
    public string? Name { get; set; }
    public string? CivilId { get; set; }
    public string? FileNumber { get; set; }
    public string? FullName { get; set; }
    public string? JobName { get; set; }
    public string? Address { get; set; }
    public string? ThelephoneNumber { get; set; }
    public string? Other { get; set; }

    //Relationship: Many to One
    public GeneralDepartment? GeneralDepartment { get; set; }
    public string? GeneralDepartmentId { get; set; }

    public Department? Department { get; set; }
    public string? DepartmentId { get; set; }

    public Town? Town { get; set; }
    public string? TownId { get; set; }
}
