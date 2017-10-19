using System.Collections.Generic;

namespace Faker.Core.Extensions
{
    public interface IRequest
    {
        IReadOnlyDictionary<string, string> Metadata { get; set; }
        string GetPropertyValueBy(string path);
        string GetPropertyValueBy(int index);
        IEnumerable<string> GetProperties();
    }
}
