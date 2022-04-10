namespace Project_Sun_1.Models;
// Класс описания отчета по осмотру питомца
public class MedicalReport : BaseModel
{
    public Guid PetId { get; set; }
    public Guid DoctorTd { get; set; }
    public virtual Pet Pet { get; set; }
    public virtual Doctor Doctor { get; set; }
}