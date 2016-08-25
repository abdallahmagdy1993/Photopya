using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Photopya.Item
{
    class TextItem:Item
    {
        private string txt;
        private Font font;
        private Color color;
        public TextItem(int l):base(l){
            font=new Font("Tahoma",15);
            color=Color.Black;
            txt = "Text";
            opacity = 255;
            name = "text " + l.ToString();
        }
        public TextItem(TextItem tx, int l) : base(tx, l) {
            font = tx.font;
            color = tx.color;
            txt = tx.txt;
            opacity = tx.opacity;
            name = "text " + l.ToString();
        }
        public void set_txt(string s) {
            txt = s;
        }
        public void set_font(Font f) {
            font = f;
        }
        public void set_color(Color c) {
            color = c;
        }
        public string get_txt()
        {
            return txt;
        }
        public Font get_font()
        {
            return font;
        }
        public Color get_color()
        {
            return color;
        }
        public override void set_opacity(int o)
        {
            opacity = o*255.0f / 100.0f;
        }
        public override int get_opacity()
        {
            return (int)(opacity * 100.0f/255.0f);
        }
        public override void draw_item(Bitmap BG)
        {
            Brush Bb = new SolidBrush(Color.FromArgb((int)(opacity), color));
            Graphics G = Graphics.FromImage(BG);
            G.DrawString(txt, font, Bb, position);
            if (selected == true)
            {
                float w = G.MeasureString(txt, font).Width;
                G.DrawRectangle(Pens.White, position.X, position.Y, w, font.Height);
            }

        }

    }
}
