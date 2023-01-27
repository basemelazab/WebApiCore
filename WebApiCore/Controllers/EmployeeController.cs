using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApiCore.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApiCore.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class EmployeeController : Controller
    {
        private readonly APIDBContext aPIDBContext;
        public EmployeeController(APIDBContext aPIDBContext)
        {
            this.aPIDBContext = aPIDBContext;
        }
        [HttpGet]
        [Route("action")]
        [Route("api/Employee/GetAllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            var Employees = await aPIDBContext.Employee.ToListAsync();
            return Ok(Employees);
        }
    }
}
