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
            this.midExButton = new System.Windows.Forms.Button();
            this.textMidEx = new System.Windows.Forms.TextBox();
            this.modeButton = new System.Windows.Forms.Button();
            this.avarageButton = new System.Windows.Forms.Button();
            this.textAvarage = new System.Windows.Forms.TextBox();
            this.rangeButton = new System.Windows.Forms.Button();
            this.textRange = new System.Windows.Forms.TextBox();
            this.linearSearchButton = new System.Windows.Forms.Button();
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
            this.loadButton.Location = new System.Drawing.Point(92, 323);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(65, 29);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.sortButton.Location = new System.Drawing.Point(176, 323);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(64, 29);
            this.sortButton.TabIndex = 6;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = false;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // midExButton
            // 
            this.midExButton.Location = new System.Drawing.Point(688, 65);
            this.midExButton.Name = "midExButton";
            this.midExButton.Size = new System.Drawing.Size(100, 26);
            this.midExButton.TabIndex = 7;
            this.midExButton.Text = "Mid-Ex";
            this.midExButton.UseVisualStyleBackColor = true;
            this.midExButton.Click += new System.EventHandler(this.midExButton_Click);
            // 
            // textMidEx
            // 
            this.textMidEx.Location = new System.Drawing.Point(688, 33);
            this.textMidEx.Name = "textMidEx";
            this.textMidEx.ReadOnly = true;
            this.textMidEx.Size = new System.Drawing.Size(100, 26);
            this.textMidEx.TabIndex = 8;
            // 
            // modeButton
            // 
            this.modeButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.modeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modeButton.Location = new System.Drawing.Point(12, 323);
            this.modeButton.Name = "modeButton";
            this.modeButton.Size = new System.Drawing.Size(63, 26);
            this.modeButton.TabIndex = 9;
            this.modeButton.Text = "Mode";
            this.modeButton.UseVisualStyleBackColor = false;
            this.modeButton.Click += new System.EventHandler(this.modeButton_Click);
            // 
            // avarageButton
            // 
            this.avarageButton.Location = new System.Drawing.Point(688, 139);
            this.avarageButton.Name = "avarageButton";
            this.avarageButton.Size = new System.Drawing.Size(100, 27);
            this.avarageButton.TabIndex = 11;
            this.avarageButton.Text = "Avarage ";
            this.avarageButton.UseVisualStyleBackColor = true;
            this.avarageButton.Click += new System.EventHandler(this.avarageButton_Click);
            // 
            // textAvarage
            // 
            this.textAvarage.Location = new System.Drawing.Point(688, 107);
            this.textAvarage.Name = "textAvarage";
            this.textAvarage.ReadOnly = true;
            this.textAvarage.Size = new System.Drawing.Size(100, 26);
            this.textAvarage.TabIndex = 12;
            // 
            // rangeButton
            // 
            this.rangeButton.Location = new System.Drawing.Point(688, 215);
            this.rangeButton.Name = "rangeButton";
            this.rangeButton.Size = new System.Drawing.Size(100, 28);
            this.rangeButton.TabIndex = 13;
            this.rangeButton.Text = "Range";
            this.rangeButton.UseVisualStyleBackColor = true;
            this.rangeButton.Click += new System.EventHandler(this.rangeButton_Click);
            // 
            // textRange
            // 
            this.textRange.Location = new System.Drawing.Point(688, 183);
            this.textRange.Name = "textRange";
            this.textRange.ReadOnly = true;
            this.textRange.Size = new System.Drawing.Size(100, 26);
            this.textRange.TabIndex = 14;
            // 
            // linearSearchButton
            // 
            this.linearSearchButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.linearSearchButton.Location = new System.Drawing.Point(274, 102);
            this.linearSearchButton.Name = "linearSearchButton";
            this.linearSearchButton.Size = new System.Drawing.Size(99, 26);
            this.linearSearchButton.TabIndex = 15;
            this.linearSearchButton.Text = "Linear Search";
            this.linearSearchButton.UseVisualStyleBackColor = false;
            this.linearSearchButton.Click += new System.EventHandler(this.linearSearchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linearSearchButton);
            this.Controls.Add(this.textRange);
            this.Controls.Add(this.rangeButton);
            this.Controls.Add(this.textAvarage);
            this.Controls.Add(this.avarageButton);
            this.Controls.Add(this.modeButton);
            this.Controls.Add(this.textMidEx);
            this.Controls.Add(this.midExButton);
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
        private System.Windows.Forms.Button midExButton;
        private System.Windows.Forms.TextBox textMidEx;
        private System.Windows.Forms.Button modeButton;
        private System.Windows.Forms.Button avarageButton;
        private System.Windows.Forms.TextBox textAvarage;
        private System.Windows.Forms.Button rangeButton;
        private System.Windows.Forms.TextBox textRange;
        private System.Windows.Forms.Button linearSearchButton;
    }
}

