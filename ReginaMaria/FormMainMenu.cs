using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ReginaMaria
{
    public partial class FormMainMenu : Form
    {

        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //Contructor
        public FormMainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                // open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;

        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormPatients());
        }

        private void btnPrescriptions_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormPrescriptions());
        }

        private void btnDrugs_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormDrugs());
        }

        private void btnRaport1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormRaport1());
        }

        private void btnRaport2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormRaport2());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            // currentChildForm.Close();

            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }

        // Drag Form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
