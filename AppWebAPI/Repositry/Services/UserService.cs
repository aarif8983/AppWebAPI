using AppWebAPI.Contracts.Request;
using AppWebAPI.Models;
using AppWebAPI.Repositry.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebAPI.Repositry.Services
{

    public class UserService : IUsers
    {
        private readonly AppDbContext dbContext;

        public UserService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Users SignIn(SignInModel model)
        {
            var user = dbContext.Users.SingleOrDefault(e => e.Email == model.Email && e.Password == model.Password);
            if (user != null)
            {
                return user;

            }
            else
            {
                return null;
            }
        }

        public Users SignUp(SignUpModel model)
        {
            var user = new Users()
            {

                Name = model.Name,
                Email = model.Email,
                Password = model.Password,
                Gender = model.Gender


            };
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
            return user;
        }
    }
}




