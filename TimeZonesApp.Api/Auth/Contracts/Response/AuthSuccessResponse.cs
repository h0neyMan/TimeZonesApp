﻿using System;

namespace TimeZonesApp.Api.Auth.Contracts.Response
{
    public class AuthSuccessResponse
    {
        public string Token { get; set; }
        
        public Guid RefreshToken { get; set; }
    }
}
