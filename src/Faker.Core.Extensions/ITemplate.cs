using System.Collections.Generic;

namespace Faker.Core.Extensions {
    public interface ITemplate
    {
        string Request { get; set; }
        string Response { get; set; }

        IList<string> GetProperties();
        string MergeFields(IEnumerable<IMergeField> mergeFields);
    }
}