namespace SariScan;

/// <summary>Who is signed in right now.</summary>
public static class Session
{
    public static AppUser User { get; private set; }

    public static void Start(AppUser user) => User = user;
    public static void End() => User = null;

    public static bool IsOwner => User?.IsOwner == true;
    /// <summary>Owner can always update stock; an attendant only if the owner granted permission.</summary>
    public static bool CanUpdateStock => IsOwner || User?.CanUpdateStock == true;
    public static string Username => User?.Username ?? "unknown";
}
