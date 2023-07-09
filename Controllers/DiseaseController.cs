using ExcellProgramTest.Data;
using ExcellProgramTest.Entites;
using Microsoft.AspNetCore.Mvc;

namespace ExcellProgramTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiseaseController : BaseController<DiseaseInformation>
    {
        public DiseaseController(IRepository<DiseaseInformation> repository) : base(repository)
        {
            
        }
    }
}
