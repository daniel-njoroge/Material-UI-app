namespace MyApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnloginClicked(object sender, EventArgs e)
        {
            if(username.Text == "njoroge" && pass.Text == "1234")
                {
                loginstatus.Text = "Login Success";
                await Shell.Current.GoToAsync("///dashboard");
            }

            else if(username.Text == "" && pass.Text == "")
                loginstatus.Text = "Enter Your Username and Password";
            else if (pass.Text != "" && username.Text == "")
                loginstatus.Text = "Enter Username";
            else if (username.Text != "" && pass.Text == "")
                loginstatus.Text = "Enter password";
            else if(pass.Text != "" && username.Text != "")
                loginstatus.Text = "Login Failed: Invalid Credentials";
        }
    }

}
