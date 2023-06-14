using CQRSArchitectureConcept.Domain.Commands.Requests;
using CQRSArchitectureConcept.Domain.Commands.Responses;
using CQRSArchitectureConcept.Domain.Handler;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRSArchitectureConcept.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator mediator;
        public CustomerController (IMediator _mediator)
        {
            mediator = _mediator;
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<CreateCustomerResponse> Create([FromBody] CreateCustomerRequest command)
        {
            return await mediator.Send(command);
        }
    }
}
