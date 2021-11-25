namespace ClearObjectTest
{
    partial class DetailForm
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
            this.olvDetail = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.bClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.olvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // olvDetail
            // 
            this.olvDetail.AllColumns.Add(this.olvColumn1);
            this.olvDetail.AllColumns.Add(this.olvColumn2);
            this.olvDetail.CellEditUseWholeCell = false;
            this.olvDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2});
            this.olvDetail.FullRowSelect = true;
            this.olvDetail.HideSelection = false;
            this.olvDetail.Location = new System.Drawing.Point(12, 12);
            this.olvDetail.Name = "olvDetail";
            this.olvDetail.ShowGroups = false;
            this.olvDetail.Size = new System.Drawing.Size(451, 262);
            this.olvDetail.TabIndex = 9;
            this.olvDetail.UseCompatibleStateImageBehavior = false;
            this.olvDetail.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Id";
            this.olvColumn1.Text = "ID";
            this.olvColumn1.Width = 80;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Name";
            this.olvColumn2.Text = "Name";
            this.olvColumn2.Width = 120;
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(486, 23);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 10;
            this.bClose.Text = "&Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 297);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.olvDetail);
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.olvDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvDetail;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private System.Windows.Forms.Button bClose;
    }
}