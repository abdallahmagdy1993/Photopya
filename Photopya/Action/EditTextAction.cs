using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Photopya;
namespace Photopya.Action
{
    class EditTextAction:Action
    {
        private string TXT;
        public EditTextAction(ApplicationManager A) : base(A) { 
        }
        public override void get_par()
        {
            IT = AP.get_selected_item();
            TXT=AP.Inter.get_textbox();
        }
        public override void Excute()
        {
            get_par();
           
            (IT as Item.TextItem).set_txt(TXT);
            AP.set_edited(true);
            AP.logFile("edit_text succeeded");
   
           
        }
    }
}
