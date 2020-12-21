using Application.Wrappers;
using Arch.EntityFrameworkCore.UnitOfWork;
using Domain.Entities;

using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EBC.Demo.App.Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateArticleCounterCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }
        
       
        public class UpdateProductCommandHandler : IRequestHandler<UpdateArticleCounterCommand, Response<int>>
        {
           
         
            private readonly IUnitOfWork _uo;

            public UpdateProductCommandHandler(IUnitOfWork uo)
            {
              
                _uo = uo;
            }
           

            public async Task<Response<int>> Handle(UpdateArticleCounterCommand request, CancellationToken cancellationToken)
            {
               var repo =  _uo.GetRepository<Article>();
                var article = await repo.FindAsync(request.Id);

                if (article == null)
                {
                    throw new Exception($"Article Not Found.");
                }
                else
                {
                    article.LikesNum++;

                    repo.Update(article);
                    _uo.SaveChanges();
                    return new Response<int>(article.LikesNum);
                }
            }
        }
    }
}
