namespace idat.shared;

public interface CommonOperationDataBases<GenericObject> where GenericObject : class
{
    Task<GenericObject> GetAll();
    Task<GenericObject> GetById(object id);
    Task<GenericObject> Save(GenericObject entity);
    Task<GenericObject> Update(GenericObject entity);
    Task Delete(object id);
}
