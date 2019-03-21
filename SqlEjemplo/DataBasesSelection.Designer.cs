namespace SqlEjemplo
{
    partial class DataBasesSelection
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
            this.listDBNames = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listTables = new System.Windows.Forms.ListBox();
            this.listViews = new System.Windows.Forms.ListBox();
            this.listSP = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listDBNames
            // 
            this.listDBNames.FormattingEnabled = true;
            this.listDBNames.Location = new System.Drawing.Point(12, 42);
            this.listDBNames.Name = "listDBNames";
            this.listDBNames.Size = new System.Drawing.Size(173, 303);
            this.listDBNames.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bases de datos";
            // 
            // listTables
            // 
            this.listTables.FormattingEnabled = true;
            this.listTables.Location = new System.Drawing.Point(227, 42);
            this.listTables.Name = "listTables";
            this.listTables.Size = new System.Drawing.Size(173, 303);
            this.listTables.TabIndex = 2;
            // 
            // listViews
            // 
            this.listViews.FormattingEnabled = true;
            this.listViews.Location = new System.Drawing.Point(406, 42);
            this.listViews.Name = "listViews";
            this.listViews.Size = new System.Drawing.Size(173, 303);
            this.listViews.TabIndex = 3;
            // 
            // listSP
            // 
            this.listSP.FormattingEnabled = true;
            this.listSP.Location = new System.Drawing.Point(585, 42);
            this.listSP.Name = "listSP";
            this.listSP.Size = new System.Drawing.Size(173, 303);
            this.listSP.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tables";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Views";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(661, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "SPs";
            // 
            // DataBasesSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 376);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listSP);
            this.Controls.Add(this.listViews);
            this.Controls.Add(this.listTables);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listDBNames);
            this.Name = "DataBasesSelection";
            this.Text = "DataBasesSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listDBNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listTables;
        private System.Windows.Forms.ListBox listViews;
        private System.Windows.Forms.ListBox listSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}