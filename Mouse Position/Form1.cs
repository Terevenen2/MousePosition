using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mouse_Position
{
    public partial class Form1 : Form
    {
        public static Timer aTimer = new Timer();

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPress += Form1_KeyPress;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ShowIcon = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.Size = new Size(0, 0);
            aTimer.Interval = 10;
            aTimer.Tick += ATimer_Tick;
            aTimer.Start();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clipboard.SetText(MousePosition.X + ", " + MousePosition.Y);
        }

        private void ATimer_Tick(object sender, EventArgs e)
        {
            this.Text = "X" + MousePosition.X + " Y" + MousePosition.Y;
            this.BackColor = Color.Black;
        }
    }
}
