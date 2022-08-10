using Shop.Domain.Commands.Response;
using Shop.Domain.Commands.Requests;
using MediatR;

namespace Shop.Domain.Handlers;
public class CreateCustomerHandler : 
    IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
{
  public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, 
  CancellationToken cancellationToken)
  {
    //verifica se o cliente ja esta cadastrado
    /// valida os dados
    /// insere o cliente
    /// envoia email de boas vindas
    var result = new CreateCustomerResponse
    {      
      Id = Guid.NewGuid(),
       Name = "Vilson Pereira",
       Email = "vilsonamani@gmail.com",
       Date = DateTime.Now
    };

    return Task.FromResult(result);
  }
}
   
