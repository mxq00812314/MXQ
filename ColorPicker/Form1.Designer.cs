using Cyotek.Windows.Forms;

namespace ColorPicker
{
  internal partial class Form1
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
            this.previewPanel = new System.Windows.Forms.Panel();
            this.lightnessColorSlider = new Cyotek.Windows.Forms.LightnessColorSlider();
            this.screenColorPicker = new Cyotek.Windows.Forms.ScreenColorPicker();
            this.colorWheel = new Cyotek.Windows.Forms.ColorWheel();
            this.colorEditor = new Cyotek.Windows.Forms.ColorEditor();
            this.colorGrid = new Cyotek.Windows.Forms.ColorGrid();
            this.colorEditorManager = new Cyotek.Windows.Forms.ColorEditorManager();
            this.txtRGB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHEX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtARGB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // previewPanel
            // 
            this.previewPanel.Location = new System.Drawing.Point(146, 330);
            this.previewPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(60, 57);
            this.previewPanel.TabIndex = 12;
            // 
            // lightnessColorSlider
            // 
            this.lightnessColorSlider.Location = new System.Drawing.Point(205, 35);
            this.lightnessColorSlider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lightnessColorSlider.Name = "lightnessColorSlider";
            this.lightnessColorSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.lightnessColorSlider.Size = new System.Drawing.Size(33, 207);
            this.lightnessColorSlider.TabIndex = 21;
            // 
            // screenColorPicker
            // 
            this.screenColorPicker.Color = System.Drawing.Color.Black;
            this.screenColorPicker.Location = new System.Drawing.Point(14, 330);
            this.screenColorPicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.screenColorPicker.Name = "screenColorPicker";
            this.screenColorPicker.Size = new System.Drawing.Size(126, 57);
            this.screenColorPicker.Zoom = 6;
            // 
            // colorWheel
            // 
            this.colorWheel.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorWheel.Location = new System.Drawing.Point(14, 35);
            this.colorWheel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.colorWheel.Name = "colorWheel";
            this.colorWheel.Size = new System.Drawing.Size(184, 207);
            this.colorWheel.TabIndex = 10;
            // 
            // colorEditor
            // 
            this.colorEditor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorEditor.Location = new System.Drawing.Point(258, 31);
            this.colorEditor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 6);
            this.colorEditor.Name = "colorEditor";
            this.colorEditor.Size = new System.Drawing.Size(293, 290);
            this.colorEditor.TabIndex = 7;
            // 
            // colorGrid
            // 
            this.colorGrid.AutoAddColors = false;
            this.colorGrid.CellBorderStyle = Cyotek.Windows.Forms.ColorCellBorderStyle.None;
            this.colorGrid.EditMode = Cyotek.Windows.Forms.ColorEditingMode.Both;
            this.colorGrid.Location = new System.Drawing.Point(14, 250);
            this.colorGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.colorGrid.Name = "colorGrid";
            this.colorGrid.Padding = new System.Windows.Forms.Padding(0);
            this.colorGrid.Palette = Cyotek.Windows.Forms.ColorPalette.Paint;
            this.colorGrid.SelectedCellStyle = Cyotek.Windows.Forms.ColorGridSelectedCellStyle.Standard;
            this.colorGrid.ShowCustomColors = false;
            this.colorGrid.Size = new System.Drawing.Size(192, 72);
            this.colorGrid.Spacing = new System.Drawing.Size(0, 0);
            this.colorGrid.TabIndex = 11;
            // 
            // colorEditorManager
            // 
            this.colorEditorManager.ColorEditor = this.colorEditor;
            this.colorEditorManager.ColorGrid = this.colorGrid;
            this.colorEditorManager.ColorWheel = this.colorWheel;
            this.colorEditorManager.LightnessColorSlider = this.lightnessColorSlider;
            this.colorEditorManager.ScreenColorPicker = this.screenColorPicker;
            this.colorEditorManager.ColorChanged += new System.EventHandler(this.colorEditorManager_ColorChanged);
            // 
            // txtRGB
            // 
            this.txtRGB.Location = new System.Drawing.Point(304, 338);
            this.txtRGB.Name = "txtRGB";
            this.txtRGB.Size = new System.Drawing.Size(236, 23);
            this.txtRGB.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "RGB";
            // 
            // txtHEX
            // 
            this.txtHEX.Location = new System.Drawing.Point(304, 367);
            this.txtHEX.Name = "txtHEX";
            this.txtHEX.Size = new System.Drawing.Size(236, 23);
            this.txtHEX.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "ARGB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "HEX";
            // 
            // txtARGB
            // 
            this.txtARGB.Location = new System.Drawing.Point(304, 396);
            this.txtARGB.Name = "txtARGB";
            this.txtARGB.Size = new System.Drawing.Size(236, 23);
            this.txtARGB.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 427);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtARGB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHEX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRGB);
            this.Controls.Add(this.lightnessColorSlider);
            this.Controls.Add(this.screenColorPicker);
            this.Controls.Add(this.colorWheel);
            this.Controls.Add(this.colorEditor);
            this.Controls.Add(this.colorGrid);
            this.Controls.Add(this.previewPanel);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(571, 466);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(571, 466);
            this.Name = "Form1";
            this.Text = "ÑÕÉ«Ñ¡ÔñÆ÷";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private ScreenColorPicker screenColorPicker;
    private ColorWheel colorWheel;
    private ColorEditor colorEditor;
    private ColorGrid colorGrid;
    private ColorEditorManager colorEditorManager;
    private System.Windows.Forms.Panel previewPanel;
    private LightnessColorSlider lightnessColorSlider;
    private System.Windows.Forms.TextBox txtRGB;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtHEX;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtARGB;
  }
}
