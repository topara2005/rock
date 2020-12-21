using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arch.EntityFrameworkCore.UnitOfWork;
using Domain.Entities;
using EBC.Demo.App.Application.Features.Products.Commands.UpdateProduct;
using EBC.Demo.App.Application.Features.Products.Queries.GetAllProducts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebTestApp.Controllers
{
    [ApiVersion("1.0")]
    public class ArticlesController : BaseApiController
    {
       
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var res = await Mediator.Send(new GetAllArticlesQuery() { PageSize = 100000, PageNumber = 1 });
            //Just for sake of demo 
            return Ok(res.Data);
        }

        [HttpPut("{id}")]

        public async Task<IActionResult> Put(int id)
        {
            if (id <0)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(new UpdateArticleCounterCommand {  Id= id }));
        }
    }
}
