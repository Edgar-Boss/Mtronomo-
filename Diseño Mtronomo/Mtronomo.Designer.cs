namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.td_cb = new Bunifu.Framework.UI.BunifuCheckbox();
            this.Mtronomo_logo_letras = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.compas_button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btonmenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.tmp = new Bunifu.Framework.UI.BunifuDropdown();
            this.compases_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cada_box = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cada_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bpm_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.avanzar_box = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.avanzar_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.menos_cinco = new Bunifu.Framework.UI.BunifuImageButton();
            this.mas_cinco = new Bunifu.Framework.UI.BunifuImageButton();
            this.menos = new Bunifu.Framework.UI.BunifuImageButton();
            this.mas = new Bunifu.Framework.UI.BunifuImageButton();
            this.bpm_textbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.td_label = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.iniciar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.separador_monitores = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.paneltransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.click_timer = new System.Windows.Forms.Timer(this.components);
            this.monitor_timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btonmenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menos_cinco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mas_cinco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mas)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.td_cb);
            this.panel1.Controls.Add(this.Mtronomo_logo_letras);
            this.panel1.Controls.Add(this.compas_button);
            this.panel1.Controls.Add(this.btonmenu);
            this.panel1.Controls.Add(this.tmp);
            this.panel1.Controls.Add(this.compases_label);
            this.panel1.Controls.Add(this.cada_box);
            this.panel1.Controls.Add(this.cada_label);
            this.panel1.Controls.Add(this.bpm_label);
            this.panel1.Controls.Add(this.avanzar_box);
            this.panel1.Controls.Add(this.avanzar_label);
            this.panel1.Controls.Add(this.menos_cinco);
            this.panel1.Controls.Add(this.mas_cinco);
            this.panel1.Controls.Add(this.menos);
            this.panel1.Controls.Add(this.mas);
            this.panel1.Controls.Add(this.bpm_textbox);
            this.panel1.Controls.Add(this.td_label);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.paneltransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 180);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.paneltransition.SetDecoration(this.textBox1, BunifuAnimatorNS.DecorationType.None);
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.HintForeColor = System.Drawing.Color.Empty;
            this.textBox1.HintText = "";
            this.textBox1.isPassword = false;
            this.textBox1.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.textBox1.LineIdleColor = System.Drawing.Color.Gray;
            this.textBox1.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.textBox1.LineThickness = 3;
            this.textBox1.Location = new System.Drawing.Point(559, 149);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(31, 28);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AllowDrop = true;
            this.bunifuCustomLabel2.AutoSize = true;
            this.paneltransition.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(473, 164);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(36, 13);
            this.bunifuCustomLabel2.TabIndex = 24;
            this.bunifuCustomLabel2.Text = "actual";
            // 
            // logo
            // 
            this.paneltransition.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = global::WindowsFormsApp1.Properties.Resources._28819_200;
            this.logo.Location = new System.Drawing.Point(284, 6);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(30, 30);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 23;
            this.logo.TabStop = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.paneltransition.SetDecoration(this.bunifuSeparator2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 39);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(707, 10);
            this.bunifuSeparator2.TabIndex = 22;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // td_cb
            // 
            this.td_cb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.td_cb.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.td_cb.Checked = false;
            this.td_cb.CheckedOnColor = System.Drawing.Color.Transparent;
            this.td_cb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paneltransition.SetDecoration(this.td_cb, BunifuAnimatorNS.DecorationType.None);
            this.td_cb.ForeColor = System.Drawing.Color.White;
            this.td_cb.Location = new System.Drawing.Point(480, 53);
            this.td_cb.Name = "td_cb";
            this.td_cb.Size = new System.Drawing.Size(20, 20);
            this.td_cb.TabIndex = 20;
            this.td_cb.OnChange += new System.EventHandler(this.td_cb_OnChange);
            // 
            // Mtronomo_logo_letras
            // 
            this.Mtronomo_logo_letras.AutoSize = true;
            this.Mtronomo_logo_letras.BackColor = System.Drawing.Color.Transparent;
            this.paneltransition.SetDecoration(this.Mtronomo_logo_letras, BunifuAnimatorNS.DecorationType.None);
            this.Mtronomo_logo_letras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtronomo_logo_letras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.Mtronomo_logo_letras.Location = new System.Drawing.Point(320, 10);
            this.Mtronomo_logo_letras.Name = "Mtronomo_logo_letras";
            this.Mtronomo_logo_letras.Size = new System.Drawing.Size(92, 21);
            this.Mtronomo_logo_letras.TabIndex = 1;
            this.Mtronomo_logo_letras.Text = "Mtronomo";
            // 
            // compas_button
            // 
            this.compas_button.Activecolor = System.Drawing.Color.Transparent;
            this.compas_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.compas_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.compas_button.BorderRadius = 0;
            this.compas_button.ButtonText = "  Compás";
            this.compas_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paneltransition.SetDecoration(this.compas_button, BunifuAnimatorNS.DecorationType.None);
            this.compas_button.DisabledColor = System.Drawing.Color.Transparent;
            this.compas_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compas_button.Iconcolor = System.Drawing.Color.Transparent;
            this.compas_button.Iconimage = null;
            this.compas_button.Iconimage_right = null;
            this.compas_button.Iconimage_right_Selected = null;
            this.compas_button.Iconimage_Selected = null;
            this.compas_button.IconMarginLeft = 0;
            this.compas_button.IconMarginRight = 0;
            this.compas_button.IconRightVisible = true;
            this.compas_button.IconRightZoom = 0D;
            this.compas_button.IconVisible = true;
            this.compas_button.IconZoom = 90D;
            this.compas_button.IsTab = false;
            this.compas_button.Location = new System.Drawing.Point(340, 48);
            this.compas_button.Name = "compas_button";
            this.compas_button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.compas_button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.compas_button.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.compas_button.selected = false;
            this.compas_button.Size = new System.Drawing.Size(57, 25);
            this.compas_button.TabIndex = 4;
            this.compas_button.Text = "  Compás";
            this.compas_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.compas_button.Textcolor = System.Drawing.Color.White;
            this.compas_button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compas_button.Click += new System.EventHandler(this.compas_button_Click);
            // 
            // btonmenu
            // 
            this.btonmenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btonmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.paneltransition.SetDecoration(this.btonmenu, BunifuAnimatorNS.DecorationType.None);
            this.btonmenu.Image = ((System.Drawing.Image)(resources.GetObject("btonmenu.Image")));
            this.btonmenu.ImageActive = null;
            this.btonmenu.Location = new System.Drawing.Point(351, 162);
            this.btonmenu.Name = "btonmenu";
            this.btonmenu.Size = new System.Drawing.Size(15, 15);
            this.btonmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btonmenu.TabIndex = 4;
            this.btonmenu.TabStop = false;
            this.btonmenu.Zoom = 10;
            this.btonmenu.Click += new System.EventHandler(this.btonmenu_Click_1);
            // 
            // tmp
            // 
            this.tmp.BackColor = System.Drawing.Color.Transparent;
            this.tmp.BorderRadius = 3;
            this.paneltransition.SetDecoration(this.tmp, BunifuAnimatorNS.DecorationType.None);
            this.tmp.DisabledColor = System.Drawing.Color.Gray;
            this.tmp.ForeColor = System.Drawing.Color.White;
            this.tmp.Items = new string[] {
        "2/4",
        "3/4",
        "4/4"};
            this.tmp.Location = new System.Drawing.Point(320, 111);
            this.tmp.Name = "tmp";
            this.tmp.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.tmp.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.tmp.selectedIndex = 2;
            this.tmp.Size = new System.Drawing.Size(92, 33);
            this.tmp.TabIndex = 19;
            // 
            // compases_label
            // 
            this.compases_label.AutoSize = true;
            this.paneltransition.SetDecoration(this.compases_label, BunifuAnimatorNS.DecorationType.None);
            this.compases_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compases_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.compases_label.Location = new System.Drawing.Point(635, 126);
            this.compases_label.Name = "compases_label";
            this.compases_label.Size = new System.Drawing.Size(55, 13);
            this.compases_label.TabIndex = 18;
            this.compases_label.Text = "compáses";
            // 
            // cada_box
            // 
            this.cada_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.paneltransition.SetDecoration(this.cada_box, BunifuAnimatorNS.DecorationType.None);
            this.cada_box.Enabled = false;
            this.cada_box.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cada_box.ForeColor = System.Drawing.Color.White;
            this.cada_box.HintForeColor = System.Drawing.Color.Empty;
            this.cada_box.HintText = "";
            this.cada_box.isPassword = false;
            this.cada_box.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.cada_box.LineIdleColor = System.Drawing.Color.Gray;
            this.cada_box.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.cada_box.LineThickness = 3;
            this.cada_box.Location = new System.Drawing.Point(518, 111);
            this.cada_box.Margin = new System.Windows.Forms.Padding(4);
            this.cada_box.Name = "cada_box";
            this.cada_box.Size = new System.Drawing.Size(110, 28);
            this.cada_box.TabIndex = 17;
            this.cada_box.Text = "2";
            this.cada_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cada_label
            // 
            this.cada_label.AllowDrop = true;
            this.cada_label.AutoSize = true;
            this.paneltransition.SetDecoration(this.cada_label, BunifuAnimatorNS.DecorationType.None);
            this.cada_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cada_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cada_label.Location = new System.Drawing.Point(479, 126);
            this.cada_label.Name = "cada_label";
            this.cada_label.Size = new System.Drawing.Size(31, 13);
            this.cada_label.TabIndex = 16;
            this.cada_label.Text = "cada";
            // 
            // bpm_label
            // 
            this.bpm_label.AutoSize = true;
            this.paneltransition.SetDecoration(this.bpm_label, BunifuAnimatorNS.DecorationType.None);
            this.bpm_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpm_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bpm_label.Location = new System.Drawing.Point(635, 90);
            this.bpm_label.Name = "bpm_label";
            this.bpm_label.Size = new System.Drawing.Size(27, 13);
            this.bpm_label.TabIndex = 15;
            this.bpm_label.Text = "bpm";
            // 
            // avanzar_box
            // 
            this.avanzar_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.paneltransition.SetDecoration(this.avanzar_box, BunifuAnimatorNS.DecorationType.None);
            this.avanzar_box.Enabled = false;
            this.avanzar_box.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.avanzar_box.ForeColor = System.Drawing.Color.White;
            this.avanzar_box.HintForeColor = System.Drawing.Color.Empty;
            this.avanzar_box.HintText = "";
            this.avanzar_box.isPassword = false;
            this.avanzar_box.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.avanzar_box.LineIdleColor = System.Drawing.Color.Gray;
            this.avanzar_box.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.avanzar_box.LineThickness = 3;
            this.avanzar_box.Location = new System.Drawing.Point(518, 77);
            this.avanzar_box.Margin = new System.Windows.Forms.Padding(4);
            this.avanzar_box.Name = "avanzar_box";
            this.avanzar_box.Size = new System.Drawing.Size(110, 28);
            this.avanzar_box.TabIndex = 14;
            this.avanzar_box.Text = "10";
            this.avanzar_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // avanzar_label
            // 
            this.avanzar_label.AutoSize = true;
            this.avanzar_label.BackColor = System.Drawing.Color.Transparent;
            this.paneltransition.SetDecoration(this.avanzar_label, BunifuAnimatorNS.DecorationType.None);
            this.avanzar_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avanzar_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.avanzar_label.Location = new System.Drawing.Point(466, 90);
            this.avanzar_label.Name = "avanzar_label";
            this.avanzar_label.Size = new System.Drawing.Size(45, 13);
            this.avanzar_label.TabIndex = 13;
            this.avanzar_label.Text = "avanzar";
            // 
            // menos_cinco
            // 
            this.menos_cinco.BackColor = System.Drawing.Color.SeaGreen;
            this.paneltransition.SetDecoration(this.menos_cinco, BunifuAnimatorNS.DecorationType.None);
            this.menos_cinco.Image = ((System.Drawing.Image)(resources.GetObject("menos_cinco.Image")));
            this.menos_cinco.ImageActive = null;
            this.menos_cinco.Location = new System.Drawing.Point(18, 135);
            this.menos_cinco.Name = "menos_cinco";
            this.menos_cinco.Size = new System.Drawing.Size(27, 26);
            this.menos_cinco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menos_cinco.TabIndex = 11;
            this.menos_cinco.TabStop = false;
            this.menos_cinco.Zoom = 10;
            this.menos_cinco.Click += new System.EventHandler(this.menos_cinco_Click);
            // 
            // mas_cinco
            // 
            this.mas_cinco.BackColor = System.Drawing.Color.SeaGreen;
            this.paneltransition.SetDecoration(this.mas_cinco, BunifuAnimatorNS.DecorationType.None);
            this.mas_cinco.Image = ((System.Drawing.Image)(resources.GetObject("mas_cinco.Image")));
            this.mas_cinco.ImageActive = null;
            this.mas_cinco.Location = new System.Drawing.Point(18, 111);
            this.mas_cinco.Name = "mas_cinco";
            this.mas_cinco.Size = new System.Drawing.Size(27, 25);
            this.mas_cinco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mas_cinco.TabIndex = 10;
            this.mas_cinco.TabStop = false;
            this.mas_cinco.Zoom = 10;
            this.mas_cinco.Click += new System.EventHandler(this.mas_cinco_Click);
            // 
            // menos
            // 
            this.menos.BackColor = System.Drawing.Color.SeaGreen;
            this.paneltransition.SetDecoration(this.menos, BunifuAnimatorNS.DecorationType.None);
            this.menos.Image = ((System.Drawing.Image)(resources.GetObject("menos.Image")));
            this.menos.ImageActive = null;
            this.menos.Location = new System.Drawing.Point(98, 135);
            this.menos.Name = "menos";
            this.menos.Size = new System.Drawing.Size(27, 26);
            this.menos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menos.TabIndex = 9;
            this.menos.TabStop = false;
            this.menos.Zoom = 10;
            this.menos.Click += new System.EventHandler(this.menos_Click);
            // 
            // mas
            // 
            this.mas.BackColor = System.Drawing.Color.SeaGreen;
            this.paneltransition.SetDecoration(this.mas, BunifuAnimatorNS.DecorationType.None);
            this.mas.Image = ((System.Drawing.Image)(resources.GetObject("mas.Image")));
            this.mas.ImageActive = null;
            this.mas.Location = new System.Drawing.Point(98, 111);
            this.mas.Name = "mas";
            this.mas.Size = new System.Drawing.Size(27, 25);
            this.mas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mas.TabIndex = 8;
            this.mas.TabStop = false;
            this.mas.Zoom = 10;
            this.mas.Click += new System.EventHandler(this.mas_Click);
            // 
            // bpm_textbox
            // 
            this.bpm_textbox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bpm_textbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bpm_textbox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bpm_textbox.BorderThickness = 3;
            this.bpm_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.paneltransition.SetDecoration(this.bpm_textbox, BunifuAnimatorNS.DecorationType.None);
            this.bpm_textbox.Enabled = false;
            this.bpm_textbox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bpm_textbox.ForeColor = System.Drawing.Color.White;
            this.bpm_textbox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.bpm_textbox.isPassword = false;
            this.bpm_textbox.Location = new System.Drawing.Point(44, 108);
            this.bpm_textbox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bpm_textbox.Name = "bpm_textbox";
            this.bpm_textbox.Size = new System.Drawing.Size(54, 54);
            this.bpm_textbox.TabIndex = 7;
            this.bpm_textbox.Text = "60";
            this.bpm_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // td_label
            // 
            this.td_label.Activecolor = System.Drawing.Color.Transparent;
            this.td_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.td_label.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.td_label.BorderRadius = 0;
            this.td_label.ButtonText = "  Tempo Dinámico";
            this.td_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paneltransition.SetDecoration(this.td_label, BunifuAnimatorNS.DecorationType.None);
            this.td_label.DisabledColor = System.Drawing.Color.Transparent;
            this.td_label.Iconcolor = System.Drawing.Color.Transparent;
            this.td_label.Iconimage = null;
            this.td_label.Iconimage_right = null;
            this.td_label.Iconimage_right_Selected = null;
            this.td_label.Iconimage_Selected = null;
            this.td_label.IconMarginLeft = 0;
            this.td_label.IconMarginRight = 0;
            this.td_label.IconRightVisible = true;
            this.td_label.IconRightZoom = 0D;
            this.td_label.IconVisible = true;
            this.td_label.IconZoom = 90D;
            this.td_label.IsTab = false;
            this.td_label.Location = new System.Drawing.Point(518, 48);
            this.td_label.Name = "td_label";
            this.td_label.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.td_label.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.td_label.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.td_label.selected = false;
            this.td_label.Size = new System.Drawing.Size(127, 25);
            this.td_label.TabIndex = 5;
            this.td_label.Text = "  Tempo Dinámico";
            this.td_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.td_label.Textcolor = System.Drawing.Color.White;
            this.td_label.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.td_label.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "  BPM";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paneltransition.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(53, 48);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(42, 25);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.Text = "  BPM";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.header.Controls.Add(this.bunifuImageButton2);
            this.header.Controls.Add(this.bunifuImageButton1);
            this.header.Controls.Add(this.bunifuCustomLabel1);
            this.paneltransition.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(711, 26);
            this.header.TabIndex = 1;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.paneltransition.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(657, 3);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 2;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.paneltransition.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(683, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.paneltransition.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(23, 5);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(92, 21);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Mtronomo";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.paneltransition.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 180);
            this.panel2.TabIndex = 2;
            // 
            // iniciar
            // 
            this.iniciar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.iniciar.BackColor = System.Drawing.Color.SeaGreen;
            this.iniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iniciar.BorderRadius = 0;
            this.iniciar.ButtonText = "INICIAR";
            this.iniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paneltransition.SetDecoration(this.iniciar, BunifuAnimatorNS.DecorationType.None);
            this.iniciar.DisabledColor = System.Drawing.Color.Gray;
            this.iniciar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iniciar.Iconcolor = System.Drawing.Color.Transparent;
            this.iniciar.Iconimage = null;
            this.iniciar.Iconimage_right = null;
            this.iniciar.Iconimage_right_Selected = null;
            this.iniciar.Iconimage_Selected = null;
            this.iniciar.IconMarginLeft = 0;
            this.iniciar.IconMarginRight = 0;
            this.iniciar.IconRightVisible = true;
            this.iniciar.IconRightZoom = 0D;
            this.iniciar.IconVisible = true;
            this.iniciar.IconZoom = 90D;
            this.iniciar.IsTab = false;
            this.iniciar.Location = new System.Drawing.Point(0, 296);
            this.iniciar.Name = "iniciar";
            this.iniciar.Normalcolor = System.Drawing.Color.SeaGreen;
            this.iniciar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.iniciar.OnHoverTextColor = System.Drawing.Color.White;
            this.iniciar.selected = false;
            this.iniciar.Size = new System.Drawing.Size(711, 32);
            this.iniciar.TabIndex = 3;
            this.iniciar.Text = "INICIAR";
            this.iniciar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.iniciar.Textcolor = System.Drawing.Color.White;
            this.iniciar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciar.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // separador_monitores
            // 
            this.separador_monitores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.separador_monitores.BackColor = System.Drawing.Color.Transparent;
            this.paneltransition.SetDecoration(this.separador_monitores, BunifuAnimatorNS.DecorationType.None);
            this.separador_monitores.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.separador_monitores.LineThickness = 1;
            this.separador_monitores.Location = new System.Drawing.Point(0, 0);
            this.separador_monitores.Name = "separador_monitores";
            this.separador_monitores.Size = new System.Drawing.Size(711, 90);
            this.separador_monitores.TabIndex = 0;
            this.separador_monitores.Transparency = 255;
            this.separador_monitores.Vertical = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.separador_monitores);
            this.paneltransition.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 206);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(711, 90);
            this.panel3.TabIndex = 4;
            // 
            // paneltransition
            // 
            this.paneltransition.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.paneltransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.paneltransition.DefaultAnimation = animation1;
            // 
            // click_timer
            // 
            this.click_timer.Interval = 1000;
            // 
            // monitor_timer
            // 
            this.monitor_timer.Interval = 1000;
            this.monitor_timer.Tick += new System.EventHandler(this.Monitor_timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(711, 328);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.header);
            this.paneltransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Mtronomo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btonmenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menos_cinco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mas_cinco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mas)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel panel2;
        private BunifuAnimatorNS.BunifuTransition paneltransition;
        private Bunifu.Framework.UI.BunifuFlatButton td_label;
        private Bunifu.Framework.UI.BunifuMetroTextbox bpm_textbox;
        private Bunifu.Framework.UI.BunifuImageButton menos_cinco;
        private Bunifu.Framework.UI.BunifuImageButton menos;
        private Bunifu.Framework.UI.BunifuCustomLabel compases_label;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cada_box;
        private Bunifu.Framework.UI.BunifuCustomLabel cada_label;
        private Bunifu.Framework.UI.BunifuFlatButton iniciar;
        private Bunifu.Framework.UI.BunifuImageButton btonmenu;
        private Bunifu.Framework.UI.BunifuCustomLabel Mtronomo_logo_letras;
        private Bunifu.Framework.UI.BunifuFlatButton compas_button;
        private Bunifu.Framework.UI.BunifuCheckbox td_cb;
        private System.Windows.Forms.Timer click_timer;
        private System.Windows.Forms.Timer monitor_timer;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuSeparator separador_monitores;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuDropdown tmp;
        private Bunifu.Framework.UI.BunifuCustomLabel bpm_label;
        private Bunifu.Framework.UI.BunifuMaterialTextbox avanzar_box;
        private Bunifu.Framework.UI.BunifuCustomLabel avanzar_label;
        private Bunifu.Framework.UI.BunifuImageButton mas_cinco;
        private Bunifu.Framework.UI.BunifuImageButton mas;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
    }

}

