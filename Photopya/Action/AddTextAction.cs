using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Photopya;
namespace Photopya.Action
{
    class AddTextAction:Action
    {
        

        public AddTextAction(ApplicationManager A) : base(A) { }
        public override void get_par()
        {

          
        }
        public override void Excute()
        {
            get_par();
              
            IT = new Item.TextItem(AP.get_item_count());
            AP.add_item(IT);
            AP.unselect();
            AP.set_edited(true);
            AP.logFile("add_text succeeded");
        }

    }
}
