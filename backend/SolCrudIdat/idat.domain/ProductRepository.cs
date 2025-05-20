using idat.entities;
using idat.shared;

namespace idat.domain;

public class ProductRepository : CommonOperationDataBases<Product>
{
    public async Task Delete(object id)
    {
        throw new NotImplementedException();
    }

    public async Task<Product> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<Product> GetById(object id)
    {
        throw new NotImplementedException();
    }

    public async Task<Product> Save(Product entity)
    {
        throw new NotImplementedException();
    }

    public async Task<Product> Update(Product entity)
    {
        throw new NotImplementedException();
    }
}
