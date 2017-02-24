namespace Sample_GraphQL.Domain
{
    public class Image
    {
        public int ImageId { get; set; }
        public string ImageUrl { get; set; }
        public ImageSize Size { get; set; }
        public int Width { get { return (int)Size; } }
    }

    public enum ImageSize
    {
        Short = 45,
        Medium = 120,
        Large = 180
    }
}
