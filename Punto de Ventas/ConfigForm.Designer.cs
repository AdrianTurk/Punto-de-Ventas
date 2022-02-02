namespace Punto_de_Ventas
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.PnlRol = new System.Windows.Forms.Panel();
            this.ChkListOptions = new System.Windows.Forms.CheckedListBox();
            this.BtnRoleDelete = new FontAwesome.Sharp.IconButton();
            this.BtnRoleAdd = new FontAwesome.Sharp.IconButton();
            this.LstRoles = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlFoot = new System.Windows.Forms.Panel();
            this.BtnImport = new FontAwesome.Sharp.IconButton();
            this.BtnExport = new FontAwesome.Sharp.IconButton();
            this.BtnCancel = new FontAwesome.Sharp.IconButton();
            this.BtnApply = new FontAwesome.Sharp.IconButton();
            this.BtnExpand = new System.Windows.Forms.Button();
            this.PnlBasic = new System.Windows.Forms.Panel();
            this.BtnUserDelete = new FontAwesome.Sharp.IconButton();
            this.BtnUserAdd = new FontAwesome.Sharp.IconButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnChangePassword = new System.Windows.Forms.Button();
            this.BtnChangePicture = new System.Windows.Forms.Button();
            this.PboxUserPicture = new System.Windows.Forms.PictureBox();
            this.TxtUserEmail = new System.Windows.Forms.TextBox();
            this.LstUsers = new System.Windows.Forms.ListBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlRol.SuspendLayout();
            this.PnlFoot.SuspendLayout();
            this.PnlBasic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PboxUserPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlRol
            // 
            this.PnlRol.AutoSize = true;
            this.PnlRol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnlRol.Controls.Add(this.ChkListOptions);
            this.PnlRol.Controls.Add(this.BtnRoleDelete);
            this.PnlRol.Controls.Add(this.BtnRoleAdd);
            this.PnlRol.Controls.Add(this.LstRoles);
            this.PnlRol.Controls.Add(this.label2);
            this.PnlRol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlRol.Location = new System.Drawing.Point(0, 173);
            this.PnlRol.Name = "PnlRol";
            this.PnlRol.Size = new System.Drawing.Size(624, 220);
            this.PnlRol.TabIndex = 10;
            this.PnlRol.Visible = false;
            // 
            // ChkListOptions
            // 
            this.ChkListOptions.BackColor = System.Drawing.SystemColors.Control;
            this.ChkListOptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChkListOptions.CheckOnClick = true;
            this.ChkListOptions.ColumnWidth = 200;
            this.ChkListOptions.FormattingEnabled = true;
            this.ChkListOptions.IntegralHeight = false;
            this.ChkListOptions.Location = new System.Drawing.Point(197, 14);
            this.ChkListOptions.MultiColumn = true;
            this.ChkListOptions.Name = "ChkListOptions";
            this.ChkListOptions.Size = new System.Drawing.Size(400, 200);
            this.ChkListOptions.Sorted = true;
            this.ChkListOptions.TabIndex = 7;
            this.ChkListOptions.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ChkListOptions_ItemCheck);
            // 
            // BtnRoleDelete
            // 
            this.BtnRoleDelete.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnRoleDelete.IconColor = System.Drawing.Color.OrangeRed;
            this.BtnRoleDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRoleDelete.IconSize = 24;
            this.BtnRoleDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRoleDelete.Location = new System.Drawing.Point(107, 167);
            this.BtnRoleDelete.Name = "BtnRoleDelete";
            this.BtnRoleDelete.Size = new System.Drawing.Size(48, 37);
            this.BtnRoleDelete.TabIndex = 6;
            this.BtnRoleDelete.UseVisualStyleBackColor = true;
            // 
            // BtnRoleAdd
            // 
            this.BtnRoleAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnRoleAdd.IconColor = System.Drawing.Color.Green;
            this.BtnRoleAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRoleAdd.IconSize = 24;
            this.BtnRoleAdd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRoleAdd.Location = new System.Drawing.Point(44, 167);
            this.BtnRoleAdd.Name = "BtnRoleAdd";
            this.BtnRoleAdd.Size = new System.Drawing.Size(48, 37);
            this.BtnRoleAdd.TabIndex = 6;
            this.BtnRoleAdd.UseVisualStyleBackColor = true;
            // 
            // LstRoles
            // 
            this.LstRoles.FormattingEnabled = true;
            this.LstRoles.ItemHeight = 15;
            this.LstRoles.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.LstRoles.Location = new System.Drawing.Point(30, 30);
            this.LstRoles.Name = "LstRoles";
            this.LstRoles.Size = new System.Drawing.Size(140, 124);
            this.LstRoles.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Roles:";
            // 
            // PnlFoot
            // 
            this.PnlFoot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnlFoot.Controls.Add(this.BtnImport);
            this.PnlFoot.Controls.Add(this.BtnExport);
            this.PnlFoot.Controls.Add(this.BtnCancel);
            this.PnlFoot.Controls.Add(this.BtnApply);
            this.PnlFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFoot.Location = new System.Drawing.Point(0, 393);
            this.PnlFoot.Name = "PnlFoot";
            this.PnlFoot.Size = new System.Drawing.Size(624, 48);
            this.PnlFoot.TabIndex = 12;
            // 
            // BtnImport
            // 
            this.BtnImport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnImport.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.BtnImport.IconColor = System.Drawing.Color.DarkOrange;
            this.BtnImport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnImport.IconSize = 30;
            this.BtnImport.Location = new System.Drawing.Point(62, 7);
            this.BtnImport.Margin = new System.Windows.Forms.Padding(0);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(100, 35);
            this.BtnImport.TabIndex = 7;
            this.BtnImport.Text = "Importar";
            this.BtnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImport.UseCompatibleTextRendering = true;
            this.BtnImport.UseVisualStyleBackColor = true;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // BtnExport
            // 
            this.BtnExport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExport.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.BtnExport.IconColor = System.Drawing.Color.DarkBlue;
            this.BtnExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExport.IconSize = 30;
            this.BtnExport.Location = new System.Drawing.Point(191, 7);
            this.BtnExport.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(100, 35);
            this.BtnExport.TabIndex = 7;
            this.BtnExport.Text = "Exportar";
            this.BtnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExport.UseCompatibleTextRendering = true;
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.BtnCancel.IconColor = System.Drawing.Color.OrangeRed;
            this.BtnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancel.IconSize = 30;
            this.BtnCancel.Location = new System.Drawing.Point(320, 7);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 35);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancel.UseCompatibleTextRendering = true;
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnApply
            // 
            this.BtnApply.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnApply.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.BtnApply.IconColor = System.Drawing.Color.Green;
            this.BtnApply.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnApply.IconSize = 30;
            this.BtnApply.Location = new System.Drawing.Point(449, 7);
            this.BtnApply.Margin = new System.Windows.Forms.Padding(0);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(100, 35);
            this.BtnApply.TabIndex = 7;
            this.BtnApply.Text = "Aceptar";
            this.BtnApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnApply.UseCompatibleTextRendering = true;
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // BtnExpand
            // 
            this.BtnExpand.Location = new System.Drawing.Point(305, 146);
            this.BtnExpand.Name = "BtnExpand";
            this.BtnExpand.Size = new System.Drawing.Size(27, 23);
            this.BtnExpand.TabIndex = 7;
            this.BtnExpand.Text = "▼";
            this.BtnExpand.UseVisualStyleBackColor = true;
            this.BtnExpand.Click += new System.EventHandler(this.BtnExpand_Click);
            // 
            // PnlBasic
            // 
            this.PnlBasic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnlBasic.Controls.Add(this.BtnUserDelete);
            this.PnlBasic.Controls.Add(this.BtnUserAdd);
            this.PnlBasic.Controls.Add(this.BtnExpand);
            this.PnlBasic.Controls.Add(this.comboBox1);
            this.PnlBasic.Controls.Add(this.BtnChangePassword);
            this.PnlBasic.Controls.Add(this.BtnChangePicture);
            this.PnlBasic.Controls.Add(this.PboxUserPicture);
            this.PnlBasic.Controls.Add(this.TxtUserEmail);
            this.PnlBasic.Controls.Add(this.LstUsers);
            this.PnlBasic.Controls.Add(this.TxtUserName);
            this.PnlBasic.Controls.Add(this.label4);
            this.PnlBasic.Controls.Add(this.label3);
            this.PnlBasic.Controls.Add(this.label5);
            this.PnlBasic.Controls.Add(this.label1);
            this.PnlBasic.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBasic.Location = new System.Drawing.Point(0, 0);
            this.PnlBasic.Name = "PnlBasic";
            this.PnlBasic.Size = new System.Drawing.Size(624, 173);
            this.PnlBasic.TabIndex = 11;
            // 
            // BtnUserDelete
            // 
            this.BtnUserDelete.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnUserDelete.IconColor = System.Drawing.Color.OrangeRed;
            this.BtnUserDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnUserDelete.IconSize = 24;
            this.BtnUserDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnUserDelete.Location = new System.Drawing.Point(107, 125);
            this.BtnUserDelete.Name = "BtnUserDelete";
            this.BtnUserDelete.Size = new System.Drawing.Size(48, 37);
            this.BtnUserDelete.TabIndex = 7;
            this.BtnUserDelete.UseVisualStyleBackColor = true;
            // 
            // BtnUserAdd
            // 
            this.BtnUserAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnUserAdd.IconColor = System.Drawing.Color.Green;
            this.BtnUserAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnUserAdd.IconSize = 24;
            this.BtnUserAdd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnUserAdd.Location = new System.Drawing.Point(44, 125);
            this.BtnUserAdd.Name = "BtnUserAdd";
            this.BtnUserAdd.Size = new System.Drawing.Size(48, 37);
            this.BtnUserAdd.TabIndex = 8;
            this.BtnUserAdd.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(245, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // BtnChangePassword
            // 
            this.BtnChangePassword.Location = new System.Drawing.Point(372, 110);
            this.BtnChangePassword.Name = "BtnChangePassword";
            this.BtnChangePassword.Size = new System.Drawing.Size(99, 23);
            this.BtnChangePassword.TabIndex = 4;
            this.BtnChangePassword.Text = "Cambiar Clave";
            this.BtnChangePassword.UseVisualStyleBackColor = true;
            // 
            // BtnChangePicture
            // 
            this.BtnChangePicture.Location = new System.Drawing.Point(507, 137);
            this.BtnChangePicture.Name = "BtnChangePicture";
            this.BtnChangePicture.Size = new System.Drawing.Size(75, 23);
            this.BtnChangePicture.TabIndex = 4;
            this.BtnChangePicture.Text = "Cambiar...";
            this.BtnChangePicture.UseVisualStyleBackColor = true;
            // 
            // PboxUserPicture
            // 
            this.PboxUserPicture.Image = ((System.Drawing.Image)(resources.GetObject("PboxUserPicture.Image")));
            this.PboxUserPicture.Location = new System.Drawing.Point(497, 25);
            this.PboxUserPicture.Name = "PboxUserPicture";
            this.PboxUserPicture.Size = new System.Drawing.Size(100, 100);
            this.PboxUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PboxUserPicture.TabIndex = 3;
            this.PboxUserPicture.TabStop = false;
            // 
            // TxtUserEmail
            // 
            this.TxtUserEmail.Location = new System.Drawing.Point(245, 69);
            this.TxtUserEmail.Name = "TxtUserEmail";
            this.TxtUserEmail.Size = new System.Drawing.Size(226, 23);
            this.TxtUserEmail.TabIndex = 2;
            // 
            // LstUsers
            // 
            this.LstUsers.FormattingEnabled = true;
            this.LstUsers.ItemHeight = 15;
            this.LstUsers.Location = new System.Drawing.Point(30, 30);
            this.LstUsers.Name = "LstUsers";
            this.LstUsers.Size = new System.Drawing.Size(138, 79);
            this.LstUsers.TabIndex = 0;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(245, 30);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(226, 23);
            this.TxtUserName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Rol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Usuarios:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.PnlRol);
            this.Controls.Add(this.PnlFoot);
            this.Controls.Add(this.PnlBasic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(640, 200);
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.PnlRol.ResumeLayout(false);
            this.PnlRol.PerformLayout();
            this.PnlFoot.ResumeLayout(false);
            this.PnlBasic.ResumeLayout(false);
            this.PnlBasic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PboxUserPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PnlRol;
        private Panel PnlFoot;
        private Button BtnExpand;
        private Panel PnlBasic;
        private Button BtnChangePicture;
        private PictureBox PboxUserPicture;
        private TextBox TxtUserEmail;
        private ListBox LstUsers;
        private TextBox TxtUserName;
        private Label label3;
        private Label label1;
        private Label label4;
        private ComboBox comboBox1;
        private ListBox LstRoles;
        private Label label2;
        private Button BtnChangePassword;
        private Label label5;
        private FontAwesome.Sharp.IconButton BtnApply;
        private FontAwesome.Sharp.IconButton BtnImport;
        private FontAwesome.Sharp.IconButton BtnExport;
        private FontAwesome.Sharp.IconButton BtnCancel;
        private FontAwesome.Sharp.IconButton BtnRoleDelete;
        private FontAwesome.Sharp.IconButton BtnRoleAdd;
        private FontAwesome.Sharp.IconButton BtnUserDelete;
        private FontAwesome.Sharp.IconButton BtnUserAdd;
        private CheckedListBox ChkListOptions;
    }
}