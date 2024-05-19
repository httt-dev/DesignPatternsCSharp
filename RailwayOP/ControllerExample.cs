using Microsoft.AspNetCore.Mvc;

namespace RailwayOP
{
    public class ControllerExampleController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] TicketRequest r)
        {
            return new Validation().ValidateAmountNumber(r.AccountNumber)
                .Bind(_ => new Validation().ValidateAmount(r.Amount))
                .Handle(this);
        }
    }
}