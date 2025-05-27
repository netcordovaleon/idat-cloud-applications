namespace idat.shared;

public interface ICommonOperationDataBases<GenericObject> where GenericObject : class
{
    Task<IEnumerable<GenericObject>> GetAll();
    Task<GenericObject> GetById(object id);
    Task<GenericObject> Save(GenericObject entity);
    Task<GenericObject> Update(GenericObject entity);
    Task Delete(object id);
}
