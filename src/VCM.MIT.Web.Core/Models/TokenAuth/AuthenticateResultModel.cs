namespace VCM.MIT.Models.TokenAuth
{
    public class AuthenticateResultModel
    {
        public long UserId { get; set; }
        public bool IsChangePassword { get; set; }
        public int ExpireInSeconds { get; set; }
        public string AccessToken { get; set; }
        public string EncryptedAccessToken { get; set; }
        public string RefreshToken { get; set; }
        public int RefreshTokenExpireInSeconds { get; set; }
    }
}
