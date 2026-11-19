using Microsoft.Data.SqlClient;

namespace SariScan;

public static class UserRepository
{
    /// <summary>Returns the user if the username and password are correct, otherwise null.</summary>
    public static AppUser Authenticate(string username, string password)
    {
        using var cn = Database.Open();
        using var cmd = new SqlCommand(
            "SELECT UserId, Username, FullName, UserRole, CanUpdateStock, PasswordHash, Salt FROM dbo.Users WHERE Username = @u", cn);
        cmd.Parameters.AddWithValue("@u", username);
        using var r = cmd.ExecuteReader();
        if (!r.Read()) return null;

        var hash = (byte[])r["PasswordHash"];
        var salt = (byte[])r["Salt"];
        if (!PasswordHasher.Verify(password, salt, hash)) return null;

        return new AppUser(r.GetInt32(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetBoolean(4));
    }
}
