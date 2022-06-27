using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reza.API.Models.Auth;
using Reza.Application.Helpers;
using Reza.Application.Queries.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reza.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }
            GetUserByEmailQuery query = new GetUserByEmailQuery(model.Email);
            var user = await _mediator.Send(query);
            var cryptographyProcessor = new CryptographyProcessor();
            var check = cryptographyProcessor.AreEqual(model.Password, user.PasswordHash, user.Salt);

            return Ok(check);
        }
    }
}
