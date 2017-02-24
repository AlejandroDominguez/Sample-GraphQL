using GraphQL.Types;
using Sample_GraphQL.Domain;

namespace Sample_GraphQL.Service.QueryTypes
{
    public  class ImageQueryType : ObjectGraphType<Image>
    {
        public ImageQueryType()
        {
            Field("id", x => x.ImageId).Description("The ID of the image");
            Field("url", x => x.ImageUrl).Description("Full image url");
            Field("width", x => x.ImageUrl).Description("Image width");
            Field("size", x => x.Size,type: typeof(EnumerationGraphType<ImageSize>)).Description("Image size");
        }
    }
}