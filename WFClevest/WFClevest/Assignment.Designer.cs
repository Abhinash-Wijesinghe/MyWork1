namespace WFClevest
{
    partial class Assignment
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
            this.btnQ1Results = new System.Windows.Forms.Button();
            this.btnQ2Results = new System.Windows.Forms.Button();
            this.btnQ3Results = new System.Windows.Forms.Button();
            this.btnQ4Results = new System.Windows.Forms.Button();
            this.lboxResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnQ1Results
            // 
            this.btnQ1Results.Location = new System.Drawing.Point(23, 25);
            this.btnQ1Results.Name = "btnQ1Results";
            this.btnQ1Results.Size = new System.Drawing.Size(121, 23);
            this.btnQ1Results.TabIndex = 0;
            this.btnQ1Results.Text = "Question 1 Results";
            this.btnQ1Results.UseVisualStyleBackColor = true;
            this.btnQ1Results.Click += new System.EventHandler(this.btnQ1Results_Click);
            // 
            // btnQ2Results
            // 
            this.btnQ2Results.Location = new System.Drawing.Point(23, 54);
            this.btnQ2Results.Name = "btnQ2Results";
            this.btnQ2Results.Size = new System.Drawing.Size(121, 23);
            this.btnQ2Results.TabIndex = 1;
            this.btnQ2Results.Text = "Question 2 Results";
            this.btnQ2Results.UseVisualStyleBackColor = true;
            this.btnQ2Results.Click += new System.EventHandler(this.btnQ2Results_Click);
            // 
            // btnQ3Results
            // 
            this.btnQ3Results.Location = new System.Drawing.Point(23, 83);
            this.btnQ3Results.Name = "btnQ3Results";
            this.btnQ3Results.Size = new System.Drawing.Size(121, 23);
            this.btnQ3Results.TabIndex = 2;
            this.btnQ3Results.Text = "Question 3 Results";
            this.btnQ3Results.UseVisualStyleBackColor = true;
            this.btnQ3Results.Click += new System.EventHandler(this.btnQ3Results_Click);
            // 
            // btnQ4Results
            // 
            this.btnQ4Results.Location = new System.Drawing.Point(23, 112);
            this.btnQ4Results.Name = "btnQ4Results";
            this.btnQ4Results.Size = new System.Drawing.Size(121, 23);
            this.btnQ4Results.TabIndex = 3;
            this.btnQ4Results.Text = "Question 4 Results";
            this.btnQ4Results.UseVisualStyleBackColor = true;
            this.btnQ4Results.Click += new System.EventHandler(this.btnQ4Results_Click);
            // 
            // lboxResults
            // 
            this.lboxResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboxResults.FormattingEnabled = true;
            this.lboxResults.Location = new System.Drawing.Point(23, 162);
            this.lboxResults.Name = "lboxResults";
            this.lboxResults.Size = new System.Drawing.Size(756, 277);
            this.lboxResults.TabIndex = 4;
            // 
            // Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 457);
            this.Controls.Add(this.lboxResults);
            this.Controls.Add(this.btnQ4Results);
            this.Controls.Add(this.btnQ3Results);
            this.Controls.Add(this.btnQ2Results);
            this.Controls.Add(this.btnQ1Results);
            this.Name = "Assignment";
            this.Text = "Technical Assignment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQ1Results;
        private System.Windows.Forms.Button btnQ2Results;
        private System.Windows.Forms.Button btnQ3Results;
        private System.Windows.Forms.Button btnQ4Results;
        private System.Windows.Forms.ListBox lboxResults;
    }
}

