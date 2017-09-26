﻿namespace WePayApi.Shared.Common
{
    /// <summary>
    /// All possible types of errors which can be returned from WePay
    /// </summary>
    public class ErrorCategories : WePayValues<ErrorCategories>
    {
        public enum Indices : int
        {
            InvalidRequest,
            AccessDenied,
            InvalidScope,
            InvalidClient,
            ProcessingError
        }

        /// <summary>
        /// The API call had a malformed URI, or incorrect or invalid parameters.
        /// </summary>
        public const string InvalidRequest = "invalid_request";

        /// <summary>
        /// The API call tried to access a resource that it does not have permission to access.
        /// </summary>
        public const string AccessDenied = "access_denied";

        /// <summary>
        /// The API call provided non existent permissions in a scope parameter.
        /// </summary>
        public const string InvalidScope = "invalid_scope";

        /// <summary>
        /// The API call provided a ClientId for a client that does not exist, or has been disabled.
        /// </summary>
        public const string InvalidClient = "invalid_client";

        /// <summary>
        /// There was an error on WePay’s end.
        /// If you receive this message, please contact api@wepay.com (https://developer.wepay.com/api/general/api@wepay.com). 
        /// </summary>
        public const string ProcessingError = "processing_error";
    }
}