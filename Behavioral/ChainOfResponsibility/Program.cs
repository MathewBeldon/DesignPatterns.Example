namespace ChainOfResponsibility
{
    public class Program
    {
        public static void Main()
        {
            // Setup Chain of Responsibility
            PermissionChecker adminChecker = new AdminChecker();
            PermissionChecker memberChecker = new MemberChecker();
            PermissionChecker guestChecker = new GuestChecker();

            adminChecker.SetSuccessor(memberChecker);
            memberChecker.SetSuccessor(guestChecker);

            var adminUser = new User()
            {
                Name = "Alice",
                Role = UserRole.Admin
            };
            adminChecker.HandleRequest(adminUser);

            var memberUser = new User()
            {
                Name = "Bob",
                Role = UserRole.Member
            };
            adminChecker.HandleRequest(memberUser);

            var guestUser = new User()
            {
                Name = "Anonymous",
                Role = UserRole.Guest
            };
            adminChecker.HandleRequest(guestUser);

            Console.ReadKey();
        }
    }
}