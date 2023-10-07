namespace AlkalmazasFejlesztes_projekt
{
    partial class SajatSzamosOldal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SajatSzamosOldal));
            this.button1 = new System.Windows.Forms.Button();
            this.lottoryTable = new System.Windows.Forms.TableLayoutPanel();
            this.sorsolasButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(87, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 89);
            this.button1.TabIndex = 5;
            this.button1.Text = "Vissza";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.lottoryTable.Location = new System.Drawing.Point(416, 34);
            this.lottoryTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lottoryTable.Name = "lottoryTable";
            this.lottoryTable.RowCount = 9;
            this.lottoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.97574F));
            this.lottoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.97574F));
            this.lottoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.97574F));
            this.lottoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.97574F));
            this.lottoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.97574F));
            this.lottoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.97574F));
            this.lottoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.97574F));
            this.lottoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.97574F));
            this.lottoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.19405F));
            this.lottoryTable.Size = new System.Drawing.Size(669, 612);
            this.lottoryTable.TabIndex = 6;
            // 
            // sorsolasButton
            // 
            this.sorsolasButton.Location = new System.Drawing.Point(171, 177);
            this.sorsolasButton.Name = "sorsolasButton";
            this.sorsolasButton.Size = new System.Drawing.Size(90, 54);
            this.sorsolasButton.TabIndex = 7;
            this.sorsolasButton.Text = "button2";
            this.sorsolasButton.UseVisualStyleBackColor = true;
            this.sorsolasButton.Click += new System.EventHandler(this.sorsolasButton_Click);
            // 
            // SajatSzamosOldal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1137, 689);
            this.Controls.Add(this.sorsolasButton);
            this.Controls.Add(this.lottoryTable);
            this.Controls.Add(this.button1);
            this.Name = "SajatSzamosOldal";
            this.Text = "Sajatszamos";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel lottoryTable;
        private System.Windows.Forms.Button sorsolasButton;
    }
}