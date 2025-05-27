using idat.shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idat.domain;

public class UnitOfWork : IUnitOfWork
{
    private readonly DbContext _context;
    private Dictionary<Type, object> _repository;

    public UnitOfWork(DbContext context)
    {
        _context = context;
        _repository = new Dictionary<Type, object>();
    }

    public ICommonOperationDataBases<GenericObject> GetRepository<GenericObject>() where GenericObject : class
    {
        if (_repository.ContainsKey(typeof(GenericObject)))
        {
            return (ICommonOperationDataBases<GenericObject>)_repository[typeof(GenericObject)];
        }

        var repository = new CommonOperationDataBases<GenericObject>(_context);
        _repository.Add(typeof(GenericObject), repository);
        return repository;
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}
