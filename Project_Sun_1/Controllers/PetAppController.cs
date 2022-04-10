using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_Sun_1.Models;

namespace Project_Sun_1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class PetAppController : ControllerBase
    {
        [ApiController]
        [Route("[controller]")]
        public class MainController : ControllerBase
        {
            private IService RepairService { get; set; }
            private BaseRepository<MedicalReport> Documents { get; set; }

            public MainController(IService repairService, BaseRepository<MedicalReport> document)
            {
                RepairService = repairService;
                Documents = document;
            }

            [HttpGet]
            public JsonResult Get()
            {
                return new JsonResult(Documents.GetAll());
            }

            [HttpPost]
            public JsonResult Post()
            {
                RepairService.Work();
                return new JsonResult("Отчет по осмотру создан!");
            }

        }
    }
}