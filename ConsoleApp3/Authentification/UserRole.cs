
namespace ConsoleApp3.Authentification
{
    public static class UserRole
    {
        private static bool adminRole = false;

        public bool GetAdminRole()
        {
            return adminRole;
        }

        public void SetAdminRole(bool role)
        {
            adminRole = role;
        }
    }
}
