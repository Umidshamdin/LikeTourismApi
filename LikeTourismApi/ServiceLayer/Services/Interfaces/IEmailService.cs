using ServiceLayer.DTOs.AppUser;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IEmailService
    {
        void Register(RegisterDto registerDto, string link);

        Task ConfirmEmail(string userId, string token);
        void OrderCreate(string email, string hotelname, string fullname, string phonenumber);
    }
}
