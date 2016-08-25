using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photopya.Action
{
    class SelectAction:Action
    {
        private string s;
        public SelectAction(ApplicationManager A) : base(A) { }
        public override void get_par()
        {
            AP.unselect();
            s = AP.Inter.get_selected_item();
            
           
        }
        public override void Excute()
        {
            get_par();
            AP.set_selected_item(s);
            if (AP.get_selected_item() is Item.ImageItem)
                AP.Inter.activeimage_options();
            else AP.Inter.activatetext_options();
               
        }

    }
}
