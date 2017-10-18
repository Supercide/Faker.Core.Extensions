namespace Faker.Core.Extensions {
    public interface ITemplate
    {
        IRequest Request { get; set; }
        string Response { get; set; }
    }
}