using System;
using System.Threading;
using System.Threading.Tasks;

namespace Faker.Core.Extensions {
    public interface ITemplateStore<T> where T : ITemplate
    {
        Task<ITemplateContainer<T>> GetTemplateContainerAsync(Uri @namespace, CancellationToken cancellationToken);

        Task StoreTemplateAsync(Uri @namespace, T template, CancellationToken cancellationToken);
        Task RemoveTemplateAsync(Uri @namespace, Guid id, CancellationToken cancellationToken);
        Task UpdateTemplateAsync(Uri @namespace, Guid id, T template, CancellationToken cancellationToken);
        Task DeleteContainerAsync(Uri @namespace, CancellationToken cancellationToken);


    }
}