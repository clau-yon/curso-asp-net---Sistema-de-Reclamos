using Microsoft.AspNetCore.Mvc;
using WebApplicationSistemaDeReclamos.Models.Dtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationSistemaDeReclamos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        // GET: api/<CustomersController>
        [HttpGet]
        public IEnumerable<CustomerDto> Get()
        {
            List<CustomerDto> customerDtos = new List<CustomerDto>();
            customerDtos.Add(new CustomerDto(1, "cliente1", "cliente1@cliente.com", "444444", "text"));
            customerDtos.Add(new CustomerDto(2, "cliente2", "cliente2@cliente.com", "544444", "text"));
            customerDtos.Add(new CustomerDto(3, "cliente3", "cliente3@cliente.com", "644444", "text"));
            
            return customerDtos;
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id == 1)
            {
                return NotFound();
            }
            CustomerDto customerDto = new CustomerDto(id,"cliente1", "cliente1@cliente.com", "444444", "text");
            return Ok(customerDto);
        }

        // POST api/<CustomersController>
        [HttpPost]
        public IActionResult Post([FromBody] CustomerDto value)
        {
            return Created("/Api/Customers/99", value);
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public CustomerDto Put(int id, [FromBody] CustomerDto value)
        {
            return value;
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
