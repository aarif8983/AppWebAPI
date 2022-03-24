using AppWebAPI.Contracts.Request;
using AppWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebAPI.Repositry.Contract
{
    public interface IUsers
    {
        Users SignIn(SignInModel model);
        Users SignUp(SignUpModel model);
    }
}
