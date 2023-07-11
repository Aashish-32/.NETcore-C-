using System.ComponentModel.DataAnnotations;
public class Employee
{
[Required(ErrorMessage ="firstname required")]
[StringLength(4)]
    [Display(Name = "First name")]
    
    public string firstname { get; set; } = "n";
    [Display(Name = "Last name")]

    public string? lastname { get; set; } = "Pant";
    public string Gender { get; set; } = "M";
    public double salary { get; set; } = 0;

    public int id { get; set; }


    public static List<Employee> getemployee()
    {
        Employee p1 = new Employee() { id = 1, firstname = "Aashish", lastname = "Roshan", salary = 3000 };
        Employee p2 = new Employee() { id = 2, firstname = "Aas", lastname = "han", salary = 30030 };
        Employee p3 = new Employee() { id = 3, firstname = "hish", lastname = "reoan", salary = 64000 };
        Employee p4 = new Employee() { id = 4, firstname = "ashis", lastname = "Rfan", salary = 30500 };
        Employee p5 = new Employee() { id = 5, firstname = "frfis", lastname = "ffRan", salary = 345500 };
        Employee p6 = new Employee() { id = 6, firstname = "frfs", lastname = "hyRan", salary = 305400 };

        List<Employee> employees = new List<Employee>() { p1, p2, p3, p4, p5, p6 };
        return employees;
    }

}