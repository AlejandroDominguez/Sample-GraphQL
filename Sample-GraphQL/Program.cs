using GraphQL;
using GraphQL.Http;
using GraphQL.Types;
using Sample_GraphQL.Service.Query;
using System;
using System.Threading.Tasks;

namespace Sample_GraphQL
{
    class Program
    {

        static void Main(string[] args)
        {
            MainAsync(args).Wait();
        }

        static async Task MainAsync(string[] args)
        {
            Console.WriteLine("[] GraphQL!");

            var schema = new Schema { Query = new StoreQuery() };

            var result = await new DocumentExecuter().ExecuteAsync(_ =>
            {
                _.Schema = schema;
                _.Query = @"
                query {
                  products {
                    id
                    name
                  }
                  product(id:1){
                    name
                    category {
                        id
                        name
                        image {
                            url
                            size
                        }            
                    }
                  }
                }
              ";
            }).ConfigureAwait(false);
            var json = new DocumentWriter(indent: true).Write(result);
            Console.WriteLine(json);
            Console.ReadLine();
        }
    }
}
