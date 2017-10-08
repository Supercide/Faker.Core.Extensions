using System;

namespace Fake.Core.Extensions {
    public interface ITemplateStore
    {
        ITemplate[] GetTemplates(Uri @namespace);
    }
}