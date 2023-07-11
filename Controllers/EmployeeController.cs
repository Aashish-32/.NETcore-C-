using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
//[Route("Api/attribute/[Controller]")]
public class EmployeeController : Controller
{
    public ActionResult Index()
    {
         var employees= Employee.getemployee();
       
        return View(employees);
        

 }
 public ActionResult detail([FromQuery] int id) {
     var employees= Employee.getemployee();
    var employee= employees.Where( x=> x.id==id).FirstOrDefault();
return View(employee);

}
 /*public ActionResult detail(string firstname) {
     var employees= Employee.getemployee();
    var employee= employees.Where( x=> x.firstname==firstname).FirstOrDefault();
return View(employee);

} */
[HttpGet]
public ActionResult Add() {
 return View("adds");

}

[HttpPost]
public ActionResult<string> Add(Employee obj) {
   
 return"re";

}



}




