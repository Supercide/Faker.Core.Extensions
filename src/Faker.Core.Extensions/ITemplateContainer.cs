using System;
using System.Collections.Generic;

namespace Faker.Core.Extensions {
    public interface ITemplateContainer<out T> where T : ITemplate
    {
        Uri Namespace { get; }

        IEnumerable<T> Templates { get; }
    }
}