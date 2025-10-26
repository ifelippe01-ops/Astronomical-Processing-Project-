namespace Astronomical_Processing
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.editBox = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(273, 33);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 26);
            this.searchBox.TabIndex = 0;
            // 
            // editBox
            // 
            this.editBox.Location = new System.Drawing.Point(408, 33);
            this.editBox.Name = "editBox";
            this.editBox.Size = new System.Drawing.Size(100, 26);
            this.editBox.TabIndex = 1;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(12, 33);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(228, 284);
            this.listBox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.searchButton.Location = new System.Drawing.Point(273, 65);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 31);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.editButton.Location = new System.Drawing.Point(408, 67);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 29);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.loadButton.Location = new System.Drawing.Point(12, 323);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(99, 29);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.sortButton.Location = new System.Drawing.Point(140, 323);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(100, 29);
            this.sortButton.TabIndex = 6;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = false;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.editBox);
            this.Controls.Add(this.searchBox);
            this.Name = "Form1";
            this.Text = "Astronomical Processing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.TextBox editBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button sortButton;
    }
}

