using ExcellProgramTest.Data;
using ExcellProgramTest.Entites;
using Microsoft.AspNetCore.Mvc;

namespace ExcellProgramTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientInfoController : BaseController<PatientInfo>
    {
        public PatientInfoController(IRepository<PatientInfo> repository) : base(repository)
        {
            
        }

    }
}
