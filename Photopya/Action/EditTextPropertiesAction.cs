using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Photopya;
using System.Drawing;
namespace Photopya.Action
{
    class EditTextPropertiesAction:Action
    {
        Color color;
        Font font;
        public EditTextPropertiesAction(ApplicationManager A) : base(A) { }
        public override void get_par()
        {
            IT = AP.get_selected_item();
            color = AP.Inter.get_textcolor();
            font = AP.Inter.get_font();
        }
        public override void Excute()
        {
            get_par();
            (IT as Item.TextItem).set_color(color);
            (IT as Item.TextItem).set_font(font);
            AP.set_edited(true);
            AP.logFile("edit_text_prop succeeded");

        }
    }
}
