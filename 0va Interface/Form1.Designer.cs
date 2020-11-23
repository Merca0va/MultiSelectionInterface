namespace _0va_Interface
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
            this.LeftListBox = new System.Windows.Forms.ListBox();
            this.RightListBox = new System.Windows.Forms.ListBox();
            this.AllLeftButton = new System.Windows.Forms.Button();
            this.AllRightButton = new System.Windows.Forms.Button();
            this.MoveLeftButton = new System.Windows.Forms.Button();
            this.MoveRightButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LeftListBox
            // 
            this.LeftListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftListBox.FormattingEnabled = true;
            this.LeftListBox.ItemHeight = 25;
            this.LeftListBox.Items.AddRange(new object[] {
            "Data1",
            "Data2",
            "Data3",
            "Data4",
            "Data5",
            "Data6",
            "Data7",
            "Data8",
            "Data9",
            "Data10"});
            this.LeftListBox.Location = new System.Drawing.Point(211, 74);
            this.LeftListBox.Name = "LeftListBox";
            this.LeftListBox.Size = new System.Drawing.Size(258, 279);
            this.LeftListBox.TabIndex = 0;
            // 
            // RightListBox
            // 
            this.RightListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightListBox.FormattingEnabled = true;
            this.RightListBox.ItemHeight = 25;
            this.RightListBox.Location = new System.Drawing.Point(694, 74);
            this.RightListBox.Name = "RightListBox";
            this.RightListBox.Size = new System.Drawing.Size(258, 279);
            this.RightListBox.TabIndex = 1;
            // 
            // AllLeftButton
            // 
            this.AllLeftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllLeftButton.Location = new System.Drawing.Point(488, 74);
            this.AllLeftButton.Name = "AllLeftButton";
            this.AllLeftButton.Size = new System.Drawing.Size(75, 23);
            this.AllLeftButton.TabIndex = 2;
            this.AllLeftButton.Text = "All ";
            this.AllLeftButton.UseVisualStyleBackColor = true;
            this.AllLeftButton.Click += new System.EventHandler(this.AllLeftButton_Click);
            // 
            // AllRightButton
            // 
            this.AllRightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllRightButton.Location = new System.Drawing.Point(595, 330);
            this.AllRightButton.Name = "AllRightButton";
            this.AllRightButton.Size = new System.Drawing.Size(75, 23);
            this.AllRightButton.TabIndex = 3;
            this.AllRightButton.Text = "All";
            this.AllRightButton.UseVisualStyleBackColor = true;
            this.AllRightButton.Click += new System.EventHandler(this.AllRightButton_Click);
            // 
            // MoveLeftButton
            // 
            this.MoveLeftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoveLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveLeftButton.Location = new System.Drawing.Point(518, 142);
            this.MoveLeftButton.Name = "MoveLeftButton";
            this.MoveLeftButton.Size = new System.Drawing.Size(126, 38);
            this.MoveLeftButton.TabIndex = 4;
            this.MoveLeftButton.Text = "<<<";
            this.MoveLeftButton.UseVisualStyleBackColor = true;
            this.MoveLeftButton.Click += new System.EventHandler(this.MoveLeftButton_Click);
            // 
            // MoveRightButton
            // 
            this.MoveRightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoveRightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveRightButton.Location = new System.Drawing.Point(518, 252);
            this.MoveRightButton.Name = "MoveRightButton";
            this.MoveRightButton.Size = new System.Drawing.Size(126, 38);
            this.MoveRightButton.TabIndex = 5;
            this.MoveRightButton.Text = ">>>";
            this.MoveRightButton.UseVisualStyleBackColor = true;
            this.MoveRightButton.Click += new System.EventHandler(this.MoveRightButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(306, 406);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(163, 57);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(694, 406);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(163, 57);
            this.SubmitButton.TabIndex = 7;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.MoveRightButton);
            this.Controls.Add(this.MoveLeftButton);
            this.Controls.Add(this.AllRightButton);
            this.Controls.Add(this.AllLeftButton);
            this.Controls.Add(this.RightListBox);
            this.Controls.Add(this.LeftListBox);
            this.Name = "Form1";
            this.Text = "Multi-Select Wizard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LeftListBox;
        private System.Windows.Forms.ListBox RightListBox;
        private System.Windows.Forms.Button AllLeftButton;
        private System.Windows.Forms.Button AllRightButton;
        private System.Windows.Forms.Button MoveLeftButton;
        private System.Windows.Forms.Button MoveRightButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button SubmitButton;
    }
}

