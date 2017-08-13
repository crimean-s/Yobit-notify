namespace Yobit_notify
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.listBoxValutes = new System.Windows.Forms.ListBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelFavorite = new System.Windows.Forms.Panel();
            this.listBoxFavorites = new System.Windows.Forms.ListBox();
            this.panelLeft.SuspendLayout();
            this.panelFavorite.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.listBoxValutes);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.MinimumSize = new System.Drawing.Size(100, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(100, 461);
            this.panelLeft.TabIndex = 0;
            // 
            // listBoxValutes
            // 
            this.listBoxValutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxValutes.FormattingEnabled = true;
            this.listBoxValutes.Location = new System.Drawing.Point(0, 0);
            this.listBoxValutes.MinimumSize = new System.Drawing.Size(200, 4);
            this.listBoxValutes.Name = "listBoxValutes";
            this.listBoxValutes.Size = new System.Drawing.Size(200, 461);
            this.listBoxValutes.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(100, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1023, 461);
            this.panelMain.TabIndex = 1;
            // 
            // panelFavorite
            // 
            this.panelFavorite.Controls.Add(this.listBoxFavorites);
            this.panelFavorite.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFavorite.Location = new System.Drawing.Point(100, 0);
            this.panelFavorite.Name = "panelFavorite";
            this.panelFavorite.Size = new System.Drawing.Size(200, 461);
            this.panelFavorite.TabIndex = 2;
            // 
            // listBoxFavorites
            // 
            this.listBoxFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFavorites.FormattingEnabled = true;
            this.listBoxFavorites.Location = new System.Drawing.Point(0, 0);
            this.listBoxFavorites.Name = "listBoxFavorites";
            this.listBoxFavorites.Size = new System.Drawing.Size(200, 461);
            this.listBoxFavorites.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 461);
            this.Controls.Add(this.panelFavorite);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelLeft);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.Text = "Yobit Notify";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelFavorite.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.ListBox listBoxValutes;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelFavorite;
        private System.Windows.Forms.ListBox listBoxFavorites;
    }
}

