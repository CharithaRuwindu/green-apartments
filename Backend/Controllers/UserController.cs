﻿using Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var userDTO = await _userService.RegisterUserAsync(model);
            return CreatedAtAction(nameof(GetUser), new { id = userDTO.Id }, userDTO);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(Guid id)
        {
            var userDTO = await _userService.GetUserByIdAsync(id);
            return userDTO != null ? Ok(userDTO) : NotFound();
        }
    }

    internal interface IUserService
    {
    }
}
