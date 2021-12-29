﻿using Registration.Models.Accounts;
using System;
using System.Collections.Generic;

namespace Registration.Services.Abstracts
{
    public interface IAccountService
    {
            AuthenticateResponse Authenticate(AuthenticateRequest model, string ipAddress);
            AuthenticateResponse RefreshToken(string token, string ipAddress);
            void RevokeToken(string token, string ipAddress);
            void Register(RegisterRequest model, string origin);
            void ForgotPassword(ForgotPasswordRequest model, string origin);
            void ValidateResetToken(ValidateResetTokenRequest model);
            void ResetPassword(ResetPasswordRequest model);
            IEnumerable<AccountResponse> GetAll();
            AccountResponse GetById(int id);
            AccountResponse Create(CreateRequest model);
            AccountResponse Update(int id, UpdateRequest model);
            void Delete(int id);
        
    }
}
