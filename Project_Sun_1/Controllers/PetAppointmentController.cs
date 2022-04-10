using Microsoft.AspNetCore.Mvc;

namespace Project_Sun_1.Controllers;

[ApiController]
[Route("[controller]")]
public class PetAppointmentController : ControllerBase
{
    private readonly ILogger<PetAppointmentController> _logger;

    public PetAppointmentController(ILogger<PetAppointmentController> logger)
    {
        _logger = logger;
    }
}