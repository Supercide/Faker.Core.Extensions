using System;
using System.Collections.Generic;

namespace Faker.Core.Extensions {
    public interface ITemplateContainer
    {
        Uri Namespace { get; }

        IEnumerable<ITemplate> Templates { get; }
    }
}