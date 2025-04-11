using DesktopKonata.Utility;
using System.Windows.Forms;

namespace DesktopKonata.Forms
{
    public partial class Menu : Form
    {
        private readonly Screen[] AllScreens = Screen.AllScreens;
        private readonly List<CharacterWindow> _windows = new();

        private NotifyIcon _notifyIcon = new()
        {
            Visible = true,
            Icon = Properties.Resources.KonataIco,
            Text = "hehe",
            BalloonTipIcon = ToolTipIcon.Info,
            BalloonTipTitle = "hehe",
            BalloonTipText = "I`am here!"
        };

        public Menu()
        {
            InitializeComponent();
            _notifyIcon.MouseClick += NotifyIcon_MouseClick!;
        }

        private void Menu_Load(object sender, EventArgs args)
        {
            foreach (var screen in AllScreens)
            {
                var window = new CharacterWindow(screen);
                window.SetBounds(screen.Bounds.X, screen.Bounds.Y, screen.Bounds.Width, screen.Bounds.Height);
                _windows.Add(window);
                window.Show();
            }
        }

        private void HideInTray()
        {
            Hide();
            _notifyIcon.ShowBalloonTip(500);
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs args)
        {

        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs args)
        {
            WindowState = FormWindowState.Normal;
            Show();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _notifyIcon.Visible = false;
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HideInTray();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CharacterManager.ClearCharacters();
        }

        private void btn_gif1_Click(object sender, EventArgs e)
        {
            Bitmap gifFromDisk = new Bitmap("GIF/1.gif");
            CharacterManager.AddCharacter(gifFromDisk);
        }

        private void btn_gif2_Click(object sender, EventArgs e)
        {
            Bitmap gifFromDisk = new Bitmap("GIF/2.gif");
            CharacterManager.AddCharacter(gifFromDisk);
        }

        private void btn_gif3_Click(object sender, EventArgs e)
        {
            Bitmap gifFromDisk = new Bitmap("GIF/3.gif");
            CharacterManager.AddCharacter(gifFromDisk);
        }

        private void btn_gif4_Click(object sender, EventArgs e)
        {
            Bitmap gifFromDisk = new Bitmap("GIF/4.gif");
            CharacterManager.AddCharacter(gifFromDisk);
        }

        private void btn_gif5_Click(object sender, EventArgs e)
        {
            Bitmap gifFromDisk = new Bitmap("GIF/5.gif");
            CharacterManager.AddCharacter(gifFromDisk);
            //CharacterManager.AddCharacter(Properties.Resources.GIF5); // BananaKonataGIF
        }
    }
}
