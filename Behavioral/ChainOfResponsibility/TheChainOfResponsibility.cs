namespace ChainOfResponsibility
{
    public abstract class PermissionChecker
    {
        protected PermissionChecker successor;
        public void SetSuccessor(PermissionChecker successor)
        {
            this.successor = successor;
        }
        public abstract void HandleRequest(User user);
    }

    public class AdminChecker : PermissionChecker
    {
        public override void HandleRequest(User user)
        {
            if (UserRole.Admin == user.Role)
            {
                Console.WriteLine("User: {0} has the role Admin", user.Name);
            }
            else if (successor != null)
            {
                successor.HandleRequest(user);
            }
        }
    }

    public class MemberChecker : PermissionChecker
    {
        public override void HandleRequest(User user)
        {
            if (UserRole.Member == user.Role)
            {
                Console.WriteLine("User: {0} has the role Member", user.Name);
            }
            else if (successor != null)
            {
                successor.HandleRequest(user);
            }
        }
    }

    public class GuestChecker : PermissionChecker
    {
        public override void HandleRequest(User user)
        {
            if (UserRole.Guest == user.Role)
            {
                Console.WriteLine("User: {0} has the role Guest", user.Name);
            }
            else if (successor != null)
            {
                successor.HandleRequest(user);
            }
        }
    }

    public class User
    {
        public string Name { get; set; }
        public UserRole Role { get; set; }
    }

    public enum UserRole {
        Admin,
        Member, 
        Guest
    }
}
