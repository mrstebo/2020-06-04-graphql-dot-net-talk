using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HotChocolate.DataLoader;
using Microsoft.EntityFrameworkCore;
using MyApi.Data.Entities;
using MyApi.Data.Repositories;

namespace MyApi.DataLoaders
{
    public class AuthorDataLoader : BatchDataLoader<long, Author>
    {
        private readonly IAuthorRepository _repository;

        public AuthorDataLoader(IAuthorRepository repository)
        {
            _repository = repository;
        }

        protected override async Task<IReadOnlyDictionary<long, Author>> LoadBatchAsync(IReadOnlyList<long> keys, CancellationToken cancellationToken)
        {
            var authors = await _repository.FindAll()
                .Where(x => keys.Contains(x.Id))
                .ToListAsync(cancellationToken);

            return authors.ToDictionary(x => x.Id);
        }
    }
}
