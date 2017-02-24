using GraphQL.Types;
using Sample_GraphQL.Domain;

namespace Sample_GraphQL.Service.QueryTypes
{
    public class CategoryQueryType : ObjectGraphType<Category>
    {
        public CategoryQueryType()
        {
            Field("id",x => x.CategoryId).Description("The ID of the category");
            Field("name",x => x.CategoryName,nullable: true).Description("Name of the category");
            Field("description", x => x.Description, nullable: true).Description("The description of the category");
            Field("image", x => x.Image, nullable: false,type: typeof(ImageQueryType)).Description("The image of the category");

        }
    }


}
