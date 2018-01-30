using System.Windows.Forms;

namespace mp3grab
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
            this.path_Textbox = new System.Windows.Forms.TextBox();
            this.open_Button = new System.Windows.Forms.Button();
            this.scan_Button = new System.Windows.Forms.Button();
            this.files_listbox = new System.Windows.Forms.ListBox();
            this.go_to_folder_button = new System.Windows.Forms.Button();
            this.artist_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.album_textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.year_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.genge_textbox = new System.Windows.Forms.TextBox();
            this.genre_label = new System.Windows.Forms.Label();
            this.status_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // path_Textbox
            // 
            this.path_Textbox.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.path_Textbox.Location = new System.Drawing.Point(12, 12);
            this.path_Textbox.Name = "path_Textbox";
            this.path_Textbox.Size = new System.Drawing.Size(219, 18);
            this.path_Textbox.TabIndex = 0;
            this.path_Textbox.Text = "E:\\downloads";
            // 
            // open_Button
            // 
            this.open_Button.Font = new System.Drawing.Font("Lucida Grande", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.open_Button.Location = new System.Drawing.Point(237, 11);
            this.open_Button.Name = "open_Button";
            this.open_Button.Size = new System.Drawing.Size(35, 20);
            this.open_Button.TabIndex = 1;
            this.open_Button.Text = "...";
            this.open_Button.UseMnemonic = false;
            this.open_Button.UseVisualStyleBackColor = true;
            this.open_Button.Click += new System.EventHandler(this.open_Button_Click);
            // 
            // scan_Button
            // 
            this.scan_Button.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scan_Button.Location = new System.Drawing.Point(12, 38);
            this.scan_Button.Name = "scan_Button";
            this.scan_Button.Size = new System.Drawing.Size(75, 23);
            this.scan_Button.TabIndex = 2;
            this.scan_Button.Text = "scan";
            this.scan_Button.UseVisualStyleBackColor = true;
            this.scan_Button.Click += new System.EventHandler(this.scan_Button_Click);
            // 
            // files_listbox
            // 
            this.files_listbox.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.files_listbox.FormattingEnabled = true;
            this.files_listbox.ItemHeight = 11;
            this.files_listbox.Location = new System.Drawing.Point(12, 67);
            this.files_listbox.Name = "files_listbox";
            this.files_listbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.files_listbox.Size = new System.Drawing.Size(260, 158);
            this.files_listbox.TabIndex = 3;
            // 
            // go_to_folder_button
            // 
            this.go_to_folder_button.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.go_to_folder_button.Location = new System.Drawing.Point(12, 231);
            this.go_to_folder_button.Name = "go_to_folder_button";
            this.go_to_folder_button.Size = new System.Drawing.Size(260, 23);
            this.go_to_folder_button.TabIndex = 4;
            this.go_to_folder_button.Text = "go to folder";
            this.go_to_folder_button.UseVisualStyleBackColor = true;
            this.go_to_folder_button.Click += new System.EventHandler(this.go_to_folder_button_Click);
            // 
            // artist_textBox
            // 
            this.artist_textBox.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.artist_textBox.Location = new System.Drawing.Point(288, 30);
            this.artist_textBox.Name = "artist_textBox";
            this.artist_textBox.Size = new System.Drawing.Size(191, 18);
            this.artist_textBox.TabIndex = 5;
            this.artist_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(444, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "artist";
            // 
            // album_textBox2
            // 
            this.album_textBox2.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.album_textBox2.Location = new System.Drawing.Point(288, 72);
            this.album_textBox2.Name = "album_textBox2";
            this.album_textBox2.Size = new System.Drawing.Size(191, 18);
            this.album_textBox2.TabIndex = 7;
            this.album_textBox2.Text = "compilation";
            this.album_textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(438, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "album";
            // 
            // year_textbox
            // 
            this.year_textbox.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year_textbox.Location = new System.Drawing.Point(288, 159);
            this.year_textbox.Name = "year_textbox";
            this.year_textbox.Size = new System.Drawing.Size(191, 18);
            this.year_textbox.TabIndex = 9;
            this.year_textbox.Text = "2018";
            this.year_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(449, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "year";
            // 
            // genge_textbox
            // 
            this.genge_textbox.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genge_textbox.Location = new System.Drawing.Point(288, 117);
            this.genge_textbox.Name = "genge_textbox";
            this.genge_textbox.Size = new System.Drawing.Size(191, 18);
            this.genge_textbox.TabIndex = 12;
            this.genge_textbox.Text = "black";
            this.genge_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // genre_label
            // 
            this.genre_label.AutoSize = true;
            this.genre_label.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genre_label.Location = new System.Drawing.Point(441, 99);
            this.genre_label.Name = "genre_label";
            this.genre_label.Size = new System.Drawing.Size(38, 15);
            this.genre_label.TabIndex = 13;
            this.genre_label.Text = "genre";
            // 
            // status_label
            // 
            this.status_label.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(89, 17);
            this.status_label.Text = "mp3grab v1.1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 265);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(491, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(491, 287);
            this.Controls.Add(this.genre_label);
            this.Controls.Add(this.genge_textbox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.year_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.album_textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.artist_textBox);
            this.Controls.Add(this.go_to_folder_button);
            this.Controls.Add(this.files_listbox);
            this.Controls.Add(this.scan_Button);
            this.Controls.Add(this.open_Button);
            this.Controls.Add(this.path_Textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mp3grab";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox path_Textbox;
        private System.Windows.Forms.Button open_Button;
        private Button scan_Button;
        private ListBox files_listbox;
        private Button go_to_folder_button;
        private TextBox artist_textBox;
        private Label label1;
        private TextBox album_textBox2;
        private Label label2;
        private TextBox year_textbox;
        private Label label3;
        private TextBox genge_textbox;
        private Label genre_label;
        private ToolStripStatusLabel status_label;
        private StatusStrip statusStrip1;
    }
}

