namespace TextCleanerApp
{
    partial class RemoveLines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveLines));
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemoveLines = new System.Windows.Forms.TextBox();
            this.txtMainText = new System.Windows.Forms.TextBox();
            this.txtResultText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPaste
            // 
            this.btnPaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.btnPaste.Location = new System.Drawing.Point(32, 445);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(138, 63);
            this.btnPaste.TabIndex = 27;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.btnRemove.Location = new System.Drawing.Point(506, 447);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(222, 63);
            this.btnRemove.TabIndex = 29;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.btnCopy.Location = new System.Drawing.Point(920, 445);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(222, 63);
            this.btnCopy.TabIndex = 30;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.btnClear.Location = new System.Drawing.Point(274, 445);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(138, 63);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.label5.Location = new System.Drawing.Point(962, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 36);
            this.label5.TabIndex = 24;
            this.label5.Text = "Result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.label4.Location = new System.Drawing.Point(555, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 36);
            this.label4.TabIndex = 25;
            this.label4.Text = "Remove";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.label3.Location = new System.Drawing.Point(182, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 36);
            this.label3.TabIndex = 26;
            this.label3.Text = "Main";
            // 
            // txtRemoveLines
            // 
            this.txtRemoveLines.Location = new System.Drawing.Point(427, 89);
            this.txtRemoveLines.Multiline = true;
            this.txtRemoveLines.Name = "txtRemoveLines";
            this.txtRemoveLines.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemoveLines.Size = new System.Drawing.Size(380, 350);
            this.txtRemoveLines.TabIndex = 22;
            // 
            // txtMainText
            // 
            this.txtMainText.Location = new System.Drawing.Point(32, 89);
            this.txtMainText.Multiline = true;
            this.txtMainText.Name = "txtMainText";
            this.txtMainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMainText.Size = new System.Drawing.Size(380, 350);
            this.txtMainText.TabIndex = 23;
            // 
            // txtResultText
            // 
            this.txtResultText.Location = new System.Drawing.Point(822, 89);
            this.txtResultText.Multiline = true;
            this.txtResultText.Name = "txtResultText";
            this.txtResultText.ReadOnly = true;
            this.txtResultText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultText.Size = new System.Drawing.Size(380, 350);
            this.txtResultText.TabIndex = 21;
            // 
            // RemoveLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 560);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResultText);
            this.Controls.Add(this.txtRemoveLines);
            this.Controls.Add(this.txtMainText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RemoveLines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Lines";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtResult;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRemoveLines;
        private System.Windows.Forms.TextBox txtMainText;
        private System.Windows.Forms.TextBox txtResultText;
    }
}

