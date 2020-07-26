namespace Ex3
{
    partial class SalesViewer
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
            this.salesList = new System.Windows.Forms.ComboBox();
            this.closeForm = new System.Windows.Forms.Button();
            this.salesGridView = new System.Windows.Forms.DataGridView();
            this.saveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // salesList
            // 
            this.salesList.FormattingEnabled = true;
            this.salesList.Location = new System.Drawing.Point(354, 378);
            this.salesList.Name = "salesList";
            this.salesList.Size = new System.Drawing.Size(121, 24);
            this.salesList.TabIndex = 0;
            this.salesList.SelectedIndexChanged += new System.EventHandler(this.salesList_SelectedIndexChanged);
            // 
            // closeForm
            // 
            this.closeForm.Location = new System.Drawing.Point(675, 378);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(92, 43);
            this.closeForm.TabIndex = 1;
            this.closeForm.Text = "Закрыть";
            this.closeForm.UseVisualStyleBackColor = true;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // salesGridView
            // 
            this.salesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesGridView.Location = new System.Drawing.Point(90, 12);
            this.salesGridView.Name = "salesGridView";
            this.salesGridView.RowHeadersWidth = 51;
            this.salesGridView.RowTemplate.Height = 24;
            this.salesGridView.Size = new System.Drawing.Size(563, 313);
            this.salesGridView.TabIndex = 2;
            // 
            // saveChanges
            // 
            this.saveChanges.Location = new System.Drawing.Point(66, 368);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(136, 43);
            this.saveChanges.TabIndex = 3;
            this.saveChanges.Text = "Обновить";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // SalesViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.salesGridView);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.salesList);
            this.Name = "SalesViewer";
            this.Text = "Sales Viewer";
            this.Load += new System.EventHandler(this.SalesViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox salesList;
        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.DataGridView salesGridView;
        private System.Windows.Forms.Button saveChanges;
    }
}

