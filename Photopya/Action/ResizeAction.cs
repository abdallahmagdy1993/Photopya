using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Photopya;
using System.Drawing;
namespace Photopya.Action
{
    class ResizeAction:Action
    {
        private Size size;
        public ResizeAction(ApplicationManager A) : base(A) { }
        public override void get_par()
        {
            IT = AP.get_selected_item();
            size=AP.Inter.get_size();
        }
        public override void Excute()
        {

            get_par();
            (IT as Item.ImageItem).set_size(size);
            AP.set_edited(true);
            AP.logFile("resize succeeded");

        }
    }
}
