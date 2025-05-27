namespace idat.shared;

public interface IUnitOfWork
{
    ICommonOperationDataBases<GenericObject> GetRepository<GenericObject>() where GenericObject : class;
    void SaveChanges();

}
