using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Liberty.Infrastructure.Helpers
{
    public static class FormHelper
    {
        public static void RemoveControlBar(this Form viewBar)
        {
            viewBar.FormBorderStyle = FormBorderStyle.None;
            viewBar.ControlBox = false;
            viewBar.ShowIcon = false;
            viewBar.MaximizeBox = false;
            viewBar.MinimizeBox = false;
            viewBar.Dock = DockStyle.Fill;
        }
    }
}
