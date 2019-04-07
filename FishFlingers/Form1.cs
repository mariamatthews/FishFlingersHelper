using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FishFlingers
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void wormsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox thisButton = (CheckBox)sender;
            Program.buttonCheckHelper(thisButton, thisButton.Checked, "worms");
        }


        private void maggotsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox thisButton = (CheckBox)sender;
            Program.buttonCheckHelper(thisButton, thisButton.Checked, "maggots");
        }

        private void locustsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox thisButton = (CheckBox)sender;
            Program.buttonCheckHelper(thisButton, thisButton.Checked, "locusts");
        }

        private void cricketsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox thisButton = (CheckBox)sender;
            Program.buttonCheckHelper(thisButton, thisButton.Checked, "crickets");
        }

        private void crayfishCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox thisButton = (CheckBox)sender;
            Program.buttonCheckHelper(thisButton, thisButton.Checked, "crayfish");
        }

        private void shrimpsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox thisButton = (CheckBox)sender;
            Program.buttonCheckHelper(thisButton, thisButton.Checked, "shrimp");
        }

        private void greenMothCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox thisButton = (CheckBox)sender;
            Program.buttonCheckHelper(thisButton, thisButton.Checked, "greenMoth");
        }

        private void greyMothCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox thisButton = (CheckBox)sender;
            Program.buttonCheckHelper(thisButton, thisButton.Checked, "greyMoth");
        }

        private void standardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox thisButton = (CheckBox)sender;
            Program.buttonCheckHelper(thisButton, thisButton.Checked, "standard");
        }

        private void slimCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox thisButton = (CheckBox)sender;
            Program.buttonCheckHelper(thisButton, thisButton.Checked, "slim");
        }

        private void largeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox thisButton = (CheckBox)sender;
            Program.buttonCheckHelper(thisButton, thisButton.Checked, "large");
        }

        private void doubleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox thisButton = (CheckBox)sender;
            Program.buttonCheckHelper(thisButton, thisButton.Checked, "doubleHook");
        }

        private void boneCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox thisButton = (CheckBox)sender;
            Program.buttonCheckHelper(thisButton, thisButton.Checked, "bone");
        }

        private void woodCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox thisButton = (CheckBox)sender;
            Program.buttonCheckHelper(thisButton, thisButton.Checked, "wood");
        }

        private void oneCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox thisButton = (CheckBox)sender;
            Program.buttonCheckHelper(thisButton, thisButton.Checked, "one");
        }

        private void twoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox thisButton = (CheckBox)sender;
            Program.buttonCheckHelper(thisButton, thisButton.Checked, "two");
        }

        private void threeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox thisButton = (CheckBox)sender;
            Program.buttonCheckHelper(thisButton, thisButton.Checked, "three");
        }

        private void fourCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox thisButton = (CheckBox)sender;
            Program.buttonCheckHelper(thisButton, thisButton.Checked, "four");
        }

        private void fiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox thisButton = (CheckBox)sender;
            Program.buttonCheckHelper(thisButton, thisButton.Checked, "five");
        }

        private void sixCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox thisButton = (CheckBox)sender;
            Program.buttonCheckHelper(thisButton, thisButton.Checked, "six");
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            foreach (var control in this.Controls )
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
            }
        }

        private void resetButton_MouseDown(object sender, MouseEventArgs e)
        {
            Button thisButton = (Button)sender;
            thisButton.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("resetButtonActive");
        }

        private void resetButton_MouseUp(object sender, MouseEventArgs e)
        {
            Button thisButton = (Button)sender;
            thisButton.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("resetButton");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

