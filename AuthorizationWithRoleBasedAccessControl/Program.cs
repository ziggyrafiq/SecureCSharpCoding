using AuthorizationWithRoleBasedAccessControl;

// Sample user data (you would get this from a database or identity provider)
string username = "john_doe";
string userRole = "admin"; // User's role (admin, user, etc.)

// Check if the user is authorized to access a specific resource (e.g., "AdminPanel")
if (CheckAccess.IsAuthorized(username, userRole, "AdminPanel"))
{
    Console.WriteLine("Access granted! User is authorized.");
}
else
{
    Console.WriteLine("Access denied! User is not authorized.");
}