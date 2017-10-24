using System.Collections.Generic;

namespace Faker.Core.Extensions {
    public interface IContentNegotiator
    {
        IRequest Negotiate(string requestContent, Dictionary<string, string> metadata);
    }
}