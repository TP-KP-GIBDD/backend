using Registration.Models.Accounts;
using Registration.Models.Docs;

namespace Registration.Services.Abstracts
{
    public interface IDocService
    {
        void AddPassport(PassportRequest model, string origin);
        void AddDriverLicence(DriverLicenceRequest model, string origin);
        void AddIdentityCard(IdentityCardRequest model, string origin);

        PassportResponce UpdatePassport(int id, PassportRequest model);
        DriverLicenceResponce UpdateDriverLicence(int id, DriverLicenceRequest model);
        IdentityCardResponce UpdateIdentityCard(int id, IdentityCardRequest model);
    }
}
