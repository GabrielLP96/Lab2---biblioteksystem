﻿namespace GUI
{
    partial class AdminHandleActicites
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
            this.Activites = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_edit = new System.Windows.Forms.Button();
            this.Btn_previous = new System.Windows.Forms.Button();
            this.Btn_createNew = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBox_description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtbox_activitieName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Activites
            // 
            this.Activites.AutoSize = true;
            this.Activites.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activites.Location = new System.Drawing.Point(10, 7);
            this.Activites.Name = "Activites";
            this.Activites.Size = new System.Drawing.Size(71, 16);
            this.Activites.TabIndex = 20;
            this.Activites.Text = "Activities";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Delete one selected activitie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Edit one selected activitie";
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(10, 414);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(106, 23);
            this.Btn_Delete.TabIndex = 17;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            // 
            // Btn_edit
            // 
            this.Btn_edit.Location = new System.Drawing.Point(10, 350);
            this.Btn_edit.Name = "Btn_edit";
            this.Btn_edit.Size = new System.Drawing.Size(106, 23);
            this.Btn_edit.TabIndex = 16;
            this.Btn_edit.Text = "Edit";
            this.Btn_edit.UseVisualStyleBackColor = true;
            this.Btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
            // 
            // Btn_previous
            // 
            this.Btn_previous.Location = new System.Drawing.Point(680, 414);
            this.Btn_previous.Name = "Btn_previous";
            this.Btn_previous.Size = new System.Drawing.Size(106, 23);
            this.Btn_previous.TabIndex = 15;
            this.Btn_previous.Text = "Previous";
            this.Btn_previous.UseVisualStyleBackColor = true;
            this.Btn_previous.Click += new System.EventHandler(this.Btn_previous_Click);
            // 
            // Btn_createNew
            // 
            this.Btn_createNew.Location = new System.Drawing.Point(680, 254);
            this.Btn_createNew.Name = "Btn_createNew";
            this.Btn_createNew.Size = new System.Drawing.Size(106, 23);
            this.Btn_createNew.TabIndex = 14;
            this.Btn_createNew.Text = "Create new";
            this.Btn_createNew.UseVisualStyleBackColor = true;
            this.Btn_createNew.Click += new System.EventHandler(this.Btn_createNew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtBox_description);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txtbox_activitieName);
            this.groupBox1.Location = new System.Drawing.Point(416, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 221);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create new activitie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // TxtBox_description
            // 
            this.TxtBox_description.Location = new System.Drawing.Point(86, 93);
            this.TxtBox_description.Multiline = true;
            this.TxtBox_description.Name = "TxtBox_description";
            this.TxtBox_description.Size = new System.Drawing.Size(253, 118);
            this.TxtBox_description.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Activitie name";
            // 
            // Txtbox_activitieName
            // 
            this.Txtbox_activitieName.Location = new System.Drawing.Point(86, 58);
            this.Txtbox_activitieName.Name = "Txtbox_activitieName";
            this.Txtbox_activitieName.Size = new System.Drawing.Size(174, 20);
            this.Txtbox_activitieName.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(400, 269);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AdminHandleActicites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.Activites);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_edit);
            this.Controls.Add(this.Btn_previous);
            this.Controls.Add(this.Btn_createNew);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminHandleActicites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Handle Acticites";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Activites;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_edit;
        private System.Windows.Forms.Button Btn_previous;
        private System.Windows.Forms.Button Btn_createNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBox_description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtbox_activitieName;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}