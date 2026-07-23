using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApplication2.Filters
{
    public class MyActionFiltercs : Attribute
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
           
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

    }
}
