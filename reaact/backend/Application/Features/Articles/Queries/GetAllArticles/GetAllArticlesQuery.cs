
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Wrappers;
using Application.Dtos;
using Arch.EntityFrameworkCore.UnitOfWork;
using Domain.Entities;

namespace EBC.Demo.App.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllArticlesQuery : IRequest<PagedResponse<IEnumerable<ArticleItemDto>>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
    public class GetAllArticlesQueryHandler : IRequestHandler<GetAllArticlesQuery, PagedResponse<IEnumerable<ArticleItemDto>>>
    {
        private readonly IRepository<Article> _repo;
        private readonly IMapper _mapper;
        public GetAllArticlesQueryHandler(IUnitOfWork uo, IMapper mapper)
        {
            _repo = uo.GetRepository<Article>();
            _mapper = mapper;
        }

        public async Task<PagedResponse<IEnumerable<ArticleItemDto>>> Handle(GetAllArticlesQuery request, CancellationToken cancellationToken)
        {
            var articlesPage = await _repo.GetPagedListAsync(pageSize: request.PageSize, pageIndex: request.PageNumber);
             
            var articlesDto = _mapper.Map<IEnumerable<ArticleItemDto>>(articlesPage.Items);
            return new PagedResponse<IEnumerable<ArticleItemDto>>(articlesDto, articlesPage.PageIndex, articlesPage.PageSize);
        }
    }
}
