using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class SkinPeeler : Form
    {
        
        public SkinPeeler()
        {
            InitializeComponent();
        }

        private void SkinPeeler_Load(object sender, EventArgs e)
        {

            var skinFiles = new DirectoryInfo("Skin/Default").GetFiles();
            var skinFileNames = skinFiles.Select(f => f.Name);
            IList<string> first = new List<string>() { "" };
            skinFileNames = first.Concat(skinFileNames.ToList());
            this.lsbSkins.DataSource = skinFileNames.ToList();
            this.lsbSkins.DisplayMember = "Name";
            lblSkinCount.Text = string.Format("共{0}个皮肤", skinFiles.Count());
        }

        private void lsbSkins_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lsbSkins.SelectedItem != null)
            {
               Program.skin.SkinFile = "Skin/Default/" + this.lsbSkins.SelectedItem;
            }
        }
    }
}
