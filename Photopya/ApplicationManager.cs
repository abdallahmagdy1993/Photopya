using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Photopya.Item;
using System.Drawing;
using Photopya;
using Photopya.Action;
namespace Photopya
{
    class ApplicationManager
    {
        private List<Item.Item> item_list;  //the list of all items (logos & texts)
        private Bitmap BG;      //the background bitmap
        private Bitmap original_BG;
        private Interface inter;    //the interface object
        private Item.Item selected_item;    //object of selected logo/text
        private Action.Action act;  //object of action to be executed
        private bool first_edit;
        private int item_count;
        private Item.Item copied_item;
        private bool edited;
        private List<Bitmap> duplicate_list=new List<Bitmap>();//list of images choosed in duplicate
        private ImageItem duplicate_logo;// logo used in duplicate
        public ApplicationManager ()
        {
            item_list=new List<Item.Item>();
            first_edit = false;
            edited = false;
            item_count = 0;
        }
        public int get_item_count()
        {
            return item_count;
        }
        public Item.Item get_selected_item()
        {
            return selected_item;
        }
        public void set_copied_item(Item.Item it)
        {
            copied_item = it;
        }
        public Item.Item get_copied_item()
        {
            return copied_item;
        }
        public void set_first_edit(bool s)
        {
            first_edit = s;
        }
        public bool get_first_edit()
        {
            return first_edit;
        }
        public Interface Inter     {   
            get
            {
            return inter;
            }
            set
            {
                inter = value;
            }
        }

        public void set_edited(bool e)
        {
            edited = e;
        }
        public bool get_edited()
        {
            return edited;
        }
        public List<Item.Item> get_itemlist()
        {
            return this.item_list;
        }
        public void set_BG(string URL)
        {
            original_BG = new Bitmap(Image.FromFile(URL));
        
        }
        public Bitmap get_BG()
        {
            return original_BG;
        
        }

        public void add_item(Item.Item I)
        {
            item_list.Add(I);
            item_count++;
            set_layers();

           
        }

        public void setduplicate_list(string[] s)
        {
            duplicate_list.Clear();
            
            for(int i=0;i<s.Length;i++)
            {
                Bitmap b = new Bitmap(Image.FromFile(s[i]));
                duplicate_list.Add(b);
            }
        }

        public void setduplicate_logo(string s)
        {
            duplicate_logo = new ImageItem(0);
            duplicate_logo.set_URL(s);

        
        }

        public ImageItem getduplicate_logo()
        {
            return duplicate_logo;

        }

        public void delete_item(Item.Item it)
        {
            item_list.Remove(it);


            set_layers();
        }

        public void delete_all()
        {
            item_list.Clear();
            set_layers();
        
        }
        public void set_layers()
        {
            List<string> L = new List<string>();
            for (int i = item_list.Count - 1; i >= 0; i--)
            {
                L.Add(item_list[i].get_name());

            }
            inter.set_layers(L);
        
        
        }
        public void swap_layers(int x)
        {
            Item.Item IT;
            for (int i = 0; i < item_list.Count; i++)
            {
                if (item_list[i] == selected_item){
                    if (x == 2 && i > 0)
                    {
                        IT = item_list[i - 1];
                        item_list[i - 1] = item_list[i];
                        item_list[i] = IT;
                        
                        set_layers();
                        logFile("layer_down succeeded");

                    }
                    if (x == 1 && i < item_list.Count - 1)
                    {
                        IT = item_list[i + 1];
                        item_list[i + 1] = item_list[i];
                        item_list[i] = IT;
                        set_layers();
                        logFile("layer_up succeeded");
                    }
                   
                    break;
                }
                            }

        }
        public void apply_duplicate()
        {
            ImageItem I;
            Size s = new Size() ;
            Point p=new Point();
            Size box_size=inter.getpicturebox_size();
            duplicate_logo.set_selected(false);
            for (int i = 0; i < duplicate_list.Count; i++)
            {
                I = new ImageItem(duplicate_logo,0);
                s.Width=duplicate_logo.get_size().Width*duplicate_list[i].Width/box_size.Width;
                s.Height=duplicate_logo.get_size().Height*duplicate_list[i].Height/box_size.Height;
                I.set_size(s);
                p.X = duplicate_logo.get_position().X * duplicate_list[i].Width / box_size.Width;
                p.Y = duplicate_logo.get_position().Y * duplicate_list[i].Height / box_size.Height;
                I.set_position(p);
                I.draw_item(duplicate_list[i]);
                string ss = inter.getduplicate_url() + "/";
                string[] rename = inter.getduplicate_name().Split('.');
                for (int k = 0; k < rename.Length - 1; k++)
                {
                    if (k > 0)
                        ss = ss + "." + rename[k];
                    else
                    ss = ss + rename[k];
                }
                ss = ss + (i + 1).ToString().PadLeft(2,'0') + "." + rename[rename.Length - 1];
                duplicate_list[i].Save(ss);

            }

        }

