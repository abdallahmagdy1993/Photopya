namespace Photopya
{
    partial class Interface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbar = new System.Windows.Forms.Panel();
            this.opacityvalue = new System.Windows.Forms.Label();
            this.opacitylabel = new System.Windows.Forms.Label();
            this.opacitybar = new System.Windows.Forms.TrackBar();
            this.sizelabelheight = new System.Windows.Forms.Label();
            this.sizelabelwidth = new System.Windows.Forms.Label();
            this.heightsize = new System.Windows.Forms.TextBox();
            this.widthsize = new System.Windows.Forms.TextBox();
            this.xposition = new System.Windows.Forms.TextBox();
            this.yposition = new System.Windows.Forms.TextBox();
            this.positionlabelX = new System.Windows.Forms.Label();
            this.positionlabelY = new System.Windows.Forms.Label();
            this.textlabel = new System.Windows.Forms.Label();
            this.textbox = new System.Windows.Forms.TextBox();
            this.duplicate = new System.Windows.Forms.Button();
            this.edittext = new System.Windows.Forms.Button();
            this.addtext = new System.Windows.Forms.Button();
            this.loadlogo = new System.Windows.Forms.Button();
            this.applybutton = new System.Windows.Forms.Button();
            this.pictureboxpanel = new System.Windows.Forms.Panel();
            this.hscrollbar = new System.Windows.Forms.HScrollBar();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.layerspanel = new System.Windows.Forms.Panel();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.unselect = new System.Windows.Forms.Button();
            this.paste = new System.Windows.Forms.Button();
            this.cut = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.movedown = new System.Windows.Forms.Button();
            this.moveup = new System.Windows.Forms.Button();
            this.layers = new System.Windows.Forms.ListBox();
            this.BGdialog = new System.Windows.Forms.OpenFileDialog();
            this.logodialog = new System.Windows.Forms.OpenFileDialog();
            this.fontdialog = new System.Windows.Forms.FontDialog();
            this.savedialog = new System.Windows.Forms.SaveFileDialog();
            this.d_savedialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacitybar)).BeginInit();
            this.pictureboxpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.layerspanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolbar
            // 
            this.toolbar.Controls.Add(this.opacityvalue);
            this.toolbar.Controls.Add(this.opacitylabel);
            this.toolbar.Controls.Add(this.opacitybar);
            this.toolbar.Controls.Add(this.sizelabelheight);
            this.toolbar.Controls.Add(this.sizelabelwidth);
            this.toolbar.Controls.Add(this.heightsize);
            this.toolbar.Controls.Add(this.widthsize);
            this.toolbar.Controls.Add(this.xposition);
            this.toolbar.Controls.Add(this.yposition);
            this.toolbar.Controls.Add(this.positionlabelX);
            this.toolbar.Controls.Add(this.positionlabelY);
            this.toolbar.Controls.Add(this.textlabel);
            this.toolbar.Controls.Add(this.textbox);
            this.toolbar.Controls.Add(this.duplicate);
            this.toolbar.Controls.Add(this.edittext);
            this.toolbar.Controls.Add(this.addtext);
            this.toolbar.Controls.Add(this.loadlogo);
            this.toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbar.Location = new System.Drawing.Point(0, 24);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(1008, 41);
            this.toolbar.TabIndex = 1;
            // 
            // opacityvalue
            // 
            this.opacityvalue.AutoSize = true;
            this.opacityvalue.Location = new System.Drawing.Point(870, 10);
            this.opacityvalue.Name = "opacityvalue";
            this.opacityvalue.Size = new System.Drawing.Size(25, 13);
            this.opacityvalue.TabIndex = 11;
            this.opacityvalue.Text = "100";
            // 
            // opacitylabel
            // 
            this.opacitylabel.AutoSize = true;
            this.opacitylabel.Location = new System.Drawing.Point(820, 11);
            this.opacitylabel.Name = "opacitylabel";
            this.opacitylabel.Size = new System.Drawing.Size(44, 13);
            this.opacitylabel.TabIndex = 2;
            this.opacitylabel.Text = "Opacity";
            // 
            // opacitybar
            // 
            this.opacitybar.Enabled = false;
            this.opacitybar.Location = new System.Drawing.Point(889, 3);
            this.opacitybar.Maximum = 100;
            this.opacitybar.Name = "opacitybar";
            this.opacitybar.Size = new System.Drawing.Size(104, 45);
            this.opacitybar.TabIndex = 3;
            this.opacitybar.Value = 100;
            this.opacitybar.Scroll += new System.EventHandler(this.opacitybar_Scroll);
            // 
            // sizelabelheight
            // 
            this.sizelabelheight.AutoSize = true;
            this.sizelabelheight.Location = new System.Drawing.Point(727, 7);
            this.sizelabelheight.Name = "sizelabelheight";
            this.sizelabelheight.Size = new System.Drawing.Size(38, 13);
            this.sizelabelheight.TabIndex = 2;
            this.sizelabelheight.Text = "Height";
            // 
            // sizelabelwidth
            // 
            this.sizelabelwidth.AutoSize = true;
            this.sizelabelwidth.Location = new System.Drawing.Point(624, 6);
            this.sizelabelwidth.Name = "sizelabelwidth";
            this.sizelabelwidth.Size = new System.Drawing.Size(61, 13);
            this.sizelabelwidth.TabIndex = 3;
            this.sizelabelwidth.Text = "Size: Width";
            // 
            // heightsize
            // 
            this.heightsize.Enabled = false;
            this.heightsize.Location = new System.Drawing.Point(771, 4);
            this.heightsize.Name = "heightsize";
            this.heightsize.Size = new System.Drawing.Size(28, 20);
            this.heightsize.TabIndex = 4;
            this.heightsize.TextChanged += new System.EventHandler(this.heightsize_TextChanged);
            // 
            // widthsize
            // 
            this.widthsize.Enabled = false;
            this.widthsize.Location = new System.Drawing.Point(691, 4);
            this.widthsize.Name = "widthsize";
            this.widthsize.Size = new System.Drawing.Size(30, 20);
            this.widthsize.TabIndex = 5;
            this.widthsize.TextChanged += new System.EventHandler(this.widthsize_TextChanged);
            // 
            // xposition
            // 
            this.xposition.Enabled = false;
            this.xposition.Location = new System.Drawing.Point(528, 3);
            this.xposition.Name = "xposition";
            this.xposition.Size = new System.Drawing.Size(34, 20);
            this.xposition.TabIndex = 10;
            this.xposition.TextChanged += new System.EventHandler(this.xposition_TextChanged);
            // 
            // yposition
            // 
            this.yposition.Enabled = false;
            this.yposition.Location = new System.Drawing.Point(587, 3);
            this.yposition.Name = "yposition";
            this.yposition.Size = new System.Drawing.Size(31, 20);
            this.yposition.TabIndex = 9;
            this.yposition.TextChanged += new System.EventHandler(this.yposition_TextChanged);
            // 
            // positionlabelX
            // 
            this.positionlabelX.AutoSize = true;
            this.positionlabelX.Location = new System.Drawing.Point(465, 6);
            this.positionlabelX.Name = "positionlabelX";
            this.positionlabelX.Size = new System.Drawing.Size(57, 13);
            this.positionlabelX.TabIndex = 7;
            this.positionlabelX.Text = "Position: X";
            // 
            // positionlabelY
            // 
            this.positionlabelY.AutoSize = true;
            this.positionlabelY.Location = new System.Drawing.Point(567, 6);
            this.positionlabelY.Name = "positionlabelY";
            this.positionlabelY.Size = new System.Drawing.Size(13, 13);
            this.positionlabelY.TabIndex = 6;
            this.positionlabelY.Text = "Y";
            // 
            // textlabel
            // 
            this.textlabel.AutoSize = true;
            this.textlabel.Location = new System.Drawing.Point(324, 6);
            this.textlabel.Name = "textlabel";
            this.textlabel.Size = new System.Drawing.Size(29, 13);
            this.textlabel.TabIndex = 5;
            this.textlabel.Text = "Text";
            // 
            // textbox
            // 
            this.textbox.Enabled = false;
            this.textbox.Location = new System.Drawing.Point(359, 3);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(100, 20);
            this.textbox.TabIndex = 4;
            this.textbox.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // duplicate
            // 
            this.duplicate.Location = new System.Drawing.Point(243, 1);
            this.duplicate.Name = "duplicate";
            this.duplicate.Size = new System.Drawing.Size(75, 23);
            this.duplicate.TabIndex = 0;
            this.duplicate.Text = "Duplicate";
            this.duplicate.UseVisualStyleBackColor = true;
            this.duplicate.Click += new System.EventHandler(this.duplicate_Click);
            // 
            // edittext
            // 
            this.edittext.Enabled = false;
            this.edittext.Location = new System.Drawing.Point(162, 1);
            this.edittext.Name = "edittext";
            this.edittext.Size = new System.Drawing.Size(75, 23);
            this.edittext.TabIndex = 3;
            this.edittext.Text = "Edit Text";
            this.edittext.UseVisualStyleBackColor = true;
            this.edittext.Click += new System.EventHandler(this.edittext_Click);
            // 
            // addtext
            // 
            this.addtext.Enabled = false;
            this.addtext.Location = new System.Drawing.Point(81, 1);
            this.addtext.Name = "addtext";
            this.addtext.Size = new System.Drawing.Size(75, 23);
            this.addtext.TabIndex = 3;
            this.addtext.Text = "Add Text";
            this.addtext.UseVisualStyleBackColor = true;
            this.addtext.Click += new System.EventHandler(this.addtext_Click);
            // 
            // loadlogo
            // 
            this.loadlogo.Enabled = false;
            this.loadlogo.Location = new System.Drawing.Point(0, 1);
            this.loadlogo.Name = "loadlogo";
            this.loadlogo.Size = new System.Drawing.Size(75, 23);
            this.loadlogo.TabIndex = 0;
            this.loadlogo.Text = "Load Logo";
            this.loadlogo.UseVisualStyleBackColor = true;
            this.loadlogo.Click += new System.EventHandler(this.loadlogo_Click);
            // 
            // applybutton
            // 
            this.applybutton.Location = new System.Drawing.Point(26, 31);
            this.applybutton.Margin = new System.Windows.Forms.Padding(2);
            this.applybutton.Name = "applybutton";
            this.applybutton.Size = new System.Drawing.Size(56, 28);
            this.applybutton.TabIndex = 12;
            this.applybutton.Text = "Apply";
            this.applybutton.UseVisualStyleBackColor = true;
            this.applybutton.Visible = false;
            this.applybutton.Click += new System.EventHandler(this.applybutton_Click);
            // 
            // pictureboxpanel
            // 
            this.pictureboxpanel.AutoScroll = true;
            this.pictureboxpanel.Controls.Add(this.hscrollbar);
            this.pictureboxpanel.Controls.Add(this.picturebox);
            this.pictureboxpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureboxpanel.Location = new System.Drawing.Point(0, 65);
            this.pictureboxpanel.Name = "pictureboxpanel";
            this.pictureboxpanel.Size = new System.Drawing.Size(1150, 544);
            this.pictureboxpanel.TabIndex = 2;
            // 
            // hscrollbar
            // 
            this.hscrollbar.Location = new System.Drawing.Point(725, 642);
            this.hscrollbar.Name = "hscrollbar";
            this.hscrollbar.Size = new System.Drawing.Size(80, 17);
            this.hscrollbar.TabIndex = 1;
            this.hscrollbar.Visible = false;
            // 
            // picturebox
            // 
            this.picturebox.Location = new System.Drawing.Point(0, 0);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(1533, 819);
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picturebox.TabIndex = 0;
            this.picturebox.TabStop = false;
            this.picturebox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseDown);
            // 
            // layerspanel
            // 
            this.layerspanel.Controls.Add(this.cancelbutton);
            this.layerspanel.Controls.Add(this.applybutton);
            this.layerspanel.Controls.Add(this.unselect);
            this.layerspanel.Controls.Add(this.paste);
            this.layerspanel.Controls.Add(this.cut);
            this.layerspanel.Controls.Add(this.copy);
            this.layerspanel.Controls.Add(this.delete);
            this.layerspanel.Controls.Add(this.movedown);
            this.layerspanel.Controls.Add(this.moveup);
            this.layerspanel.Controls.Add(this.layers);
            this.layerspanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.layerspanel.Location = new System.Drawing.Point(838, 65);
            this.layerspanel.Name = "layerspanel";
            this.layerspanel.Size = new System.Drawing.Size(170, 544);
            this.layerspanel.TabIndex = 3;
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(99, 31);
            this.cancelbutton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(56, 28);
            this.cancelbutton.TabIndex = 13;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Visible = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // unselect
            // 
            this.unselect.Enabled = false;
            this.unselect.Location = new System.Drawing.Point(101, 192);
            this.unselect.Name = "unselect";
            this.unselect.Size = new System.Drawing.Size(64, 23);
            this.unselect.TabIndex = 7;
            this.unselect.Text = "Un Select";
            this.unselect.UseVisualStyleBackColor = true;
            this.unselect.Click += new System.EventHandler(this.unselect_Click);
            // 
            // paste
            // 
            this.paste.Enabled = false;
            this.paste.Location = new System.Drawing.Point(47, 134);
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(75, 23);
            this.paste.TabIndex = 6;
            this.paste.Text = "Paste";
            this.paste.UseVisualStyleBackColor = true;
            this.paste.Click += new System.EventHandler(this.paste_Click);
            // 
            // cut
            // 
            this.cut.Enabled = false;
            this.cut.Location = new System.Drawing.Point(47, 105);
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(75, 23);
            this.cut.TabIndex = 5;
            this.cut.Text = "Cut";
            this.cut.UseVisualStyleBackColor = true;
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // copy
            // 
            this.copy.Enabled = false;
            this.copy.Location = new System.Drawing.Point(47, 76);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(75, 23);
            this.copy.TabIndex = 4;
            this.copy.Text = "Copy";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // delete
            // 
            this.delete.Enabled = false;
            this.delete.Location = new System.Drawing.Point(47, 163);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // movedown
            // 
            this.movedown.Enabled = false;
            this.movedown.Location = new System.Drawing.Point(51, 192);
            this.movedown.Name = "movedown";
            this.movedown.Size = new System.Drawing.Size(44, 23);
            this.movedown.TabIndex = 2;
            this.movedown.Text = "Down";
            this.movedown.UseVisualStyleBackColor = true;
            this.movedown.Click += new System.EventHandler(this.movedown_Click);
            // 
            // moveup
            // 
            this.moveup.Enabled = false;
            this.moveup.Location = new System.Drawing.Point(7, 192);
            this.moveup.Name = "moveup";
            this.moveup.Size = new System.Drawing.Size(38, 23);
            this.moveup.TabIndex = 1;
            this.moveup.Text = "Up";
            this.moveup.UseVisualStyleBackColor = true;
            this.moveup.Click += new System.EventHandler(this.moveup_Click);
            // 
            // layers
            // 
            this.layers.FormattingEnabled = true;
            this.layers.Location = new System.Drawing.Point(7, 221);
            this.layers.Name = "layers";
            this.layers.Size = new System.Drawing.Size(160, 303);
            this.layers.TabIndex = 0;
            this.layers.SelectedIndexChanged += new System.EventHandler(this.layers_SelectedIndexChanged);
            // 
            // BGdialog
            // 
            this.BGdialog.Filter = "All Images|*.gif;*.jpg;*.bmp;*.png;*.jpeg;|Bitmap Image (*.BMP)|*.bmp|JPG Image (" +
    "*.JPG)|*.jpg|JPEG Image (*.jpeg)|*.jpeg|PNG Image (*.PNG)|*.png|GIF Image (*.GIF" +
    ")|*.gif";
            // 
            // logodialog
            // 
            this.logodialog.Filter = "All Images|*.gif;*.jpg;*.bmp;*.png;*.jpeg;|Bitmap Image (*.BMP)|*.bmp|JPG Image (" +
    "*.JPG)|*.jpg|JPEG Image (*.jpeg)|*.jpeg|PNG Image (*.PNG)|*.png|GIF Image (*.GIF" +
    ")|*.gif";
            this.logodialog.FileOk += new System.ComponentModel.CancelEventHandler(this.logodialog_FileOk);
            // 
            // fontdialog
            // 
            this.fontdialog.Color = System.Drawing.SystemColors.ControlText;
            this.fontdialog.ShowApply = true;
            this.fontdialog.ShowColor = true;
            this.fontdialog.ShowHelp = true;
            this.fontdialog.Apply += new System.EventHandler(this.fontdialog_Apply);
            // 
            // savedialog
            // 
            this.savedialog.FileName = "Untitled";
            this.savedialog.Filter = "JPG Image (*.JPG)|*.jpg|Bitmap Image (*.BMP)|*.bmp|JPEG Image (*.jpeg)|*.jpeg|PNG" +
    " Image (*.PNG)|*.png|GIF Image (*.GIF)|*.gif";
            this.savedialog.FileOk += new System.ComponentModel.CancelEventHandler(this.savedialog_FileOk);
            // 
            // d_savedialog
            // 
            this.d_savedialog.FileName = "Untitled";
            this.d_savedialog.Filter = "JPG Image (*.JPG)|*.jpg|Bitmap Image (*.BMP)|*.bmp|JPEG Image (*.jpeg)|*.jpeg|PNG" +
    " Image (*.PNG)|*.png|GIF Image (*.GIF)|*.gif";
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1008, 609);
            this.Controls.Add(this.layerspanel);
            this.Controls.Add(this.pictureboxpanel);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photopya";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Interface_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Interface_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacitybar)).EndInit();
            this.pictureboxpanel.ResumeLayout(false);
            this.pictureboxpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.layerspanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Panel toolbar;
        private System.Windows.Forms.Button loadlogo;
        private System.Windows.Forms.Panel pictureboxpanel;
        private System.Windows.Forms.Button edittext;
        private System.Windows.Forms.Button addtext;
        private System.Windows.Forms.Button duplicate;
        private System.Windows.Forms.Panel layerspanel;
        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.HScrollBar hscrollbar;
        private System.Windows.Forms.ListBox layers;
        private System.Windows.Forms.Button movedown;
        private System.Windows.Forms.Button moveup;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button paste;
        private System.Windows.Forms.Button cut;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.TextBox xposition;
        private System.Windows.Forms.TextBox yposition;
        private System.Windows.Forms.Label positionlabelX;
        private System.Windows.Forms.Label positionlabelY;
        private System.Windows.Forms.Label textlabel;
        private System.Windows.Forms.Label sizelabelheight;
        private System.Windows.Forms.Label sizelabelwidth;
        private System.Windows.Forms.TextBox heightsize;
        private System.Windows.Forms.TextBox widthsize;
        private System.Windows.Forms.Label opacitylabel;
        private System.Windows.Forms.TrackBar opacitybar;
        private System.Windows.Forms.Label opacityvalue;
        private System.Windows.Forms.OpenFileDialog BGdialog;
        private System.Windows.Forms.OpenFileDialog logodialog;
        private System.Windows.Forms.FontDialog fontdialog;
        private System.Windows.Forms.SaveFileDialog savedialog;
        private System.Windows.Forms.DialogResult dd;
        private string saveURL;
        private string logoURL;
        private string bgURL;
        private string selected_item;
        private System.Drawing.Font textfont;
        private System.Drawing.Color textcolor;
        private ApplicationManager App = new ApplicationManager();
        private System.Windows.Forms.Button unselect;
        private bool duplicate_check=false;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button applybutton;
        private System.Windows.Forms.SaveFileDialog d_savedialog;
        private string duplicate_url;
        private string duplicate_name;
    }
}

