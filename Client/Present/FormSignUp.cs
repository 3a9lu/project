using Client.Data.Service;
using Client.UseCases;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Client.Present
{
    public partial class FormSignUp : MaterialForm
    {
        UserUseCases SignUp = new UserCases_Impl();
        Dictionary<string, Color> colors = new Dictionary<string, Color>()
            {
                { "dark", Color.FromArgb(85, 0, 176) },
                { "dark-low", Color.FromArgb(165, 9, 189) },
                { "medium", Color.FromArgb(164, 68, 179) },
                { "light", Color.FromArgb(255, 255, 255)},
                { "very-light", Color.FromArgb(0, 0, 0) },
            };
        public FormSignUp()
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

        private async void materialButtonSignUp_Click(object sender, EventArgs e)
        {
            string result = "";
            try
            {
                if(materialTextBoxName.Text == "" || materialTextBoxLastname.Text == "" || materialTextBoxEmail.Text == "" || 
                    materialTextBoxPhone.Text == "" || materialTextBoxAddress.Text == "" || materialTextBoxPassword.Text == "")
                {
                    MaterialMessageBox.Show("Выдолжны заполнить все поля");
                } 
                else if (materialTextBoxPassword.Text == materialTextBoxRepeatPassword.Text && 
                    materialCheckboxAgree.Checked == true)
                {
                    result = await SignUp.SignUp(materialTextBoxName.Text, materialTextBoxLastname.Text, 
                        materialTextBoxEmail.Text, materialTextBoxPhone.Text, materialTextBoxAddress.Text, 
                        materialTextBoxPassword.Text);
                    if (result == "Conflict")
                        MaterialMessageBox.Show("Такой email уже используется", "Пользователь уже существует");
                    else
                        MaterialMessageBox.Show(result);
                } 
                else
                {
                    MaterialMessageBox.Show("Пароли не совпадают, либо вы не приняли соглашение.");
                }
            }
            catch(Exception ex)
            {
                MaterialMessageBox.Show(ex.ToString());
            }
        }
    }
}
