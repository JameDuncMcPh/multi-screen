using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS
{
    public partial class firstForm : Form
    {
        public static String password = "1666";
        public static String username = "Cody";

        public firstForm()
        {
            InitializeComponent();

            mainScreen ms = new mainScreen();
            this.Controls.Add(ms);
        }
    }
}
