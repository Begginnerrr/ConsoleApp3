using ConsoleApp2;
using ConsoleApp3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Repository
{
    internal static class UserRepository
    {
        internal static List<User> GetUsers()
        {
            using (var db = new SchoolContext())
            {
                return db.Users.ToList();
            }
        }

        internal static User GetUserById(int UserID)
        {
            using (var db = new SchoolContext())
            {
                return db.Users.FirstOrDefault(user => user.userId == UserID);
            }
        }

        internal static User GetUserByName(string UserName)
        {
            using (var db = new SchoolContext())
            {
                return db.Users.FirstOrDefault(user => user.name == UserName);
            }
        }

        internal static bool GetUserByCredentials(string UserName, string pass)
        {
            try
            {
                using (var db = new SchoolContext())
                {
                    var result = db.Users.Where(p => p.name == UserName && p.password == pass);
                    if (result.Count() == 1) return true;
                    else return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        internal static bool CreateUser(User userToAdd)
        {
            using (var db = new SchoolContext())
            {
                try
                {
                    db.Users.Add(userToAdd);
                    return db.SaveChanges() >= 1;

                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        internal static bool UpdateUser(User userToUpdate)
        {
            using (var db = new SchoolContext())
            {
                try
                {
                    db.Users.Update(userToUpdate);

                    return db.SaveChanges() >= 1;

                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        internal static bool DeleteUser(int userID)
        {
            using (var db = new SchoolContext())
            {
                try
                {
                    User userToDelete = GetUserById(userID);

                    db.Remove(userToDelete);

                    return db.SaveChanges() >= 1;

                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

    }
}
