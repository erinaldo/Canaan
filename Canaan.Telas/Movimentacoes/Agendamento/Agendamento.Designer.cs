using System.ComponentModel;
using System.Windows.Forms;
using Canaan.Lib.Componentes;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.UI;

namespace Canaan.Telas.Movimentacoes.Agendamento
{
    partial class Agendamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agendamento));
            this.schedulerBarController1 = new DevExpress.XtraScheduler.UI.SchedulerBarController();
            this.openScheduleItem1 = new DevExpress.XtraScheduler.UI.OpenScheduleItem();
            this.saveScheduleItem1 = new DevExpress.XtraScheduler.UI.SaveScheduleItem();
            this.printPreviewItem1 = new DevExpress.XtraScheduler.UI.PrintPreviewItem();
            this.printItem1 = new DevExpress.XtraScheduler.UI.PrintItem();
            this.printPageSetupItem1 = new DevExpress.XtraScheduler.UI.PrintPageSetupItem();
            this.newAppointmentItem1 = new DevExpress.XtraScheduler.UI.NewAppointmentItem();
            this.gotoTodayItem1 = new DevExpress.XtraScheduler.UI.GotoTodayItem();
            this.switchToDayViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToDayViewItem();
            this.switchToWorkWeekViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem();
            this.switchToWeekViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToWeekViewItem();
            this.switchToMonthViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToMonthViewItem();
            this.switchTimeScalesItem1 = new DevExpress.XtraScheduler.UI.SwitchTimeScalesItem();
            this.changeScaleWidthItem1 = new DevExpress.XtraScheduler.UI.ChangeScaleWidthItem();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.switchTimeScalesCaptionItem1 = new DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem();
            this.switchCompressWeekendItem1 = new DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem();
            this.switchShowWorkTimeOnlyItem1 = new DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem();
            this.switchCellsAutoHeightItem1 = new DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem();
            this.changeSnapToCellsUIItem1 = new DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem();
            this.editAppointmentQueryItem2 = new DevExpress.XtraScheduler.UI.EditAppointmentQueryItem();
            this.editOccurrenceUICommandItem1 = new DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem();
            this.editSeriesUICommandItem1 = new DevExpress.XtraScheduler.UI.EditSeriesUICommandItem();
            this.deleteAppointmentsItem1 = new DevExpress.XtraScheduler.UI.DeleteAppointmentsItem();
            this.deleteOccurrenceItem1 = new DevExpress.XtraScheduler.UI.DeleteOccurrenceItem();
            this.deleteSeriesItem1 = new DevExpress.XtraScheduler.UI.DeleteSeriesItem();
            this.splitAppointmentItem1 = new DevExpress.XtraScheduler.UI.SplitAppointmentItem();
            this.changeAppointmentStatusItem1 = new DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem();
            this.changeAppointmentLabelItem1 = new DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem();
            this.toggleRecurrenceItem1 = new DevExpress.XtraScheduler.UI.ToggleRecurrenceItem();
            this.changeAppointmentReminderItem1 = new DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem();
            this.repositoryItemDuration1 = new DevExpress.XtraScheduler.UI.RepositoryItemDuration();
            this.scheduler = new DevExpress.XtraScheduler.SchedulerControl();
            this.toolBar = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ckFaltante = new DevExpress.XtraBars.BarCheckItem();
            this.ckConfirmados = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.listFiltros = new DevExpress.XtraBars.BarSubItem();
            this.bLinkContainerItem = new DevExpress.XtraBars.BarLinkContainerItem();
            this.btDescartar = new DevExpress.XtraBars.BarButtonItem();
            this.homeRibbonPage1 = new DevExpress.XtraScheduler.UI.HomeRibbonPage();
            this.appointmentRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.AppointmentRibbonPageGroup();
            this.recepcao = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.navigatorRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.NavigatorRibbonPageGroup();
            this.arrangeRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.ArrangeRibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.editAppointmentQueryItem1 = new DevExpress.XtraScheduler.UI.EditAppointmentQueryItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cLabel5 = new Canaan.Lib.Componentes.CLabel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.cLabel4 = new Canaan.Lib.Componentes.CLabel();
            this.cLabel3 = new Canaan.Lib.Componentes.CLabel();
            this.cLabel2 = new Canaan.Lib.Componentes.CLabel();
            this.cLabel1 = new Canaan.Lib.Componentes.CLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateNavigator = new DevExpress.XtraScheduler.DateNavigator();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDuration1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerBarController1
            // 
            this.schedulerBarController1.BarItems.Add(this.openScheduleItem1);
            this.schedulerBarController1.BarItems.Add(this.saveScheduleItem1);
            this.schedulerBarController1.BarItems.Add(this.printPreviewItem1);
            this.schedulerBarController1.BarItems.Add(this.printItem1);
            this.schedulerBarController1.BarItems.Add(this.printPageSetupItem1);
            this.schedulerBarController1.BarItems.Add(this.newAppointmentItem1);
            this.schedulerBarController1.BarItems.Add(this.gotoTodayItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToDayViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToWorkWeekViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToWeekViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToMonthViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchTimeScalesItem1);
            this.schedulerBarController1.BarItems.Add(this.changeScaleWidthItem1);
            this.schedulerBarController1.BarItems.Add(this.switchTimeScalesCaptionItem1);
            this.schedulerBarController1.BarItems.Add(this.switchCompressWeekendItem1);
            this.schedulerBarController1.BarItems.Add(this.switchShowWorkTimeOnlyItem1);
            this.schedulerBarController1.BarItems.Add(this.switchCellsAutoHeightItem1);
            this.schedulerBarController1.BarItems.Add(this.changeSnapToCellsUIItem1);
            this.schedulerBarController1.BarItems.Add(this.editAppointmentQueryItem2);
            this.schedulerBarController1.BarItems.Add(this.editOccurrenceUICommandItem1);
            this.schedulerBarController1.BarItems.Add(this.editSeriesUICommandItem1);
            this.schedulerBarController1.BarItems.Add(this.deleteAppointmentsItem1);
            this.schedulerBarController1.BarItems.Add(this.deleteOccurrenceItem1);
            this.schedulerBarController1.BarItems.Add(this.deleteSeriesItem1);
            this.schedulerBarController1.BarItems.Add(this.splitAppointmentItem1);
            this.schedulerBarController1.BarItems.Add(this.changeAppointmentStatusItem1);
            this.schedulerBarController1.BarItems.Add(this.changeAppointmentLabelItem1);
            this.schedulerBarController1.BarItems.Add(this.toggleRecurrenceItem1);
            this.schedulerBarController1.BarItems.Add(this.changeAppointmentReminderItem1);
            this.schedulerBarController1.Control = this.scheduler;
            // 
            // openScheduleItem1
            // 
            this.openScheduleItem1.Id = 1;
            this.openScheduleItem1.Name = "openScheduleItem1";
            // 
            // saveScheduleItem1
            // 
            this.saveScheduleItem1.Id = 2;
            this.saveScheduleItem1.Name = "saveScheduleItem1";
            // 
            // printPreviewItem1
            // 
            this.printPreviewItem1.Id = 3;
            this.printPreviewItem1.Name = "printPreviewItem1";
            // 
            // printItem1
            // 
            this.printItem1.Id = 4;
            this.printItem1.Name = "printItem1";
            // 
            // printPageSetupItem1
            // 
            this.printPageSetupItem1.Id = 5;
            this.printPageSetupItem1.Name = "printPageSetupItem1";
            // 
            // newAppointmentItem1
            // 
            this.newAppointmentItem1.Caption = "Novo Agendamento";
            this.newAppointmentItem1.Id = 6;
            this.newAppointmentItem1.Name = "newAppointmentItem1";
            // 
            // gotoTodayItem1
            // 
            this.gotoTodayItem1.Caption = "Hoje";
            this.gotoTodayItem1.Id = 10;
            this.gotoTodayItem1.Name = "gotoTodayItem1";
            // 
            // switchToDayViewItem1
            // 
            this.switchToDayViewItem1.Caption = "&Dia";
            this.switchToDayViewItem1.Id = 13;
            this.switchToDayViewItem1.Name = "switchToDayViewItem1";
            // 
            // switchToWorkWeekViewItem1
            // 
            this.switchToWorkWeekViewItem1.Caption = "Semana de Trabalho";
            this.switchToWorkWeekViewItem1.Id = 14;
            this.switchToWorkWeekViewItem1.Name = "switchToWorkWeekViewItem1";
            // 
            // switchToWeekViewItem1
            // 
            this.switchToWeekViewItem1.Caption = "Semana";
            this.switchToWeekViewItem1.Id = 15;
            this.switchToWeekViewItem1.Name = "switchToWeekViewItem1";
            // 
            // switchToMonthViewItem1
            // 
            this.switchToMonthViewItem1.Caption = "Mês";
            this.switchToMonthViewItem1.Id = 16;
            this.switchToMonthViewItem1.Name = "switchToMonthViewItem1";
            // 
            // switchTimeScalesItem1
            // 
            this.switchTimeScalesItem1.Id = 22;
            this.switchTimeScalesItem1.Name = "switchTimeScalesItem1";
            // 
            // changeScaleWidthItem1
            // 
            this.changeScaleWidthItem1.Edit = this.repositoryItemSpinEdit1;
            this.changeScaleWidthItem1.Id = 23;
            this.changeScaleWidthItem1.Name = "changeScaleWidthItem1";
            this.changeScaleWidthItem1.UseCommandCaption = true;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // switchTimeScalesCaptionItem1
            // 
            this.switchTimeScalesCaptionItem1.Id = 24;
            this.switchTimeScalesCaptionItem1.Name = "switchTimeScalesCaptionItem1";
            // 
            // switchCompressWeekendItem1
            // 
            this.switchCompressWeekendItem1.Id = 25;
            this.switchCompressWeekendItem1.Name = "switchCompressWeekendItem1";
            // 
            // switchShowWorkTimeOnlyItem1
            // 
            this.switchShowWorkTimeOnlyItem1.Id = 26;
            this.switchShowWorkTimeOnlyItem1.Name = "switchShowWorkTimeOnlyItem1";
            // 
            // switchCellsAutoHeightItem1
            // 
            this.switchCellsAutoHeightItem1.Id = 27;
            this.switchCellsAutoHeightItem1.Name = "switchCellsAutoHeightItem1";
            // 
            // changeSnapToCellsUIItem1
            // 
            this.changeSnapToCellsUIItem1.Id = 28;
            this.changeSnapToCellsUIItem1.Name = "changeSnapToCellsUIItem1";
            // 
            // editAppointmentQueryItem2
            // 
            this.editAppointmentQueryItem2.Id = 29;
            this.editAppointmentQueryItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.editOccurrenceUICommandItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.editSeriesUICommandItem1)});
            this.editAppointmentQueryItem2.Name = "editAppointmentQueryItem2";
            this.editAppointmentQueryItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // editOccurrenceUICommandItem1
            // 
            this.editOccurrenceUICommandItem1.Id = 30;
            this.editOccurrenceUICommandItem1.Name = "editOccurrenceUICommandItem1";
            // 
            // editSeriesUICommandItem1
            // 
            this.editSeriesUICommandItem1.Id = 31;
            this.editSeriesUICommandItem1.Name = "editSeriesUICommandItem1";
            // 
            // deleteAppointmentsItem1
            // 
            this.deleteAppointmentsItem1.Id = 32;
            this.deleteAppointmentsItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteOccurrenceItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteSeriesItem1)});
            this.deleteAppointmentsItem1.Name = "deleteAppointmentsItem1";
            this.deleteAppointmentsItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // deleteOccurrenceItem1
            // 
            this.deleteOccurrenceItem1.Id = 33;
            this.deleteOccurrenceItem1.Name = "deleteOccurrenceItem1";
            // 
            // deleteSeriesItem1
            // 
            this.deleteSeriesItem1.Id = 34;
            this.deleteSeriesItem1.Name = "deleteSeriesItem1";
            // 
            // splitAppointmentItem1
            // 
            this.splitAppointmentItem1.Id = 35;
            this.splitAppointmentItem1.Name = "splitAppointmentItem1";
            // 
            // changeAppointmentStatusItem1
            // 
            this.changeAppointmentStatusItem1.Id = 36;
            this.changeAppointmentStatusItem1.Name = "changeAppointmentStatusItem1";
            // 
            // changeAppointmentLabelItem1
            // 
            this.changeAppointmentLabelItem1.Id = 37;
            this.changeAppointmentLabelItem1.Name = "changeAppointmentLabelItem1";
            // 
            // toggleRecurrenceItem1
            // 
            this.toggleRecurrenceItem1.Id = 38;
            this.toggleRecurrenceItem1.Name = "toggleRecurrenceItem1";
            // 
            // changeAppointmentReminderItem1
            // 
            this.changeAppointmentReminderItem1.Edit = this.repositoryItemDuration1;
            this.changeAppointmentReminderItem1.Id = 39;
            this.changeAppointmentReminderItem1.Name = "changeAppointmentReminderItem1";
            // 
            // repositoryItemDuration1
            // 
            this.repositoryItemDuration1.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemDuration1.AutoHeight = false;
            this.repositoryItemDuration1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDuration1.DisabledStateText = null;
            this.repositoryItemDuration1.Name = "repositoryItemDuration1";
            this.repositoryItemDuration1.NullValuePromptShowForEmptyValue = true;
            this.repositoryItemDuration1.ShowEmptyItem = true;
            this.repositoryItemDuration1.ValidateOnEnterKey = true;
            // 
            // scheduler
            // 
            this.scheduler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.scheduler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scheduler.DragDropMode = DevExpress.XtraScheduler.DragDropMode.Manual;
            this.scheduler.Location = new System.Drawing.Point(200, 141);
            this.scheduler.MenuManager = this.toolBar;
            this.scheduler.Name = "scheduler";
            this.scheduler.OptionsCustomization.AllowAppointmentConflicts = DevExpress.XtraScheduler.AppointmentConflictsMode.Custom;
            this.scheduler.OptionsCustomization.AllowAppointmentCopy = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.scheduler.OptionsCustomization.AllowAppointmentCreate = DevExpress.XtraScheduler.UsedAppointmentType.Custom;
            this.scheduler.OptionsCustomization.AllowAppointmentDelete = DevExpress.XtraScheduler.UsedAppointmentType.Custom;
            this.scheduler.OptionsCustomization.AllowAppointmentDrag = DevExpress.XtraScheduler.UsedAppointmentType.Custom;
            this.scheduler.OptionsCustomization.AllowAppointmentMultiSelect = false;
            this.scheduler.OptionsCustomization.AllowAppointmentResize = DevExpress.XtraScheduler.UsedAppointmentType.Custom;
            this.scheduler.OptionsCustomization.AllowInplaceEditor = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.scheduler.OptionsView.NavigationButtons.NextCaption = "Próximo Cupom";
            this.scheduler.OptionsView.NavigationButtons.PrevCaption = "Cupom Anterior";
            this.scheduler.Size = new System.Drawing.Size(918, 473);
            this.scheduler.Start = new System.DateTime(2013, 10, 7, 0, 0, 0, 0);
            this.scheduler.TabIndex = 5;
            this.scheduler.Text = "schedulerControl1";
            this.scheduler.Views.DayView.TimeRulers.Add(timeRuler1);
            this.scheduler.Views.GanttView.Enabled = false;
            this.scheduler.Views.TimelineView.Enabled = false;
            this.scheduler.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            this.scheduler.SelectionChanged += new System.EventHandler(this.schedulerControl1_SelectionChanged);
            this.scheduler.VisibleIntervalChanged += new System.EventHandler(this.schedulerControl1_VisibleIntervalChanged);
            this.scheduler.QueryWorkTime += new DevExpress.XtraScheduler.QueryWorkTimeEventHandler(this.schedulerControl1_QueryWorkTime);
            this.scheduler.InitAppointmentDisplayText += new DevExpress.XtraScheduler.AppointmentDisplayTextEventHandler(this.schedulerControl1_InitAppointmentDisplayText);
            this.scheduler.AppointmentViewInfoCustomizing += new DevExpress.XtraScheduler.AppointmentViewInfoCustomizingEventHandler(this.scheduler_AppointmentViewInfoCustomizing);
            this.scheduler.AllowAppointmentDrag += new DevExpress.XtraScheduler.AppointmentOperationEventHandler(this.scheduler_AllowAppointmentDrag);
            this.scheduler.AllowAppointmentResize += new DevExpress.XtraScheduler.AppointmentOperationEventHandler(this.scheduler_AllowAppointmentResize);
            this.scheduler.AllowAppointmentDelete += new DevExpress.XtraScheduler.AppointmentOperationEventHandler(this.scheduler_AllowAppointmentDelete);
            this.scheduler.AllowAppointmentCreate += new DevExpress.XtraScheduler.AppointmentOperationEventHandler(this.schedulerControl1_AllowAppointmentCreate);
            this.scheduler.AppointmentDrop += new DevExpress.XtraScheduler.AppointmentDragEventHandler(this.schedulerControl1_AppointmentDrop);
            this.scheduler.AllowAppointmentConflicts += new DevExpress.XtraScheduler.AppointmentConflictEventHandler(this.schedulerControl1_AllowAppointmentConflicts);
            this.scheduler.PopupMenuShowing += new DevExpress.XtraScheduler.PopupMenuShowingEventHandler(this.schedulerControl1_PopupMenuShowing);
            this.scheduler.EditAppointmentFormShowing += new DevExpress.XtraScheduler.AppointmentFormEventHandler(this.schedulerControl1_EditAppointmentFormShowing);
            this.scheduler.VisibleChanged += new System.EventHandler(this.scheduler_VisibleChanged);
            // 
            // toolBar
            // 
            this.toolBar.ExpandCollapseItem.Id = 0;
            this.toolBar.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.toolBar.ExpandCollapseItem,
            this.openScheduleItem1,
            this.saveScheduleItem1,
            this.printPreviewItem1,
            this.printItem1,
            this.printPageSetupItem1,
            this.newAppointmentItem1,
            this.gotoTodayItem1,
            this.switchToDayViewItem1,
            this.switchToWorkWeekViewItem1,
            this.switchToWeekViewItem1,
            this.switchToMonthViewItem1,
            this.switchTimeScalesItem1,
            this.changeScaleWidthItem1,
            this.switchTimeScalesCaptionItem1,
            this.switchCompressWeekendItem1,
            this.switchShowWorkTimeOnlyItem1,
            this.switchCellsAutoHeightItem1,
            this.changeSnapToCellsUIItem1,
            this.editAppointmentQueryItem2,
            this.editOccurrenceUICommandItem1,
            this.editSeriesUICommandItem1,
            this.deleteAppointmentsItem1,
            this.deleteOccurrenceItem1,
            this.deleteSeriesItem1,
            this.splitAppointmentItem1,
            this.changeAppointmentStatusItem1,
            this.changeAppointmentLabelItem1,
            this.toggleRecurrenceItem1,
            this.changeAppointmentReminderItem1,
            this.barButtonItem1,
            this.barButtonItem2,
            this.ckFaltante,
            this.ckConfirmados,
            this.barButtonItem3,
            this.listFiltros,
            this.bLinkContainerItem,
            this.btDescartar,
            this.barButtonItem4});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.MaxItemId = 70;
            this.toolBar.Name = "toolBar";
            this.toolBar.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.homeRibbonPage1});
            this.toolBar.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemDuration1,
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2,
            this.repositoryItemComboBox3});
            this.toolBar.ShowToolbarCustomizeItem = false;
            this.toolBar.Size = new System.Drawing.Size(1118, 141);
            this.toolBar.Toolbar.ShowCustomizeItem = false;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Faltantes";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 40;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btFaltante_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Confirmar";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 41;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btConfirmar_ItemClick);
            // 
            // ckFaltante
            // 
            this.ckFaltante.Caption = "Visualizar Faltantes";
            this.ckFaltante.Glyph = ((System.Drawing.Image)(resources.GetObject("ckFaltante.Glyph")));
            this.ckFaltante.Id = 53;
            this.ckFaltante.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ckFaltante.LargeGlyph")));
            this.ckFaltante.Name = "ckFaltante";
            this.ckFaltante.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.ckFaltante_CheckedChanged);
            this.ckFaltante.DownChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.ckFaltante_DownChanged);
            // 
            // ckConfirmados
            // 
            this.ckConfirmados.Caption = "Visualizar Confirmados";
            this.ckConfirmados.Glyph = ((System.Drawing.Image)(resources.GetObject("ckConfirmados.Glyph")));
            this.ckConfirmados.Id = 55;
            this.ckConfirmados.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ckConfirmados.LargeGlyph")));
            this.ckConfirmados.Name = "ckConfirmados";
            this.ckConfirmados.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.ckConfirmados_CheckedChanged);
            this.ckConfirmados.DownChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.ckConfirmados_DownChanged);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Recepção de Cliente";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 56;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // listFiltros
            // 
            this.listFiltros.Caption = "Filtros";
            this.listFiltros.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.listFiltros.Glyph = ((System.Drawing.Image)(resources.GetObject("listFiltros.Glyph")));
            this.listFiltros.Id = 65;
            this.listFiltros.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("listFiltros.LargeGlyph")));
            this.listFiltros.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bLinkContainerItem)});
            this.listFiltros.Name = "listFiltros";
            // 
            // bLinkContainerItem
            // 
            this.bLinkContainerItem.Caption = "bLinkContainerItem";
            this.bLinkContainerItem.Id = 66;
            this.bLinkContainerItem.Name = "bLinkContainerItem";
            // 
            // btDescartar
            // 
            this.btDescartar.Caption = "Excluir Agendamento";
            this.btDescartar.Glyph = ((System.Drawing.Image)(resources.GetObject("btDescartar.Glyph")));
            this.btDescartar.Id = 68;
            this.btDescartar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btDescartar.LargeGlyph")));
            this.btDescartar.Name = "btDescartar";
            this.btDescartar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btDescartar_ItemClick);
            // 
            // homeRibbonPage1
            // 
            this.homeRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.appointmentRibbonPageGroup1,
            this.recepcao,
            this.navigatorRibbonPageGroup1,
            this.arrangeRibbonPageGroup1,
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup4,
            this.ribbonPageGroup3});
            this.homeRibbonPage1.Name = "homeRibbonPage1";
            // 
            // appointmentRibbonPageGroup1
            // 
            this.appointmentRibbonPageGroup1.ItemLinks.Add(this.newAppointmentItem1);
            this.appointmentRibbonPageGroup1.Name = "appointmentRibbonPageGroup1";
            this.appointmentRibbonPageGroup1.Text = "Agendamento";
            // 
            // recepcao
            // 
            this.recepcao.ItemLinks.Add(this.barButtonItem3);
            this.recepcao.Name = "recepcao";
            this.recepcao.Text = "Recepção";
            // 
            // navigatorRibbonPageGroup1
            // 
            this.navigatorRibbonPageGroup1.ItemLinks.Add(this.gotoTodayItem1);
            this.navigatorRibbonPageGroup1.Name = "navigatorRibbonPageGroup1";
            this.navigatorRibbonPageGroup1.Text = "Navegação";
            // 
            // arrangeRibbonPageGroup1
            // 
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToDayViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToWorkWeekViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToWeekViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToMonthViewItem1);
            this.arrangeRibbonPageGroup1.Name = "arrangeRibbonPageGroup1";
            this.arrangeRibbonPageGroup1.Text = "Arranjo";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Status";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.ckFaltante);
            this.ribbonPageGroup2.ItemLinks.Add(this.ckConfirmados);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Visualização";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btDescartar);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Telemarketing";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.listFiltros);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Filtros";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // repositoryItemComboBox3
            // 
            this.repositoryItemComboBox3.AutoHeight = false;
            this.repositoryItemComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox3.Name = "repositoryItemComboBox3";
            // 
            // editAppointmentQueryItem1
            // 
            this.editAppointmentQueryItem1.Id = 29;
            this.editAppointmentQueryItem1.Name = "editAppointmentQueryItem1";
            this.editAppointmentQueryItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.dateNavigator);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 473);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(3, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 172);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cLabel5);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.cLabel4);
            this.groupBox1.Controls.Add(this.cLabel3);
            this.groupBox1.Controls.Add(this.cLabel2);
            this.groupBox1.Controls.Add(this.cLabel1);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Legenda";
            // 
            // cLabel5
            // 
            this.cLabel5.AutoSize = true;
            this.cLabel5.Location = new System.Drawing.Point(32, 130);
            this.cLabel5.Name = "cLabel5";
            this.cLabel5.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel5.Size = new System.Drawing.Size(60, 23);
            this.cLabel5.TabIndex = 9;
            this.cLabel5.Text = "Atendido";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Canaan.Telas.Properties.Resources.atendido;
            this.pictureBox5.Location = new System.Drawing.Point(6, 130);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // cLabel4
            // 
            this.cLabel4.AutoSize = true;
            this.cLabel4.Location = new System.Drawing.Point(32, 98);
            this.cLabel4.Name = "cLabel4";
            this.cLabel4.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel4.Size = new System.Drawing.Size(77, 23);
            this.cLabel4.TabIndex = 7;
            this.cLabel4.Text = "Fotografado";
            // 
            // cLabel3
            // 
            this.cLabel3.AutoSize = true;
            this.cLabel3.Location = new System.Drawing.Point(32, 69);
            this.cLabel3.Name = "cLabel3";
            this.cLabel3.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel3.Size = new System.Drawing.Size(57, 23);
            this.cLabel3.TabIndex = 6;
            this.cLabel3.Text = "Faltante";
            // 
            // cLabel2
            // 
            this.cLabel2.AutoSize = true;
            this.cLabel2.Location = new System.Drawing.Point(32, 43);
            this.cLabel2.Name = "cLabel2";
            this.cLabel2.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel2.Size = new System.Drawing.Size(72, 23);
            this.cLabel2.TabIndex = 5;
            this.cLabel2.Text = "Confirmado";
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.Location = new System.Drawing.Point(32, 17);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel1.Size = new System.Drawing.Size(66, 23);
            this.cLabel1.TabIndex = 4;
            this.cLabel1.Text = "Agendado";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Canaan.Telas.Properties.Resources.fotografado;
            this.pictureBox4.Location = new System.Drawing.Point(6, 98);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Canaan.Telas.Properties.Resources.faltante;
            this.pictureBox3.Location = new System.Drawing.Point(6, 72);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Canaan.Telas.Properties.Resources.Confirmado;
            this.pictureBox2.Location = new System.Drawing.Point(6, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Canaan.Telas.Properties.Resources.Agendado;
            this.pictureBox1.Location = new System.Drawing.Point(6, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dateNavigator
            // 
            this.dateNavigator.HighlightTodayCell = DevExpress.Utils.DefaultBoolean.Default;
            this.dateNavigator.HotDate = null;
            this.dateNavigator.Location = new System.Drawing.Point(3, 0);
            this.dateNavigator.Multiselect = false;
            this.dateNavigator.Name = "dateNavigator";
            this.dateNavigator.SchedulerControl = this.scheduler;
            this.dateNavigator.ShowWeekNumbers = false;
            this.dateNavigator.Size = new System.Drawing.Size(194, 175);
            this.dateNavigator.TabIndex = 0;
            this.dateNavigator.Click += new System.EventHandler(this.dateNavigator_Click);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Status";
            this.barButtonItem4.Glyph = global::Canaan.Telas.Properties.Resources.pencil_005_16xLG;
            this.barButtonItem4.Id = 69;
            this.barButtonItem4.LargeGlyph = global::Canaan.Telas.Properties.Resources.pencil_005_16xLG;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btStatus_ItemClick);
            // 
            // Agendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 614);
            this.Controls.Add(this.scheduler);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolBar);
            this.Name = "Agendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Agendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDuration1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SchedulerBarController schedulerBarController1;
        private EditAppointmentQueryItem editAppointmentQueryItem1;
        private RibbonControl toolBar;
        private OpenScheduleItem openScheduleItem1;
        private SaveScheduleItem saveScheduleItem1;
        private PrintPreviewItem printPreviewItem1;
        private PrintItem printItem1;
        private PrintPageSetupItem printPageSetupItem1;
        private NewAppointmentItem newAppointmentItem1;
        private GotoTodayItem gotoTodayItem1;
        private SwitchToDayViewItem switchToDayViewItem1;
        private SwitchToWorkWeekViewItem switchToWorkWeekViewItem1;
        private SwitchToWeekViewItem switchToWeekViewItem1;
        private SwitchToMonthViewItem switchToMonthViewItem1;
        private SwitchTimeScalesItem switchTimeScalesItem1;
        private ChangeScaleWidthItem changeScaleWidthItem1;
        private RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private SwitchTimeScalesCaptionItem switchTimeScalesCaptionItem1;
        private SwitchCompressWeekendItem switchCompressWeekendItem1;
        private SwitchShowWorkTimeOnlyItem switchShowWorkTimeOnlyItem1;
        private SwitchCellsAutoHeightItem switchCellsAutoHeightItem1;
        private ChangeSnapToCellsUIItem changeSnapToCellsUIItem1;
        private EditAppointmentQueryItem editAppointmentQueryItem2;
        private EditOccurrenceUICommandItem editOccurrenceUICommandItem1;
        private EditSeriesUICommandItem editSeriesUICommandItem1;
        private DeleteAppointmentsItem deleteAppointmentsItem1;
        private DeleteOccurrenceItem deleteOccurrenceItem1;
        private DeleteSeriesItem deleteSeriesItem1;
        private SplitAppointmentItem splitAppointmentItem1;
        private ChangeAppointmentStatusItem changeAppointmentStatusItem1;
        private ChangeAppointmentLabelItem changeAppointmentLabelItem1;
        private ToggleRecurrenceItem toggleRecurrenceItem1;
        private ChangeAppointmentReminderItem changeAppointmentReminderItem1;
        private RepositoryItemDuration repositoryItemDuration1;
        private HomeRibbonPage homeRibbonPage1;
        private AppointmentRibbonPageGroup appointmentRibbonPageGroup1;
        private NavigatorRibbonPageGroup navigatorRibbonPageGroup1;
        private ArrangeRibbonPageGroup arrangeRibbonPageGroup1;
        private Panel panel2;
        private DateNavigator dateNavigator;
        private SchedulerControl scheduler;
        private RibbonPageGroup ribbonPageGroup1;
        private BarButtonItem barButtonItem1;
        private BarButtonItem barButtonItem2;
        private RibbonPageGroup ribbonPageGroup2;
        private BarCheckItem ckFaltante;
        private BarCheckItem ckConfirmados;
        private RibbonPageGroup recepcao;
        private BarButtonItem barButtonItem3;
        private RibbonPageGroup ribbonPageGroup3;
        private RepositoryItemComboBox repositoryItemComboBox1;
        private RepositoryItemComboBox repositoryItemComboBox2;
        private BarSubItem listFiltros;
        private RepositoryItemComboBox repositoryItemComboBox3;
        private BarLinkContainerItem bLinkContainerItem;
        private Panel panel1;
        private GroupBox groupBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private CLabel cLabel1;
        private CLabel cLabel2;
        private CLabel cLabel3;
        private CLabel cLabel4;
        private CLabel cLabel5;
        private PictureBox pictureBox5;
        private BarButtonItem btDescartar;
        private RibbonPageGroup ribbonPageGroup4;
        private BarButtonItem barButtonItem4;
    }
}