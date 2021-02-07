
namespace TimeSheetReminder
{
    partial class TimeSheet : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public TimeSheet()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeSheet));
            this.tabTimeSheet = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnAdd = this.Factory.CreateRibbonButton();
            this.timerReminder = new System.Windows.Forms.Timer(this.components);
            this.tabTimeSheet.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTimeSheet
            // 
            this.tabTimeSheet.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabTimeSheet.Groups.Add(this.group1);
            this.tabTimeSheet.Label = "Time Sheet";
            this.tabTimeSheet.Name = "tabTimeSheet";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnAdd);
            this.group1.Label = "Operations";
            this.group1.Name = "group1";
            // 
            // btnAdd
            // 
            this.btnAdd.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Label = "Add";
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShowImage = true;
            this.btnAdd.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAdd_Click);
            // 
            // timerReminder
            // 
            this.timerReminder.Tick += new System.EventHandler(this.timerReminder_Tick);
            // 
            // TimeSheet
            // 
            this.Name = "TimeSheet";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.tabTimeSheet);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.TimeSheet_Load);
            this.tabTimeSheet.ResumeLayout(false);
            this.tabTimeSheet.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabTimeSheet;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAdd;
        private System.Windows.Forms.Timer timerReminder;
    }

    partial class ThisRibbonCollection
    {
        internal TimeSheet TimeSheet
        {
            get { return this.GetRibbon<TimeSheet>(); }
        }
    }
}
