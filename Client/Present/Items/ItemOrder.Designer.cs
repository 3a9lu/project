namespace Client.Present.Items
{
    partial class ItemOrder
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabelOrderNumber = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabelOrderStatus = new MaterialSkin.Controls.MaterialLabel();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeaderName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDescription = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPrice = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderCount = new System.Windows.Forms.ColumnHeader();
            this.materialLabelTotal = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelDate = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonPay = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabelOrderNumber
            // 
            this.materialLabelOrderNumber.AutoSize = true;
            this.materialLabelOrderNumber.Depth = 0;
            this.materialLabelOrderNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelOrderNumber.Location = new System.Drawing.Point(3, 19);
            this.materialLabelOrderNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelOrderNumber.Name = "materialLabelOrderNumber";
            this.materialLabelOrderNumber.Size = new System.Drawing.Size(83, 19);
            this.materialLabelOrderNumber.TabIndex = 0;
            this.materialLabelOrderNumber.Text = "Заказ №: 1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 15);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ImageLocation = "C:\\Users\\TheHa\\source\\repos\\BmxShopService\\Client\\Present\\images\\delete.png";
            this.pictureBox1.Location = new System.Drawing.Point(1041, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // materialLabelOrderStatus
            // 
            this.materialLabelOrderStatus.AutoSize = true;
            this.materialLabelOrderStatus.Depth = 0;
            this.materialLabelOrderStatus.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelOrderStatus.Location = new System.Drawing.Point(798, 81);
            this.materialLabelOrderStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelOrderStatus.Name = "materialLabelOrderStatus";
            this.materialLabelOrderStatus.Size = new System.Drawing.Size(180, 19);
            this.materialLabelOrderStatus.TabIndex = 4;
            this.materialLabelOrderStatus.Text = "Статус заказа: Оплачен";
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderDescription,
            this.columnHeaderPrice,
            this.columnHeaderCount});
            this.materialListView1.Depth = 0;
            this.materialListView1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.Location = new System.Drawing.Point(27, 48);
            this.materialListView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialListView1.MinimumSize = new System.Drawing.Size(229, 133);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(686, 167);
            this.materialListView1.TabIndex = 5;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            this.materialListView1.SelectedIndexChanged += new System.EventHandler(this.materialListView1_SelectedIndexChanged);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Название";
            this.columnHeaderName.Width = 210;
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Tag = "";
            this.columnHeaderDescription.Text = "Описание";
            this.columnHeaderDescription.Width = 290;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Цена";
            this.columnHeaderPrice.Width = 80;
            // 
            // columnHeaderCount
            // 
            this.columnHeaderCount.Text = "Кол-во";
            this.columnHeaderCount.Width = 80;
            // 
            // materialLabelTotal
            // 
            this.materialLabelTotal.AutoSize = true;
            this.materialLabelTotal.Depth = 0;
            this.materialLabelTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelTotal.Location = new System.Drawing.Point(798, 116);
            this.materialLabelTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelTotal.Name = "materialLabelTotal";
            this.materialLabelTotal.Size = new System.Drawing.Size(98, 19);
            this.materialLabelTotal.TabIndex = 6;
            this.materialLabelTotal.Text = "Сумма: 500₽";
            // 
            // materialLabelDate
            // 
            this.materialLabelDate.AutoSize = true;
            this.materialLabelDate.Depth = 0;
            this.materialLabelDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelDate.Location = new System.Drawing.Point(798, 48);
            this.materialLabelDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelDate.Name = "materialLabelDate";
            this.materialLabelDate.Size = new System.Drawing.Size(127, 19);
            this.materialLabelDate.TabIndex = 7;
            this.materialLabelDate.Text = "Дата: 12.12.2022";
            // 
            // materialButtonPay
            // 
            this.materialButtonPay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonPay.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonPay.Depth = 0;
            this.materialButtonPay.HighEmphasis = true;
            this.materialButtonPay.Icon = null;
            this.materialButtonPay.Location = new System.Drawing.Point(798, 166);
            this.materialButtonPay.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.materialButtonPay.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonPay.Name = "materialButtonPay";
            this.materialButtonPay.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonPay.Size = new System.Drawing.Size(100, 36);
            this.materialButtonPay.TabIndex = 8;
            this.materialButtonPay.Text = "Оплатить";
            this.materialButtonPay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonPay.UseAccentColor = false;
            this.materialButtonPay.UseVisualStyleBackColor = true;
            this.materialButtonPay.Click += new System.EventHandler(this.materialButtonPay_Click);
            // 
            // ItemOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.materialButtonPay);
            this.Controls.Add(this.materialLabelDate);
            this.Controls.Add(this.materialLabelTotal);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.materialLabelOrderStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialLabelOrderNumber);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ItemOrder";
            this.Size = new System.Drawing.Size(1078, 231);
            this.Load += new System.EventHandler(this.ItemOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabelOrderNumber;
        private Panel panel1;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabelOrderStatus;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderDescription;
        private ColumnHeader columnHeaderPrice;
        private ColumnHeader columnHeaderCount;
        private MaterialSkin.Controls.MaterialLabel materialLabelTotal;
        private MaterialSkin.Controls.MaterialLabel materialLabelDate;
        private MaterialSkin.Controls.MaterialButton materialButtonPay;
    }
}
