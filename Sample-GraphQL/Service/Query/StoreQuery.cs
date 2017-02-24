using GraphQL.Types;
using Sample_GraphQL.Domain;
using Sample_GraphQL.Service.QueryTypes;
using System.Collections.Generic;
using System.Linq;

namespace Sample_GraphQL.Service.Query
{
    public class StoreQuery : ObjectGraphType
    {
        public StoreQuery()
        {
            Field<ListGraphType<ProductQueryType>>(
              "products",
              resolve: context => GetAll()
            );

            Field<ProductQueryType>(
              "product",
              arguments: new QueryArguments(new QueryArgument(typeof(IntGraphType)) {
                  Name = "id"
              }),
              resolve: context => Get(context.GetArgument<int>("id"))
            );
        }


        private IEnumerable<Product> GetAll()
        {
            return new List<Product>()
            {
                new Product
                {
                    ProductName = "Good box",
                    Discontinued = false,
                    ProductId = 1,
                    Category = new Category {
                        CategoryId = 1,
                        CategoryName = "Boxes",
                        Description = "All boxes",
                        Image = new Image
                        {
                            ImageId = 1,
                            ImageUrl = "https://www.store.box.com",
                            Size = ImageSize.Large,
                        }
                    }
                    
                },
                new Product
                {
                    ProductName = "Bad box",
                    Discontinued = true,
                    ProductId = 2
                }
            };
        }

        private Product Get(int productId)
        {
            return GetAll().First(x => x.ProductId == productId);
        }
    }
}
