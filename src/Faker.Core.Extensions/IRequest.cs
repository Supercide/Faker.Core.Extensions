using System.Collections.Generic;

namespace Faker.Core.Extensions
{
    public interface IRequest
    {
        string RawContent { get; }
        IReadOnlyDictionary<string, string> Metadata { get; }
        string GetPropertyValueBy(string path);
        string GetPropertyValueBy(int index);
        IEnumerable<string> GetProperties();
    }
}
