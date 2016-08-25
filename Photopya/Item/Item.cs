using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Photopya.Item
{
    abstract class Item
    {
     protected Point position; //position of item on picture box
     
     protected float opacity;
     protected bool selected; //item selected or not
     protected string name;
     public Item(Item I, int ly)
     {
         position.X = 0;
         position.Y = 0;
     
         selected = false;
         opacity = I.opacity;
     }   
        public Item(int ly)
     {
        
         position.X = 0;
         position.Y = 0;
     
         selected = false;
         opacity = 1.0f;

     }
     public void set_position(Point p) {
         position = p;
     }
     
     public void set_selected(bool b)
     {
         selected = b;
     }
     public abstract void set_opacity(int o);
     public  Point get_position()
     {
         return position;
     }
     public bool get_selected()
     {
         return selected;
     }
     public string get_name() { return name; }
     public abstract int get_opacity();

     public abstract void draw_item(Bitmap BG);     //func of drawing item will be implemented in image and text classes
    }
}
