using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FontAwesome.Sharp;

namespace Cookies_V2._0.Views
{
    public partial class ucShiftInfo : DevExpress.XtraEditors.XtraUserControl
    {
        public ucShiftInfo()
        {
            InitializeComponent();

            layoutShift.CaptionImageOptions.Image = IconChar.CalendarAlt.ToBitmap(85, Color.Orange);

            //cmdShiftX.ImageOptions.Image = IconChar.UserClock.ToBitmap(85, Color.Green);
            //cmdShiftY.ImageOptions.Image = IconChar.UserClock.ToBitmap(85, Color.Brown);
            //cmdShiftZ.ImageOptions.Image = IconChar.UserClock.ToBitmap(85, Color.OliveDrab);

            layoutTeamLead.CaptionImageOptions.Image = IconChar.UserCog.ToBitmap(85, Color.PaleVioletRed);
            layoutMachine.CaptionImageOptions.Image = IconChar.Whmcs.ToBitmap(85, Color.DarkGray);

            cmdOKShift.ImageOptions.Image = IconChar.Save.ToBitmap(85, Color.Brown);
            cmdCancelShift.ImageOptions.Image = IconChar.WindowClose.ToBitmap(85, Color.Brown);
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            frmMain formMain = this.FindForm() as frmMain;            

            if (formMain.ShowSaveFlyoutMessage() == DialogResult.OK)
            {
                if (formMain.windowsUIView.ActiveContentContainer.Name == "pageGroup1")
                {
                    formMain.windowsUIView.ActivateDocument(formMain.windowsUIView.Documents[4]);
                }
                else if (formMain.windowsUIView.ActiveContentContainer.Name == "pageGroup2")
                {
                    formMain.windowsUIView.ActivateDocument(formMain.windowsUIView.Documents[0]);
                }
            }
        }

        private void cmdCancelShift_Click(object sender, EventArgs e)
        {

        }

        private void ucShiftInfo_Load(object sender, EventArgs e)
        {
            frmMain formMain = this.FindForm() as frmMain;

            if (formMain.windowsUIView.ActiveContentContainer.Name == "pageGroup2")
            {
                listShift.SelectedValue = "Y";
                txtMachine.Text = "04";
            }
            else if (formMain.windowsUIView.ActiveContentContainer.Name == "pageGroup1")
            {
                listShift.SelectedValue = "X";
                txtMachine.Text = null;
            }
        }
    }
}
