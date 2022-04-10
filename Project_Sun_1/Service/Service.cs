using Project_Sun_1.Models;
using Project_Sun_1.Repositorium.InterfaceRep;
// Сервис-имитация работы врача.
// Создаются случайные имена животных, врачей, их специализация, а также отчет об осмотре питомца.
public class Service : IService
{
    private InterfaceRep<MedicalReport> Documents { get; set; }
    private InterfaceRep<Doctor> Doctors { get; set; }
    private InterfaceRep<Pet> Pets { get; set; }

    public void Work()
    {
        var PetId = new Guid();
        var DoctorId = new Guid();

        List<string> petNames = new List<string>();
        petNames.Add("Toby");
        petNames.Add("Ann");
        petNames.Add("Kitty");
        petNames.Add("Tom");
        
        List<string> animalsList = new List<string>();
        animalsList.Add("Cat");
        animalsList.Add("Dog");
        animalsList.Add("Rabbit");
        animalsList.Add("Mice");
        
        Random randNum = new Random();
        int petNamesPos = randNum.Next(petNames.Count);
        Random randNum2 = new Random();
        int animalNamesPos = randNum2.Next(animalsList.Count);
        Random randNum3 = new Random();
        
        Pets.Create(new Pet
        {
            Id = PetId,
            Name = petNames[petNamesPos],
            Animal = animalsList[animalNamesPos],
            Age = randNum3.Next()
        });

        List<string> doctorsList = new List<string>();
        doctorsList.Add("Dr.Jenny");
        doctorsList.Add("Dr.Eiza");
        doctorsList.Add("Dr.Alex");
        doctorsList.Add("Dr.Mike");
        
        Random randNum4 = new Random();
        int doctorNamePos = randNum4.Next(doctorsList.Count);
        
        List<string> specList = new List<string>();
        specList.Add("Surgeon");
        specList.Add("Dentist");
        specList.Add("Therapist");
        specList.Add("Ophthalmologist");
        
        Random randNum5 = new Random();
        int specPos = randNum4.Next(specList.Count);
        
        Random rand = new Random();
        Doctors.Create(new Doctor
        {
            Id = DoctorId,
            Name = doctorsList[doctorNamePos],
            Specialization = specList[specPos],
            Phone = String.Format($"8912{rand.Next()}{rand.Next()}{rand.Next()}{rand.Next()}{rand.Next()}{rand.Next()}{rand.Next()}")
        });

        var pet = Pets.Get(PetId);
        var doctor = Doctors.Get(DoctorId);

        Documents.Create(new MedicalReport() {
            PetId = pet.Id,
            DoctorTd = doctor.Id,
            Pet = pet,
            Doctor = doctor
        });
    }
}