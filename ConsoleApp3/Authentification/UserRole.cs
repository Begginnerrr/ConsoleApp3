
namespace ConsoleApp3.Authentification
{
    public static class UserRole
    {
        private static bool adminRole = false;

        public static bool GetAdminRole()
        {
            return adminRole;
        }

        public static void SetAdminRole(bool role)
        {
            adminRole = role;
        }
    }
}
