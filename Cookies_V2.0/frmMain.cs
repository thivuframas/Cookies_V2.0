using DevExpress.XtraEditors;
using System.Collections.Generic;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Docking2010.Views;
using System.Drawing;
using FontAwesome.Sharp;
using Cookies_V2._0.Views;
using System.Diagnostics;
using System.Windows.Forms;

namespace Cookies_V2._0
{
    public partial class frmMain : XtraForm
    {
        DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction closeAppAction = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction()
        {
            Caption = "Xác nhận",
            Description = "Bạn có muốn thoát khỏi ứng dụng?"            
        };

        DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction saveAction = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction()
        {
            Caption = "Xác nhận",
            Description = "Bạn có chắc chắn lưu thông tin?"
        };

        DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction saveWeightAction = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction()
        {
            Caption = "Xác nhận",
            Description = "Bạn có chắc chắn lưu số liệu vừa cân?"
        };

        DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction finishScaleCookiesAction = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction()
        {
            Caption = "Xác nhận",
            Description = "Bạn có muốn kết thúc đợt cân cookies này?"
        };

        public frmMain()
        {
            InitializeComponent();

            closeAppAction.Commands.Add(FlyoutCommand.OK);
            closeAppAction.Commands.Add(FlyoutCommand.Cancel);

            closeAppFlyout.Action = closeAppAction;

            saveAction.Commands.Add(new SaveCommand());
            saveAction.Commands.Add(FlyoutCommand.Cancel);            

            saveFlyout.Action = saveAction;

            saveWeightAction.Commands.Add(FlyoutCommand.OK);
            saveWeightAction.Commands.Add(FlyoutCommand.Cancel);

            saveWeightFlyout.Action = saveWeightAction;

            finishScaleCookiesAction.Commands.Add(new FinishYesCommand());
            finishScaleCookiesAction.Commands.Add(new FinishNoCommand());

            finishScaleCookiesFlyout.Action = finishScaleCookiesAction;

            var bitmap1 = IconChar.CookieBite.ToBitmap(96, Color.Azure);
            var bitmap2 = IconChar.Weight.ToBitmap(96, Color.Azure);
            var bitmap3 = IconChar.ChartBar.ToBitmap(96, Color.Azure);

            ucScaleManualTile.Elements[1].Image = bitmap1;
            ucScalewScanTile.Elements[1].Image = bitmap2;
            ucStatisticTile.Elements[1].Image = bitmap3;           
                        
            this.windowsUIView.QueryControl += windowsUIView_QueryControl;
        }
        
        // Assigning a required content for each auto generated Document
        void windowsUIView_QueryControl(object sender, QueryControlEventArgs e)
        {   
            if (e.Document == ucScaleManualDocument)
                e.Control = new Cookies_V2._0.Views.ucScaleManual();
            if (e.Document == ucScalewScanDocument)
                e.Control = new Cookies_V2._0.Views.ucScalewScan();
            if (e.Document == ucStatisticDocument)
                e.Control = new Cookies_V2._0.Views.ucStatistic();
            if (e.Document == ucShiftInfoDocument)
                e.Control = new Cookies_V2._0.Views.ucShiftInfo();
            if (e.Document == ucItemInfoDocument)
                e.Control = new Cookies_V2._0.Views.ucItemInfo();
            if (e.Control == null)
                e.Control = new System.Windows.Forms.Control();
        }      

        private void frmMain_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (windowsUIView.ShowFlyoutDialog(closeAppFlyout) != System.Windows.Forms.DialogResult.OK) e.Cancel = true;
        }

        public DialogResult ShowSaveFlyoutMessage()
        {
            return windowsUIView.ShowFlyoutDialog(saveFlyout);
        }

        public DialogResult ShowSaveWeightFlyoutMessage()
        {
            return windowsUIView.ShowFlyoutDialog(saveWeightFlyout);
        }

        public DialogResult ShowFinishScaleMessage()
        {
            return windowsUIView.ShowFlyoutDialog(finishScaleCookiesFlyout);
        }
    }

    class SaveCommand : FlyoutCommand
    {
        public override string Text
        {
            get
            {
                return "Lưu";
            }
        }
        public override DialogResult Result
        {
            get
            {
                return DialogResult.OK;
            }
        }
    }

    class FinishYesCommand : FlyoutCommand
    {
        public override string Text
        {
            get
            {
                return "Kết thúc và tiếp tục cân";
            }
        }
        public override DialogResult Result
        {
            get
            {
                return DialogResult.Yes;
            }
        }
    }

    class FinishNoCommand : FlyoutCommand
    {
        public override string Text
        {
            get
            {
                return "Kết thúc";
            }
        }
        public override DialogResult Result
        {
            get
            {
                return DialogResult.No;
            }
        }
    }
}
