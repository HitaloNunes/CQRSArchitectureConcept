using CQRSArchitectureConcept.Domain.Commands.Responses;
using MediatR;

namespace CQRSArchitectureConcept.Domain.Commands.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
