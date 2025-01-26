﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyRecipeBook.Application.UseCases.User.Register;
using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;

namespace MyRecipeBook.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [ProducesResponseType(typeof(ResponseRegisteredUserJson),StatusCodes.Status201Created)]
    public class UserController : ControllerBase
    {

        [HttpPost]
        public IActionResult Register(RequestRegisterUseJson request)
        {
            var useCase = new RegisterUseCase();

            var result = useCase.Execute(request);

            return Created(string.Empty,result);
        }

    }
}
