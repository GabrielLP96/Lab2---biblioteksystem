﻿namespace GUI
{
    partial class AdminShowSection
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
            this.Btn_previous = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_show = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_previous
            // 
            this.Btn_previous.Location = new System.Drawing.Point(648, 478);
            this.Btn_previous.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_previous.Name = "Btn_previous";
            this.Btn_previous.Size = new System.Drawing.Size(100, 28);
            this.Btn_previous.TabIndex = 11;
            this.Btn_previous.Text = "Previous";
            this.Btn_previous.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(662, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Section";
            // 
            // Btn_show
            // 
            this.Btn_show.Location = new System.Drawing.Point(648, 77);
            this.Btn_show.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_show.Name = "Btn_show";
            this.Btn_show.Size = new System.Drawing.Size(100, 28);
            this.Btn_show.TabIndex = 9;
            this.Btn_show.Text = "Show";
            this.Btn_show.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(600, 420);
            this.dataGridView1.TabIndex = 8;
            // 
            // AdminShowSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 520);
            this.Controls.Add(this.Btn_previous);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_show);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminShowSection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Show Section";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_previous;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_show;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}