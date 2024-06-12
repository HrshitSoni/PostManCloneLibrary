using PostManCloneLibrary;

namespace PostManCloneUI
{
    public partial class Dashboard : Form
    {
        private readonly ApiAccess api = new();
        public Dashboard()
        {
            InitializeComponent();
        }

        private async void FetchButton_Click(object sender, EventArgs e)
        {
            try
            {
               ResponseTextBox.Text =  await api.CallApi(ApiLinktextBox.Text);
            }
            catch (Exception ex)
            {
                ResponseTextBox.Text = "Error" + ex.Message;
            }
        }
    }
}
