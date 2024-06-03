using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Prueba2_Fase1
{
    public partial class FormaMenu : Form
    {
        public int RolUsuario { get; set; }
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public FormaMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            // Quitar funciones de windows
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void FormaMenu_Load(object sender, EventArgs e)
        {
            // Configurar pnlDesktop para llenar el formulario principal
            pnlDesktop.Dock = DockStyle.Fill;

            // Inicializar la interfaz basada en el rol del usuario
            InicializarInterfazUsuario();
        }

        private void InicializarInterfazUsuario()
        {
            // Inicializar todos los botones
            IconButton[] botones = { btn1, btn2, btn3, btn4, btn5, btn6 };

            foreach (var boton in botones)
            {
                boton.Enabled = false;
                boton.ForeColor = Color.Gray; // Cambiar el color del texto a gris
                boton.IconColor = Color.Gray; // Cambiar el color del icono a gris
            }

            // Configurar botones según el rol del usuario
            switch (RolUsuario)
            {
                case 1: // Administrador
                    // Habilitar todas las opciones
                    foreach (var boton in botones)
                    {
                        boton.Enabled = true;
                        boton.ForeColor = SystemColors.Window;
                        boton.IconColor = SystemColors.Window;
                    }
                    break;
                case 2: // Ventas
                    // Habilitar solo las opciones de ventas
                    btn3.Enabled = true;
                    btn3.ForeColor = SystemColors.Window;
                    btn3.IconColor = SystemColors.Window;
                    break;
                case 3: // Contador
                    // Habilitar solo las opciones de reportes
                    btn6.Enabled = true;
                    btn6.ForeColor = SystemColors.Window;
                    btn6.IconColor = SystemColors.Window;
                    break;
            }
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private async void OpenChildFrm(Form childForm)
        {
            // Mostrar pantalla de carga en el subproceso principal
            LoadingForm loadingForm = new LoadingForm();
            loadingForm.Size = pnlDesktop.Size; // Ajustar tamaño al tamaño del panel
            loadingForm.StartPosition = FormStartPosition.Manual;
            loadingForm.Location = pnlDesktop.PointToScreen(Point.Empty); // Posicionar sobre pnlDesktop
            loadingForm.Show();
            loadingForm.Refresh();

            await Task.Run(() =>
            {
                // Aquí se realiza la carga del formulario hijo
                Invoke(new Action(() =>
                {
                    if (currentChildForm != null)
                    {
                        currentChildForm.Close();
                    }
                    currentChildForm = childForm;
                    childForm.TopLevel = false;
                    childForm.FormBorderStyle = FormBorderStyle.None;
                    childForm.Dock = DockStyle.Fill;
                    pnlDesktop.Controls.Add(childForm);
                    pnlDesktop.Tag = childForm;
                    childForm.BringToFront();
                    childForm.Show();
                    lblHome.Text = childForm.Text;
                }));
            });

            // Cerrar pantalla de carga en el subproceso principal
            loadingForm.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            ActivateButton(sender, RGBColors.color1);
            OpenChildFrm(new FrmUsuarios());
            this.Cursor = Cursors.Arrow;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.Cursor = Cursors.WaitCursor;
            ActivateButton(sender, RGBColors.color2);
            OpenChildFrm(new FrmPrueba2());
            btn2.Cursor = Cursors.Arrow;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.Cursor = Cursors.WaitCursor;
            ActivateButton(sender, RGBColors.color3);
            OpenChildFrm(new frmPrueba3());
            btn3.Cursor = Cursors.Arrow;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btn4.Cursor = Cursors.WaitCursor;
            ActivateButton(sender, RGBColors.color4);
            OpenChildFrm(new FrmClientes());
            btn4.Cursor = Cursors.Arrow;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btn5.Cursor = Cursors.WaitCursor;
            ActivateButton(sender, RGBColors.color5);
            OpenChildFrm(new FrmPrueba5());
            btn5.Cursor = Cursors.Arrow;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btn6.Cursor = Cursors.WaitCursor;
            ActivateButton(sender, RGBColors.color6);
            OpenChildFrm(new FrmPrueba6());
            btn6.Cursor = Cursors.Arrow;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblHome.Text = "Home";
        }

        private void ActivateButton(Object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 0, 64);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
            lblFecha.Text = DateTime.Now.ToString("dddd dd MMMM yyyy");
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
