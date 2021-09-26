
namespace Lab1_task3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.READ = new System.Windows.Forms.Button();
            this.WRITE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // READ
            // 
            this.READ.Location = new System.Drawing.Point(144, 302);
            this.READ.Name = "READ";
            this.READ.Size = new System.Drawing.Size(94, 29);
            this.READ.TabIndex = 0;
            this.READ.Text = "READ";
            this.READ.UseVisualStyleBackColor = true;
            this.READ.Click += new System.EventHandler(this.READ_Click);
            // 
            // WRITE
            // 
            this.WRITE.Location = new System.Drawing.Point(486, 302);
            this.WRITE.Name = "WRITE";
            this.WRITE.Size = new System.Drawing.Size(94, 29);
            this.WRITE.TabIndex = 1;
            this.WRITE.Text = "WRITE";
            this.WRITE.UseVisualStyleBackColor = true;
            this.WRITE.Click += new System.EventHandler(this.WRITE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WRITE);
            this.Controls.Add(this.READ);
            this.Name = "Form1";
            this.Text = "TASK3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button READ;
        public System.Windows.Forms.Button WRITE;
    }
}

