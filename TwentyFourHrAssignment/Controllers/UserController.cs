﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TwentyFour.Models;
using TwentyFour.Services;

namespace TwentyFourHrAssignment.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {
        private UserServices CreateUserService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var userService = new UserServices(userId);
            return userService;
        }
        public IHttpActionResult Get()
        {
            UserServices userService = CreateUserService();
            var users = userService.GetUsers();
            return Ok(users);
        }
        public IHttpActionResult Post(UserCreate user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateUserService();

            if (!service.CreateUser(user))
                return InternalServerError();

            return Ok();
        }
    }
}
