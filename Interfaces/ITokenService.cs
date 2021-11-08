using Cinema.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
