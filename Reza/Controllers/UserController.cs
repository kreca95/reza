using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Reza.API.Models.User;
using Reza.Application.Commands.User;
using Reza.Application.Helpers;
using Reza.Application.Queries.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reza.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IConfiguration _config;

        public UserController(IMediator mediator, IConfiguration config)
        {
            _mediator = mediator;
            _config = config;
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(Models.User.CreateUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
          
            var request = new CreateUserCommand(model.Email, model.FirstName, model.LastName,model.Password);

            var result = await _mediator.Send(request);
            if (result.StatusCode==200)
            {
                //var confirmationUrl = string.Format();
            }
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var request = new GetUsersQuery();
            var result = await _mediator.Send(request);
            var vm = new List<UserViewModel>();
            foreach (var item in result)
            {
                vm.Add(new UserViewModel { CreatedAt = item.CreatedAt, Email = item.Email, FirstName = item.FirstName, Id = item.Id, LastName = item.LastName });
            }
            return Ok(vm);
        }
    }
}
