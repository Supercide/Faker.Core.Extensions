using System.Collections.Generic;

namespace Faker.Core.Extensions {
    public interface ITemplate
    {
        Dictionary<string, string> Properties { get; }

        Dictionary<string, string> Metadata { get; }

        string Response { get; }
    }
}