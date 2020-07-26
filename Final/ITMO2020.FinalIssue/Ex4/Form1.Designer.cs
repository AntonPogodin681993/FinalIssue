namespace Ex4
{
    partial class Form1
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
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sizetextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colortextBox = new System.Windows.Forms.TextBox();
            this.showProductbutton = new System.Windows.Forms.Button();
            this.addProductbutton = new System.Windows.Forms.Button();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productGridView
            // 
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(12, 12);
            this.productGridView.Name = "productGridView";
            this.productGridView.RowHeadersWidth = 51;
            this.productGridView.RowTemplate.Height = 24;
            this.productGridView.Size = new System.Drawing.Size(776, 203);
            this.productGridView.TabIndex = 0;
            this.productGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productGridView_CellClick);
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(247, 249);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(136, 22);
            this.nametextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название продукта";
            // 
            // sizetextBox
            // 
            this.sizetextBox.Location = new System.Drawing.Point(247, 296);
            this.sizetextBox.Name = "sizetextBox";
            this.sizetextBox.Size = new System.Drawing.Size(136, 22);
            this.sizetextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Размер ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цвет";
            // 
            // colortextBox
            // 
            this.colortextBox.Location = new System.Drawing.Point(247, 337);
            this.colortextBox.Name = "colortextBox";
            this.colortextBox.Size = new System.Drawing.Size(136, 22);
            this.colortextBox.TabIndex = 6;
            // 
            // showProductbutton
            // 
            this.showProductbutton.Location = new System.Drawing.Point(404, 242);
            this.showProductbutton.Name = "showProductbutton";
            this.showProductbutton.Size = new System.Drawing.Size(121, 71);
            this.showProductbutton.TabIndex = 7;
            this.showProductbutton.Text = "Показать продукты";
            this.showProductbutton.UseVisualStyleBackColor = true;
            this.showProductbutton.Click += new System.EventHandler(this.showProductbutton_Click);
            // 
            // addProductbutton
            // 
            this.addProductbutton.Location = new System.Drawing.Point(531, 242);
            this.addProductbutton.Name = "addProductbutton";
            this.addProductbutton.Size = new System.Drawing.Size(115, 71);
            this.addProductbutton.TabIndex = 8;
            this.addProductbutton.Text = "Добавить продукт";
            this.addProductbutton.UseVisualStyleBackColor = true;
            this.addProductbutton.Click += new System.EventHandler(this.addProductbutton_Click);
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(247, 388);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(136, 22);
            this.IdBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID(толька числовые значения)";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(731, 393);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 17);
            this.labelId.TabIndex = 11;
            this.labelId.Text = "ID";
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(664, 242);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(124, 29);
            this.buttonDel.TabIndex = 12;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(664, 277);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(124, 36);
            this.buttonEdit.TabIndex = 13;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.addProductbutton);
            this.Controls.Add(this.showProductbutton);
            this.Controls.Add(this.colortextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sizetextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.productGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sizetextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox colortextBox;
        private System.Windows.Forms.Button showProductbutton;
        private System.Windows.Forms.Button addProductbutton;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
    }
}

