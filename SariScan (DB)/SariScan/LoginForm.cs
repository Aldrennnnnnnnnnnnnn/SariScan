namespace SariScan;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
    {
        txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
    }

    private void btnSignIn_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text.Trim();
        string password = txtPassword.Text;
        if (username.Length == 0 || password.Length == 0)
        {
            Ui.Error("Please enter your username and password.");
            return;
        }

        AppUser user;
        try
        {
            user = UserRepository.Authenticate(username, password);
        }
        catch (Exception ex)
        {
            Ui.Error(ex);
            return;
        }

        if (user == null)
        {
            Ui.Error("Incorrect username or password.");
            txtPassword.Clear();
            txtPassword.Focus();
            return;
        }

        Session.Start(user);
        using var main = new MainForm();
        Hide();
        var result = main.ShowDialog();
        Session.End();

        if (result == DialogResult.Retry)   // user pressed Logout
        {
            txtUsername.Clear();
            txtPassword.Clear();
            Show();
            txtUsername.Focus();
        }
        else
        {
            Close();
        }
    }
}
