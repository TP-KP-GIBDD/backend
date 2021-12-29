using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Registration.Entities;
using Registration.Models.Accounts;
using Registration.Services.Abstracts;
using Registration.Models.Docs;

namespace Registration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountsController : BaseController
    {
        private readonly IAccountService _accountService;
        private readonly IDocService _docService;
        private readonly IMapper _mapper;

        public AccountsController(
            IAccountService accountService,
            IDocService docService,
            IMapper mapper)
        {
            _accountService = accountService;
            _docService = docService;
            _mapper = mapper;
        }

        [HttpPost("authenticate")]
        public ActionResult<AuthenticateResponse> Authenticate(AuthenticateRequest model)
        {
            var response = _accountService.Authenticate(model, ipAddress());
            setTokenCookie(response.RefreshToken);
            return Ok(response);
        }

        [HttpPost("refresh-token")]
        public ActionResult<AuthenticateResponse> RefreshToken()
        {
            var refreshToken = Request.Cookies["refreshToken"];
            var response = _accountService.RefreshToken(refreshToken, ipAddress());
            setTokenCookie(response.RefreshToken);
            return Ok(response);
        }

        [Authorize]
        [HttpPost("revoke-token")]
        public IActionResult RevokeToken(RevokeTokenRequest model)
        {
            // принимаем токен из запроса или файла cookie
            var token = model.Token ?? Request.Cookies["refreshToken"];

            if (string.IsNullOrEmpty(token))
                return BadRequest(new { message = "Token is required" });

            // пользователи могут отозвать свои собственные токены, а администраторы могут отозвать любые токены
            if (!Account.OwnsToken(token) && Account.Role != Role.Admin)
                return Unauthorized(new { message = "Unauthorized" });

            _accountService.RevokeToken(token, ipAddress());
            return Ok(new { message = "Token revoked" });
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest model)
        {
            _accountService.Register(model, Request.Headers["origin"]);
            return Ok(new { message = "Registration successful" });
        }

        [HttpPost("forgot-password")]
        public IActionResult ForgotPassword(ForgotPasswordRequest model)
        {
            _accountService.ForgotPassword(model, Request.Headers["origin"]);
            return Ok(new { message = "Please check your email for password reset instructions" });
        }

        [HttpPost("validate-reset-token")]
        public IActionResult ValidateResetToken(ValidateResetTokenRequest model)
        {
            _accountService.ValidateResetToken(model);
            return Ok(new { message = "Token is valid" });
        }

        [HttpPost("reset-password")]
        public IActionResult ResetPassword(ResetPasswordRequest model)
        {
            _accountService.ResetPassword(model);
            return Ok(new { message = "Password reset successful, you can now login" });
        }

        [Authorize(Role.Admin)]
        [HttpGet]
        public ActionResult<IEnumerable<AccountResponse>> GetAll()
        {
            var accounts = _accountService.GetAll();
            return Ok(accounts);
        }

        [Authorize]
        [HttpGet("{id:int}")]
        public ActionResult<AccountResponse> GetById(int id)
        {
            //пользователи могут получить свою собственную учетную запись, а администраторы могут получить любую учетную запись
            if (id != Account.Id && Account.Role != Role.Admin)
                return Unauthorized(new { message = "Unauthorized" });

            var account = _accountService.GetById(id);
            return Ok(account);
        }

        [Authorize(Role.Admin)]
        [HttpPost]
        public ActionResult<AccountResponse> Create(CreateRequest model)
        {
            var account = _accountService.Create(model);
            return Ok(account);
        }

        [Authorize]
        [HttpPut("{id:int}")]
        public ActionResult<AccountResponse> Update(int id, UpdateRequest model)
        {
            // пользователи могут обновлять свою собственную учетную запись, а администраторы могут обновлять любую учетную запись
            if (id != Account.Id && Account.Role != Role.Admin)
                return Unauthorized(new { message = "Unauthorized" });

            // только администраторы могут изменить роль
            if (Account.Role != Role.Admin)
                model.Role = null;

            var account = _accountService.Update(id, model);
            return Ok(account);
        }

        [Authorize]
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            // пользователи могут удалить свою собственную учетную запись, а администраторы могут удалить любую учетную запись
            if (id != Account.Id && Account.Role != Role.Admin)
                return Unauthorized(new { message = "Unauthorized" });

            _accountService.Delete(id);
            return Ok(new { message = "Account deleted successfully" });
        }

        [Authorize]
        [HttpPost("addPassport")]
        public IActionResult addPassport (PassportRequest model)
        {
            _docService.AddPassport(model, Request.Headers["origin"]);
            return Ok(new { message = "Added passport" });
        }

        [Authorize]
        [HttpPost("addDriverLicence")]
        public IActionResult addDriverLicence(DriverLicenceRequest model)
        {
            _docService.AddDriverLicence(model, Request.Headers["origin"]);
            return Ok(new { message = "Added driver licence" });
        }

        [Authorize(Role.Admin)]
        [HttpPost("addIdentityCard")]
        public IActionResult addIdentityCard(IdentityCardRequest model)
        {
            _docService.AddIdentityCard(model, Request.Headers["origin"]);
            return Ok(new { message = "Added identity card" });
        }

        [Authorize]
        [HttpPut("/UpdatePassport/{id:int}")]
        public ActionResult<PassportResponce> UpdatePassport(int id, PassportRequest model)
        {
            var passport = _docService.UpdatePassport(id, model);
            return Ok(passport);
        }

        [Authorize]
        [HttpPut("/UpdateDriverLicence/{id:int}")]
        public ActionResult<DriverLicenceResponce> UpdateDriverLicence(int id, DriverLicenceRequest model)
        {
            var driverLicence = _docService.UpdateDriverLicence(id, model);
            return Ok(driverLicence);
        }

        [Authorize(Role.Admin)]
        [HttpPut("/UpdateIdentityCard/{id:int}")]
        public ActionResult<IdentityCardResponce> UpdateIdentityCard(int id, IdentityCardRequest model)
        {
            var identityCard = _docService.UpdateIdentityCard(id, model);
            return Ok(identityCard);
        }

        private void setTokenCookie(string token)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.UtcNow.AddDays(7)
            };
            Response.Cookies.Append("refreshToken", token, cookieOptions);
        }

        private string ipAddress()
        {
            if (Request.Headers.ContainsKey("X-Forwarded-For"))
                return Request.Headers["X-Forwarded-For"];
            else
                return HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
        }
    }
}
