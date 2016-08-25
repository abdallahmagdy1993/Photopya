using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Photopya;
namespace Photopya.Action
{
    class LoadImageAction:Action
    {
        private string URL;
        public LoadImageAction(ApplicationManager A) : base(A) { 
        
        }
        public override void get_par()
        {
            URL=AP.Inter.get_bgURL();

        }
        public override void Excute()
        {
            get_par();
            AP.set_BG(URL);
            AP.set_edited(true);
            AP.set_first_edit(true);
            AP.delete_all();
            AP.logFile("load_image succeeded");
   

        }
    }
}
