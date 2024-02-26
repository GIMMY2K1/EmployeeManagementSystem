namespace ServerLibrary.Helpers;

public interface JwtSection
{
    public string? Key { get; set; }
    public string? Issuer { get; set; }
    public string? Audience { get; set; }
}
