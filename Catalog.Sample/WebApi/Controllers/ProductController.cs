using Catalog.Sample.Domain.Core.Entity;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Sample.WebApi.Controllers
{
    public class ProductController : LiquidCrudExample.WebApi.Controllers.GenericCrudController<Product, int>
    {
        public ProductController(IMediator mediator) : base(mediator) { }
    }
}
