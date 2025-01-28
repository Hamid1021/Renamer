namespace Serial_Renamer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.alwaysOnTop = new System.Windows.Forms.ToolStripButton();
            this.Credit = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.r_mkv_mp4 = new System.Windows.Forms.RadioButton();
            this.r_srt = new System.Windows.Forms.RadioButton();
            this.r_mp4 = new System.Windows.Forms.RadioButton();
            this.open_folder_btn = new System.Windows.Forms.Button();
            this.r_mkv = new System.Windows.Forms.RadioButton();
            this.r_ass = new System.Windows.Forms.RadioButton();
            this.r_srt_ass = new System.Windows.Forms.RadioButton();
            this.reset_select_type_btn = new System.Windows.Forms.Button();
            this.clean_select_path_btn = new System.Windows.Forms.Button();
            this.from_clipboard_path_btn = new System.Windows.Forms.Button();
            this.select_path_btn = new System.Windows.Forms.Button();
            this.folder_path_txt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.check_sort_list_btn = new System.Windows.Forms.Button();
            this.submit_path_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.redo_rename_btn = new System.Windows.Forms.Button();
            this.start_renam_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.start_number_from_txt = new System.Windows.Forms.NumericUpDown();
            this.clean_after_name_btn = new System.Windows.Forms.Button();
            this.from_clipboard_after_name_btn = new System.Windows.Forms.Button();
            this.after_name_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clean_befor_name_btn = new System.Windows.Forms.Button();
            this.from_clipboard_befor_name_btn = new System.Windows.Forms.Button();
            this.before_name_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.start_number_from_txt)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.alwaysOnTop,
            this.Credit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(353, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Enabled = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(98, 22);
            this.toolStripLabel1.Text = "همیشه روی صفحه";
            // 
            // alwaysOnTop
            // 
            this.alwaysOnTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.alwaysOnTop.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alwaysOnTop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alwaysOnTop.Name = "alwaysOnTop";
            this.alwaysOnTop.Size = new System.Drawing.Size(56, 22);
            this.alwaysOnTop.Text = "غیر فعال";
            this.alwaysOnTop.Click += new System.EventHandler(this.alwaysOnTop_Click);
            // 
            // Credit
            // 
            this.Credit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Credit.Image = ((System.Drawing.Image)(resources.GetObject("Credit.Image")));
            this.Credit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Credit.Margin = new System.Windows.Forms.Padding(12, 1, 0, 2);
            this.Credit.Name = "Credit";
            this.Credit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Credit.Size = new System.Drawing.Size(91, 22);
            this.Credit.Text = "درباره سازنده";
            this.Credit.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.Credit.Click += new System.EventHandler(this.Credit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.r_mkv_mp4);
            this.groupBox1.Controls.Add(this.r_srt);
            this.groupBox1.Controls.Add(this.r_mp4);
            this.groupBox1.Controls.Add(this.open_folder_btn);
            this.groupBox1.Controls.Add(this.r_mkv);
            this.groupBox1.Controls.Add(this.r_ass);
            this.groupBox1.Controls.Add(this.r_srt_ass);
            this.groupBox1.Controls.Add(this.reset_select_type_btn);
            this.groupBox1.Controls.Add(this.clean_select_path_btn);
            this.groupBox1.Controls.Add(this.from_clipboard_path_btn);
            this.groupBox1.Controls.Add(this.select_path_btn);
            this.groupBox1.Controls.Add(this.folder_path_txt);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Size = new System.Drawing.Size(336, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بخش محتویات";
            // 
            // r_mkv_mp4
            // 
            this.r_mkv_mp4.AutoSize = true;
            this.r_mkv_mp4.Location = new System.Drawing.Point(236, 104);
            this.r_mkv_mp4.Name = "r_mkv_mp4";
            this.r_mkv_mp4.Size = new System.Drawing.Size(82, 20);
            this.r_mkv_mp4.TabIndex = 10;
            this.r_mkv_mp4.TabStop = true;
            this.r_mkv_mp4.Text = "MKV+MP4";
            this.r_mkv_mp4.UseVisualStyleBackColor = true;
            // 
            // r_srt
            // 
            this.r_srt.AutoSize = true;
            this.r_srt.Location = new System.Drawing.Point(114, 78);
            this.r_srt.Name = "r_srt";
            this.r_srt.Size = new System.Drawing.Size(49, 20);
            this.r_srt.TabIndex = 9;
            this.r_srt.TabStop = true;
            this.r_srt.Text = "SRT";
            this.r_srt.UseVisualStyleBackColor = true;
            // 
            // r_mp4
            // 
            this.r_mp4.AutoSize = true;
            this.r_mp4.Location = new System.Drawing.Point(176, 104);
            this.r_mp4.Name = "r_mp4";
            this.r_mp4.Size = new System.Drawing.Size(49, 20);
            this.r_mp4.TabIndex = 8;
            this.r_mp4.TabStop = true;
            this.r_mp4.Text = "MP4";
            this.r_mp4.UseVisualStyleBackColor = true;
            // 
            // open_folder_btn
            // 
            this.open_folder_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_folder_btn.Location = new System.Drawing.Point(6, 78);
            this.open_folder_btn.Name = "open_folder_btn";
            this.open_folder_btn.Size = new System.Drawing.Size(95, 23);
            this.open_folder_btn.TabIndex = 0;
            this.open_folder_btn.Text = "باز کردن پوشه";
            this.open_folder_btn.UseVisualStyleBackColor = true;
            this.open_folder_btn.Click += new System.EventHandler(this.open_folder_btn_Click);
            // 
            // r_mkv
            // 
            this.r_mkv.AutoSize = true;
            this.r_mkv.Location = new System.Drawing.Point(113, 104);
            this.r_mkv.Name = "r_mkv";
            this.r_mkv.Size = new System.Drawing.Size(50, 20);
            this.r_mkv.TabIndex = 7;
            this.r_mkv.TabStop = true;
            this.r_mkv.Text = "MKV";
            this.r_mkv.UseVisualStyleBackColor = true;
            // 
            // r_ass
            // 
            this.r_ass.AutoSize = true;
            this.r_ass.Location = new System.Drawing.Point(176, 78);
            this.r_ass.Name = "r_ass";
            this.r_ass.Size = new System.Drawing.Size(49, 20);
            this.r_ass.TabIndex = 6;
            this.r_ass.TabStop = true;
            this.r_ass.Text = "ASS";
            this.r_ass.UseVisualStyleBackColor = true;
            // 
            // r_srt_ass
            // 
            this.r_srt_ass.AutoSize = true;
            this.r_srt_ass.Location = new System.Drawing.Point(237, 78);
            this.r_srt_ass.Name = "r_srt_ass";
            this.r_srt_ass.Size = new System.Drawing.Size(81, 20);
            this.r_srt_ass.TabIndex = 5;
            this.r_srt_ass.TabStop = true;
            this.r_srt_ass.Text = "ASS+SRT";
            this.r_srt_ass.UseVisualStyleBackColor = true;
            // 
            // reset_select_type_btn
            // 
            this.reset_select_type_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_select_type_btn.Location = new System.Drawing.Point(6, 106);
            this.reset_select_type_btn.Name = "reset_select_type_btn";
            this.reset_select_type_btn.Size = new System.Drawing.Size(95, 23);
            this.reset_select_type_btn.TabIndex = 4;
            this.reset_select_type_btn.Text = "بازنشانی انتخاب";
            this.reset_select_type_btn.UseVisualStyleBackColor = true;
            this.reset_select_type_btn.Click += new System.EventHandler(this.reset_select_type_btn_Click);
            // 
            // clean_select_path_btn
            // 
            this.clean_select_path_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clean_select_path_btn.Location = new System.Drawing.Point(109, 49);
            this.clean_select_path_btn.Name = "clean_select_path_btn";
            this.clean_select_path_btn.Size = new System.Drawing.Size(96, 23);
            this.clean_select_path_btn.TabIndex = 3;
            this.clean_select_path_btn.Text = "پاک کردن";
            this.clean_select_path_btn.UseVisualStyleBackColor = true;
            this.clean_select_path_btn.Click += new System.EventHandler(this.clean_select_path_btn_Click);
            // 
            // from_clipboard_path_btn
            // 
            this.from_clipboard_path_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_clipboard_path_btn.Location = new System.Drawing.Point(211, 49);
            this.from_clipboard_path_btn.Name = "from_clipboard_path_btn";
            this.from_clipboard_path_btn.Size = new System.Drawing.Size(118, 23);
            this.from_clipboard_path_btn.TabIndex = 2;
            this.from_clipboard_path_btn.Text = "جاگذاری از کلیپ برد";
            this.from_clipboard_path_btn.UseVisualStyleBackColor = true;
            this.from_clipboard_path_btn.Click += new System.EventHandler(this.from_clipboard_path_btn_Click);
            // 
            // select_path_btn
            // 
            this.select_path_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_path_btn.Location = new System.Drawing.Point(6, 49);
            this.select_path_btn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.select_path_btn.Name = "select_path_btn";
            this.select_path_btn.Size = new System.Drawing.Size(96, 23);
            this.select_path_btn.TabIndex = 1;
            this.select_path_btn.Text = "انتخاب آدرس";
            this.select_path_btn.UseVisualStyleBackColor = true;
            this.select_path_btn.Click += new System.EventHandler(this.select_path_btn_Click);
            // 
            // folder_path_txt
            // 
            this.folder_path_txt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folder_path_txt.Location = new System.Drawing.Point(6, 22);
            this.folder_path_txt.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.folder_path_txt.Name = "folder_path_txt";
            this.folder_path_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.folder_path_txt.Size = new System.Drawing.Size(322, 21);
            this.folder_path_txt.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.check_sort_list_btn);
            this.groupBox2.Controls.Add(this.submit_path_btn);
            this.groupBox2.Location = new System.Drawing.Point(12, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 52);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بخش ثبت و مرتب سازی فایل ها";
            // 
            // check_sort_list_btn
            // 
            this.check_sort_list_btn.Enabled = false;
            this.check_sort_list_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_sort_list_btn.Location = new System.Drawing.Point(109, 22);
            this.check_sort_list_btn.Name = "check_sort_list_btn";
            this.check_sort_list_btn.Size = new System.Drawing.Size(219, 23);
            this.check_sort_list_btn.TabIndex = 3;
            this.check_sort_list_btn.Text = "بررسی فایل های مرتب شده";
            this.check_sort_list_btn.UseVisualStyleBackColor = true;
            this.check_sort_list_btn.Click += new System.EventHandler(this.check_sort_list_btn_Click);
            // 
            // submit_path_btn
            // 
            this.submit_path_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_path_btn.Location = new System.Drawing.Point(6, 22);
            this.submit_path_btn.Name = "submit_path_btn";
            this.submit_path_btn.Size = new System.Drawing.Size(96, 23);
            this.submit_path_btn.TabIndex = 2;
            this.submit_path_btn.Text = "ثبت فایل ها";
            this.submit_path_btn.UseVisualStyleBackColor = true;
            this.submit_path_btn.Click += new System.EventHandler(this.submit_path_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox3.Controls.Add(this.redo_rename_btn);
            this.groupBox3.Controls.Add(this.start_renam_btn);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.start_number_from_txt);
            this.groupBox3.Controls.Add(this.clean_after_name_btn);
            this.groupBox3.Controls.Add(this.from_clipboard_after_name_btn);
            this.groupBox3.Controls.Add(this.after_name_txt);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.clean_befor_name_btn);
            this.groupBox3.Controls.Add(this.from_clipboard_befor_name_btn);
            this.groupBox3.Controls.Add(this.before_name_txt);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 271);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بخش اطلاعات ویدئو";
            // 
            // redo_rename_btn
            // 
            this.redo_rename_btn.Enabled = false;
            this.redo_rename_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redo_rename_btn.Location = new System.Drawing.Point(6, 235);
            this.redo_rename_btn.Name = "redo_rename_btn";
            this.redo_rename_btn.Size = new System.Drawing.Size(143, 23);
            this.redo_rename_btn.TabIndex = 16;
            this.redo_rename_btn.Text = "برگرداند نام ها به حالت قبل";
            this.redo_rename_btn.UseVisualStyleBackColor = true;
            this.redo_rename_btn.Click += new System.EventHandler(this.redo_rename_btn_Click);
            // 
            // start_renam_btn
            // 
            this.start_renam_btn.Enabled = false;
            this.start_renam_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_renam_btn.Location = new System.Drawing.Point(155, 235);
            this.start_renam_btn.Name = "start_renam_btn";
            this.start_renam_btn.Size = new System.Drawing.Size(174, 23);
            this.start_renam_btn.TabIndex = 15;
            this.start_renam_btn.Text = "تغییر نام";
            this.start_renam_btn.UseVisualStyleBackColor = true;
            this.start_renam_btn.Click += new System.EventHandler(this.start_renam_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "شروع عدد گذاری از : ";
            // 
            // start_number_from_txt
            // 
            this.start_number_from_txt.Location = new System.Drawing.Point(7, 206);
            this.start_number_from_txt.Name = "start_number_from_txt";
            this.start_number_from_txt.ReadOnly = true;
            this.start_number_from_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.start_number_from_txt.Size = new System.Drawing.Size(199, 23);
            this.start_number_from_txt.TabIndex = 13;
            this.start_number_from_txt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // clean_after_name_btn
            // 
            this.clean_after_name_btn.Enabled = false;
            this.clean_after_name_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clean_after_name_btn.Location = new System.Drawing.Point(109, 175);
            this.clean_after_name_btn.Name = "clean_after_name_btn";
            this.clean_after_name_btn.Size = new System.Drawing.Size(96, 23);
            this.clean_after_name_btn.TabIndex = 12;
            this.clean_after_name_btn.Text = "پاک کردن";
            this.clean_after_name_btn.UseVisualStyleBackColor = true;
            this.clean_after_name_btn.Click += new System.EventHandler(this.clean_after_name_btn_Click);
            // 
            // from_clipboard_after_name_btn
            // 
            this.from_clipboard_after_name_btn.Enabled = false;
            this.from_clipboard_after_name_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_clipboard_after_name_btn.Location = new System.Drawing.Point(210, 175);
            this.from_clipboard_after_name_btn.Name = "from_clipboard_after_name_btn";
            this.from_clipboard_after_name_btn.Size = new System.Drawing.Size(118, 23);
            this.from_clipboard_after_name_btn.TabIndex = 11;
            this.from_clipboard_after_name_btn.Text = "جاگذاری از کلیپ برد";
            this.from_clipboard_after_name_btn.UseVisualStyleBackColor = true;
            this.from_clipboard_after_name_btn.Click += new System.EventHandler(this.from_clipboard_after_name_btn_Click);
            // 
            // after_name_txt
            // 
            this.after_name_txt.Location = new System.Drawing.Point(6, 146);
            this.after_name_txt.Name = "after_name_txt";
            this.after_name_txt.ReadOnly = true;
            this.after_name_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.after_name_txt.Size = new System.Drawing.Size(322, 23);
            this.after_name_txt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "S01E xxxx";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "مقدار نام بعد از حرف E (رو به روی حرف E عدد نگذارید)";
            // 
            // clean_befor_name_btn
            // 
            this.clean_befor_name_btn.Enabled = false;
            this.clean_befor_name_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clean_befor_name_btn.Location = new System.Drawing.Point(109, 83);
            this.clean_befor_name_btn.Name = "clean_befor_name_btn";
            this.clean_befor_name_btn.Size = new System.Drawing.Size(96, 23);
            this.clean_befor_name_btn.TabIndex = 7;
            this.clean_befor_name_btn.Text = "پاک کردن";
            this.clean_befor_name_btn.UseVisualStyleBackColor = true;
            this.clean_befor_name_btn.Click += new System.EventHandler(this.clean_befor_name_btn_Click);
            // 
            // from_clipboard_befor_name_btn
            // 
            this.from_clipboard_befor_name_btn.Enabled = false;
            this.from_clipboard_befor_name_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_clipboard_befor_name_btn.Location = new System.Drawing.Point(210, 83);
            this.from_clipboard_befor_name_btn.Name = "from_clipboard_befor_name_btn";
            this.from_clipboard_befor_name_btn.Size = new System.Drawing.Size(118, 23);
            this.from_clipboard_befor_name_btn.TabIndex = 6;
            this.from_clipboard_befor_name_btn.Text = "جاگذاری از کلیپ برد";
            this.from_clipboard_befor_name_btn.UseVisualStyleBackColor = true;
            this.from_clipboard_befor_name_btn.Click += new System.EventHandler(this.from_clipboard_befor_name_btn_Click);
            // 
            // before_name_txt
            // 
            this.before_name_txt.Location = new System.Drawing.Point(6, 54);
            this.before_name_txt.Name = "before_name_txt";
            this.before_name_txt.ReadOnly = true;
            this.before_name_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.before_name_txt.Size = new System.Drawing.Size(322, 23);
            this.before_name_txt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "xxxx S01E";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "مقدار نام قبل از حرف E مانند : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(353, 493);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "هم نام کننده زیر نویس و فیلم";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.start_number_from_txt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton alwaysOnTop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button from_clipboard_path_btn;
        private System.Windows.Forms.Button select_path_btn;
        private System.Windows.Forms.TextBox folder_path_txt;
        private System.Windows.Forms.RadioButton r_mkv_mp4;
        private System.Windows.Forms.RadioButton r_srt;
        private System.Windows.Forms.RadioButton r_mp4;
        private System.Windows.Forms.RadioButton r_mkv;
        private System.Windows.Forms.RadioButton r_ass;
        private System.Windows.Forms.RadioButton r_srt_ass;
        private System.Windows.Forms.Button reset_select_type_btn;
        private System.Windows.Forms.Button clean_select_path_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button check_sort_list_btn;
        private System.Windows.Forms.Button submit_path_btn;
        private System.Windows.Forms.Button open_folder_btn;
        private System.Windows.Forms.Button clean_after_name_btn;
        private System.Windows.Forms.Button from_clipboard_after_name_btn;
        private System.Windows.Forms.TextBox after_name_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clean_befor_name_btn;
        private System.Windows.Forms.Button from_clipboard_befor_name_btn;
        private System.Windows.Forms.TextBox before_name_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton Credit;
        private System.Windows.Forms.Button start_renam_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown start_number_from_txt;
        private System.Windows.Forms.Button redo_rename_btn;
    }
}

