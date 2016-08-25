using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photopya.Action
{
    class CutAction:Action
    {
        public CutAction(ApplicationManager A) : base(A) { }
        public override void get_par()
        {
            IT = AP.get_selected_item();
        }
        public override void Excute()
        {
            get_par();
            AP.set_copied_item(IT);
            AP.delete_item(IT);
            AP.unselect();
            AP.Inter.activate_paste();
            AP.set_edited(true);
            AP.logFile("cut succeeded");


        }
    }
}
