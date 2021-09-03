
namespace Assignment_2_Q1
{
    partial class Innings_Information
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
            this.rtb1_II = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb1_II = new System.Windows.Forms.Label();
            this.btn1_II = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb1_II
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.rtb1_II, 2);
            this.rtb1_II.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb1_II.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb1_II.Location = new System.Drawing.Point(3, 82);
            this.rtb1_II.Name = "rtb1_II";
            this.rtb1_II.Size = new System.Drawing.Size(1071, 562);
            this.rtb1_II.TabIndex = 0;
            this.rtb1_II.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rtb1_II, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb1_II, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn1_II, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.22159F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.68182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.096591F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1077, 704);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lb1_II
            // 
            this.lb1_II.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb1_II.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lb1_II, 2);
            this.lb1_II.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1_II.Location = new System.Drawing.Point(3, 0);
            this.lb1_II.Name = "lb1_II";
            this.lb1_II.Size = new System.Drawing.Size(1071, 79);
            this.lb1_II.TabIndex = 1;
            this.lb1_II.Text = "Innings Information";
            this.lb1_II.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn1_II
            // 
            this.btn1_II.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.btn1_II, 2);
            this.btn1_II.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1_II.Location = new System.Drawing.Point(3, 650);
            this.btn1_II.Name = "btn1_II";
            this.btn1_II.Size = new System.Drawing.Size(1071, 51);
            this.btn1_II.TabIndex = 2;
            this.btn1_II.Text = "OK";
            this.btn1_II.UseVisualStyleBackColor = true;
            this.btn1_II.Click += new System.EventHandler(this.button1_Click);
            // 
            // Innings_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1079, 707);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Innings_Information";
            this.Text = "Innings Information";
            this.Load += new System.EventHandler(this.Innings_Information_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb1_II;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb1_II;
        private System.Windows.Forms.Button btn1_II;
    }
}