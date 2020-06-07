using Solidariedade.Domain.Entities;

namespace Solidariedade.Application.Interfaces
{
    public interface ISessionApp
    {
        void SetSessionUser(string email);
        bool IsNewUser();
        bool IsCurrentUserADonator();
        bool IsCurrentUserADonee();
        Person GetLoggedPerson();
        string GetNameLoggedPerson();
        string GetEmail();
    }
}
