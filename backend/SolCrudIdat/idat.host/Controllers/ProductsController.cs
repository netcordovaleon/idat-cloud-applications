using idat.entities;
using idat.services;
using Microsoft.AspNetCore.Mvc;

namespace idat.host.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductServices _productServices;
    public ProductsController(IProductServices productServices)
    {
        _productServices = productServices;
    }


    [Route("{id}")]
    [HttpGet]
    public Product Get(int id) {
        throw new NotImplementedException();
    }

    [Route("")]
    [HttpGet]
    public async Task< IEnumerable<Product>> GetProducts() {
       return  await _productServices.GetAll();
    }


    [Route("")]
    [HttpPost]
    public async Task<Product> SaveProduct(Product entity)
    {
        return await _productServices.SaveProduct(entity);
    }

    [Route("")]
    [HttpPatch]
    public Product UpdateProduct(Product entity)
    {
        throw new NotImplementedException();
    }

    [Route("{id}")]
    [HttpDelete]
    public Product DeleteProduct(int id)
    {
        throw new NotImplementedException();
    }

}

