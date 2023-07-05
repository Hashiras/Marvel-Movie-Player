using AxWMPLib;
using Movie_Player.Menu;
using Movie_Player.Model.Manager;
using Movie_Player.Model;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Movie_Player
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void proceed()
        {
            this.Hide();
            FrmMain menu = new FrmMain();
            menu.FormClosed += NewForm_FormClosed;
            menu.Show();
        }

        private void NewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            ((Form)sender).Dispose();
        }
        private void FrmSplash_Load(object sender, EventArgs e)
        {
            splashPlayer.URL = Path.Combine(Application.StartupPath, "Media", "intro.mp4");
            Debug.WriteLine("Debug: The player's path is " + splashPlayer.URL);
            splashPlayer.Ctlcontrols.play();
            splashPlayer.uiMode = "none";


        }
        private void splashPlayer_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            if ((WMPLib.WMPPlayState)e.newState == WMPLib.WMPPlayState.wmppsStopped)
            {
                //The intro is done playing
                proceed();
            }
        }
        private void splashPlayer_ClickEvent(object sender, _WMPOCXEvents_ClickEvent e)
        {
            splashPlayer.Ctlcontrols.stop();
        }
    }
}
