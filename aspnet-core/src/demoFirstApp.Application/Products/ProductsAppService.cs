using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoFirstApp.Products
{
    public class ProductsAppService : CrudAppService<Product, ProductDto>
    {
        public ProductsAppService(IRepository<Product, int> repository) : base(repository)
        {

        }
    }
}
