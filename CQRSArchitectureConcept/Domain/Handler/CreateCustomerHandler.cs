using CQRSArchitectureConcept.Domain.Commands.Requests;
using CQRSArchitectureConcept.Domain.Commands.Responses;
using MediatR;

namespace CQRSArchitectureConcept.Domain.Handler
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            // Verifica se o Cliente Já está cadastrado
            // Valida os dados
            // Insere o Cliente
            // Envia o e-mail de boas vindas
            var result = new CreateCustomerResponse()
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Email = request.Email
            };

            return Task.FromResult(result);
        }
    }
}
