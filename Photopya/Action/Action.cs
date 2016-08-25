using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Photopya;
namespace Photopya.Action
{
    abstract class  Action
    {
       protected  ApplicationManager AP;
       protected Item.Item IT;
       
      
       public Action(ApplicationManager A) {
           AP = A;
       }
       public abstract void Excute();
       public abstract void get_par();

       
    }
}
