using ScriptCompare.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScriptCompare
{
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Configuration_Load(object sender, EventArgs e)
        {
            tilesetBox.Text = Settings.Default.TilesetPath;
            tilewidthBox.Value = Settings.Default.VisualTileWidth;
            maxtilesBox.Value = Settings.Default.MaxTilesPerLine;
            tilemapbox.Text = Settings.Default.TilemapPath;
            tmwidthBox.Text = Settings.Default.TilemapWidthFile;
            tmSepBox.Text = Settings.Default.TilemapSep;
            enableAutoWrap.Checked = Settings.Default.EnableAutoWrapping;
            EnableMassAutoWrap.Checked = Settings.Default.EnableMassAutoWrap;
            EnableLeftEditing.Checked = Settings.Default.LeftFileEditing;
        }

    }
}
