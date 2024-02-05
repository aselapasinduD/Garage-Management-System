using System.ComponentModel;

namespace GarageTuto
{
    public partial class CustomMessageBox : Component
    {
        public DialogResult Show(string title, string message)
        {
            using (Form form = new Form())
            {
                form.Text = title;
                form.ClientSize = new Size(260, 100);
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.StartPosition = FormStartPosition.CenterParent;
                if (title == "Success")
                {
                    form.Icon = new Icon("icon/icons-success.ico");
                }
                else
                {
                    form.Icon = new Icon("icon/icons-warning.ico");
                }

                Label lblMessage = new Label()
                {
                    Text = message,
                    Size = new Size(form.ClientSize.Width, form.ClientSize.Height - 30 - 10),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                form.Controls.Add(lblMessage);

                Button btnOk = new Button()
                {
                    Text = "OK",
                    Size = new Size(60, 30),
                    Location = new Point((form.ClientSize.Width - 60)/2, form.ClientSize.Height - 30 - 10)
                };
                btnOk.Click += (sender, e) =>
                {
                    form.DialogResult = DialogResult.OK;
                    form.Close();
                };
                form.Controls.Add(btnOk);
                return form.ShowDialog();
            }
        }
    }
}
