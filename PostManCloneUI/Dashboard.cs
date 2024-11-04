using PostManCloneLibrary;
using System.Runtime.CompilerServices;

namespace PostManCloneUI
{
    public partial class Dashboard : Form
    {
        private readonly IApiAccess api = new ApiAccess();
        public Dashboard()
        {
            InitializeComponent();

            MethodsComboBox.SelectedIndex = 0;

            MethodsComboBox.DrawMode = DrawMode.OwnerDrawFixed;

            MethodsComboBox.DrawItem += cbxDesign_DrawItem;
        }

        private void cbxDesign_DrawItem(object sender, DrawItemEventArgs e)
        {
            // By using Sender, one method could handle multiple ComboBoxes
            ComboBox? cbx = sender as ComboBox;

            if (cbx != null)
            {
                // Always draw the background
                e.DrawBackground();

                // Drawing one of the items?
                if (e.Index >= 0)
                {
                    // Set the string alignment.  Choices are Center, Near and Far
                    StringFormat sf = new StringFormat();
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Alignment = StringAlignment.Center;

                    // Set the Brush to ComboBox ForeColor to maintain any ComboBox color settings
                    // Assumes Brush is solid
                    Brush brush = new SolidBrush(cbx.ForeColor);

                    string text = cbx.Items[e.Index]?.ToString() ?? "";
                    // Draw the string
                    e.Graphics.DrawString(text, cbx.Font, brush, e.Bounds, sf);
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ApiLinktextBox.Clear();
            ResponseTextBox.Clear();
        }

        private async void SendButton_Click(object sender, EventArgs e)
        {
            string method = MethodsComboBox.SelectedItem?.ToString() ?? "";
            string url = ApiLinktextBox.Text;
            string jsonBody = ResponseTextBox.Text;

            try
            {
                if (api.validateUrl(url))
                {
                    string response;

                    switch (method)
                    {
                        case "GET":
                            response = await api.CallApi(url, httpMethods.GET, null);
                            break;
                        case "POST":
                            response = await api.CallApi(url, httpMethods.POST, jsonBody);
                            break;
                        case "PUT":
                            response = await api.CallApi(url, httpMethods.PUT, jsonBody);
                            break;
                        case "DELETE":
                            response = await api.CallApi(url, httpMethods.DELETE, null);
                            break;
                        case "PATCH":
                            response = await api.CallApi(url, httpMethods.PATCH, jsonBody);
                            break;
                        default:
                            response = "Invalid method selected.";
                            break;
                    }

                    ResponseTextBox.Text = response;
                }
                else
                {
                    ResponseTextBox.Text = "Invalid Url" + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                ResponseTextBox.Text = $"Error : {ex.Message}";
            }
        }

        private void MethodsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentSelectedMethod = MethodsComboBox.SelectedItem?.ToString()??"";

            ResponseTextBox.Clear();

            if (currentSelectedMethod == "PUT" || currentSelectedMethod == "POST" || currentSelectedMethod == "PATCH")
            {
                ResponseTextBox.ReadOnly = false;
                ResponseTextBox.BackColor = Color.White;
            }
            else
            {
                ResponseTextBox.ReadOnly = true;
                ResponseTextBox.BackColor = Color.LightGray;
            }
        }
    }
}
