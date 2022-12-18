
namespace theloailist
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TheLoaiGrid = new System.Windows.Forms.DataGridView();
            this.buttonChangeValueTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TheLoaiGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TheLoaiGrid
            // 
            this.TheLoaiGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TheLoaiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TheLoaiGrid.Location = new System.Drawing.Point(0, 0);
            this.TheLoaiGrid.Name = "TheLoaiGrid";
            this.TheLoaiGrid.RowHeadersWidth = 62;
            this.TheLoaiGrid.RowTemplate.Height = 33;
            this.TheLoaiGrid.Size = new System.Drawing.Size(478, 199);
            this.TheLoaiGrid.TabIndex = 0;
            // 
            // buttonChangeValueTest
            // 
            this.buttonChangeValueTest.Location = new System.Drawing.Point(0, 205);
            this.buttonChangeValueTest.Name = "buttonChangeValueTest";
            this.buttonChangeValueTest.Size = new System.Drawing.Size(177, 34);
            this.buttonChangeValueTest.TabIndex = 1;
            this.buttonChangeValueTest.Text = "ChangeValueTest";
            this.buttonChangeValueTest.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.buttonChangeValueTest);
            this.Controls.Add(this.TheLoaiGrid);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.TheLoaiGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TheLoaiGrid;
        private System.Windows.Forms.Button buttonChangeValueTest;
    }
}

