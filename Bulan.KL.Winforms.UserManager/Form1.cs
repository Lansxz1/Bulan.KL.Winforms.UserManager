namespace Bulan.KL.Winforms.UserManager
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullname = tbFullName.Text;
            string username = tbUserName.Text;
            string password = tbPassword.Text;

            if (string.IsNullOrWhiteSpace(fullname) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Saving Failed Successfully!", "Incorrect Input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User userToSave = new User(fullname, username, password);
                UserRepository repository = new UserRepository();
                bool isSaved = repository.Add(userToSave);

                if (isSaved)
                {
                    MessageBox.Show("User Saved!","Sucessful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
