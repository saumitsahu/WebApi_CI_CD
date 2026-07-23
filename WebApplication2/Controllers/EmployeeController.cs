using Microsoft.AspNetCore.Mvc;
using WebApplication2.Classes;
using WebApplication2.Filters;

namespace WebApplication2.Controllers
{
    [MyActionFiltercs]
    public class EmployeeController : Controller
    {
       //Employee obj = new Employee();
        private readonly  IEmployee _emp;  /*saumit sahu*/
        public EmployeeController(IEmployee emp)
        {
            _emp=emp;
            
        }
        public IActionResult Index()
        {
           string res= _emp.getemployee();
            return Content(res);
        }
    }
}
