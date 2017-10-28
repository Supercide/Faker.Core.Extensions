using System.Collections.Generic;

namespace Faker.Core.Extensions {
    public interface ITemplate
    {
        IReadOnlyDictionary<string, string> Properties { get; }

        IReadOnlyDictionary<string, string> Metadata { get; }

        string Response { get; }
    }
}