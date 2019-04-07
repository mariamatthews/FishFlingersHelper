using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishFlingers
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void buttonCheckHelper(CheckBox thisButton, bool buttonStatus, string picture)
        {
            if (buttonStatus == true)
            {
                thisButton.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(picture + "Active");
            }
            else
            {
                thisButton.BackgroundImage = (Bitmap) Properties.Resources.ResourceManager.GetObject(picture);
            }
        }
    }
}
