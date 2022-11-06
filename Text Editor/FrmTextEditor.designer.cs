namespace Text_Editor
{
  partial class FrmTextEditor
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTextEditor));
      this.TxtDocument = new System.Windows.Forms.RichTextBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.SecondStrip = new System.Windows.Forms.ToolStrip();
      this.BtnSave = new System.Windows.Forms.ToolStripButton();
      this.BtnOpen = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
      this.BtnPrint = new System.Windows.Forms.ToolStripButton();
      this.BtnPrintPreview = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.BtnUndo = new System.Windows.Forms.ToolStripButton();
      this.BtnRedo = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.CbxFontFamily = new System.Windows.Forms.ToolStripComboBox();
      this.fontSizeComboBox = new System.Windows.Forms.ToolStripComboBox();
      this.BtnIncreases = new System.Windows.Forms.ToolStripButton();
      this.BtnDecrease = new System.Windows.Forms.ToolStripButton();
      this.BtnFontColor = new System.Windows.Forms.ToolStripDropDownButton();
      this.BtnChangeCase = new System.Windows.Forms.ToolStripDropDownButton();
      this.BtnLowercase = new System.Windows.Forms.ToolStripMenuItem();
      this.BtnUppercase = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
      this.BtnClear = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.BtnBold = new System.Windows.Forms.ToolStripButton();
      this.BtnItalic = new System.Windows.Forms.ToolStripButton();
      this.BtnUnderline = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.BtnLeftAlign = new System.Windows.Forms.ToolStripButton();
      this.BtnCenterAlign = new System.Windows.Forms.ToolStripButton();
      this.BtnRightAlign = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.BtnBulletList = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
      this.BtnZoom = new System.Windows.Forms.ToolStripDropDownButton();
      this.OpenFileD = new System.Windows.Forms.OpenFileDialog();
      this.ToolStrip = new System.Windows.Forms.MenuStrip();
      this.btnFile = new System.Windows.Forms.ToolStripMenuItem();
      this.BtnNewFile = new System.Windows.Forms.ToolStripMenuItem();
      this.BtnOpenFile = new System.Windows.Forms.ToolStripMenuItem();
      this.BtnSaveFile = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
      this.BtnPrintFile = new System.Windows.Forms.ToolStripMenuItem();
      this.BtnPrintPreviewFile = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
      this.BtnExit = new System.Windows.Forms.ToolStripMenuItem();
      this.BtnEdit = new System.Windows.Forms.ToolStripMenuItem();
      this.BtnUndoFile = new System.Windows.Forms.ToolStripMenuItem();
      this.BtnRedoFile = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
      this.BtnCut = new System.Windows.Forms.ToolStripMenuItem();
      this.BtnCopy = new System.Windows.Forms.ToolStripMenuItem();
      this.BtnPaste = new System.Windows.Forms.ToolStripMenuItem();
      this.BtnDelete = new System.Windows.Forms.ToolStripMenuItem();
      this.BtnSelectAll = new System.Windows.Forms.ToolStripMenuItem();
      this.BtnClearAll = new System.Windows.Forms.ToolStripMenuItem();
      this.BtnFormat = new System.Windows.Forms.ToolStripMenuItem();
      this.BtnWordWrap = new System.Windows.Forms.ToolStripMenuItem();
      this.BtnFont = new System.Windows.Forms.ToolStripMenuItem();
      this.BtnColorOp = new System.Windows.Forms.ToolStripMenuItem();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.PrintD = new System.Windows.Forms.PrintDialog();
      this.FontD = new System.Windows.Forms.FontDialog();
      this.PrintPreviewD = new System.Windows.Forms.PrintPreviewDialog();
      this.printDocument = new System.Drawing.Printing.PrintDocument();
      this.ColorD = new System.Windows.Forms.ColorDialog();
      this.LineStatus = new System.Windows.Forms.ToolStripStatusLabel();
      this.ControllerMenu = new System.Windows.Forms.StatusStrip();
      this.SecondStrip.SuspendLayout();
      this.ToolStrip.SuspendLayout();
      this.ControllerMenu.SuspendLayout();
      this.SuspendLayout();
      // 
      // TxtDocument
      // 
      this.TxtDocument.Location = new System.Drawing.Point(12, 65);
      this.TxtDocument.Name = "TxtDocument";
      this.TxtDocument.Size = new System.Drawing.Size(833, 523);
      this.TxtDocument.TabIndex = 0;
      this.TxtDocument.Text = "";
      this.TxtDocument.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtDocument_DragDrop);
      this.TxtDocument.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtDocument_DragEnter);
      this.TxtDocument.SelectionChanged += new System.EventHandler(this.TxtDocument_SelectionChanged);
      this.TxtDocument.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtDocument_KeyUp);
      this.TxtDocument.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TxtDocument_MouseDown);
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
      this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel2.Location = new System.Drawing.Point(0, 566);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(852, 4);
      this.panel2.TabIndex = 15;
      // 
      // SecondStrip
      // 
      this.SecondStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.SecondStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnSave,
            this.BtnOpen,
            this.toolStripSeparator10,
            this.BtnPrint,
            this.BtnPrintPreview,
            this.toolStripSeparator5,
            this.BtnUndo,
            this.BtnRedo,
            this.toolStripSeparator1,
            this.CbxFontFamily,
            this.fontSizeComboBox,
            this.BtnIncreases,
            this.BtnDecrease,
            this.BtnFontColor,
            this.BtnChangeCase,
            this.toolStripSeparator9,
            this.BtnClear,
            this.toolStripSeparator2,
            this.BtnBold,
            this.BtnItalic,
            this.BtnUnderline,
            this.toolStripSeparator3,
            this.BtnLeftAlign,
            this.BtnCenterAlign,
            this.BtnRightAlign,
            this.toolStripSeparator4,
            this.BtnBulletList,
            this.toolStripSeparator8,
            this.BtnZoom});
      this.SecondStrip.Location = new System.Drawing.Point(0, 24);
      this.SecondStrip.Name = "SecondStrip";
      this.SecondStrip.Size = new System.Drawing.Size(852, 31);
      this.SecondStrip.TabIndex = 16;
      this.SecondStrip.Text = "toolStrip1";
      // 
      // BtnSave
      // 
      this.BtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
      this.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BtnSave.Name = "BtnSave";
      this.BtnSave.Size = new System.Drawing.Size(28, 28);
      this.BtnSave.Text = "Save File";
      this.BtnSave.Click += new System.EventHandler(this.BtnSaveFile_Click);
      // 
      // BtnOpen
      // 
      this.BtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("BtnOpen.Image")));
      this.BtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BtnOpen.Name = "BtnOpen";
      this.BtnOpen.Size = new System.Drawing.Size(28, 28);
      this.BtnOpen.Text = "Open File";
      this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
      // 
      // toolStripSeparator10
      // 
      this.toolStripSeparator10.Name = "toolStripSeparator10";
      this.toolStripSeparator10.Size = new System.Drawing.Size(6, 31);
      // 
      // BtnPrint
      // 
      this.BtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrint.Image")));
      this.BtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BtnPrint.Name = "BtnPrint";
      this.BtnPrint.Size = new System.Drawing.Size(28, 28);
      this.BtnPrint.Text = "Print Page";
      this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
      // 
      // BtnPrintPreview
      // 
      this.BtnPrintPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BtnPrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrintPreview.Image")));
      this.BtnPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BtnPrintPreview.Name = "BtnPrintPreview";
      this.BtnPrintPreview.Size = new System.Drawing.Size(28, 28);
      this.BtnPrintPreview.Text = "Print Preview";
      this.BtnPrintPreview.Click += new System.EventHandler(this.BtnPrintPreview_Click);
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
      // 
      // BtnUndo
      // 
      this.BtnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BtnUndo.Image = ((System.Drawing.Image)(resources.GetObject("BtnUndo.Image")));
      this.BtnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BtnUndo.Name = "BtnUndo";
      this.BtnUndo.Size = new System.Drawing.Size(28, 28);
      this.BtnUndo.Text = "Undo Move";
      this.BtnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
      // 
      // BtnRedo
      // 
      this.BtnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BtnRedo.Image = ((System.Drawing.Image)(resources.GetObject("BtnRedo.Image")));
      this.BtnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BtnRedo.Name = "BtnRedo";
      this.BtnRedo.Size = new System.Drawing.Size(28, 28);
      this.BtnRedo.Text = "Redo Move";
      this.BtnRedo.Click += new System.EventHandler(this.BtnRedo_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
      // 
      // CbxFontFamily
      // 
      this.CbxFontFamily.Name = "CbxFontFamily";
      this.CbxFontFamily.Size = new System.Drawing.Size(155, 31);
      this.CbxFontFamily.Sorted = true;
      this.CbxFontFamily.Text = "Font Family";
      this.CbxFontFamily.ToolTipText = "Font Family";
      this.CbxFontFamily.SelectedIndexChanged += new System.EventHandler(this.CbxFontStyle_SelectedIndexChanged);
      // 
      // fontSizeComboBox
      // 
      this.fontSizeComboBox.AutoSize = false;
      this.fontSizeComboBox.Name = "fontSizeComboBox";
      this.fontSizeComboBox.Size = new System.Drawing.Size(73, 23);
      this.fontSizeComboBox.Text = "Font Size";
      this.fontSizeComboBox.ToolTipText = "Font Size";
      this.fontSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.CbxFontSize_SelectedIndexChanged);
      // 
      // BtnIncreases
      // 
      this.BtnIncreases.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BtnIncreases.Image = ((System.Drawing.Image)(resources.GetObject("BtnIncreases.Image")));
      this.BtnIncreases.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BtnIncreases.Name = "BtnIncreases";
      this.BtnIncreases.Size = new System.Drawing.Size(28, 28);
      this.BtnIncreases.Text = "Increase Font Size";
      this.BtnIncreases.Click += new System.EventHandler(this.BtnIncrease_Click);
      // 
      // BtnDecrease
      // 
      this.BtnDecrease.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BtnDecrease.Image = ((System.Drawing.Image)(resources.GetObject("BtnDecrease.Image")));
      this.BtnDecrease.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BtnDecrease.Name = "BtnDecrease";
      this.BtnDecrease.Size = new System.Drawing.Size(28, 28);
      this.BtnDecrease.Text = "Decrease Font Size";
      this.BtnDecrease.Click += new System.EventHandler(this.BtnDecrease_Click);
      // 
      // BtnFontColor
      // 
      this.BtnFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BtnFontColor.Image = ((System.Drawing.Image)(resources.GetObject("BtnFontColor.Image")));
      this.BtnFontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BtnFontColor.Name = "BtnFontColor";
      this.BtnFontColor.Size = new System.Drawing.Size(37, 28);
      this.BtnFontColor.Text = "Font Color";
      this.BtnFontColor.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.BtnFontColor_DropDownItemClicked);
      // 
      // BtnChangeCase
      // 
      this.BtnChangeCase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BtnChangeCase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnLowercase,
            this.BtnUppercase});
      this.BtnChangeCase.Image = ((System.Drawing.Image)(resources.GetObject("BtnChangeCase.Image")));
      this.BtnChangeCase.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BtnChangeCase.Name = "BtnChangeCase";
      this.BtnChangeCase.Size = new System.Drawing.Size(37, 28);
      this.BtnChangeCase.Text = "Change Case";
      // 
      // BtnLowercase
      // 
      this.BtnLowercase.Name = "BtnLowercase";
      this.BtnLowercase.Size = new System.Drawing.Size(137, 22);
      this.BtnLowercase.Text = "lowercase";
      this.BtnLowercase.Click += new System.EventHandler(this.BtnLowerCase_Click);
      // 
      // BtnUppercase
      // 
      this.BtnUppercase.Name = "BtnUppercase";
      this.BtnUppercase.Size = new System.Drawing.Size(137, 22);
      this.BtnUppercase.Text = "UPPERCASE";
      this.BtnUppercase.Click += new System.EventHandler(this.BtnUpperCase_Click);
      // 
      // toolStripSeparator9
      // 
      this.toolStripSeparator9.Name = "toolStripSeparator9";
      this.toolStripSeparator9.Size = new System.Drawing.Size(6, 31);
      // 
      // BtnClear
      // 
      this.BtnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("BtnClear.Image")));
      this.BtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BtnClear.Name = "BtnClear";
      this.BtnClear.Size = new System.Drawing.Size(28, 28);
      this.BtnClear.Text = "Clear All Formatting";
      this.BtnClear.Click += new System.EventHandler(this.BtnClearAll_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
      // 
      // BtnBold
      // 
      this.BtnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BtnBold.Image = ((System.Drawing.Image)(resources.GetObject("BtnBold.Image")));
      this.BtnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BtnBold.Name = "BtnBold";
      this.BtnBold.Size = new System.Drawing.Size(28, 28);
      this.BtnBold.Text = "Bold";
      this.BtnBold.Click += new System.EventHandler(this.BtnBold_Click);
      // 
      // BtnItalic
      // 
      this.BtnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BtnItalic.Image = ((System.Drawing.Image)(resources.GetObject("BtnItalic.Image")));
      this.BtnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BtnItalic.Name = "BtnItalic";
      this.BtnItalic.Size = new System.Drawing.Size(28, 28);
      this.BtnItalic.Text = "Italics";
      this.BtnItalic.Click += new System.EventHandler(this.BtnItalic_Click);
      // 
      // BtnUnderline
      // 
      this.BtnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BtnUnderline.Image = ((System.Drawing.Image)(resources.GetObject("BtnUnderline.Image")));
      this.BtnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BtnUnderline.Name = "BtnUnderline";
      this.BtnUnderline.Size = new System.Drawing.Size(28, 28);
      this.BtnUnderline.Text = "Underline";
      this.BtnUnderline.Click += new System.EventHandler(this.BtnUnderLine_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
      // 
      // BtnLeftAlign
      // 
      this.BtnLeftAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BtnLeftAlign.Image = ((System.Drawing.Image)(resources.GetObject("BtnLeftAlign.Image")));
      this.BtnLeftAlign.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BtnLeftAlign.Name = "BtnLeftAlign";
      this.BtnLeftAlign.Size = new System.Drawing.Size(28, 28);
      this.BtnLeftAlign.Text = "Left Align";
      this.BtnLeftAlign.Click += new System.EventHandler(this.AlignDocument_Click);
      // 
      // BtnCenterAlign
      // 
      this.BtnCenterAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BtnCenterAlign.Image = ((System.Drawing.Image)(resources.GetObject("BtnCenterAlign.Image")));
      this.BtnCenterAlign.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BtnCenterAlign.Name = "BtnCenterAlign";
      this.BtnCenterAlign.Size = new System.Drawing.Size(28, 28);
      this.BtnCenterAlign.Text = "Center Align";
      this.BtnCenterAlign.Click += new System.EventHandler(this.AlignDocument_Click);
      // 
      // BtnRightAlign
      // 
      this.BtnRightAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BtnRightAlign.Image = ((System.Drawing.Image)(resources.GetObject("BtnRightAlign.Image")));
      this.BtnRightAlign.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BtnRightAlign.Name = "BtnRightAlign";
      this.BtnRightAlign.Size = new System.Drawing.Size(28, 28);
      this.BtnRightAlign.Text = "Right Align";
      this.BtnRightAlign.Click += new System.EventHandler(this.AlignDocument_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
      // 
      // BtnBulletList
      // 
      this.BtnBulletList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BtnBulletList.Image = ((System.Drawing.Image)(resources.GetObject("BtnBulletList.Image")));
      this.BtnBulletList.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BtnBulletList.Name = "BtnBulletList";
      this.BtnBulletList.Size = new System.Drawing.Size(28, 28);
      this.BtnBulletList.Text = "Bullet List";
      this.BtnBulletList.Click += new System.EventHandler(this.BtnBullet_Click);
      // 
      // toolStripSeparator8
      // 
      this.toolStripSeparator8.Name = "toolStripSeparator8";
      this.toolStripSeparator8.Size = new System.Drawing.Size(6, 31);
      // 
      // BtnZoom
      // 
      this.BtnZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BtnZoom.Image = ((System.Drawing.Image)(resources.GetObject("BtnZoom.Image")));
      this.BtnZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BtnZoom.Name = "BtnZoom";
      this.BtnZoom.Size = new System.Drawing.Size(37, 28);
      this.BtnZoom.Text = "Zoom Factor";
      this.BtnZoom.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.BtnZoom_DropDownItemClicked);
      // 
      // OpenFileD
      // 
      this.OpenFileD.FileName = "OpenFileD";
      // 
      // ToolStrip
      // 
      this.ToolStrip.BackColor = System.Drawing.Color.White;
      this.ToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFile,
            this.BtnEdit,
            this.BtnFormat});
      this.ToolStrip.Location = new System.Drawing.Point(0, 0);
      this.ToolStrip.Name = "ToolStrip";
      this.ToolStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
      this.ToolStrip.Size = new System.Drawing.Size(852, 24);
      this.ToolStrip.TabIndex = 17;
      this.ToolStrip.Text = "menuStrip1";
      // 
      // btnFile
      // 
      this.btnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNewFile,
            this.BtnOpenFile,
            this.BtnSaveFile,
            this.toolStripSeparator11,
            this.BtnPrintFile,
            this.BtnPrintPreviewFile,
            this.toolStripSeparator7,
            this.BtnExit});
      this.btnFile.Name = "btnFile";
      this.btnFile.Size = new System.Drawing.Size(37, 22);
      this.btnFile.Text = "File";
      // 
      // BtnNewFile
      // 
      this.BtnNewFile.Image = ((System.Drawing.Image)(resources.GetObject("BtnNewFile.Image")));
      this.BtnNewFile.Name = "BtnNewFile";
      this.BtnNewFile.Size = new System.Drawing.Size(143, 22);
      this.BtnNewFile.Text = "New";
      this.BtnNewFile.Click += new System.EventHandler(this.BtnNewFile_Click);
      // 
      // BtnOpenFile
      // 
      this.BtnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("BtnOpenFile.Image")));
      this.BtnOpenFile.Name = "BtnOpenFile";
      this.BtnOpenFile.Size = new System.Drawing.Size(143, 22);
      this.BtnOpenFile.Text = "Open";
      this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
      // 
      // BtnSaveFile
      // 
      this.BtnSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("BtnSaveFile.Image")));
      this.BtnSaveFile.Name = "BtnSaveFile";
      this.BtnSaveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.BtnSaveFile.Size = new System.Drawing.Size(143, 22);
      this.BtnSaveFile.Text = "Save";
      this.BtnSaveFile.Click += new System.EventHandler(this.BtnSaveFile_Click);
      // 
      // toolStripSeparator11
      // 
      this.toolStripSeparator11.Name = "toolStripSeparator11";
      this.toolStripSeparator11.Size = new System.Drawing.Size(140, 6);
      // 
      // BtnPrintFile
      // 
      this.BtnPrintFile.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrintFile.Image")));
      this.BtnPrintFile.Name = "BtnPrintFile";
      this.BtnPrintFile.Size = new System.Drawing.Size(143, 22);
      this.BtnPrintFile.Text = "Print";
      this.BtnPrintFile.Click += new System.EventHandler(this.BtnPrint_Click);
      // 
      // BtnPrintPreviewFile
      // 
      this.BtnPrintPreviewFile.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrintPreviewFile.Image")));
      this.BtnPrintPreviewFile.Name = "BtnPrintPreviewFile";
      this.BtnPrintPreviewFile.Size = new System.Drawing.Size(143, 22);
      this.BtnPrintPreviewFile.Text = "Print Preview";
      this.BtnPrintPreviewFile.Click += new System.EventHandler(this.BtnPrintPreview_Click);
      // 
      // toolStripSeparator7
      // 
      this.toolStripSeparator7.Name = "toolStripSeparator7";
      this.toolStripSeparator7.Size = new System.Drawing.Size(140, 6);
      // 
      // BtnExit
      // 
      this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
      this.BtnExit.Name = "BtnExit";
      this.BtnExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
      this.BtnExit.Size = new System.Drawing.Size(143, 22);
      this.BtnExit.Text = "Exit";
      this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
      // 
      // BtnEdit
      // 
      this.BtnEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnUndoFile,
            this.BtnRedoFile,
            this.toolStripSeparator6,
            this.BtnCut,
            this.BtnCopy,
            this.BtnPaste,
            this.BtnDelete,
            this.BtnSelectAll,
            this.BtnClearAll});
      this.BtnEdit.Name = "BtnEdit";
      this.BtnEdit.Size = new System.Drawing.Size(39, 22);
      this.BtnEdit.Text = "Edit";
      // 
      // BtnUndoFile
      // 
      this.BtnUndoFile.Image = ((System.Drawing.Image)(resources.GetObject("BtnUndoFile.Image")));
      this.BtnUndoFile.Name = "BtnUndoFile";
      this.BtnUndoFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
      this.BtnUndoFile.Size = new System.Drawing.Size(164, 22);
      this.BtnUndoFile.Text = "Undo";
      this.BtnUndoFile.Click += new System.EventHandler(this.BtnUndo_Click);
      // 
      // BtnRedoFile
      // 
      this.BtnRedoFile.Image = ((System.Drawing.Image)(resources.GetObject("BtnRedoFile.Image")));
      this.BtnRedoFile.Name = "BtnRedoFile";
      this.BtnRedoFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
      this.BtnRedoFile.Size = new System.Drawing.Size(164, 22);
      this.BtnRedoFile.Text = "Redo";
      this.BtnRedoFile.Click += new System.EventHandler(this.BtnRedo_Click);
      // 
      // toolStripSeparator6
      // 
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      this.toolStripSeparator6.Size = new System.Drawing.Size(161, 6);
      // 
      // BtnCut
      // 
      this.BtnCut.Image = ((System.Drawing.Image)(resources.GetObject("BtnCut.Image")));
      this.BtnCut.Name = "BtnCut";
      this.BtnCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.BtnCut.Size = new System.Drawing.Size(164, 22);
      this.BtnCut.Text = "Cut";
      this.BtnCut.Click += new System.EventHandler(this.BtnCut_Click);
      // 
      // BtnCopy
      // 
      this.BtnCopy.Image = ((System.Drawing.Image)(resources.GetObject("BtnCopy.Image")));
      this.BtnCopy.Name = "BtnCopy";
      this.BtnCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.BtnCopy.Size = new System.Drawing.Size(164, 22);
      this.BtnCopy.Text = "Copy";
      this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
      // 
      // BtnPaste
      // 
      this.BtnPaste.Image = ((System.Drawing.Image)(resources.GetObject("BtnPaste.Image")));
      this.BtnPaste.Name = "BtnPaste";
      this.BtnPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.BtnPaste.Size = new System.Drawing.Size(164, 22);
      this.BtnPaste.Text = "Paste";
      this.BtnPaste.Click += new System.EventHandler(this.BtnPaste_Click);
      // 
      // BtnDelete
      // 
      this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
      this.BtnDelete.Name = "BtnDelete";
      this.BtnDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
      this.BtnDelete.Size = new System.Drawing.Size(164, 22);
      this.BtnDelete.Text = "Delete";
      this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
      // 
      // BtnSelectAll
      // 
      this.BtnSelectAll.Image = ((System.Drawing.Image)(resources.GetObject("BtnSelectAll.Image")));
      this.BtnSelectAll.Name = "BtnSelectAll";
      this.BtnSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
      this.BtnSelectAll.Size = new System.Drawing.Size(164, 22);
      this.BtnSelectAll.Text = "Select All";
      this.BtnSelectAll.Click += new System.EventHandler(this.BtnSelectAll_Click);
      // 
      // BtnClearAll
      // 
      this.BtnClearAll.Image = ((System.Drawing.Image)(resources.GetObject("BtnClearAll.Image")));
      this.BtnClearAll.Name = "BtnClearAll";
      this.BtnClearAll.Size = new System.Drawing.Size(164, 22);
      this.BtnClearAll.Text = "Clear All";
      this.BtnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
      // 
      // BtnFormat
      // 
      this.BtnFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnWordWrap,
            this.BtnFont,
            this.BtnColorOp});
      this.BtnFormat.Name = "BtnFormat";
      this.BtnFormat.Size = new System.Drawing.Size(57, 22);
      this.BtnFormat.Text = "Format";
      // 
      // BtnWordWrap
      // 
      this.BtnWordWrap.Name = "BtnWordWrap";
      this.BtnWordWrap.Size = new System.Drawing.Size(180, 22);
      this.BtnWordWrap.Text = "WordWrap";
      this.BtnWordWrap.Click += new System.EventHandler(this.BtnWordWrap_Click);
      // 
      // BtnFont
      // 
      this.BtnFont.Name = "BtnFont";
      this.BtnFont.Size = new System.Drawing.Size(180, 22);
      this.BtnFont.Text = "Font...";
      this.BtnFont.Click += new System.EventHandler(this.BtnFont_Click);
      // 
      // BtnColorOp
      // 
      this.BtnColorOp.Name = "BtnColorOp";
      this.BtnColorOp.Size = new System.Drawing.Size(180, 22);
      this.BtnColorOp.Text = "Color Options";
      this.BtnColorOp.Click += new System.EventHandler(this.BtnColorOp_Click);
      // 
      // PrintD
      // 
      this.PrintD.UseEXDialog = true;
      // 
      // FontD
      // 
      this.FontD.Apply += new System.EventHandler(this.FontD_Apply);
      this.FontD.HelpRequest += new System.EventHandler(this.FontD_HelpRequest);
      // 
      // PrintPreviewD
      // 
      this.PrintPreviewD.AutoScrollMargin = new System.Drawing.Size(0, 0);
      this.PrintPreviewD.AutoScrollMinSize = new System.Drawing.Size(0, 0);
      this.PrintPreviewD.ClientSize = new System.Drawing.Size(359, 211);
      this.PrintPreviewD.Enabled = true;
      this.PrintPreviewD.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewD.Icon")));
      this.PrintPreviewD.Name = "printPreviewDialog";
      this.PrintPreviewD.Visible = false;
      // 
      // printDocument
      // 
      this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.BtnPrint_PrintPage);
      // 
      // ColorD
      // 
      this.ColorD.HelpRequest += new System.EventHandler(this.ColorD_HelpRequest);
      // 
      // LineStatus
      // 
      this.LineStatus.Name = "LineStatus";
      this.LineStatus.Size = new System.Drawing.Size(806, 17);
      this.LineStatus.Spring = true;
      this.LineStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // ControllerMenu
      // 
      this.ControllerMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.ControllerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LineStatus});
      this.ControllerMenu.Location = new System.Drawing.Point(0, 544);
      this.ControllerMenu.Name = "ControllerMenu";
      this.ControllerMenu.Size = new System.Drawing.Size(852, 22);
      this.ControllerMenu.TabIndex = 19;
      this.ControllerMenu.Text = "statusStrip1";
      // 
      // FrmTextEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(852, 570);
      this.Controls.Add(this.ControllerMenu);
      this.Controls.Add(this.SecondStrip);
      this.Controls.Add(this.ToolStrip);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.TxtDocument);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.ToolStrip;
      this.Name = "FrmTextEditor";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Text Editor";
      this.Load += new System.EventHandler(this.FrmTextEditor_Load);
      this.SecondStrip.ResumeLayout(false);
      this.SecondStrip.PerformLayout();
      this.ToolStrip.ResumeLayout(false);
      this.ToolStrip.PerformLayout();
      this.ControllerMenu.ResumeLayout(false);
      this.ControllerMenu.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RichTextBox TxtDocument;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.ToolStrip SecondStrip;
    private System.Windows.Forms.ToolStripButton BtnSave;
    private System.Windows.Forms.ToolStripButton BtnOpen;
    private System.Windows.Forms.ToolStripComboBox CbxFontFamily;
    private System.Windows.Forms.ToolStripComboBox fontSizeComboBox;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton BtnBold;
    private System.Windows.Forms.ToolStripButton BtnItalic;
    private System.Windows.Forms.ToolStripButton BtnUnderline;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripDropDownButton BtnFontColor;
    private System.Windows.Forms.ToolStripButton BtnLeftAlign;
    private System.Windows.Forms.ToolStripButton BtnCenterAlign;
    private System.Windows.Forms.ToolStripButton BtnRightAlign;
    private System.Windows.Forms.OpenFileDialog OpenFileD;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripButton BtnIncreases;
    private System.Windows.Forms.ToolStripButton BtnDecrease;
    private System.Windows.Forms.ToolStripButton BtnBulletList;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripButton BtnUndo;
    private System.Windows.Forms.ToolStripButton BtnRedo;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.MenuStrip ToolStrip;
    private System.Windows.Forms.ToolStripMenuItem btnFile;
    private System.Windows.Forms.ToolStripMenuItem BtnSaveFile;
    private System.Windows.Forms.ToolStripMenuItem BtnExit;
    private System.Windows.Forms.ToolStripMenuItem BtnEdit;
    private System.Windows.Forms.ToolStripMenuItem BtnUndoFile;
    private System.Windows.Forms.ToolStripMenuItem BtnRedoFile;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    private System.Windows.Forms.ToolStripMenuItem BtnCut;
    private System.Windows.Forms.ToolStripMenuItem BtnCopy;
    private System.Windows.Forms.ToolStripMenuItem BtnPaste;
    private System.Windows.Forms.ToolStripMenuItem BtnDelete;
    private System.Windows.Forms.ToolStripMenuItem BtnSelectAll;
    private System.Windows.Forms.ToolStripMenuItem BtnClearAll;
    private System.Windows.Forms.ToolStripMenuItem BtnOpenFile;
    private System.Windows.Forms.ToolStripMenuItem BtnNewFile;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.PrintDialog PrintD;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    private System.Windows.Forms.ToolStripDropDownButton BtnChangeCase;
    private System.Windows.Forms.ToolStripMenuItem BtnLowercase;
    private System.Windows.Forms.ToolStripMenuItem BtnUppercase;
    private System.Windows.Forms.ToolStripMenuItem BtnFormat;
    private System.Windows.Forms.ToolStripMenuItem BtnWordWrap;
    private System.Windows.Forms.ToolStripMenuItem BtnFont;
    private System.Windows.Forms.FontDialog FontD;
    private System.Windows.Forms.ToolStripDropDownButton BtnZoom;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
    private System.Windows.Forms.ToolStripButton BtnClear;
    private System.Windows.Forms.PrintPreviewDialog PrintPreviewD;
    private System.Drawing.Printing.PrintDocument printDocument;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
    private System.Windows.Forms.ToolStripButton BtnPrint;
    private System.Windows.Forms.ToolStripButton BtnPrintPreview;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
    private System.Windows.Forms.ToolStripMenuItem BtnPrintFile;
    private System.Windows.Forms.ToolStripMenuItem BtnPrintPreviewFile;
    private System.Windows.Forms.ColorDialog ColorD;
    private System.Windows.Forms.ToolStripMenuItem BtnColorOp;
    private System.Windows.Forms.ToolStripStatusLabel LineStatus;
    private System.Windows.Forms.StatusStrip ControllerMenu;
  }
}