﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Shared;

namespace WePay.Risk.Structure.Rbit.RbitProperties
{
    public class ExternalAccountRbitProperties : RbitProperties
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Risk.Structure.Rbit.RbitProperties.ExternalAccountRbitProperties";

        /// <summary>
        /// Not an API field, only use for validating requests, mainly for testing purposes
        /// </summary>
        [JsonIgnore]
        public override string RbitType
        {
            get
            {
                return RbitTypeContainer;
            }
            set
            {
                RbitTypeContainer = Common.RbitTypes.ExternalAccount;
            }
        }

        /// <summary>
        /// (Enumeration of these values can be found in WePay.Risk.Common.IsPartnerAccountOptions)
        /// </summary>
        [ValidateWePayValue(IsRequired = true, ErrorMessage = Identifier, WePayValuesClassName = "WePay.Risk.Common.IsPartnerAccountOptions")]
        public string IsPartnerAccount { get; set; }

        /// <summary>
        /// Name of the provider of the account.
        /// If this is an account controlled by you, set this parameter to the name of the company where the account was created
        /// (Enumeration of these values can be found in WePay.Risk.Common.ExternalAccountTypes)
        /// </summary>
        [ValidateWePayValue(IsRequired = true, ErrorMessage = Identifier, WePayValuesClassName = "WePay.Risk.Common.ExternalAccountTypes")]
        public string AccountType { get; set; }

        /// <summary>
        /// The user's ID of the external account.
        /// </summary>
        public long? UserId { get; set; }

        /// <summary>
        /// The user's profile URL on the external service.
        /// </summary>
        [StringLength(255, ErrorMessage = Identifier + " - Uri cannot exceed 255 characters")]
        public string Uri { get; set; }

        /// <summary>
        /// The Unix timestamp when external account was created (unix seconds since Jan 1st 1970 UTC).
        /// </summary>
        public long? CreateTime { get; set; }

        /// <summary>
        /// The Unix timestamp when external account was modified (unix seconds since Jan 1st 1970 UTC).
        /// </summary>
        public long? ModifyTime { get; set; }

        /// <summary>
        /// The number of people the user is following (Twitter) or has in his/her circles (Google+).
        /// </summary>
        public int? Following { get; set; }

        /// <summary>
        /// The number of followers (Twitter) or the number of members in his/her circles (Google+).
        /// </summary>
        public int? Followers { get; set; }

        /// <summary>
        /// The number of friends (Facebook) or connections (LinkedIn).
        /// </summary>
        public int? Connections { get; set; }

        /// <summary>
        /// Number of times this user has received feedback.
        /// </summary>
        public int? FeedbackScoresProvided { get; set; }

        /// <summary>
        /// Percentage of feedback which is positive (for positive / negative scoring systems).
        /// </summary>
        public float? FeedbackScorePercentPositive { get; set; }

        /// <summary>
        /// Average feedback score for this user (for star rating feedback systems) normalized between 0.0 (worst) and 1.0 (best).
        /// </summary>
        public float? FeedbackAverageScore { get; set; }

        public ExternalAccountRbitProperties()
        {
            RbitTypeContainer = Common.RbitTypes.ExternalAccount;
        }
    }
}