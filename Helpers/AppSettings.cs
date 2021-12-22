namespace Registration.Helpers
{
    public class AppSettings
    {
        public string Secret { get; set; }

        // время обновления токена (в днях)
        // неактивные токены автоматически удаляются из базы данных по истечении этого времени
        public int RefreshTokenTTL { get; set; }

        public string EmailFrom { get; set; }
        public string SmtpHost { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpUser { get; set; }
        public string SmtpPass { get; set; }
    }
}