using System;

namespace Faker.Core.Extensions {
    public interface ITemplateStore
    {
        ITemplateContainer GetTemplateContainer(Uri @namespace);

        void StoreTemplate(Uri @namespace, ITemplate template);
    }
}