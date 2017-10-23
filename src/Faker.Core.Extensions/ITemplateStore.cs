﻿using System;

namespace Faker.Core.Extensions {
    public interface ITemplateStore
    {
        ITemplate[] GetTemplates(Uri @namespace);

        void StoreTemplate(ITemplate template);
    }
}