using Client.Data.Service;
using Client.UseCases;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Client.Present
{
    public partial class FormLogin : MaterialForm
    {
       UserUseCases login = new UserCases_Impl();
        Dictionary<string, Color> colors = new Dictionary<string, Color>()
            {
                { "dark", Color.FromArgb(85, 0, 176) },
                { "dark-low", Color.FromArgb(165, 9, 189) },
                { "medium", Color.FromArgb(164, 68, 179) },
                { "light", Color.FromArgb(255, 255, 255)},
                { "very-light", Color.FromArgb(0, 0, 0) },
            };
        public FormLogin()
        {
            InitializeComponent();
            InitMaterialSkin();
        }
        private void InitMaterialSkin()
        {
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
               colors["dark-low"], colors["dark"], colors["light"], colors["medium"], TextShade.WHITE
            );
        }

        private void materialLabelSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp signUp = new FormSignUp();
            signUp.Show();
        }

        private async void materialButtonLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                var info = await login.LogIn(materialTextBoxLogin.Text, materialTextBoxPassword.Text);
                var t = new Thread(() => Application.Run(new Shop(info.Item1)));
                t.Start();
                this.Close();
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show("Логин или пароль введены неверно", "Ошибка авторизации");
            }
        }
    }
}
