using BibliotecaPilar.Data;

namespace BibliotecaPilar
{
    public partial class Login : Form
    {
        readonly DataContext dataContext = new DataContext();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            var user = dataContext.Users.Where(user => user.Username == username && user.Password == password).FirstOrDefault();


            if (user != null)
            {
                this.Hide();
                MainScreen mainScreen = new MainScreen(user);
                mainScreen.ShowDialog();
                this.Close();
                return;
            }
            lblErroLogin.Visible = true;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataContext.Dispose();
        }
    }
}