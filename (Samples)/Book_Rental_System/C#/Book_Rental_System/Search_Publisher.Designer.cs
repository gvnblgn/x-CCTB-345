﻿namespace Book_Rental_System
{
    partial class Search_Publisher
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAll_Records = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPublisher_ID = new System.Windows.Forms.TextBox();
            this.lblPublisher_ID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Book_Rental_System.Properties.Resources.Search;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(482, 51);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAll_Records);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtPublisher_ID);
            this.panel1.Controls.Add(this.lblPublisher_ID);
            this.panel1.Location = new System.Drawing.Point(73, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 96);
            this.panel1.TabIndex = 3;
            // 
            // btnAll_Records
            // 
            this.btnAll_Records.Location = new System.Drawing.Point(120, 62);
            this.btnAll_Records.Name = "btnAll_Records";
            this.btnAll_Records.Size = new System.Drawing.Size(75, 23);
            this.btnAll_Records.TabIndex = 5;
            this.btnAll_Records.Text = "All Records";
            this.btnAll_Records.UseVisualStyleBackColor = true;
            this.btnAll_Records.Click += new System.EventHandler(this.btnAll_Records_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(221, 62);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(16, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPublisher_ID
            // 
            this.txtPublisher_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPublisher_ID.Location = new System.Drawing.Point(131, 17);
            this.txtPublisher_ID.Name = "txtPublisher_ID";
            this.txtPublisher_ID.Size = new System.Drawing.Size(165, 20);
            this.txtPublisher_ID.TabIndex = 1;
            // 
            // lblPublisher_ID
            // 
            this.lblPublisher_ID.AutoSize = true;
            this.lblPublisher_ID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher_ID.Location = new System.Drawing.Point(12, 17);
            this.lblPublisher_ID.Name = "lblPublisher_ID";
            this.lblPublisher_ID.Size = new System.Drawing.Size(87, 19);
            this.lblPublisher_ID.TabIndex = 0;
            this.lblPublisher_ID.Text = "Publisher ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 301);
            this.dataGridView1.TabIndex = 4;
            // 
            // Search_Publisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 488);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.Name = "Search_Publisher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search_Publisher";
            this.Load += new System.EventHandler(this.Search_Publisher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPublisher_ID;
        private System.Windows.Forms.Label lblPublisher_ID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAll_Records;

    }
}