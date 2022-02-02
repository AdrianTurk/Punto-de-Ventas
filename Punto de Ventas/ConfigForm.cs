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
            BtnRoleAdd.Enabled = false;
            
        }

        private void BtnExpand_Click(object sender, EventArgs e)
        {
            PnlRol.Visible = !PnlRol.Visible;
            BtnExpand.Text= PnlRol.Visible? "▲" : "▼";
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

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = LstRoles.Items;
            //TODO: Borrar este codigo de prueba - solo mantiene grans en 
            LoadListGrants(((MainForm)this.Owner).LoggedUser.Grants);
        }

        private void ChkListOptions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if ((e is not null) &
                (Enum.GetName((UserGrants)ChkListOptions.Items[e.Index]).ToString().StartsWith('R')))
                        LoadListGrants(
                            (UserGrants) ChkListOptions.Items[e.Index],
                            false );
        }
    }
}
