using GraphQL.Types;
using Sample_GraphQL.Domain;

namespace Sample_GraphQL.Service.QueryTypes
{
    public class ProductQueryType : ObjectGraphType<Product>
    {
        public ProductQueryType()
        {
            Field("id", x => x.ProductId).Description("The ID of the product");
            Field("name", x => x.ProductName, nullable: true).Description("Name of the product");
            Field("discontinued", x => x.Discontinued, nullable: false).Description("If product is descontinuated");
            Field("category", x => x.Category, type: typeof(CategoryQueryType)).Description("If product is descontinuated");
        }
    }


}
