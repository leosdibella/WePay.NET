﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Settlement.Response;

namespace WePayApi.Settlement.Request
{
    public class AuthorizeRequest : Shared.WePayRequest<AuthorizeResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Settlement.Request.AuthorizeRequest";

        /// <summary>
        /// The unique ID returned by the Settlement Create call.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires SettlementBankId")]
        public long? SettlementBankId { get; set; }

        /// <summary>
        /// The unique ID of the account you want to look up.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires AccountId")]
        public long? AccountId { get; set; }
    }
}