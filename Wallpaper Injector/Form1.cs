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

namespace Wallpaper_Injector
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SystemParametersInfo(UInt32 action, 
            UInt32 uParam, string vParam, UInt32 winIni);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void WallpaperSetting_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Photo File |*.jpg;*.nef;*.png;*.jpeg;";
            openFile.Title = "InjectedWallpaper";
            openFile.ShowDialog();
            string filePath = openFile.FileName;
            SetWallpaper(filePath);
        }

        public void SetWallpaper(string path)
        {
            SystemParametersInfo(0x14, 0, path, 0x01 | 0x02);
        }
    }
}
