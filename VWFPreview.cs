using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ScriptCompare.Properties;

namespace ScriptCompare
{
    public partial class VWFPreview : Form
    {
        Bitmap font = new Bitmap(1, 1);
        Dictionary<string, tile> tilemap = new Dictionary<string, tile>();
        string lasttext = "";
        public VWFPreview()
        {
            InitializeComponent();
        }

        public string SetText(string thetext)
        {
            string StringOut = "";
            if (thetext.Length > 0 && !(lasttext == thetext))
            {
                lasttext = thetext;
                //convert tilemap to point list
                List<tmap> instruction = new List<tmap>();
                bool ignore = false;
                int dr = 0;
                int dc = 0;
                //int maxcol = 22;//the destination...
                for (int p = 0; p < thetext.Length; p++)
                {
                    char c = thetext[p]; //support up to 4 characters/(bytes in a control code) for a single tile
                    string c2 = (thetext.Length > p + 1) ? thetext[p] + thetext[p + 1].ToString() : "~herp";
                    string c3 = (thetext.Length > p + 2) ? thetext[p] + thetext[p + 1].ToString() + thetext[p + 2].ToString() : "~herp";
                    string c4 = (thetext.Length > p + 3) ? thetext[p] + thetext[p + 1].ToString() + thetext[p + 2].ToString() + thetext[p + 3].ToString() : "~herp";

                    string used = "";

                    if (c == '[')
                    {
                        ignore = true;
                        used = c.ToString();
                    }
                    else if (c == ']')
                    {
                        ignore = false;
                        used = c.ToString();
                    }
                    else if (c == '\r')
                    {
                        dr++;
                        p++;
                        dc = 0;
                        used = "\r\n";
                    }
                    else if (c == ' ' && !ignore)
                    {
                        tmap tm = new tmap();
                        tm.Source = new Point(-1, -1);
                        tm.Dest = new Point(dc, dr);
                        instruction.Add(tm);
                        dc += (Settings.Default.VisualTileWidth / 2); //spaces are a half-width
                        used = c.ToString();
                    }
                    else if (!ignore)
                    {
                        if (tilemap.ContainsKey(c4))
                        {
                            tmap tm = new tmap();
                            tm.Source = new Point(tilemap[c4].col, tilemap[c4].row);
                            tm.Dest = new Point(dc, dr);
                            instruction.Add(tm);
                            p += c4.Length - 1;
                            dc += tilemap[c4].width-1;
                            used = c4;
                        }
                        else if (tilemap.ContainsKey(c3))
                        {
                            tmap tm = new tmap();
                            tm.Source = new Point(tilemap[c3].col, tilemap[c3].row);
                            tm.Dest = new Point(dc, dr);
                            instruction.Add(tm);
                            p += c3.Length - 1;
                            dc += tilemap[c3].width-1;
                            used = c3;
                        }
                        else if (tilemap.ContainsKey(c2))
                        {
                            tmap tm = new tmap();
                            tm.Source = new Point(tilemap[c2].col, tilemap[c2].row);
                            tm.Dest = new Point(dc, dr);
                            instruction.Add(tm);
                            p += c2.Length - 1;
                            dc += tilemap[c2].width-1;
                            used = c2;
                        }
                        else if (tilemap.ContainsKey(c.ToString()))
                        {
                            tmap tm = new tmap();
                            tm.Source = new Point(tilemap[c.ToString()].col, tilemap[c.ToString()].row);
                            tm.Dest = new Point(dc, dr);
                            instruction.Add(tm);
                            dc += tilemap[c.ToString()].width-1;
                            used = c.ToString();
                        }
                    }
                    else
                    {//character ignored by the preview
                        used = c.ToString();
                    }

                    //build the output string
                    //if max tiles per line width is exceeded, increment the dr (drawing row)
                    if (dc > (Settings.Default.MaxTilesPerLine * Settings.Default.VisualTileWidth))
                    {
                        dr++;
                        dc = 0;
                        //find the last space character and apply line break there... if none, just do it here.
                        string[] sp = StringOut.Split(' ');
                        if (sp.Length > 0)
                        {
                            StringOut = "";
                            for (int hc = 0; hc < sp.Length; hc++)
                            {
                                if (hc == sp.Length - 1)
                                {//last one
                                    StringOut += "\r\n" + sp[hc];
                                }
                                else
                                {//any other
                                    StringOut += ((StringOut == "") ? "" : " ") + sp[hc]; 
                                }
                            }
                            StringOut += used;
                        }
                        else
                        {
                            StringOut += "\r\n" + used;
                        }
                    }
                    else
                    {//we havent gone beyond the line width
                        StringOut += used;
                    }
                }
                DrawText(font, instruction);
            }
            return StringOut;
        }


        struct tmap
        {
            public Point Source;
            public Point Dest;
        }

        struct tile
        {
            public int row;
            public int col;
            public int width;
        }

        private void Preview_Load(object sender, EventArgs e)
        {
            //fontDisplay.Image = 
            font = GetImage(Properties.Settings.Default.TilesetPath);
            tilemap = GetTileMap(Properties.Settings.Default.TilemapPath, Properties.Settings.Default.TilemapWidthFile);
        }

        private void Preview_Shown(object sender, EventArgs e)
        {//drawing points are tile-based, not pixel based... so will make defining the tiles easier... kinda
            //DrawText(font, new Point[] { new Point(0, 0), new Point(1, 0), new Point(2, 0), new Point(3, 0) },
            //    new Point[] { new Point(0, 0), new Point(1, 0), new Point(3, 5), new Point(6, 80) });
            using (Graphics g = this.CreateGraphics())
            {
                g.Clear(Color.Black);
                DrawBounds(g);
            }
        }


