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
    public partial class mainScreen : UserControl
    {
        public mainScreen()
        {
            InitializeComponent();
        }

        

        private void playButton_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == firstForm.password && textBox1.Text == firstForm.username)
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                playScreen ps = new playScreen();
                f.Controls.Add(ps);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        } 
    }
}
