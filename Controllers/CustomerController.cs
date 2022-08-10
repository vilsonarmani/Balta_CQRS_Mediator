using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.Response;
using Shop.Domain.Commands.Requests;
using MediatR;

namespace Shop.Controllers;

[ApiController, Route("v1/Customers")]
public class CustomerController : ControllerBase
{
    [HttpPost, Route("")]    
    public Task<CreateCustomerResponse> Create(
        [FromServices] IMediator mediator,
        [FromBody] CreateCustomerRequest command)
    {
        return mediator.Send(command);
    }

    /// outra forma
    /*
    public Task<CreateCustomerResponse> Create(
      [FromServices] IMediator mediator,
      [FromBody] CreateCustomerRequest command) => mediator.Send(command);
    */
}
