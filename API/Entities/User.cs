using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class User : IdentityUser<int> // int - override a string as PK that default for identity
    {
        
    }
}
