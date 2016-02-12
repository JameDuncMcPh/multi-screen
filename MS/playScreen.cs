using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS
{
    public partial class playScreen : UserControl
    {
        public playScreen()
        {
            InitializeComponent();

            welcomeLabel.Text = "Welcome back " + firstForm.username;
        }
    }
}
