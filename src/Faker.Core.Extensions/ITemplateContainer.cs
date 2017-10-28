using System;
using System.Collections.Generic;

namespace Faker.Core.Extensions {
    public interface ITemplateContainer<T> where T : ITemplate
    {
        Uri Namespace { get; }

        List<T> Templates { get; }
    }
}