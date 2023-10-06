namespace AlkalmazasFejlesztes_projekt
{
    partial class VeletlenSzamosOldal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeletlenSzamosOldal));
            this.randomSzamok = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lottoryTable = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // randomSzamok
            // 
            this.randomSzamok.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.randomSzamok.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.randomSzamok.Location = new System.Drawing.Point(141, 12);
            this.randomSzamok.Name = "randomSzamok";
            this.randomSzamok.Size = new System.Drawing.Size(153, 76);
            this.randomSzamok.TabIndex = 1;
            this.randomSzamok.Text = "Random számok";
            this.randomSzamok.UseVisualStyleBackColor = false;
            this.randomSzamok.Click += new System.EventHandler(this.Veletlengeneralas);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(52, 333);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Vissza";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lottoryTable
            // 
            this.lottoryTable.BackColor = System.Drawing.Color.PeachPuff;
            this.lottoryTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.lottoryTable.ColumnCount = 10;
            this.lottoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lottoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lottoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lottoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lottoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lottoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lottoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lottoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lottoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lottoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lottoryTable.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lottoryTable.Location = new System.Drawing.Point(365, 36);
            this.lottoryTable.Name = "lottoryTable";
            this.lottoryTable.RowCount = 9;
            this.lottoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.97574F));
            this.lottoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.97574F));
            this.lottoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.11905F));
            this.lottoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.30952F));
            this.lottoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.97574F));
            this.lottoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.97574F));
            this.lottoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.97574F));
            this.lottoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.97574F));
            this.lottoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.19405F));
            this.lottoryTable.Size = new System.Drawing.Size(359, 338);
            this.lottoryTable.TabIndex = 0;
            // 
            // VeletlenSzamosOldal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(758, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.randomSzamok);
            this.Controls.Add(this.lottoryTable);
            this.Name = "VeletlenSzamosOldal";
            this.Text = "Veletlenszamos";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button randomSzamok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel lottoryTable;
    }
}