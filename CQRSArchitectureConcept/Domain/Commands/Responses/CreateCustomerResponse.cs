namespace CQRSArchitectureConcept.Domain.Commands.Responses
{
    public class CreateCustomerResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "Hitalo Nunes";
        public string Email { get; set; } = "hitalowingred@hotmail.com";
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
