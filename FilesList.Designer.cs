namespace Serial_Renamer
{
    partial class FilesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilesList));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.go_up = new System.Windows.Forms.Button();
            this.go_down = new System.Windows.Forms.Button();
            this.go_topest = new System.Windows.Forms.Button();
            this.go_downest = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(524, 415);
            this.dataGridView1.TabIndex = 0;
            // 
            // go_up
            // 
            this.go_up.Location = new System.Drawing.Point(7, 20);
            this.go_up.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.go_up.Name = "go_up";
            this.go_up.Size = new System.Drawing.Size(114, 23);
            this.go_up.TabIndex = 1;
            this.go_up.Text = "انتقال به بالا";
            this.go_up.UseVisualStyleBackColor = true;
            this.go_up.Click += new System.EventHandler(this.go_up_Click);
            // 
            // go_down
            // 
            this.go_down.Location = new System.Drawing.Point(7, 49);
            this.go_down.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.go_down.Name = "go_down";
            this.go_down.Size = new System.Drawing.Size(114, 23);
            this.go_down.TabIndex = 2;
            this.go_down.Text = "انتقال به پایین";
            this.go_down.UseVisualStyleBackColor = true;
            this.go_down.Click += new System.EventHandler(this.go_down_Click);
            // 
            // go_topest
            // 
            this.go_topest.Location = new System.Drawing.Point(7, 78);
            this.go_topest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.go_topest.Name = "go_topest";
            this.go_topest.Size = new System.Drawing.Size(114, 23);
            this.go_topest.TabIndex = 3;
            this.go_topest.Text = "انتقال به بالاترین";
            this.go_topest.UseVisualStyleBackColor = true;
            this.go_topest.Click += new System.EventHandler(this.go_topest_Click);
            // 
            // go_downest
            // 
            this.go_downest.Location = new System.Drawing.Point(7, 107);
            this.go_downest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.go_downest.Name = "go_downest";
            this.go_downest.Size = new System.Drawing.Size(114, 23);
            this.go_downest.TabIndex = 4;
            this.go_downest.Text = "انتقال به پایین ترین";
            this.go_downest.UseVisualStyleBackColor = true;
            this.go_downest.Click += new System.EventHandler(this.go_downest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.go_up);
            this.groupBox1.Controls.Add(this.go_downest);
            this.groupBox1.Controls.Add(this.go_down);
            this.groupBox1.Controls.Add(this.go_topest);
            this.groupBox1.Location = new System.Drawing.Point(533, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(130, 415);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "گزینه ها";
            // 
            // FilesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(667, 418);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FilesList";
            this.Text = "FilesList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button go_up;
        private System.Windows.Forms.Button go_down;
        private System.Windows.Forms.Button go_topest;
        private System.Windows.Forms.Button go_downest;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}