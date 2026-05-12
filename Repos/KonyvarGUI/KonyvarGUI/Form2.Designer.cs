namespace KonyvarGUI
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.TitleTextbox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReleaseTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BekuldBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.mentesText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cím";
            // 
            // TitleTextbox
            // 
            this.TitleTextbox.Location = new System.Drawing.Point(25, 50);
            this.TitleTextbox.Name = "TitleTextbox";
            this.TitleTextbox.Size = new System.Drawing.Size(192, 22);
            this.TitleTextbox.TabIndex = 1;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(25, 110);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(192, 22);
            this.AuthorTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Szerző";
            // 
            // ReleaseTextBox
            // 
            this.ReleaseTextBox.Location = new System.Drawing.Point(25, 168);
            this.ReleaseTextBox.Name = "ReleaseTextBox";
            this.ReleaseTextBox.Size = new System.Drawing.Size(192, 22);
            this.ReleaseTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Megjelenés";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(25, 231);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(192, 22);
            this.PriceTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ár (Ft)";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(25, 293);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(192, 22);
            this.GenreTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Műfaj";
            // 
            // BekuldBTN
            // 
            this.BekuldBTN.Location = new System.Drawing.Point(25, 369);
            this.BekuldBTN.Name = "BekuldBTN";
            this.BekuldBTN.Size = new System.Drawing.Size(192, 51);
            this.BekuldBTN.TabIndex = 10;
            this.BekuldBTN.Text = "Beküldés";
            this.BekuldBTN.UseVisualStyleBackColor = true;
            this.BekuldBTN.Click += new System.EventHandler(this.BekuldBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(242, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(546, 317);
            this.dataGridView1.TabIndex = 11;
            // 
            // SaveBTN
            // 
            this.SaveBTN.Location = new System.Drawing.Point(596, 369);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(192, 51);
            this.SaveBTN.TabIndex = 12;
            this.SaveBTN.Text = "Mentés";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // mentesText
            // 
            this.mentesText.AutoSize = true;
            this.mentesText.Location = new System.Drawing.Point(320, 386);
            this.mentesText.Name = "mentesText";
            this.mentesText.Size = new System.Drawing.Size(0, 16);
            this.mentesText.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mentesText);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BekuldBTN);
            this.Controls.Add(this.GenreTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReleaseTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleTextbox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ReleaseTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BekuldBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Label mentesText;
    }
}