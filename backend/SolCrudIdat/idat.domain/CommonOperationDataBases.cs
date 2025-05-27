using idat.shared;
using Microsoft.EntityFrameworkCore;

namespace idat.domain;
public class CommonOperationDataBases<GenericObject> : ICommonOperationDataBases<GenericObject> where GenericObject : class
{

    //ADO.NET | Dapper | NHibernate | EntityFramework
    private readonly DbContext _context;
    private readonly DbSet<GenericObject> _set;

    public CommonOperationDataBases(DbContext context) {
        _context = context;
        _set = context.Set<GenericObject>();
    }

    public async Task Delete(object id)
    {
        
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<GenericObject>> GetAll()
    {
        return await _set.ToListAsync();
    }

    public async Task<GenericObject> GetById(object id)
    {
        return await _set.FindAsync(id);
    }

    public async Task<GenericObject> Save(GenericObject entity)
    {
        await _set.AddAsync(entity);
        return entity;
    }

    public async Task<GenericObject> Update(GenericObject entity)
    {
        throw new NotImplementedException();
    }
}
