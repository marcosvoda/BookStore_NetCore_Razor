using Microsoft.AspNetCore.Authorization;
using Sideas.BookStore.Dto;
using Sideas.BookStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Sideas.BookStore.Services
{
    [Authorize]
    public class AuthorAppService : ApplicationService, IAuthorAppService
    {
        public Task<AuthorDto> CreateAsync(CreateUpdateBookDto input)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<AuthorDto> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultDto<AuthorDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            throw new NotImplementedException();
        }

        public Task<AuthorDto> UpdateAsync(Guid id, CreateUpdateBookDto input)
        {
            throw new NotImplementedException();
        }
    }
}
