using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photopya.Action
{
    class PasteAction:Action
    {
        private Item.Item i;
        public PasteAction(ApplicationManager A) : base(A) { }
        public override void get_par()
        {
            IT = AP.get_copied_item();
            if (IT == null)
                return;
            
            if (IT is Item.ImageItem)
                i = new Item.ImageItem((IT as Item.ImageItem), AP.get_item_count());
            else
                i = new Item.TextItem((IT as Item.TextItem), AP.get_item_count());
        }
        public override void Excute()
        {
            get_par();
            if (IT == null)
                return;
            AP.add_item(i);
            AP.unselect();
            AP.set_edited(true);
            AP.logFile("paste succeeded");

           
        }
    }
}
