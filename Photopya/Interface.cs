using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Photopya
{
    public partial class Interface : Form
    {
        public Interface()
        {
            App = new ApplicationManager();
            App.Inter = this;
            App.logFile("================ session started ================");
            InitializeComponent();
        }
        
        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (App.get_edited())
            {
                dd = MessageBox.Show("Do you want to save changes ?", "My Application", MessageBoxButtons.YesNo);

                // Display a MsgBox asking the user to save changes or abort. 
                if (dd == DialogResult.Yes)
                {
                    // Cancel the Closing event from closing the form.
                    //e.Cancel = true;
                    App.set_action("save");
                }
               


            }
            BGdialog.Multiselect = false;
           DialogResult d= BGdialog.ShowDialog();
           if (d == DialogResult.OK)
           {
               bgURL = System.IO.Path.GetDirectoryName(BGdialog.FileName) + "/" + System.IO.Path.GetFileName(BGdialog.FileName);
               afterloading_activate();
               App.set_action("load_image");
           }
        }

        private void loadlogo_Click(object sender, EventArgs e)
        {
           logodialog.ShowDialog();
           
        }

        private void addtext_Click(object sender, EventArgs e)
        {
            textbox.Enabled = true;
            App.set_action("add_text");
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            App.set_action("save_as");
        }

        private void savedialog_FileOk(object sender, CancelEventArgs e)
        {
            if (savedialog.FileName != "")
                saveURL = System.IO.Path.GetDirectoryName(savedialog.FileName) + "/" + System.IO.Path.GetFileName(savedialog.FileName);
            else saveURL = "";
            
        }

        private void logodialog_FileOk(object sender, CancelEventArgs e)
        {
            
            logoURL = System.IO.Path.GetDirectoryName(logodialog.FileName) + "/" + System.IO.Path.GetFileName(logodialog.FileName);
            App.set_action("load_logo");
        }

       

        private void edittext_Click(object sender, EventArgs e)
        {
          //  fontdialog.ShowDialog();

            DialogResult result = fontdialog.ShowDialog();

            // If the OK button in the Font dialog box is clicked,  
            // set all the controls' fonts to the chosen font by calling 
            // the FontDialog1_Apply method. 
            if (result == DialogResult.OK)
            {
                textfont = fontdialog.Font;
                textcolor = fontdialog.Color;
                App.set_action("edit_text_prop");
            }
        }

        private void fontdialog_Apply(object sender, EventArgs e)
        {
            textfont = fontdialog.Font;
            textcolor = fontdialog.Color;
            App.set_action("edit_text_prop");

        }

        public void afterloading_activate() //activate load logo & add text buttons after loading a background
        {
            loadlogo.Enabled = true;
            addtext.Enabled = true;
            saveAsToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = true;

        }
        public void activeimage_options()//activate item options after selecting it
        {
            unselect.Enabled = true;
            moveup.Enabled = true;
            movedown.Enabled = true;
            copy.Enabled = true;
            cut.Enabled = true;
            paste.Enabled = true;
            xposition.Enabled = true;
            yposition.Enabled = true;
            widthsize.Enabled = true;
            heightsize.Enabled = true;
            opacitybar.Enabled = true;
            delete.Enabled = true;
            
        }
        public void deactiveimage_options()//deactivate item options after unselecting it
        {
            unselect.Enabled = false;
            moveup.Enabled = false;
            movedown.Enabled = false;
            copy.Enabled = false;
            cut.Enabled = false;
            paste.Enabled = false;
            xposition.Enabled = false;
            yposition.Enabled = false;
            widthsize.Enabled = false;
            heightsize.Enabled = false;
            opacitybar.Enabled = false;
            delete.Enabled = false;
            
        }
        public void activatetext_options()//activate text options after selecting it
        {
            unselect.Enabled = true;
            moveup.Enabled = true;
            movedown.Enabled = true;
            
            edittext.Enabled = true;
            textbox.Enabled = true;
            copy.Enabled = true;
            cut.Enabled = true;
            xposition.Enabled = true;
            yposition.Enabled = true;
            opacitybar.Enabled = true;
            delete.Enabled = true;
            
        }
        public void deactivatetext_options()//deactivate text options after unselecting it
        {
            unselect.Enabled = false;
            moveup.Enabled = false;
            movedown.Enabled = false;
            
            edittext.Enabled = false;
            textbox.Enabled = false;
            copy.Enabled = false;
            cut.Enabled = false;
            xposition.Enabled = false;
            yposition.Enabled = false;
            opacitybar.Enabled = false;
            delete.Enabled = false;
            
        }

        public void setpicturebox_image(Bitmap b)
        {
            if (duplicate_check == true)
            {
                Bitmap resultImage = new Bitmap(picturebox.Width, picturebox.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                using (Graphics grp = Graphics.FromImage(resultImage))
                {
                    grp.FillRectangle(
                        Brushes.LightSkyBlue, 0, 0, picturebox.Width, picturebox.Height);

                }
                App.getduplicate_logo().set_selected(true);
                App.getduplicate_logo().draw_item(resultImage);
                picturebox.Image = resultImage;
            }
            else
            picturebox.Image= b;
        }
        public Image getpicturebox_image()
        {
            return picturebox.Image;
        }

        public Size getpicturebox_size()
        {
            return picturebox.Size;
        }
        public string get_bgURL()
        {
            return bgURL;
        }
        public string get_saveURL()
        {
            return saveURL;
        }
        public string get_logoURL()
        {
            return logoURL;
        }

        public void set_position(Point p)
        {
            xposition.Text = p.X.ToString();
            yposition.Text = p.Y.ToString();
        }


        public Point get_postion()
        {
            
            
            Point position=new Point();
            if (xposition.Text != "")
                position.X = int.Parse(xposition.Text);
            else
                position.X = 0;
            if (yposition.Text != "")
                position.Y = int.Parse(yposition.Text);
            else
                position.Y = 0;
            
            return position;
        }
        public void set_size(Size s)
        {
            widthsize.Text = s.Width.ToString();
            heightsize.Text = s.Height.ToString();
        }
        public Size get_size()
        {
            
            Size size=new Size();
            if (widthsize.Text != "")
                size.Width = int.Parse(widthsize.Text);
            else size.Width = 50;
            if (heightsize.Text != "")
                size.Height = int.Parse(heightsize.Text);
            else size.Height = 50;

            
            return size;

        }
        /////////////////////////////////////////////////
        public void set_opacity(int op)
        {
            opacitybar.Value = op;
            opacityvalue.Text = op.ToString();
        }
        public int get_opacity()
        {
            return opacitybar.Value;
        }

        public Font get_font()
        {
            return textfont;
        }
        public Color get_textcolor()
        {
            return textcolor;
        }
        public void set_textbox(string text)
        {
            textbox.Text = text;
        }
        public string get_textbox()
        {
            return textbox.Text;
        }
        public void set_selected_item(string s)
        {
            selected_item = s;
            
        
        }
        public string get_selected_item()
        {
            return selected_item;
        }
        public void show_savedialog()
        {
            savedialog.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            App.set_action("save");
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            App.set_action("edit_text");
        }
        public void set_layers(List<string> L)
        {
            layers.DataSource = L;
           layers.ClearSelected();
        }

        
        private void unselect_Click(object sender, EventArgs e)
        {
           
            layers.ClearSelected();
            App.set_action("un_select");
            
        }

        private void xposition_TextChanged(object sender, EventArgs e)
        {
            string tString = xposition.Text;
            if (tString == "-")
                return;
            if (tString.Trim() != "")
            {if(tString[0]!='-'&&!char.IsNumber(tString[0]))
            {
                MessageBox.Show("Please enter a valid number");
                xposition.Text = "";
                return;
            }
                for (int i = 1; i < tString.Length; i++)
                {
                    if (!char.IsNumber(tString[i]))
                    {
                        MessageBox.Show("Please enter a valid number");
                        xposition.Text = "";
                        return;
                    }

                }
            }
            if (duplicate_check == false)
                App.set_action("move");
            else
            {
                App.getduplicate_logo().set_position(get_postion());
                setpicturebox_image(new Bitmap(10, 10));
            }
        }

        private void yposition_TextChanged(object sender, EventArgs e)
        {
            string tString = yposition.Text;
            if (tString == "-")
                return;
            if (tString.Trim() != "")
            {
                if (tString[0] != '-' && !char.IsNumber(tString[0]))
                {
                    MessageBox.Show("Please enter a valid number");
                    yposition.Text = "";
                    return;
                }
                for (int i = 1; i < tString.Length; i++)
                {
                    if (!char.IsNumber(tString[i]))
                    {
                        MessageBox.Show("Please enter a valid number");
                        yposition.Text = "";
                        return;
                    }

                }
            }
            if (duplicate_check == false)
                App.set_action("move");
            else
            {
                App.getduplicate_logo().set_position(get_postion());
                setpicturebox_image(new Bitmap(10, 10));
            }

        }

        private void widthsize_TextChanged(object sender, EventArgs e)
        {
            string tString = widthsize.Text;
            if (tString.Trim() != "")
                for (int i = 0; i < tString.Length; i++)
                {
                    if (!char.IsNumber(tString[i]))
                    {
                        MessageBox.Show("Please enter a valid number");
                        widthsize.Text = "";
                        return;
                    }

                }
            if (duplicate_check == false)
                App.set_action("resize");
            else
            {
                App.getduplicate_logo().set_size(get_size());
                setpicturebox_image(new Bitmap(10, 10));
            }

        }

        private void heightsize_TextChanged(object sender, EventArgs e)
        {

            string tString = heightsize.Text;
            if (tString.Trim() != "")
                for (int i = 0; i < tString.Length; i++)
                {
                    if (!char.IsNumber(tString[i]))
                    {
                        MessageBox.Show("Please enter a valid number");
                        heightsize.Text = "";
                        return;
                    }

                }
            if (duplicate_check == false)
                App.set_action("resize");
            else
            {
                App.getduplicate_logo().set_size(get_size());
                setpicturebox_image(new Bitmap(10, 10));
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            App.set_action("delete");
        }

        private void copy_Click(object sender, EventArgs e)
        {
            App.set_action("copy");
        }

        private void cut_Click(object sender, EventArgs e)
        {
            App.set_action("cut");
        }

        private void paste_Click(object sender, EventArgs e)
        {
            App.set_action("paste");
        }
        public void activate_paste()
        {
            paste.Enabled = true;
        }

        private void opacitybar_Scroll(object sender, EventArgs e)
        {
            set_opacity(get_opacity());
            if (duplicate_check == false)
                App.set_action("opacity");
            else{
                App.getduplicate_logo().set_opacity(get_opacity());
                setpicturebox_image(new Bitmap(10, 10));
            }
        }

        private void layers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (layers.SelectedValue == null)
                return;
            selected_item = layers.SelectedValue.ToString();
            App.set_action("select");
        }

        public void Interface_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (App.get_edited())
            {
                dd=MessageBox.Show("Do you want to save changes ?", "My Application",MessageBoxButtons.YesNoCancel);
                
                // Display a MsgBox asking the user to save changes or abort. 
                if ( dd == DialogResult.Yes)
                {
                    // Cancel the Closing event from closing the form.
                   //e.Cancel = true;
                    App.set_action("save");
                }
                else if (dd == DialogResult.Cancel)
                {
                    
                    e.Cancel = true;
                 
                }
                
                
                 
                
            }
            App.logFile("================ session ended ================\n");
        }

        private void picturebox_MouseDown(object sender, MouseEventArgs e)
        {
            if (App.get_selected_item() != null || duplicate_check == true)
            {
                xposition.Text = e.X.ToString();
                yposition.Text = e.Y.ToString();
               
            }
        }

        private void Interface_KeyDown(object sender, KeyEventArgs e)
        {
            if (App.get_selected_item() != null||duplicate_check==true)
            {
                if (e.KeyData == Keys.Right)
                    xposition.Text = (int.Parse(xposition.Text) + 1).ToString();
                else if (e.KeyData == Keys.Left)
                {
                    xposition.Text = (int.Parse(xposition.Text) - 1).ToString();
                }
                else if (e.KeyData == Keys.Up)
                {
                    yposition.Text = (int.Parse(yposition.Text) - 1).ToString();
                }
                else if (e.KeyData == Keys.Down)
                    yposition.Text = (int.Parse(yposition.Text) + 1).ToString();


            
            }
        }

        private void duplicate_Click(object sender, EventArgs e)
        {
            App.logFile("duplicate started");
            deactivatetext_options();
            deactiveimage_options();
            loadlogo.Enabled = false;
            saveAsToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Enabled = false;
            addtext.Enabled = false;
                    
            
            if (App.get_edited())
            {
                dd = MessageBox.Show("Do you want to save changes ?", "My Application", MessageBoxButtons.YesNo);

                // Display a MsgBox asking the user to save changes or abort. 
                if (dd == DialogResult.Yes)
                {
                    // Cancel the Closing event from closing the form.
                    //e.Cancel = true;
                    App.set_action("save");
                }



            }
            setpicturebox_image(null);
            App.delete_all();
            App.set_edited(false);      
            duplicate_check = true;
            MessageBox.Show("Select the list of images");
            BGdialog.Multiselect = true;
            
            DialogResult d = BGdialog.ShowDialog();
            if (d == DialogResult.OK)
            {
                string[] ss = new string[BGdialog.FileNames.Length];
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                for (int i = 0; i < BGdialog.FileNames.Length; i++)
                    ss[i] = System.IO.Path.GetDirectoryName(BGdialog.FileNames[i]) + "/" + System.IO.Path.GetFileName(BGdialog.FileNames[i]);
                App.setduplicate_list(ss);
                this.Cursor = System.Windows.Forms.Cursors.Default;


                MessageBox.Show("Select the logo");
                BGdialog.Multiselect = false;
                d = BGdialog.ShowDialog();
                if (d == DialogResult.OK)
                {
                    string sss = System.IO.Path.GetDirectoryName(BGdialog.FileName) + "/" + System.IO.Path.GetFileName(BGdialog.FileName);
                    App.setduplicate_logo(sss);


                    MessageBox.Show("Edit the properties of the logo (position - size - opacity)");
                    setpicturebox_image(new Bitmap(10, 10));
                    set_size(App.getduplicate_logo().get_size());
                    set_position(App.getduplicate_logo().get_position());
                    set_opacity(App.getduplicate_logo().get_opacity());

                    xposition.Enabled = true;
                    yposition.Enabled = true;
                    widthsize.Enabled = true;
                    heightsize.Enabled = true;
                    opacitybar.Enabled = true;
                    applybutton.Visible = true;
                    cancelbutton.Visible = true;
                    loadImageToolStripMenuItem.Enabled = false;
                }
                else
                {
                    duplicate_check = false;
                    App.logFile("duplicate aborted");
                }
            }
            else
            {
                duplicate_check = false;
                App.logFile("duplicate aborted");
            }



         
        }
        public string getduplicate_url()
        {
            return duplicate_url;
        }
        public string getduplicate_name()
        {
            return duplicate_name;
        }
        private void applybutton_Click(object sender, EventArgs e)
        {
            DialogResult d = d_savedialog.ShowDialog();
            if (d == DialogResult.OK)
            {
                if (d_savedialog.FileName != "")
                {
                    duplicate_url = System.IO.Path.GetDirectoryName(d_savedialog.FileName);
                    duplicate_name = System.IO.Path.GetFileName(d_savedialog.FileName);
                }
                else
                {
                    duplicate_name = "";
                    duplicate_url = "";
                }
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                App.apply_duplicate();
                this.Cursor = System.Windows.Forms.Cursors.Default;
                MessageBox.Show("Done");
                duplicate_check = false;

                xposition.Enabled = false;
                yposition.Enabled = false;
                widthsize.Enabled = false;
                heightsize.Enabled = false;
                opacitybar.Enabled = false;
                applybutton.Visible = false;
                cancelbutton.Visible = false;
                loadImageToolStripMenuItem.Enabled = true;
                setpicturebox_image(null);
                App.set_edited(false);
                App.logFile("duplicate applied");

            }
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            
            duplicate_check = false;

            xposition.Enabled = false;
            yposition.Enabled = false;
            widthsize.Enabled = false;
            heightsize.Enabled = false;
            opacitybar.Enabled = false;
            applybutton.Visible = false;
            cancelbutton.Visible = false;
            loadImageToolStripMenuItem.Enabled = true;
            setpicturebox_image(null);
            App.set_edited(false);
            App.logFile("duplicate aborted");
        }

        private void moveup_Click(object sender, EventArgs e)
        {
            App.logFile("layer_up started");
            App.swap_layers(1);
            App.set_action("un_select");
        }

        private void movedown_Click(object sender, EventArgs e)
        {
            App.logFile("layer_down started");
            App.swap_layers(2);
            App.set_action("un_select");
        }

     
     
        
        
        

       
    }
}
