using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace Text_Editor
{
  public partial class FrmTextEditor : Form
  {
    readonly List<string> colorList = new List<string>();
    string fileName;
    const int MIDDLE = 382;
    int sumRGB;
    int pos, line, column;

    public FrmTextEditor()
    {
      InitializeComponent();
    }

    private void FrmTextEditor_Load(object sender, EventArgs e)
    {
      TxtDocument.AllowDrop = true;
      TxtDocument.AcceptsTab = true;
      TxtDocument.WordWrap = false;
      TxtDocument.ShortcutsEnabled = true;
      TxtDocument.DetectUrls = true;
      FontD.ShowColor = true;
      FontD.ShowApply = true;
      FontD.ShowHelp = true;
      ColorD.AllowFullOpen = true;
      ColorD.AnyColor = true;
      ColorD.SolidColorOnly = false;
      ColorD.ShowHelp = true;
      ColorD.AnyColor = true;
      BtnLeftAlign.Checked = true;
      BtnCenterAlign.Checked = false;
      BtnRightAlign.Checked = false;
      BtnBold.Checked = false;
      BtnItalic.Checked = false;
      BtnRightAlign.Checked = false;
      BtnBulletList.Checked = false;
      BtnWordWrap.Image = null;
      MinimizeBox = false;
      MaximizeBox = false;
      this.FormBorderStyle = FormBorderStyle.FixedSingle;

      BtnZoom.DropDown.Items.Add("20%");
      BtnZoom.DropDown.Items.Add("50%");
      BtnZoom.DropDown.Items.Add("70%");
      BtnZoom.DropDown.Items.Add("100%");
      BtnZoom.DropDown.Items.Add("150%");
      BtnZoom.DropDown.Items.Add("200%");
      BtnZoom.DropDown.Items.Add("300%");
      BtnZoom.DropDown.Items.Add("400%");
      BtnZoom.DropDown.Items.Add("500%");

      for (int i = 8; i < 80; i += 2)
      {
        fontSizeComboBox.Items.Add(i);
      }

      foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
      {
        if (prop.PropertyType.FullName == "System.Drawing.Color")
        {
          colorList.Add(prop.Name);
        }
      }

      foreach (string color in colorList)
      {
        BtnFontColor.DropDownItems.Add(color);
      }

      for (int i = 0; i < BtnFontColor.DropDownItems.Count; i++)
      {
        KnownColor selectedColor;
        selectedColor = (KnownColor)System.Enum.Parse(typeof(KnownColor), colorList[i]);
        BtnFontColor.DropDownItems[i].BackColor = Color.FromKnownColor(selectedColor);

        Color col = Color.FromName(colorList[i]);
        sumRGB = ConvertToRGB(col);
        if (sumRGB <= MIDDLE)
        {
          BtnFontColor.DropDownItems[i].ForeColor = Color.White;
        }
        else if (sumRGB > MIDDLE)
        {
          BtnFontColor.DropDownItems[i].ForeColor = Color.Black;
        }
      }

      InstalledFontCollection fonts = new InstalledFontCollection();
      foreach (FontFamily family in fonts.Families)
      {
        CbxFontFamily.Items.Add(family.Name);
      }

      int pos = TxtDocument.SelectionStart;
      int line = TxtDocument.GetLineFromCharIndex(pos);
      int column = TxtDocument.SelectionStart - TxtDocument.GetFirstCharIndexFromLine(line);
      LineStatus.Text = "Line " + (line + 1) + ", Column " + (column + 1);
    }

    private int ConvertToRGB(System.Drawing.Color c)
    {
      int r = c.R,
          g = c.G,
          b = c.B;

      int sum = r + g + b;

      return sum;
    }
    private void BtnSelectAll_Click(object sender, EventArgs e)
    {
      TxtDocument.SelectAll();
    }

    private void BtnClearAll_Click(object sender, EventArgs e)
    {
      TxtDocument.Clear();
      TxtDocument.Focus();
    }

    private void BtnPaste_Click(object sender, EventArgs e)
    {
      TxtDocument.Paste();
    }

    private void BtnCopy_Click(object sender, EventArgs e)
    {
      TxtDocument.Copy();
    }

    private void BtnCut_Click(object sender, EventArgs e)
    {
      TxtDocument.Cut();
    }

    private void BtnBold_Click(object sender, EventArgs e)
    {

      if (BtnBold.Checked == false)
      {
        BtnBold.Checked = true;
      }
      else if (BtnBold.Checked == true)
      {
        BtnBold.Checked = false;
      }

      if (TxtDocument.SelectionFont == null)
      {
        return;
      }

      FontStyle style = TxtDocument.SelectionFont.Style;

      if (TxtDocument.SelectionFont.Bold)
      {
        style &= ~FontStyle.Bold;
      }
      else
      {
        style |= FontStyle.Bold;

      }
      TxtDocument.SelectionFont = new Font(TxtDocument.SelectionFont, style);
    }

    private void BtnUnderLine_Click(object sender, EventArgs e)
    {
      if (BtnUnderline.Checked == false)
      {
        BtnUnderline.Checked = true;
      }
      else if (BtnUnderline.Checked == true)
      {
        BtnUnderline.Checked = false;
      }

      if (TxtDocument.SelectionFont == null)
      {
        return;
      }

      FontStyle style = TxtDocument.SelectionFont.Style;

      if (TxtDocument.SelectionFont.Underline)
      {
        style &= ~FontStyle.Underline;
      }
      else
      {
        style |= FontStyle.Underline;
      }
      TxtDocument.SelectionFont = new Font(TxtDocument.SelectionFont, style);
    }

    private void BtnItalic_Click(object sender, EventArgs e)
    {
      if (BtnItalic.Checked == false)
      {
        BtnItalic.Checked = true;
      }
      else if (BtnItalic.Checked == true)
      {
        BtnItalic.Checked = false;
      }

      if (TxtDocument.SelectionFont == null)
      {
        return;
      }
      FontStyle style = TxtDocument.SelectionFont.Style;

      if (TxtDocument.SelectionFont.Italic)
      {
        style &= ~FontStyle.Italic;
      }
      else
      {
        style |= FontStyle.Italic;
      }
      TxtDocument.SelectionFont = new Font(TxtDocument.SelectionFont, style);
    }

    private void CbxFontSize_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (TxtDocument.SelectionFont == null)
      {
        return;
      }
      TxtDocument.SelectionFont = new Font(TxtDocument.SelectionFont.FontFamily, Convert.ToInt32(fontSizeComboBox.Text), TxtDocument.SelectionFont.Style);
    }

    private void CbxFontStyle_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (TxtDocument.SelectionFont == null)
      {

        TxtDocument.SelectionFont = new Font(CbxFontFamily.Text, TxtDocument.Font.Size);
      }

      TxtDocument.SelectionFont = new Font(CbxFontFamily.Text, TxtDocument.SelectionFont.Size);
    }


    private void BtnOpen_Click(object sender, EventArgs e)
    {
      OpenFileD.ShowDialog();
      if (OpenFileD.ShowDialog() == DialogResult.OK)
      {
        fileName = OpenFileD.FileName;
        TxtDocument.LoadFile(fileName, RichTextBoxStreamType.PlainText);

      }
    }

    private void BtnFontColor_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

      KnownColor selectedColor;
      selectedColor = (KnownColor)System.Enum.Parse(typeof(KnownColor), e.ClickedItem.Text);
      TxtDocument.SelectionColor = Color.FromKnownColor(selectedColor);
    }

    private void TxtDocument_SelectionChanged(object sender, EventArgs e)
    {

      if (TxtDocument.SelectionFont != null)
      {
        BtnBold.Checked = TxtDocument.SelectionFont.Bold;
        BtnItalic.Checked = TxtDocument.SelectionFont.Italic;
        BtnUnderline.Checked = TxtDocument.SelectionFont.Underline;
      }
    }
    private void AlignDocument_Click(object sender, EventArgs e)
    {
      switch (((ToolStripButton)sender).Name)
      {
        case "BtnLeftAlign":
          TxtDocument.SelectionAlignment = HorizontalAlignment.Left;
          BtnLeftAlign.Checked = true;
          BtnCenterAlign.Checked = false;
          BtnRightAlign.Checked = false;
          break;
        case "BtnCenterAlign":
          TxtDocument.SelectionAlignment = HorizontalAlignment.Center;
          BtnCenterAlign.Checked = true;
          BtnLeftAlign.Checked = false;
          BtnRightAlign.Checked = false;
          break;
        case "BtnRightAlign":
          TxtDocument.SelectionAlignment = HorizontalAlignment.Right;
          BtnRightAlign.Checked = true;
          BtnLeftAlign.Checked = false;
          BtnCenterAlign.Checked = false;
          break;
      }
    }

    private void BtnBullet_Click(object sender, EventArgs e)
    {
      if (BtnBulletList.Checked == false)
      {
        BtnBulletList.Checked = true;
        TxtDocument.SelectionBullet = true;
      }
      else if (BtnBulletList.Checked == true)
      {
        BtnBulletList.Checked = false;
        TxtDocument.SelectionBullet = false;
      }
    }

    private void BtnIncrease_Click(object sender, EventArgs e)
    {
      string fontSizeNum = fontSizeComboBox.Text;
      try
      {
        int size = Convert.ToInt32(fontSizeNum) + 1;
        if (TxtDocument.SelectionFont == null)
        {
          return;
        }

        TxtDocument.SelectionFont = new Font(TxtDocument.SelectionFont.FontFamily, size, TxtDocument.SelectionFont.Style);
        fontSizeComboBox.Text = size.ToString();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void BtnDecrease_Click(object sender, EventArgs e)
    {
      string fontSizeNum = fontSizeComboBox.Text;
      try
      {
        int size = Convert.ToInt32(fontSizeNum) - 1;
        if (TxtDocument.SelectionFont == null)
        {
          return;
        }

        TxtDocument.SelectionFont = new Font(TxtDocument.SelectionFont.FontFamily, size, TxtDocument.SelectionFont.Style);
        fontSizeComboBox.Text = size.ToString();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void TxtDocument_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
    {
      if (e.Data.GetDataPresent(DataFormats.Text))
        e.Effect = DragDropEffects.Copy;
      else
        e.Effect = DragDropEffects.None;
    }

    private void TxtDocument_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
    {
      int i;
      String s;
      i = TxtDocument.SelectionStart;
      s = TxtDocument.Text.Substring(i);
      TxtDocument.Text = TxtDocument.Text.Substring(0, i);
      TxtDocument.Text += e.Data.GetData(DataFormats.Text).ToString();
      TxtDocument.Text += s;
    }


    private void BtnUndo_Click(object sender, EventArgs e)
    {
      TxtDocument.Undo();
    }
    private void BtnRedo_Click(object sender, EventArgs e)
    {
      TxtDocument.Redo();
    }

    private void BtnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void BtnDelete_Click(object sender, EventArgs e)
    {
      TxtDocument.SelectedText = "";
      TxtDocument.Focus();
    }
    private void BtnOpenFile_Click(object sender, EventArgs e)
    {
      OpenFileD.ShowDialog();
      if (OpenFileD.ShowDialog() == DialogResult.OK)
      {
        TxtDocument.LoadFile(OpenFileD.FileName, RichTextBoxStreamType.PlainText);
      }
    }
    private void BtnNewFile_Click(object sender, EventArgs e)
    {
      if (TxtDocument.Text != string.Empty)
      {
        DialogResult result = MessageBox.Show("Would you like to save your changes? Editor is not empty.", "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (result == DialogResult.Yes)
        {
          saveFileDialog1.ShowDialog();
          string file;
          if (saveFileDialog1.ShowDialog() == DialogResult.OK)
          {
            string filename = saveFileDialog1.FileName;
            TxtDocument.SaveFile(filename, RichTextBoxStreamType.PlainText);
            file = Path.GetFileName(filename);
            MessageBox.Show("File " + file + " was saved successfully.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          TxtDocument.ResetText();
          TxtDocument.Focus();
        }
        else if (result == DialogResult.No)
        {
          TxtDocument.ResetText();
          TxtDocument.Focus();
        }
      }
      else
      {
        TxtDocument.ResetText();
        TxtDocument.Focus();
      }
    }
    private void BtnSaveFile_Click(object sender, EventArgs e)
    {
      saveFileDialog1.ShowDialog();
      string file;
      if (saveFileDialog1.ShowDialog() == DialogResult.OK)
      {
        string filename = saveFileDialog1.FileName;
        TxtDocument.SaveFile(filename, RichTextBoxStreamType.PlainText);
      }
      file = Path.GetFileName(fileName);
      MessageBox.Show("File " + file + " was saved successfully.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    private void BtnZoom_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
      float zoomPercent = Convert.ToSingle(e.ClickedItem.Text.Trim('%'));
      TxtDocument.ZoomFactor = zoomPercent / 100;
      if (e.ClickedItem.Image == null)
      {
        for (int i = 0; i < BtnZoom.DropDownItems.Count; i++)
        {
          BtnZoom.DropDownItems[i].Image = null;
        }
        Bitmap bmp = new Bitmap(5, 5);
        using (Graphics gfx = Graphics.FromImage(bmp))
        {
          gfx.FillEllipse(Brushes.Black, 1, 1, 3, 3);
        }
        e.ClickedItem.Image = bmp;
      }
      else
      {
        e.ClickedItem.Image = null;
        TxtDocument.ZoomFactor = 1.0f;
      }
    }
    private void BtnUpperCase_Click(object sender, EventArgs e)
    {
      TxtDocument.SelectedText = TxtDocument.SelectedText.ToUpper();
    }
    private void BtnLowerCase_Click(object sender, EventArgs e)
    {
      TxtDocument.SelectedText = TxtDocument.SelectedText.ToLower();
    }
    private void BtnWordWrap_Click(object sender, EventArgs e)
    {
      Bitmap bmp = new Bitmap(5, 5);
      using (Graphics gfx = Graphics.FromImage(bmp))
      {
        gfx.FillEllipse(Brushes.Black, 1, 1, 3, 3);
      }
      if (TxtDocument.WordWrap == false)
      {
        TxtDocument.WordWrap = true;
        BtnWordWrap.Image = bmp;
      }
      else if (TxtDocument.WordWrap == true)
      {
        TxtDocument.WordWrap = false;
        BtnWordWrap.Image = null;
      }
    }
    private void BtnFont_Click(object sender, EventArgs e)
    {
      try
      {
        System.Drawing.Font oldFont = this.Font;
        FontD.ShowDialog();
        if (FontD.ShowDialog() == DialogResult.OK)
        {
          FontD_Apply(TxtDocument, new System.EventArgs());
        }
        else if (FontD.ShowDialog() == DialogResult.Cancel)
        {
          this.Font = oldFont;
          foreach (Control containedControl in TxtDocument.Controls)
          {
            containedControl.Font = oldFont;
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }
    private void FontD_HelpRequest(object sender, EventArgs e)
    {
      // display HelpRequest message
      MessageBox.Show("Please choose a font and any other attributes; then hit Apply and OK.", "Font Dialog Help Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    private void FontD_Apply(object sender, EventArgs e)
    {
      FontD.FontMustExist = true;
      TxtDocument.Font = FontD.Font;
      TxtDocument.ForeColor = FontD.Color;
      foreach (Control containedControl in TxtDocument.Controls)
      {
        containedControl.Font = FontD.Font;
      }
    }

    private void BtnPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
      e.Graphics.DrawString(TxtDocument.Text, TxtDocument.Font, Brushes.Black, 100, 20);
      e.Graphics.PageUnit = GraphicsUnit.Inch;
    }
    private void BtnPrint_Click(object sender, EventArgs e)
    {
      PrintD.Document = printDocument;
      if (PrintD.ShowDialog() == DialogResult.OK)
      {
        printDocument.Print();
      }
    }
    private void BtnPrintPreview_Click(object sender, EventArgs e)
    {
      try
      {
        PrintPreviewD.Document = printDocument;
        PrintPreviewD.ShowDialog();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void ColorD_HelpRequest(object sender, EventArgs e)
    {
      MessageBox.Show("Please select a color by clicking it. This will change the text color.", "Color Dialog Help Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    private void BtnColorOp_Click(object sender, EventArgs e)
    {
      ColorD.ShowDialog();
      if (ColorD.ShowDialog() == DialogResult.OK)
      {
        TxtDocument.ForeColor = ColorD.Color;
      }
    }



    private void TxtDocument_KeyUp(object sender, KeyEventArgs e)
    {
      switch (e.KeyCode)
      {
        case Keys.Down:
          pos = TxtDocument.SelectionStart;
          line = TxtDocument.GetLineFromCharIndex(pos);
          column = TxtDocument.SelectionStart - TxtDocument.GetFirstCharIndexFromLine(line);
          LineStatus.Text = "Line " + (line + 1) + ", Column " + (column + 1);
          break;
        case Keys.Right:
          pos = TxtDocument.SelectionStart;
          line = TxtDocument.GetLineFromCharIndex(pos);
          column = TxtDocument.SelectionStart - TxtDocument.GetFirstCharIndexFromLine(line);
          LineStatus.Text = "Line " + (line + 1) + ", Column " + (column + 1);
          break;
        case Keys.Up:
          pos = TxtDocument.SelectionStart;
          line = TxtDocument.GetLineFromCharIndex(pos);
          column = TxtDocument.SelectionStart - TxtDocument.GetFirstCharIndexFromLine(line);
          LineStatus.Text = "Line " + (line + 1) + ", Column " + (column + 1);
          break;
        case Keys.Left:
          pos = TxtDocument.SelectionStart;
          line = TxtDocument.GetLineFromCharIndex(pos);
          column = TxtDocument.SelectionStart - TxtDocument.GetFirstCharIndexFromLine(line);
          LineStatus.Text = "Line " + (line + 1) + ", Column " + (column + 1);
          break;
      }
    }
    private void TxtDocument_MouseDown(object sender, MouseEventArgs e)
    {
      int pos = TxtDocument.SelectionStart;
      int line = TxtDocument.GetLineFromCharIndex(pos);
      int column = TxtDocument.SelectionStart - TxtDocument.GetFirstCharIndexFromLine(line);
      LineStatus.Text = "Line " + (line + 1) + ", Column " + (column + 1);
    }
  }
}
