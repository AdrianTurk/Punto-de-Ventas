using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_Ventas
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void BtnExpand_Click(object sender, EventArgs e)
        {
            PnlRol.Visible = !PnlRol.Visible;
            BtnExpand.Text= PnlRol.Visible? "▲ Permisos ▲" : "▼ Permisos ▼";
            //this.Height = this.Height -  ( PnlRol.Visible? 0 : PnlRol.Height);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadListGrants(UserGrants grants=UserGrants.R_NONE, bool clear=true)
        {
            
            this.ChkListOptions.ItemCheck -= ChkListOptions_ItemCheck;

            if (ChkListOptions.DataSource is null) 
                ChkListOptions.DataSource = Enum.GetValues(typeof(UserGrants));

            foreach (UserGrants grant in Enum.GetValues<UserGrants>())
            {
                if (grants.HasFlag(grant))
                    ChkListOptions.SetItemChecked(
                        ChkListOptions.Items.IndexOf(grant),true);
                else if (clear)
                    ChkListOptions.SetItemChecked(
                        ChkListOptions.Items.IndexOf(grant), false);
            }
            this.ChkListOptions.ItemCheck += ChkListOptions_ItemCheck;
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            UserGrants res=0;
            
            foreach (UserGrants Grant in ChkListOptions.CheckedItems)
                res|=Grant;
            //TODO: REMOVE NEXT CODE
            ((MainForm)this.Owner).LoggedUser.Grants = res;
            this.Close();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented"); // TODO
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented"); // TODO
        }

        UserGrants currentGrants=UserGrants.R_NONE;

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            //TODO: Borrar este codigo de prueba - solo mantiene grans en 
            currentGrants= ((MainForm)this.Owner).LoggedUser.Grants;

            LoadListGrants(currentGrants);
            bool isAdmin = currentGrants.HasFlag(UserGrants.R_ADMIN);
            ChkListOptions.Enabled = isAdmin;
            BtnUserAdd.Enabled = isAdmin;
            BtnUserDelete.Enabled = isAdmin;
            BtnExport.Enabled = isAdmin;
            BtnImport.Enabled = isAdmin;

        }

        private void ChkListOptions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if ((e is not null) &
                (Enum.GetName((UserGrants)ChkListOptions.Items[e.Index]).ToString().StartsWith('R')))
                        LoadListGrants(
                            (UserGrants) ChkListOptions.Items[e.Index],
                            false );
        }

        private void BtnUserDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
