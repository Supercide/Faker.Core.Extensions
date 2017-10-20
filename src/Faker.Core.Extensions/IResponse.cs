﻿using System.Collections.Generic;

namespace Faker.Core.Extensions {
    public interface IResponse
    {
        IReadOnlyDictionary<string, string> Metadata { get; set; }
        string Content { get; set; }
    }
}