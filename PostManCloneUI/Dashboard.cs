using PostManCloneLibrary;

namespace PostManCloneUI
{
    public partial class Dashboard : Form
    {
        private readonly ApiAccess api = new();
        public Dashboard()
        {
            InitializeComponent();

            ApiLinktextBox.KeyDown += ApiLinktextBox_KeyDown;

        }

        private void ApiLinktextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FetchButton_Click(sender, e);

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if(e.Control && e.KeyCode == Keys.N)
            {
                ResetButton_Click(sender, e);

                e.Handled = true;
                e.SuppressKeyPress = true;
            }

        }

        private async void FetchButton_Click(object sender, EventArgs e)
        {
            if (api.validateUrl(ApiLinktextBox.Text) == true)
            {
                try
                {
                    ResponseTextBox.Text = await api.CallApi(ApiLinktextBox.Text);
                }
                catch (Exception ex)
                {
                    ResponseTextBox.Text = "Error" + ex.Message;
                }
            }
            else
            {
                ResponseTextBox.Text = "Invalid Url";
                return;
            }

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ApiLinktextBox.Clear();
            ResponseTextBox.Clear();
        }
    }
}