        private List<int> GetWidths(string widfile)
        {
            List<int> myList = new List<int>();
            if (File.Exists(widfile))
            {
                using (StreamReader sr = new StreamReader(widfile))
                {
                    while (!sr.EndOfStream)
                    {
                        string l = sr.ReadLine().Trim();
                        if (!l.StartsWith(@"//")) // not a comment line
                        {
                            string[] lA = l.Split(new string[] { "," }, StringSplitOptions.None);
                            foreach (string s in lA)
                            {
                                try
                                {
                                    myList.Add(int.Parse(s));
                                }
                                catch { }
                            }
                        }
                    }
                }
            }
            return myList;
        }

        private int GetWid(List<int> widths, int col, int row)
        {
            int retVal = 16;

            int index = (row * 8) + col;
            if (index < widths.Count)
            {
                try
                {
                    retVal = widths[index];
                }
                catch { }
            }

            return retVal;
        }
        private Dictionary<string, tile> GetTileMap(string tmfile, string widfile)
        {
            string tSep = Properties.Settings.Default.TilemapSep;
            bool oldmap = false;
            int oldlen = 0;

            List<int> widths = GetWidths(widfile);

            Dictionary<string, tile> tm = new Dictionary<string, tile>();
            if (File.Exists(tmfile))
            {
                using (StreamReader sr = new StreamReader(tmfile))
                {
                    int row = 0;
                    while (!sr.EndOfStream)
                    {
                        string l = sr.ReadLine();
                        //detect if the seperator exists...
                        if (l.Contains(tSep))
                        {//get the new tilemap format
                            string[] lA = l.Split(new string[] {tSep}, StringSplitOptions.None);
                            for (int col = 0; col < lA.Length; col++)
                            {
                                tile t = new tile();
                                t.col = col;
                                t.row = row;
                                t.width = GetWid(widths, col, row);
                                if (!tm.ContainsKey(lA[col]))
                                {
                                    tm.Add(lA[col], t);
                                }
                            }
                        }
                        else
                        {//old tilemap
                            if (oldlen == 0)
                            {
                                oldmap = true;
                                oldlen = l.Length;
                            }
                            for (int col = 0; col < l.Length; col++)
                            {
                                tile t = new tile();
                                t.col = col;
                                t.row = row;
                                if (!tm.ContainsKey(l[col].ToString()))
                                {
                                    tm.Add(l[col].ToString(), t);
                                }
                                else
                                {
                                    int cinc = 0;
                                    string chk = l[col].ToString();
                                    while (tm.ContainsKey(chk))
                                    {
                                        cinc++;
                                        chk = l[col].ToString() + cinc;
                                    }
                                    tm.Add(chk, t);
                                }
                            }
                        }
                        row++;
                    }
                }
            }
            if (oldmap)
            {//save in the new format... Will only need this once.
                using (StreamWriter sw = new StreamWriter(tmfile, false))
                {
                    int pos = 0;
                    foreach (KeyValuePair<string, tile> t in tm)
                    {
                        if (pos == oldlen-1)
                        {
                            sw.WriteLine(t.Key);
                            pos = -1;
                        }
                        else
                        {
                            sw.Write(t.Key + tSep);
                        }
                        pos++;
                    }
                }
            }
            return tm;
        }
        private Bitmap GetImage(string font)
        {
            Bitmap b = new Bitmap(1,1);
            if (File.Exists(font))
            {
                Image i = Image.FromFile(font);
                b = new Bitmap(i);
                Color xP = Color.FromArgb(0, 0, 248);
                for (int y = 0; y < b.Size.Height; y++)
                {
                    for (int x = 0; x < b.Size.Width; x++)
                    {
                        if (b.GetPixel(x, y) == xP)
                        {
                            b.SetPixel(x, y, Color.Transparent);
                        }
                    }
                }
            }
            return b;
        }

        private void DrawText(Bitmap b, List<tmap> mTile)
        {
            using (Graphics g = this.CreateGraphics())
            {
                g.Clear(Color.Black);
                foreach (tmap tm in mTile)
                {
                    Rectangle dest;
                    Rectangle src;
                    if (tm.Source.Y == -1)
                    {
                        dest = new Rectangle(tm.Dest.X, tm.Dest.Y * 16, 16, 16);
                        src = new Rectangle(0, 0, 1, 1);
                    }
                    else
                    {
                        dest = new Rectangle(tm.Dest.X, tm.Dest.Y * 16, 16, 16);
                        src = new Rectangle(tm.Source.X * 16, tm.Source.Y * 16, 16, 16);
                    }
                    g.DrawImage(b, dest, src, GraphicsUnit.Pixel);
                }
                DrawBounds(g);
            }
        }

        private void DrawBounds(Graphics g)
        {
            g.DrawLine(Pens.Red, new Point(0, 16), new Point(352, 16));
            g.DrawLine(Pens.Red, new Point(352, 16), new Point(352, 64));
            g.DrawLine(Pens.Red, new Point(0, 64), new Point(352, 64));
        }

        //private void DrawText(Bitmap b, Point[] destpoints, Point[] sourcepoints)
        //{
        //    using (Graphics g = this.CreateGraphics())
        //    {
        //        g.Clear(Color.Black);
        //        for (int p = 0; p < destpoints.Length; p++)
        //        {
        //            Rectangle dest = new Rectangle(destpoints[p].X * 16, destpoints[p].Y * 16, 16, 16);
        //            Rectangle src = new Rectangle(sourcepoints[p].X * 16, sourcepoints[p].Y * 16, 16, 16);
        //            g.DrawImage(b, dest, src, GraphicsUnit.Pixel);
        //        }
        //        DrawBounds(g);
        //    }
        //}
    }
}
