﻿using Newtonsoft.Json;
using System;

namespace Nop.Plugin.Payments.bKashAdvance.Models
{
    public class GrantTokenResponseModel
    {
        [JsonProperty(PropertyName = "token_type")]
        public string TokenType { get; set; }

        [JsonProperty(PropertyName = "id_token")]
        public string IdToken { get; set; }

        [JsonProperty(PropertyName = "expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty(PropertyName = "refresh_token")]
        public string RefreshToken { get; set; }

        public DateTime TokenCreateTime { get; set; }
    }
}
