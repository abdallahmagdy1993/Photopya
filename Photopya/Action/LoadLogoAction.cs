using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Photopya;

namespace Photopya.Action
{
    class LoadLogoAction:Action
    {
        
        private string URL;
        public LoadLogoAction(ApplicationManager A) : base(A) { }

        public override void get_par()
        {
            URL = AP.Inter.get_logoURL();
        }
        public override void Excute()
        {
            get_par();
            AP.unselect();
            IT = new Item.ImageItem(AP.get_item_count());
            (IT as Item.ImageItem).set_URL(URL);
            AP.add_item(IT);
            AP.unselect();
            AP.set_edited(true);
            AP.logFile("load_logo succeeded");

        }

    }
}
