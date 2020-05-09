using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorPicker
{
    // Cyotek Color Picker controls library
    // Copyright © 2013-2017 Cyotek Ltd.
    // http://cyotek.com/blog/tag/colorpicker

    // Licensed under the MIT License. See license.txt for the full text.

    // If you use this code in your applications, donations or attribution are welcome

    internal partial class Form1 : Form
    {
        #region Constructors

        public Form1()
        {
            this.InitializeComponent();
            this.SuspendLayout();
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Cursor.Current = Cursors.Default;
        }

        protected override void OnResize(EventArgs e){}

        #endregion

        #region Methods


        private void colorEditorManager_ColorChanged(object sender, EventArgs e)
        {
            previewPanel.BackColor = colorEditorManager.Color;
            txtRGB.Text = $"{colorEditorManager.Color.R},{colorEditorManager.Color.G},{colorEditorManager.Color.B}";
            txtHEX.Text = $"{string.Format("{0:X2}{1:X2}{2:X2}", colorEditorManager.Color.R, colorEditorManager.Color.G, colorEditorManager.Color.B)}";
            txtARGB.Text = $"{colorEditorManager.Color.A},{colorEditorManager.Color.R},{colorEditorManager.Color.G},{colorEditorManager.Color.B}";
        }

        #endregion
    }
}
