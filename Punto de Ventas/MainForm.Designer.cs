namespace Punto_de_Ventas
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PnlAccount = new System.Windows.Forms.Panel();
            this.BtnConfig = new System.Windows.Forms.Button();
            this.BtnChangeUser = new System.Windows.Forms.Button();
            this.PboxUserPicture = new System.Windows.Forms.PictureBox();
            this.LblUserName = new System.Windows.Forms.Label();
            this.PnlModules = new System.Windows.Forms.Panel();
            this.BtnReport = new FontAwesome.Sharp.IconButton();
            this.BtnPurchases = new FontAwesome.Sharp.IconButton();
            this.BtnSuppliers = new FontAwesome.Sharp.IconButton();
            this.BtnClients = new FontAwesome.Sharp.IconButton();
            this.BtnSales = new FontAwesome.Sharp.IconButton();
            this.BtnStocks = new FontAwesome.Sharp.IconButton();
            this.PnlViewer = new System.Windows.Forms.Panel();
            this.PnlWindowControls = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnMax = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.PnlAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PboxUserPicture)).BeginInit();
            this.PnlModules.SuspendLayout();
            this.PnlWindowControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlAccount
            // 
            this.PnlAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlAccount.Controls.Add(this.BtnConfig);
            this.PnlAccount.Controls.Add(this.BtnChangeUser);
            this.PnlAccount.Controls.Add(this.PboxUserPicture);
            this.PnlAccount.Controls.Add(this.LblUserName);
            this.PnlAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlAccount.Location = new System.Drawing.Point(0, 0);
            this.PnlAccount.Name = "PnlAccount";
            this.PnlAccount.Size = new System.Drawing.Size(176, 202);
            this.PnlAccount.TabIndex = 0;
            this.PnlAccount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.movibleArea_MouseDown);
            // 
            // BtnConfig
            // 
            this.BtnConfig.FlatAppearance.BorderSize = 0;
            this.BtnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.BtnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfig.Image = ((System.Drawing.Image)(resources.GetObject("BtnConfig.Image")));
            this.BtnConfig.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.BtnConfig.Location = new System.Drawing.Point(117, 152);
            this.BtnConfig.Name = "BtnConfig";
            this.BtnConfig.Size = new System.Drawing.Size(54, 48);
            this.BtnConfig.TabIndex = 3;
            this.BtnConfig.UseVisualStyleBackColor = true;
            this.BtnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
            // 
            // BtnChangeUser
            // 
            this.BtnChangeUser.FlatAppearance.BorderSize = 0;
            this.BtnChangeUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.BtnChangeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangeUser.ForeColor = System.Drawing.Color.Lime;
            this.BtnChangeUser.Location = new System.Drawing.Point(19, 152);
            this.BtnChangeUser.Name = "BtnChangeUser";
            this.BtnChangeUser.Size = new System.Drawing.Size(100, 48);
            this.BtnChangeUser.TabIndex = 2;
            this.BtnChangeUser.Text = "Cambiar Usuario";
            this.BtnChangeUser.UseVisualStyleBackColor = true;
            // 
            // PboxUserPicture
            // 
            this.PboxUserPicture.Image = ((System.Drawing.Image)(resources.GetObject("PboxUserPicture.Image")));
            this.PboxUserPicture.Location = new System.Drawing.Point(19, 22);
            this.PboxUserPicture.Name = "PboxUserPicture";
            this.PboxUserPicture.Size = new System.Drawing.Size(128, 128);
            this.PboxUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PboxUserPicture.TabIndex = 1;
            this.PboxUserPicture.TabStop = false;
            // 
            // LblUserName
            // 
            this.LblUserName.ForeColor = System.Drawing.Color.Lime;
            this.LblUserName.Location = new System.Drawing.Point(19, -2);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(128, 20);
            this.LblUserName.TabIndex = 0;
            this.LblUserName.Text = "Unknown";
            this.LblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlModules
            // 
            this.PnlModules.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlModules.Controls.Add(this.BtnReport);
            this.PnlModules.Controls.Add(this.BtnPurchases);
            this.PnlModules.Controls.Add(this.BtnSuppliers);
            this.PnlModules.Controls.Add(this.BtnClients);
            this.PnlModules.Controls.Add(this.BtnSales);
            this.PnlModules.Controls.Add(this.BtnStocks);
            this.PnlModules.Controls.Add(this.PnlAccount);
            this.PnlModules.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlModules.Location = new System.Drawing.Point(0, 0);
            this.PnlModules.Name = "PnlModules";
            this.PnlModules.Size = new System.Drawing.Size(180, 729);
            this.PnlModules.TabIndex = 1;
            this.PnlModules.MouseDown += new System.Windows.Forms.MouseEventHandler(this.movibleArea_MouseDown);
            // 
            // BtnReport
            // 
            this.BtnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReport.FlatAppearance.BorderSize = 0;
            this.BtnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.BtnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.BtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReport.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnReport.ForeColor = System.Drawing.Color.Lime;
            this.BtnReport.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.BtnReport.IconColor = System.Drawing.Color.White;
            this.BtnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnReport.IconSize = 32;
            this.BtnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReport.Location = new System.Drawing.Point(0, 452);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnReport.Size = new System.Drawing.Size(176, 50);
            this.BtnReport.TabIndex = 6;
            this.BtnReport.Text = "Reportes";
            this.BtnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReport.UseVisualStyleBackColor = true;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // BtnPurchases
            // 
            this.BtnPurchases.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPurchases.FlatAppearance.BorderSize = 0;
            this.BtnPurchases.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.BtnPurchases.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.BtnPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPurchases.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPurchases.ForeColor = System.Drawing.Color.Lime;
            this.BtnPurchases.IconChar = FontAwesome.Sharp.IconChar.TruckLoading;
            this.BtnPurchases.IconColor = System.Drawing.Color.White;
            this.BtnPurchases.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPurchases.IconSize = 32;
            this.BtnPurchases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPurchases.Location = new System.Drawing.Point(0, 402);
            this.BtnPurchases.Name = "BtnPurchases";
            this.BtnPurchases.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnPurchases.Size = new System.Drawing.Size(176, 50);
            this.BtnPurchases.TabIndex = 5;
            this.BtnPurchases.Text = "Compras";
            this.BtnPurchases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPurchases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPurchases.UseVisualStyleBackColor = true;
            this.BtnPurchases.Click += new System.EventHandler(this.BtnPurchases_Click);
            // 
            // BtnSuppliers
            // 
            this.BtnSuppliers.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSuppliers.FlatAppearance.BorderSize = 0;
            this.BtnSuppliers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.BtnSuppliers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.BtnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSuppliers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSuppliers.ForeColor = System.Drawing.Color.Lime;
            this.BtnSuppliers.IconChar = FontAwesome.Sharp.IconChar.TruckMoving;
            this.BtnSuppliers.IconColor = System.Drawing.Color.White;
            this.BtnSuppliers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSuppliers.IconSize = 32;
            this.BtnSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSuppliers.Location = new System.Drawing.Point(0, 352);
            this.BtnSuppliers.Name = "BtnSuppliers";
            this.BtnSuppliers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnSuppliers.Size = new System.Drawing.Size(176, 50);
            this.BtnSuppliers.TabIndex = 4;
            this.BtnSuppliers.Text = "Proveedores";
            this.BtnSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSuppliers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSuppliers.UseVisualStyleBackColor = true;
            this.BtnSuppliers.Click += new System.EventHandler(this.BtnSuppliers_Click);
            // 
            // BtnClients
            // 
            this.BtnClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnClients.FlatAppearance.BorderSize = 0;
            this.BtnClients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.BtnClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.BtnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClients.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnClients.ForeColor = System.Drawing.Color.Lime;
            this.BtnClients.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.BtnClients.IconColor = System.Drawing.Color.White;
            this.BtnClients.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClients.IconSize = 32;
            this.BtnClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClients.Location = new System.Drawing.Point(0, 302);
            this.BtnClients.Name = "BtnClients";
            this.BtnClients.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnClients.Size = new System.Drawing.Size(176, 50);
            this.BtnClients.TabIndex = 3;
            this.BtnClients.Text = "Clientes";
            this.BtnClients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClients.UseVisualStyleBackColor = true;
            this.BtnClients.Click += new System.EventHandler(this.BtnClients_Click);
            // 
            // BtnSales
            // 
            this.BtnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSales.FlatAppearance.BorderSize = 0;
            this.BtnSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.BtnSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.BtnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSales.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSales.ForeColor = System.Drawing.Color.Lime;
            this.BtnSales.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.BtnSales.IconColor = System.Drawing.Color.White;
            this.BtnSales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSales.IconSize = 32;
            this.BtnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSales.Location = new System.Drawing.Point(0, 252);
            this.BtnSales.Name = "BtnSales";
            this.BtnSales.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnSales.Size = new System.Drawing.Size(176, 50);
            this.BtnSales.TabIndex = 2;
            this.BtnSales.Text = "Ventas";
            this.BtnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSales.UseVisualStyleBackColor = true;
            this.BtnSales.Click += new System.EventHandler(this.BtnSales_Click);
            // 
            // BtnStocks
            // 
            this.BtnStocks.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnStocks.FlatAppearance.BorderSize = 0;
            this.BtnStocks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.BtnStocks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.BtnStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStocks.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnStocks.ForeColor = System.Drawing.Color.Lime;
            this.BtnStocks.IconChar = FontAwesome.Sharp.IconChar.Marker;
            this.BtnStocks.IconColor = System.Drawing.Color.White;
            this.BtnStocks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnStocks.IconSize = 32;
            this.BtnStocks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStocks.Location = new System.Drawing.Point(0, 202);
            this.BtnStocks.Name = "BtnStocks";
            this.BtnStocks.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnStocks.Size = new System.Drawing.Size(176, 50);
            this.BtnStocks.TabIndex = 1;
            this.BtnStocks.Text = "Productos";
            this.BtnStocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStocks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnStocks.UseVisualStyleBackColor = true;
            this.BtnStocks.Click += new System.EventHandler(this.BtnStocks_Click);
            // 
            // PnlViewer
            // 
            this.PnlViewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlViewer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlViewer.Location = new System.Drawing.Point(180, 35);
            this.PnlViewer.Name = "PnlViewer";
            this.PnlViewer.Size = new System.Drawing.Size(828, 694);
            this.PnlViewer.TabIndex = 2;
            this.PnlViewer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.movibleArea_MouseDown);
            // 
            // PnlWindowControls
            // 
            this.PnlWindowControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlWindowControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlWindowControls.Controls.Add(this.button1);
            this.PnlWindowControls.Controls.Add(this.BtnMin);
            this.PnlWindowControls.Controls.Add(this.BtnMax);
            this.PnlWindowControls.Controls.Add(this.BtnClose);
            this.PnlWindowControls.Location = new System.Drawing.Point(854, 0);
            this.PnlWindowControls.Name = "PnlWindowControls";
            this.PnlWindowControls.Size = new System.Drawing.Size(154, 36);
            this.PnlWindowControls.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(5, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 33);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BtnMin
            // 
            this.BtnMin.FlatAppearance.BorderSize = 0;
            this.BtnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Image = ((System.Drawing.Image)(resources.GetObject("BtnMin.Image")));
            this.BtnMin.Location = new System.Drawing.Point(43, -1);
            this.BtnMin.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(33, 33);
            this.BtnMin.TabIndex = 0;
            this.BtnMin.UseVisualStyleBackColor = false;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnMax
            // 
            this.BtnMax.FlatAppearance.BorderSize = 0;
            this.BtnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.BtnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMax.Image = ((System.Drawing.Image)(resources.GetObject("BtnMax.Image")));
            this.BtnMax.Location = new System.Drawing.Point(79, -1);
            this.BtnMax.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(33, 33);
            this.BtnMax.TabIndex = 0;
            this.BtnMax.UseVisualStyleBackColor = false;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(115, -1);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(33, 33);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.ControlBox = false;
            this.Controls.Add(this.PnlWindowControls);
            this.Controls.Add(this.PnlViewer);
            this.Controls.Add(this.PnlModules);
            this.Name = "MainForm";
            this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.MainForm_Layout);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.movibleArea_MouseDown);
            this.PnlAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PboxUserPicture)).EndInit();
            this.PnlModules.ResumeLayout(false);
            this.PnlWindowControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PnlAccount;
        private Panel PnlModules;
        private Panel PnlViewer;
        private Panel PnlWindowControls;
        private Button BtnMin;
        private Button BtnMax;
        private Button BtnClose;
        private Button BtnConfig;
        private Button BtnChangeUser;
        private PictureBox PboxUserPicture;
        private Label LblUserName;
        private FontDialog fontDialog1;
        private FontAwesome.Sharp.IconButton BtnStocks;
        private FontAwesome.Sharp.IconButton BtnReport;
        private FontAwesome.Sharp.IconButton BtnPurchases;
        private FontAwesome.Sharp.IconButton BtnSuppliers;
        private FontAwesome.Sharp.IconButton BtnClients;
        private FontAwesome.Sharp.IconButton BtnSales;
        private Button button1;
    }
}