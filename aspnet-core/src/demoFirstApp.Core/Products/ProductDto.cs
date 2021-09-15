using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace demoFirstApp.Products
{
    [AutoMapFrom(typeof(Product))]
    public class ProductDto : EntityDto<int>
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

    }
}
