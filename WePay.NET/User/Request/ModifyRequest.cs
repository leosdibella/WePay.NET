﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Shared;
using WePay.User.Response;

namespace WePay.User.Request
{
    public class ModifyRequest : WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePay.User.Request.ModifyRequest";

        /// <summary>
        /// The callback URI where you want to receive IPNs. Must be a full URI.
        /// </summary>
        [StringLength(2083, ErrorMessage = Identifier + " - CallbackUri cannot exceed 2083 characters")]
        public string CallbackUri { get; set; }
    }
}