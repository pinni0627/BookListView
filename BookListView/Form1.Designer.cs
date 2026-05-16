namespace BookListView
{
    partial class frmBooks
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooks));
            this.pnlTools = new System.Windows.Forms.Panel();
            this.grpView = new System.Windows.Forms.GroupBox();
            this.grpBorrow = new System.Windows.Forms.GroupBox();
            this.lstBorrow = new System.Windows.Forms.ListBox();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.ImgL = new System.Windows.Forms.ImageList(this.components);
            this.ImgS = new System.Windows.Forms.ImageList(this.components);
            this.lvwBooks = new System.Windows.Forms.ListView();
            this.pnlTools.SuspendLayout();
            this.grpView.SuspendLayout();
            this.grpBorrow.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTools
            // 
            this.pnlTools.Controls.Add(this.grpBorrow);
            this.pnlTools.Controls.Add(this.grpView);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTools.Location = new System.Drawing.Point(547, 0);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(253, 450);
            this.pnlTools.TabIndex = 0;
            // 
            // grpView
            // 
            this.grpView.Controls.Add(this.cmbView);
            this.grpView.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpView.Location = new System.Drawing.Point(0, 0);
            this.grpView.Name = "grpView";
            this.grpView.Size = new System.Drawing.Size(253, 82);
            this.grpView.TabIndex = 1;
            this.grpView.TabStop = false;
            this.grpView.Text = "檢視方式：";
            // 
            // grpBorrow
            // 
            this.grpBorrow.Controls.Add(this.lstBorrow);
            this.grpBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBorrow.Location = new System.Drawing.Point(0, 82);
            this.grpBorrow.Name = "grpBorrow";
            this.grpBorrow.Size = new System.Drawing.Size(253, 368);
            this.grpBorrow.TabIndex = 0;
            this.grpBorrow.TabStop = false;
            this.grpBorrow.Text = "借書清單：";
            // 
            // lstBorrow
            // 
            this.lstBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBorrow.FormattingEnabled = true;
            this.lstBorrow.ItemHeight = 15;
            this.lstBorrow.Location = new System.Drawing.Point(3, 21);
            this.lstBorrow.Name = "lstBorrow";
            this.lstBorrow.Size = new System.Drawing.Size(247, 344);
            this.lstBorrow.TabIndex = 1;
            // 
            // cmbView
            // 
            this.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Location = new System.Drawing.Point(9, 36);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(240, 23);
            this.cmbView.TabIndex = 0;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // ImgL
            // 
            this.ImgL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgL.ImageStream")));
            this.ImgL.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgL.Images.SetKeyName(0, "Book1.bmp");
            this.ImgL.Images.SetKeyName(1, "Book2.bmp");
            this.ImgL.Images.SetKeyName(2, "Book3.bmp");
            this.ImgL.Images.SetKeyName(3, "Book4.bmp");
            this.ImgL.Images.SetKeyName(4, "Book5.bmp");
            this.ImgL.Images.SetKeyName(5, "Book6.bmp");
            this.ImgL.Images.SetKeyName(6, "Book7.bmp");
            this.ImgL.Images.SetKeyName(7, "Book8.bmp");
            // 
            // ImgS
            // 
            this.ImgS.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgS.ImageStream")));
            this.ImgS.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgS.Images.SetKeyName(0, "Book1.bmp");
            this.ImgS.Images.SetKeyName(1, "Book2.bmp");
            this.ImgS.Images.SetKeyName(2, "Book3.bmp");
            this.ImgS.Images.SetKeyName(3, "Book4.bmp");
            this.ImgS.Images.SetKeyName(4, "Book5.bmp");
            this.ImgS.Images.SetKeyName(5, "Book6.bmp");
            this.ImgS.Images.SetKeyName(6, "Book7.bmp");
            this.ImgS.Images.SetKeyName(7, "Book8.bmp");
            // 
            // lvwBooks
            // 
            this.lvwBooks.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvwBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwBooks.HideSelection = false;
            this.lvwBooks.LargeImageList = this.ImgL;
            this.lvwBooks.Location = new System.Drawing.Point(0, 0);
            this.lvwBooks.Name = "lvwBooks";
            this.lvwBooks.Size = new System.Drawing.Size(547, 450);
            this.lvwBooks.SmallImageList = this.ImgS;
            this.lvwBooks.TabIndex = 1;
            this.lvwBooks.UseCompatibleStateImageBehavior = false;
            this.lvwBooks.ItemActivate += new System.EventHandler(this.lvwBooks_ItemActivate);
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvwBooks);
            this.Controls.Add(this.pnlTools);
            this.Name = "frmBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "圖書管理";
            this.Load += new System.EventHandler(this.frmBooks_Load);
            this.pnlTools.ResumeLayout(false);
            this.grpView.ResumeLayout(false);
            this.grpBorrow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.GroupBox grpBorrow;
        private System.Windows.Forms.GroupBox grpView;
        private System.Windows.Forms.ListBox lstBorrow;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.ImageList ImgL;
        private System.Windows.Forms.ImageList ImgS;
        private System.Windows.Forms.ListView lvwBooks;
    }
}

