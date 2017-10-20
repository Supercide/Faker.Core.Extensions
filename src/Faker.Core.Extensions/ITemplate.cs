namespace Faker.Core.Extensions {
    public interface ITemplate
    {
        IRequest Request { get; set; }
        IResponse Response { get; set; }
    }
}