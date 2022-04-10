namespace Project_Sun_1.Repositorium.InterfaceRep;

public interface InterfaceRep<TDbModel> 
{
    public List<TDbModel> GetAll();
    public TDbModel Get(Guid id);
    public TDbModel Create(TDbModel model);
    public TDbModel Update(TDbModel model);
    public void Delete(Guid id);
}