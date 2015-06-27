using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sphero_360_Frontend
{
    public partial class GamepadControls : Form
    {
        public GamepadControls()
        {
            InitializeComponent();
        }

        private void GamepadControls_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
