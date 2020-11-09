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
    public partial class ucItemInfo : DevExpress.XtraEditors.XtraUserControl
    {
        public ucItemInfo()
        {
            InitializeComponent();

            layoutItem.CaptionImageOptions.Image = IconChar.ShoePrints.ToBitmap(85, Color.Orange);
            layoutReason.CaptionImageOptions.Image = IconChar.Edit.ToBitmap(85, Color.BlueViolet);
            layoutPurging.CaptionImageOptions.Image = IconChar.Tools.ToBitmap(85, Color.DimGray);


            cmdSaveItem.ImageOptions.Image = IconChar.Save.ToBitmap(85, Color.Brown);
            cmdCancelItem.ImageOptions.Image = IconChar.WindowClose.ToBitmap(85, Color.Brown);

            
        }

        private void cmdSaveItem_Click(object sender, EventArgs e)
        {
            frmMain formMain = this.FindForm() as frmMain;

            if (formMain.ShowSaveFlyoutMessage() == DialogResult.OK)
            {
                if (formMain.windowsUIView.ActiveContentContainer.Name == "pageGroup1")
                {
                    formMain.windowsUIView.ActivateDocument(formMain.windowsUIView.Documents[0]);
                }
                else if (formMain.windowsUIView.ActiveContentContainer.Name == "pageGroup2")
                {
                    formMain.windowsUIView.ActivateDocument(formMain.windowsUIView.Documents[3]);
                }
            }
        }

        private void ucItemInfo_Load(object sender, EventArgs e)
        {
            frmMain formMain = this.FindForm() as frmMain;
            if (formMain.windowsUIView.ActiveContentContainer.Name == "pageGroup2")
            {
                lookupItem.Text = "MI|20201013|0-VD321905-NBTR-0000|12670";
                textItemName.Text = "Base Shank #BBKLS V1_new Color:Citra Yellow NB-S21-2840";
            }
            else if (formMain.windowsUIView.ActiveContentContainer.Name == "pageGroup1")
            {
                lookupItem.Text = "Input Item Name (suggestion)";
                textItemName.Text = "Base Shank #BBKLS V1_new Color:Citra Yellow NB-S21-2840";
            }
        }
    }
}
