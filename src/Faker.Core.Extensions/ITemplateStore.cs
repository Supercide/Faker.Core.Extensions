using System;

namespace Faker.Core.Extensions {
    public interface ITemplateStore<T> where T : ITemplate
    {
        ITemplateContainer<T> GetTemplateContainer(Uri @namespace);

        void StoreTemplate(Uri @namespace, T template);
    }
}