        public void save(string url)
        {
            Bitmap im = new Bitmap(inter.getpicturebox_image());
            im.Save(url);
        }
        public void set_selected_item(string s)
        {
            for (int i = 0; i < item_list.Count; i++)
                if (item_list[i].get_name() == s)
                {
                    selected_item = item_list[i];
                    item_list[i].set_selected(true);
                    break;
                }
        }
        public void draw()
        {
            if (selected_item != null)
            {
                inter.set_position(selected_item.get_position());
                inter.set_opacity(selected_item.get_opacity());
                if (selected_item is ImageItem)
                {
                    Size s = (selected_item as Item.ImageItem).get_size();
                    inter.set_size(s);
                }
                else
                    inter.set_textbox((selected_item as TextItem).get_txt());

            }
            BG = new Bitmap(original_BG);

            
            for (int i = 0; i < item_list.Count; i++)
            {

                item_list[i].draw_item(BG);
            }
            
            inter.setpicturebox_image(BG);
        
        }
        public void unselect()
        {

            for (int i = 0; i < item_list.Count; i++)
            {
                    item_list[i].set_selected(false);
                    
                
            }
            selected_item = null;
            inter.deactivatetext_options();
            inter.deactiveimage_options();
            if (copied_item != null)
                inter.activate_paste();
        }
        public void logFile(string S)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("LogFile.log", true))
            {
               
                string date = System.DateTime.Now.ToString();
                writer.WriteLine(date+"  "+S);
            }
        }
        public void set_action(string act_type)
        {
            logFile(act_type + " started");
            switch (act_type){
                case "load_image":
                    act = new Action.LoadImageAction(this);
                    break;
                case "load_logo":
                    act = new Action.LoadLogoAction(this);
                    break;
                case "add_text":
                    act = new Action.AddTextAction(this);
                    break;
                case "edit_text":
                    act = new Action.EditTextAction(this);
                    break;
                case "edit_text_prop":
                    act = new Action.EditTextPropertiesAction(this);
                    break;
                case "move":
                    act=new Action.MoveAction(this);
                    break;
                case "resize":
                    act=new Action.ResizeAction(this);
                    break;
                case "save":
                    act = new Action.SaveAction(this);
                    break;
                case "save_as":
                    act = new Action.SaveAsAction(this);
                    break;
                case "select":
                    act = new Action.SelectAction(this);
                    break;
                case "copy":
                    act = new Action.CopyAction(this);
                    break;
                case "cut":
                    act=new Action.CutAction(this);
                    break;
                case "paste":
                    act = new Action.PasteAction(this);
                    break;
                case "delete":
                    act = new Action.DeleteAction(this);
                    break;
                case "opacity":
                    act = new Action.OpacityAction(this);
                    break;
                case "un_select":
                    unselect();
                    act = null;
                    logFile("un_select succeeded");
                    break;
                default:
                    break;
            }
            
            execute();
        }
        public void execute(){
            if(act!=null)
                act.Excute();
            draw();
        }


    }
}
