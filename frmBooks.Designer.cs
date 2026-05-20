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
            this.grpBorrow = new System.Windows.Forms.GroupBox();
            this.lstBorrow = new System.Windows.Forms.ListBox();
            this.grpView = new System.Windows.Forms.GroupBox();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.imgL = new System.Windows.Forms.ImageList(this.components);
            this.imgS = new System.Windows.Forms.ImageList(this.components);
            this.pnlView = new System.Windows.Forms.Panel();
            this.lvwBooks = new System.Windows.Forms.ListView();
            this.pnlTools.SuspendLayout();
            this.grpBorrow.SuspendLayout();
            this.grpView.SuspendLayout();
            this.pnlView.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTools
            // 
            this.pnlTools.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlTools.Controls.Add(this.grpBorrow);
            this.pnlTools.Controls.Add(this.grpView);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTools.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pnlTools.Location = new System.Drawing.Point(447, 5);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(200, 490);
            this.pnlTools.TabIndex = 0;
            // 
            // grpBorrow
            // 
            this.grpBorrow.BackColor = System.Drawing.Color.LightSkyBlue;
            this.grpBorrow.Controls.Add(this.lstBorrow);
            this.grpBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBorrow.ForeColor = System.Drawing.SystemColors.Control;
            this.grpBorrow.Location = new System.Drawing.Point(0, 70);
            this.grpBorrow.Name = "grpBorrow";
            this.grpBorrow.Padding = new System.Windows.Forms.Padding(5);
            this.grpBorrow.Size = new System.Drawing.Size(200, 420);
            this.grpBorrow.TabIndex = 1;
            this.grpBorrow.TabStop = false;
            this.grpBorrow.Text = "借書清單";
            // 
            // lstBorrow
            // 
            this.lstBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBorrow.FormattingEnabled = true;
            this.lstBorrow.ItemHeight = 21;
            this.lstBorrow.Location = new System.Drawing.Point(5, 27);
            this.lstBorrow.Name = "lstBorrow";
            this.lstBorrow.Size = new System.Drawing.Size(190, 388);
            this.lstBorrow.TabIndex = 0;
            // 
            // grpView
            // 
            this.grpView.BackColor = System.Drawing.Color.LightSkyBlue;
            this.grpView.Controls.Add(this.cmbView);
            this.grpView.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpView.ForeColor = System.Drawing.SystemColors.Control;
            this.grpView.Location = new System.Drawing.Point(0, 0);
            this.grpView.Name = "grpView";
            this.grpView.Size = new System.Drawing.Size(200, 70);
            this.grpView.TabIndex = 0;
            this.grpView.TabStop = false;
            this.grpView.Text = "檢視方式";
            // 
            // cmbView
            // 
            this.cmbView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Location = new System.Drawing.Point(6, 28);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(188, 29);
            this.cmbView.TabIndex = 0;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // imgL
            // 
            this.imgL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgL.ImageStream")));
            this.imgL.TransparentColor = System.Drawing.Color.Transparent;
            this.imgL.Images.SetKeyName(0, "Book1.jpg");
            this.imgL.Images.SetKeyName(1, "Book2.jpg");
            this.imgL.Images.SetKeyName(2, "Book3.jpg");
            this.imgL.Images.SetKeyName(3, "Book4.jpg");
            this.imgL.Images.SetKeyName(4, "Book5.jpg");
            this.imgL.Images.SetKeyName(5, "Book6.jpg");
            this.imgL.Images.SetKeyName(6, "Book7.jpg");
            this.imgL.Images.SetKeyName(7, "Book8.jpg");
            // 
            // imgS
            // 
            this.imgS.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgS.ImageStream")));
            this.imgS.TransparentColor = System.Drawing.Color.Transparent;
            this.imgS.Images.SetKeyName(0, "Book1.jpg");
            this.imgS.Images.SetKeyName(1, "Book2.jpg");
            this.imgS.Images.SetKeyName(2, "Book3.jpg");
            this.imgS.Images.SetKeyName(3, "Book4.jpg");
            this.imgS.Images.SetKeyName(4, "Book5.jpg");
            this.imgS.Images.SetKeyName(5, "Book6.jpg");
            this.imgS.Images.SetKeyName(6, "Book7.jpg");
            this.imgS.Images.SetKeyName(7, "Book8.jpg");
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlView.Controls.Add(this.lvwBooks);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pnlView.Location = new System.Drawing.Point(5, 5);
            this.pnlView.Name = "pnlView";
            this.pnlView.Padding = new System.Windows.Forms.Padding(5);
            this.pnlView.Size = new System.Drawing.Size(442, 490);
            this.pnlView.TabIndex = 2;
            // 
            // lvwBooks
            // 
            this.lvwBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwBooks.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lvwBooks.HideSelection = false;
            this.lvwBooks.LargeImageList = this.imgL;
            this.lvwBooks.Location = new System.Drawing.Point(5, 5);
            this.lvwBooks.Name = "lvwBooks";
            this.lvwBooks.Size = new System.Drawing.Size(432, 480);
            this.lvwBooks.SmallImageList = this.imgS;
            this.lvwBooks.TabIndex = 4;
            this.lvwBooks.UseCompatibleStateImageBehavior = false;
            this.lvwBooks.ItemActivate += new System.EventHandler(this.lvwBooks_ItemActivate);
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(652, 500);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.pnlTools);
            this.Name = "frmBooks";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "圖書管理程式";
            this.Load += new System.EventHandler(this.frmBooks_Load);
            this.pnlTools.ResumeLayout(false);
            this.grpBorrow.ResumeLayout(false);
            this.grpView.ResumeLayout(false);
            this.pnlView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.GroupBox grpView;
        private System.Windows.Forms.GroupBox grpBorrow;
        private System.Windows.Forms.ListBox lstBorrow;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.ImageList imgL;
        private System.Windows.Forms.ImageList imgS;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.ListView lvwBooks;
    }
}

