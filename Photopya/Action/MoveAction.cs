using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Photopya;
using System.Drawing;
namespace Photopya.Action
{
    class MoveAction:Action
    {
        private Point pos;
        public MoveAction(ApplicationManager A) : base(A) { }
        public override void get_par()
        {
            IT = AP.get_selected_item();
            pos=AP.Inter.get_postion();
        }
        public override void Excute()
        {
            get_par();
            IT.set_position(pos);
            AP.set_edited(true);
            AP.logFile("move succeeded");

        }

    }
}
