using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photopya.Action
{
    class SaveAction:Action
    {
        private string URL;
        public SaveAction(ApplicationManager A) : base(A) { }

        public override void get_par()
        {
            if (AP.get_first_edit())
                AP.Inter.show_savedialog();
            URL = AP.Inter.get_saveURL();
        }

        public override void Excute()
        {
            get_par();
            if (URL == ""||URL==null)
                return;
            AP.set_first_edit(false);
            AP.set_edited(false);

            AP.unselect();
            AP.draw();
         
            AP.save(URL);
            AP.logFile("save succeeded");

        }

    }
}
