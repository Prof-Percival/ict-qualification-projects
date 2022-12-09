using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Salt_Hashing
{
    public class ContinuousProgressBar : ProgressBar
    {
        public ContinuousProgressBar()
        {
            this.Style = ProgressBarStyle.Continuous;
        }
        protected override void CreateHandle()
        {
            base.CreateHandle();
            try { _ = SetWindowTheme(this.Handle, "", ""); }
            catch { }
        }
        [System.Runtime.InteropServices.DllImport("uxtheme.dll")]
        private static extern int SetWindowTheme(IntPtr hwnd, string appname, string idlist);
    }
}
