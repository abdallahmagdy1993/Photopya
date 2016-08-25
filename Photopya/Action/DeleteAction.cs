using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Photopya;
using System.Drawing;
namespace Photopya.Action
{
    class DeleteAction:Action
    {
        public DeleteAction(ApplicationManager A) : base(A) { }
        public override void get_par()
        {
            IT = AP.get_selected_item();
        }
        public override void Excute()
        {
            get_par();
            AP.delete_item(IT);
            AP.unselect();
            AP.set_edited(true);
            AP.logFile("delete succeeded");

        }
    }
}
