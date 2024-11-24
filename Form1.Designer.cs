namespace Paint
{
    partial class form_paintit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_paintit));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanCanvasMstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.backGroundChangeColorMstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.dezhacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_utensils = new System.Windows.Forms.Panel();
            this.lbl_shapes = new System.Windows.Forms.Label();
            this.lbl_tools = new System.Windows.Forms.Label();
            this.btn_text = new System.Windows.Forms.Button();
            this.btn_rectangle = new System.Windows.Forms.Button();
            this.btn_polygon = new System.Windows.Forms.Button();
            this.btn_triangle = new System.Windows.Forms.Button();
            this.btn_square = new System.Windows.Forms.Button();
            this.btn_circle = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.panel_tools = new System.Windows.Forms.Panel();
            this.lbl_width_show = new System.Windows.Forms.Label();
            this.lbl_pen_width = new System.Windows.Forms.Label();
            this.width_bar_pen = new System.Windows.Forms.TrackBar();
            this.btn_swap_color = new System.Windows.Forms.Button();
            this.btn_ColorSet = new System.Windows.Forms.PictureBox();
            this.lbl_coordsText = new System.Windows.Forms.Label();
            this.lbl_coords = new System.Windows.Forms.Label();
            this.picbox_second_colorSet = new System.Windows.Forms.PictureBox();
            this.picbox_canvas = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel_utensils.SuspendLayout();
            this.panel_tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.width_bar_pen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ColorSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_second_colorSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.cleanToolStripMenuItem,
            this.dezhacerToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1182, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.saveAsMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(141, 26);
            this.openMenuItem.Text = "Open";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.Size = new System.Drawing.Size(141, 26);
            this.saveAsMenuItem.Text = "Save as";
            this.saveAsMenuItem.Click += new System.EventHandler(this.saveAsMenuItem_Click);
            // 
            // cleanToolStripMenuItem
            // 
            this.cleanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cleanCanvasMstrip,
            this.backGroundChangeColorMstrip});
            this.cleanToolStripMenuItem.Name = "cleanToolStripMenuItem";
            this.cleanToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.cleanToolStripMenuItem.Text = "Options";
            // 
            // cleanCanvasMstrip
            // 
            this.cleanCanvasMstrip.Name = "cleanCanvasMstrip";
            this.cleanCanvasMstrip.Size = new System.Drawing.Size(212, 26);
            this.cleanCanvasMstrip.Text = "Clean Canvas";
            this.cleanCanvasMstrip.Click += new System.EventHandler(this.cleanCanvasMstrip_Click);
            // 
            // backGroundChangeColorMstrip
            // 
            this.backGroundChangeColorMstrip.Name = "backGroundChangeColorMstrip";
            this.backGroundChangeColorMstrip.Size = new System.Drawing.Size(212, 26);
            this.backGroundChangeColorMstrip.Text = "BackGround Color";
            this.backGroundChangeColorMstrip.Click += new System.EventHandler(this.backgroundChangeColorMstrip_Click);
            // 
            // dezhacerToolStripMenuItem
            // 
            this.dezhacerToolStripMenuItem.Name = "dezhacerToolStripMenuItem";
            this.dezhacerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.dezhacerToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.dezhacerToolStripMenuItem.Text = "Undo";
            this.dezhacerToolStripMenuItem.Click += new System.EventHandler(this.dezhacerToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // panel_utensils
            // 
            this.panel_utensils.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel_utensils.Controls.Add(this.lbl_shapes);
            this.panel_utensils.Controls.Add(this.lbl_tools);
            this.panel_utensils.Controls.Add(this.btn_text);
            this.panel_utensils.Controls.Add(this.btn_rectangle);
            this.panel_utensils.Controls.Add(this.btn_polygon);
            this.panel_utensils.Controls.Add(this.btn_triangle);
            this.panel_utensils.Controls.Add(this.btn_square);
            this.panel_utensils.Controls.Add(this.btn_circle);
            this.panel_utensils.Controls.Add(this.btn_fill);
            this.panel_utensils.Controls.Add(this.btn_eraser);
            this.panel_utensils.Controls.Add(this.btn_line);
            this.panel_utensils.Controls.Add(this.btn_pencil);
            this.panel_utensils.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_utensils.Location = new System.Drawing.Point(0, 32);
            this.panel_utensils.Margin = new System.Windows.Forms.Padding(5);
            this.panel_utensils.Name = "panel_utensils";
            this.panel_utensils.Size = new System.Drawing.Size(167, 630);
            this.panel_utensils.TabIndex = 1;
            // 
            // lbl_shapes
            // 
            this.lbl_shapes.AutoSize = true;
            this.lbl_shapes.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shapes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_shapes.Location = new System.Drawing.Point(24, 223);
            this.lbl_shapes.Name = "lbl_shapes";
            this.lbl_shapes.Size = new System.Drawing.Size(116, 34);
            this.lbl_shapes.TabIndex = 14;
            this.lbl_shapes.Text = "Shapes";
            // 
            // lbl_tools
            // 
            this.lbl_tools.AutoSize = true;
            this.lbl_tools.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tools.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_tools.Location = new System.Drawing.Point(37, 14);
            this.lbl_tools.Name = "lbl_tools";
            this.lbl_tools.Size = new System.Drawing.Size(94, 34);
            this.lbl_tools.TabIndex = 4;
            this.lbl_tools.Text = "Tools";
            // 
            // btn_text
            // 
            this.btn_text.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_text.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_text.FlatAppearance.BorderSize = 2;
            this.btn_text.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_text.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_text.Location = new System.Drawing.Point(40, 533);
            this.btn_text.Name = "btn_text";
            this.btn_text.Size = new System.Drawing.Size(86, 76);
            this.btn_text.TabIndex = 13;
            this.btn_text.Text = "Text";
            this.btn_text.UseVisualStyleBackColor = false;
            this.btn_text.Click += new System.EventHandler(this.btn_text_Click);
            // 
            // btn_rectangle
            // 
            this.btn_rectangle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_rectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_rectangle.BackgroundImage")));
            this.btn_rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_rectangle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_rectangle.FlatAppearance.BorderSize = 2;
            this.btn_rectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_rectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rectangle.Location = new System.Drawing.Point(6, 342);
            this.btn_rectangle.Name = "btn_rectangle";
            this.btn_rectangle.Size = new System.Drawing.Size(153, 76);
            this.btn_rectangle.TabIndex = 12;
            this.btn_rectangle.UseVisualStyleBackColor = false;
            this.btn_rectangle.Click += new System.EventHandler(this.btn_rectangle_Click);
            // 
            // btn_polygon
            // 
            this.btn_polygon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_polygon.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_polygon.FlatAppearance.BorderSize = 2;
            this.btn_polygon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_polygon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_polygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_polygon.Location = new System.Drawing.Point(87, 424);
            this.btn_polygon.Name = "btn_polygon";
            this.btn_polygon.Size = new System.Drawing.Size(74, 76);
            this.btn_polygon.TabIndex = 11;
            this.btn_polygon.Text = "Polygon";
            this.btn_polygon.UseVisualStyleBackColor = false;
            this.btn_polygon.Click += new System.EventHandler(this.btn_polygon_Click);
            // 
            // btn_triangle
            // 
            this.btn_triangle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_triangle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_triangle.FlatAppearance.BorderSize = 2;
            this.btn_triangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_triangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_triangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_triangle.Image = ((System.Drawing.Image)(resources.GetObject("btn_triangle.Image")));
            this.btn_triangle.Location = new System.Drawing.Point(6, 424);
            this.btn_triangle.Name = "btn_triangle";
            this.btn_triangle.Size = new System.Drawing.Size(74, 76);
            this.btn_triangle.TabIndex = 10;
            this.btn_triangle.UseVisualStyleBackColor = false;
            this.btn_triangle.Click += new System.EventHandler(this.btn_triangle_Click);
            // 
            // btn_square
            // 
            this.btn_square.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_square.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_square.FlatAppearance.BorderSize = 2;
            this.btn_square.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_square.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_square.Image = ((System.Drawing.Image)(resources.GetObject("btn_square.Image")));
            this.btn_square.Location = new System.Drawing.Point(87, 260);
            this.btn_square.Name = "btn_square";
            this.btn_square.Size = new System.Drawing.Size(74, 76);
            this.btn_square.TabIndex = 9;
            this.btn_square.UseVisualStyleBackColor = false;
            this.btn_square.Click += new System.EventHandler(this.btn_square_Click);
            // 
            // btn_circle
            // 
            this.btn_circle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_circle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_circle.FlatAppearance.BorderSize = 2;
            this.btn_circle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_circle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_circle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_circle.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_circle.Image = ((System.Drawing.Image)(resources.GetObject("btn_circle.Image")));
            this.btn_circle.Location = new System.Drawing.Point(6, 260);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(74, 76);
            this.btn_circle.TabIndex = 8;
            this.btn_circle.UseVisualStyleBackColor = false;
            this.btn_circle.Click += new System.EventHandler(this.btn_circle_Click);
            // 
            // btn_fill
            // 
            this.btn_fill.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_fill.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_fill.FlatAppearance.BorderSize = 2;
            this.btn_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fill.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fill.Image = ((System.Drawing.Image)(resources.GetObject("btn_fill.Image")));
            this.btn_fill.Location = new System.Drawing.Point(87, 133);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(74, 76);
            this.btn_fill.TabIndex = 7;
            this.btn_fill.Text = "Fill";
            this.btn_fill.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_fill.UseVisualStyleBackColor = false;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // btn_eraser
            // 
            this.btn_eraser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_eraser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_eraser.FlatAppearance.BorderSize = 2;
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eraser.Image = ((System.Drawing.Image)(resources.GetObject("btn_eraser.Image")));
            this.btn_eraser.Location = new System.Drawing.Point(6, 133);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(74, 76);
            this.btn_eraser.TabIndex = 6;
            this.btn_eraser.Text = "Eraser";
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_eraser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_eraser.UseVisualStyleBackColor = false;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_line.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_line.FlatAppearance.BorderSize = 2;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_line.Image = ((System.Drawing.Image)(resources.GetObject("btn_line.Image")));
            this.btn_line.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_line.Location = new System.Drawing.Point(87, 51);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(74, 76);
            this.btn_line.TabIndex = 5;
            this.btn_line.Text = "Line";
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_line.UseVisualStyleBackColor = false;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_pencil
            // 
            this.btn_pencil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_pencil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_pencil.FlatAppearance.BorderSize = 2;
            this.btn_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pencil.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pencil.Image = ((System.Drawing.Image)(resources.GetObject("btn_pencil.Image")));
            this.btn_pencil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_pencil.Location = new System.Drawing.Point(6, 51);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(74, 76);
            this.btn_pencil.TabIndex = 4;
            this.btn_pencil.Text = "Pencil";
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_pencil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_pencil.UseVisualStyleBackColor = false;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            // 
            // panel_tools
            // 
            this.panel_tools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_tools.Controls.Add(this.lbl_width_show);
            this.panel_tools.Controls.Add(this.lbl_pen_width);
            this.panel_tools.Controls.Add(this.width_bar_pen);
            this.panel_tools.Controls.Add(this.btn_swap_color);
            this.panel_tools.Controls.Add(this.btn_ColorSet);
            this.panel_tools.Controls.Add(this.lbl_coordsText);
            this.panel_tools.Controls.Add(this.lbl_coords);
            this.panel_tools.Controls.Add(this.picbox_second_colorSet);
            this.panel_tools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_tools.Location = new System.Drawing.Point(0, 662);
            this.panel_tools.Margin = new System.Windows.Forms.Padding(5);
            this.panel_tools.Name = "panel_tools";
            this.panel_tools.Size = new System.Drawing.Size(1182, 91);
            this.panel_tools.TabIndex = 2;
            // 
            // lbl_width_show
            // 
            this.lbl_width_show.AutoSize = true;
            this.lbl_width_show.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_width_show.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_width_show.Location = new System.Drawing.Point(367, 14);
            this.lbl_width_show.Name = "lbl_width_show";
            this.lbl_width_show.Size = new System.Drawing.Size(34, 34);
            this.lbl_width_show.TabIndex = 16;
            this.lbl_width_show.Text = "1";
            // 
            // lbl_pen_width
            // 
            this.lbl_pen_width.AutoSize = true;
            this.lbl_pen_width.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pen_width.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_pen_width.Location = new System.Drawing.Point(203, 48);
            this.lbl_pen_width.Name = "lbl_pen_width";
            this.lbl_pen_width.Size = new System.Drawing.Size(158, 34);
            this.lbl_pen_width.TabIndex = 15;
            this.lbl_pen_width.Text = "Thickness";
            // 
            // width_bar_pen
            // 
            this.width_bar_pen.Location = new System.Drawing.Point(185, 14);
            this.width_bar_pen.Maximum = 5;
            this.width_bar_pen.Name = "width_bar_pen";
            this.width_bar_pen.Size = new System.Drawing.Size(187, 56);
            this.width_bar_pen.TabIndex = 5;
            this.width_bar_pen.Scroll += new System.EventHandler(this.width_bar_pen_Scroll);
            // 
            // btn_swap_color
            // 
            this.btn_swap_color.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_swap_color.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_swap_color.BackgroundImage")));
            this.btn_swap_color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_swap_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_swap_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_swap_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_swap_color.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_swap_color.Location = new System.Drawing.Point(6, 70);
            this.btn_swap_color.Name = "btn_swap_color";
            this.btn_swap_color.Size = new System.Drawing.Size(18, 18);
            this.btn_swap_color.TabIndex = 4;
            this.btn_swap_color.UseVisualStyleBackColor = false;
            this.btn_swap_color.Click += new System.EventHandler(this.btn_swap_color_Click);
            // 
            // btn_ColorSet
            // 
            this.btn_ColorSet.Image = ((System.Drawing.Image)(resources.GetObject("btn_ColorSet.Image")));
            this.btn_ColorSet.Location = new System.Drawing.Point(26, 6);
            this.btn_ColorSet.Name = "btn_ColorSet";
            this.btn_ColorSet.Size = new System.Drawing.Size(64, 64);
            this.btn_ColorSet.TabIndex = 2;
            this.btn_ColorSet.TabStop = false;
            this.btn_ColorSet.Click += new System.EventHandler(this.btn_ColorSet_Click);
            // 
            // lbl_coordsText
            // 
            this.lbl_coordsText.AutoSize = true;
            this.lbl_coordsText.Location = new System.Drawing.Point(1011, 14);
            this.lbl_coordsText.Name = "lbl_coordsText";
            this.lbl_coordsText.Size = new System.Drawing.Size(147, 28);
            this.lbl_coordsText.TabIndex = 1;
            this.lbl_coordsText.Text = "Coordinates";
            // 
            // lbl_coords
            // 
            this.lbl_coords.AutoSize = true;
            this.lbl_coords.Location = new System.Drawing.Point(1011, 42);
            this.lbl_coords.Name = "lbl_coords";
            this.lbl_coords.Size = new System.Drawing.Size(90, 28);
            this.lbl_coords.TabIndex = 0;
            this.lbl_coords.Text = "------";
            // 
            // picbox_second_colorSet
            // 
            this.picbox_second_colorSet.Image = ((System.Drawing.Image)(resources.GetObject("picbox_second_colorSet.Image")));
            this.picbox_second_colorSet.Location = new System.Drawing.Point(52, 22);
            this.picbox_second_colorSet.Name = "picbox_second_colorSet";
            this.picbox_second_colorSet.Size = new System.Drawing.Size(64, 64);
            this.picbox_second_colorSet.TabIndex = 3;
            this.picbox_second_colorSet.TabStop = false;
            // 
            // picbox_canvas
            // 
            this.picbox_canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbox_canvas.Location = new System.Drawing.Point(167, 32);
            this.picbox_canvas.Margin = new System.Windows.Forms.Padding(5);
            this.picbox_canvas.Name = "picbox_canvas";
            this.picbox_canvas.Size = new System.Drawing.Size(1015, 630);
            this.picbox_canvas.TabIndex = 3;
            this.picbox_canvas.TabStop = false;
            this.picbox_canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picbox_canvas_Paint);
            this.picbox_canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picbox_canvas_MouseClick);
            this.picbox_canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picbox_canvas_MouseDown);
            this.picbox_canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picbox_canvas_MouseMove);
            this.picbox_canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picbox_canvas_MouseUp);
            // 
            // form_paintit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.picbox_canvas);
            this.Controls.Add(this.panel_utensils);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel_tools);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "form_paintit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "8As Canvas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_utensils.ResumeLayout(false);
            this.panel_utensils.PerformLayout();
            this.panel_tools.ResumeLayout(false);
            this.panel_tools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.width_bar_pen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ColorSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_second_colorSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleanCanvasMstrip;
        private System.Windows.Forms.ToolStripMenuItem backGroundChangeColorMstrip;
        private System.Windows.Forms.ToolStripMenuItem dezhacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.Panel panel_utensils;
        private System.Windows.Forms.Panel panel_tools;
        private System.Windows.Forms.PictureBox picbox_canvas;
        private System.Windows.Forms.Label lbl_coordsText;
        private System.Windows.Forms.Label lbl_coords;
        private System.Windows.Forms.Button btn_text;
        private System.Windows.Forms.Button btn_rectangle;
        private System.Windows.Forms.Button btn_polygon;
        private System.Windows.Forms.Button btn_triangle;
        private System.Windows.Forms.Button btn_square;
        private System.Windows.Forms.Button btn_circle;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.PictureBox btn_ColorSet;
        private System.Windows.Forms.PictureBox picbox_second_colorSet;
        private System.Windows.Forms.Button btn_swap_color;
        private System.Windows.Forms.Label lbl_shapes;
        private System.Windows.Forms.Label lbl_tools;
        private System.Windows.Forms.TrackBar width_bar_pen;
        private System.Windows.Forms.Label lbl_pen_width;
        private System.Windows.Forms.Label lbl_width_show;
    }
}

