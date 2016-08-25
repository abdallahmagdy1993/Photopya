using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photopya.Action
{
    class CopyAction:Action
    {
        
        public CopyAction(ApplicationManager A) : base(A) { }
        public override void get_par()
        {
            IT = AP.get_selected_item();
            
        }
        public override void Excute()
        {
            get_par();
            AP.set_copied_item(IT);
            AP.Inter.activate_paste();
            AP.logFile("copy succeeded");

        }
    }
}
