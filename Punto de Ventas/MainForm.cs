namespace Punto_de_Ventas
{
    using System.Runtime.InteropServices; // for dll import
    public partial class MainForm : Form
    {

        //Win32API - Usadas para poder mover desde barra personalizada

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private Form? frmStocks = null;
        private Form? frmSales = null;
        private Form? frmClients = null;
        private Form? frmSuppliers = null;
        private Form? frmPurchases = null;
        private Form? frmReports = null;

        public MainForm()
        {
            InitializeComponent();
            this.PnlModules.SuspendLayout();

            foreach (Button bt in this.PnlModules.Controls.OfType<Button>())  //agregado de borde lateral en botones
            {
                Panel pnlMark = new();

                pnlMark.Location = new Point(bt.Location.X, bt.Location.Y + 10);
                //pnlMark.Location = new Point(200,200);
                pnlMark.BackColor = System.Drawing.Color.MediumPurple;
                pnlMark.Size = new System.Drawing.Size(8, 25);
                this.PnlModules.Controls.Add(pnlMark);
            }
            foreach (Panel pnl in this.PnlModules.Controls.OfType<Panel>())
            {
                if (pnl.Name != "PnlAccount") pnl.BringToFront();//this.PnlModules.Controls.SetChildIndex(pnl, 0); //Forzar orden docking/bringtofront
            }

            this.PnlModules.ResumeLayout();

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HT_CAPTION = 0x2;

            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (this.PointToClient(Cursor.Position).Y < PnlWindowControls.Height) ?
                           (IntPtr)(HT_CAPTION) : m.Result;
        }
        private void movibleArea_MouseDown(object sender, MouseEventArgs e)
        {
            const int HT_CAPTION = 0x2;
            const int WM_NCLBUTTONDOWN = 0xA1;

            ReleaseCapture();
            //SendMessage(this.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0);
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void MainForm_Layout(object sender, LayoutEventArgs e)
        {
            PnlViewer.Height = this.ClientRectangle.Height - PnlWindowControls.Height;
            Screen curScreen = Screen.FromControl(this);

            if (WindowState == FormWindowState.Maximized)
                PnlViewer.Width = curScreen.WorkingArea.Width - PnlViewer.Location.X;
            else
                PnlViewer.Width = this.ClientRectangle.Width - PnlViewer.Location.X;
            PnlWindowControls.Location = new Point(PnlViewer.Location.X + PnlViewer.Width - PnlWindowControls.Width, 0);
        }

        private void MainForm_LocationChanged(object sender, EventArgs e)
        {
            Screen curScreen = Screen.FromPoint(Cursor.Position);
            this.MaximizedBounds = new Rectangle(-8, -8, curScreen.WorkingArea.Width + 16, curScreen.WorkingArea.Height + 16);
        }

        Button? lastButton = null;
        private void MarkButton(Button setButton)
        {
            if (!(lastButton is null))
                lastButton.BackColor = this.BackColor;
            lastButton = setButton;
            lastButton.BackColor = lastButton.FlatAppearance.MouseDownBackColor;
        }
        private void ShowSubForm(Form frm)
        {
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            //PnlViewer.Controls(0).
            PnlViewer.Controls.Clear();
            PnlViewer.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void BtnStocks_Click(object sender, EventArgs e)
        {
            if (frmStocks is null)
                frmStocks = new StocksForm();
            ShowSubForm(frmStocks);
            MarkButton((Button)sender);
        }

        private void BtnSales_Click(object sender, EventArgs e)
        {
            MarkButton((Button)sender);
        }

        private void BtnClients_Click(object sender, EventArgs e)
        {
            MarkButton((Button)sender);
        }

        private void BtnSuppliers_Click(object sender, EventArgs e)
        {
            MarkButton((Button)sender);
        }

        private void BtnPurchases_Click(object sender, EventArgs e)
        {
            MarkButton((Button)sender);
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            MarkButton((Button)sender);
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            Form frmCfg = new ConfigForm();
            //frmCfg.TopMost = true;
            frmCfg.ShowDialog(this);
        }
    }
}