using RubicX_223020_Server.BusinesLogic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubicX_223020_Server.BusinesLogic.Core.Interfaces
{
    public interface IUserService
    {
        Task<UserInformationBlo> RegisterWithPhone(string numberPrefix, string number, string password);
    }
}
