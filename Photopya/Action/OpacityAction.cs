using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photopya.Action
{
    class OpacityAction:Action
    {
        private int opa;
        public OpacityAction(ApplicationManager A) : base(A) { }
        public override void get_par()
        {
            IT = AP.get_selected_item();
            opa = AP.Inter.get_opacity();
        }
        public override void Excute()
        {
            get_par();
            
            IT.set_opacity(opa);
            AP.set_edited(true);
            AP.logFile("opacity succeeded");

        }
    }
}
