using System;

namespace VCM.MIT
{
    public class AppConsts
    {
        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public const string DefaultPassPhrase = "gsKxGZ012HLL3MI5";
        public static string UserIdentifier = "user_identifier";
        public const string TokenType = "token_type";

        public static TimeSpan AccessTokenExpiration = TimeSpan.FromMinutes(30);
        public static TimeSpan RefreshTokenExpiration = TimeSpan.FromDays(365);

        public const string DateTimeOffsetFormat = "yyyy-MM-ddTHH:mm:sszzz";
        public const int DefaultPageSize = 10;
        public const int MaxPageSize = 1000;
    }
}
