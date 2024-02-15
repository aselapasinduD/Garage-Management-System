using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageTuto
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            loadingBarTimer.Start();
        }

        int startLoding = 0;
        private void loadingBarTimer_Tick(object sender, EventArgs e)
        {
            startLoding++;
            LoadingBar.Value = startLoding;
            if (startLoding == 100)
            {
                loadingBarTimer.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
