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
    public partial class ucScaleManual : DevExpress.XtraEditors.XtraUserControl
    {        
        public ucScaleManual()
        {
            InitializeComponent();

            layoutCookieType.CaptionImageOptions.Image = IconChar.DollyFlatbed.ToBitmap(85, Color.PaleVioletRed);
            layoutScaleWeight.CaptionImageOptions.Image = IconChar.Weight.ToBitmap(85, Color.PaleVioletRed);

            cmdItemCookie.ImageOptions.Image = IconChar.ShoePrints.ToBitmap(85, Color.DarkOrange);
            cmdMixedCookie.ImageOptions.Image = IconChar.Recycle.ToBitmap(85, Color.DarkGray);
            cmdPurgingCookie.ImageOptions.Image = IconChar.Envira.ToBitmap(85, Color.DarkSeaGreen);

            cmdFinish.ImageOptions.Image = IconChar.CheckDouble.ToBitmap(85, Color.Brown);
        }

        private void cmdItemCookie_Click(object sender, EventArgs e)
        {
            frmMain formMain = this.FindForm() as frmMain;
            formMain.ShowSaveWeightFlyoutMessage();
        }

        private void cmdMixedCookie_Click(object sender, EventArgs e)
        {
            frmMain formMain = this.FindForm() as frmMain;
            formMain.ShowSaveWeightFlyoutMessage();
        }

        private void cmdPurgingCookie_Click(object sender, EventArgs e)
        {
            frmMain formMain = this.FindForm() as frmMain;
            formMain.ShowSaveWeightFlyoutMessage();
        }

        private void cmdFinish_Click(object sender, EventArgs e)
        {
            frmMain formMain = this.FindForm() as frmMain;            
            if (formMain.ShowFinishScaleMessage() == DialogResult.No)
            {                
                formMain.windowsUIView.ActivateTile(formMain.windowsUIView.Tiles[1]);
                formMain.windowsUIView.ActivateDocument(formMain.windowsUIView.Documents[1]);
            }
            else
            {
                if (formMain.windowsUIView.ActiveContentContainer.Name == "pageGroup1")
                {
                    formMain.windowsUIView.ActivateDocument(formMain.windowsUIView.Documents[3]);
                }
                else if (formMain.windowsUIView.ActiveContentContainer.Name == "pageGroup2")
                {
                    formMain.windowsUIView.ActivateDocument(formMain.windowsUIView.Documents[4]);
                }                
            }
        }
    }
}
