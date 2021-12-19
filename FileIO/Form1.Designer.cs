namespace FileIO
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
            this.textbox = new System.Windows.Forms.TextBox();
            this.create_file = new System.Windows.Forms.Button();
            this.read_file = new System.Windows.Forms.Button();
            this.write_to_file = new System.Windows.Forms.Button();
            this.display_meta_data = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(327, 13);
            this.textbox.Multiline = true;
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(461, 202);
            this.textbox.TabIndex = 0;
            // 
            // create_file
            // 
            this.create_file.Location = new System.Drawing.Point(13, 13);
            this.create_file.Name = "create_file";
            this.create_file.Size = new System.Drawing.Size(308, 46);
            this.create_file.TabIndex = 1;
            this.create_file.Text = "Create File";
            this.create_file.UseVisualStyleBackColor = true;
            this.create_file.Click += new System.EventHandler(this.create_file_Click);
            // 
            // read_file
            // 
            this.read_file.Location = new System.Drawing.Point(13, 65);
            this.read_file.Name = "read_file";
            this.read_file.Size = new System.Drawing.Size(308, 46);
            this.read_file.TabIndex = 2;
            this.read_file.Text = "Read File";
            this.read_file.UseVisualStyleBackColor = true;
            this.read_file.Click += new System.EventHandler(this.read_file_Click);
            // 
            // write_to_file
            // 
            this.write_to_file.Location = new System.Drawing.Point(12, 117);
            this.write_to_file.Name = "write_to_file";
            this.write_to_file.Size = new System.Drawing.Size(308, 46);
            this.write_to_file.TabIndex = 3;
            this.write_to_file.Text = "Write To File";
            this.write_to_file.UseVisualStyleBackColor = true;
            this.write_to_file.Click += new System.EventHandler(this.write_to_file_Click);
            // 
            // display_meta_data
            // 
            this.display_meta_data.Location = new System.Drawing.Point(12, 169);
            this.display_meta_data.Name = "display_meta_data";
            this.display_meta_data.Size = new System.Drawing.Size(308, 46);
            this.display_meta_data.TabIndex = 4;
            this.display_meta_data.Text = "Display Meta Data";
            this.display_meta_data.UseVisualStyleBackColor = true;
            this.display_meta_data.Click += new System.EventHandler(this.display_meta_data_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 225);
            this.Controls.Add(this.display_meta_data);
            this.Controls.Add(this.write_to_file);
            this.Controls.Add(this.read_file);
            this.Controls.Add(this.create_file);
            this.Controls.Add(this.textbox);
            this.Name = "Form1";
            this.Text = "File I/O";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Button create_file;
        private System.Windows.Forms.Button read_file;
        private System.Windows.Forms.Button write_to_file;
        private System.Windows.Forms.Button display_meta_data;
    }
}

