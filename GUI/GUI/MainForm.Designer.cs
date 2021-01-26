
namespace GUI
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ExceptionsButton = new MetroFramework.Controls.MetroTile();
            this.UpdateButton = new MetroFramework.Controls.MetroTile();
            this.QuarantineButton = new MetroFramework.Controls.MetroTile();
            this.settingsButton = new MetroFramework.Controls.MetroTile();
            this.ScanButton = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroListView2 = new MetroFramework.Controls.MetroListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Controls.Add(this.tabPage4);
            this.TabControl.Controls.Add(this.tabPage5);
            this.TabControl.Controls.Add(this.tabPage6);
            this.TabControl.Location = new System.Drawing.Point(2, 29);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(904, 396);
            this.TabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.Controls.Add(this.ExceptionsButton);
            this.tabPage1.Controls.Add(this.UpdateButton);
            this.tabPage1.Controls.Add(this.QuarantineButton);
            this.tabPage1.Controls.Add(this.settingsButton);
            this.tabPage1.Controls.Add(this.ScanButton);
            this.tabPage1.Controls.Add(this.metroTile1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(896, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "page_main";
            // 
            // ExceptionsButton
            // 
            this.ExceptionsButton.ActiveControl = null;
            this.ExceptionsButton.Location = new System.Drawing.Point(515, 158);
            this.ExceptionsButton.Name = "ExceptionsButton";
            this.ExceptionsButton.Size = new System.Drawing.Size(128, 151);
            this.ExceptionsButton.TabIndex = 17;
            this.ExceptionsButton.Text = "ИСКЛЮЧЕНИЯ";
            this.ExceptionsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExceptionsButton.TileImage = global::GUI.Properties.Resources.close_96;
            this.ExceptionsButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExceptionsButton.UseSelectable = true;
            this.ExceptionsButton.UseTileImage = true;
            this.ExceptionsButton.Click += new System.EventHandler(this.ExceptionsButton_Click_1);
            // 
            // UpdateButton
            // 
            this.UpdateButton.ActiveControl = null;
            this.UpdateButton.Location = new System.Drawing.Point(677, 76);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(168, 168);
            this.UpdateButton.TabIndex = 16;
            this.UpdateButton.Text = "ОБНОВЛЕНИЯ";
            this.UpdateButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UpdateButton.TileImage = global::GUI.Properties.Resources.reload_96;
            this.UpdateButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateButton.UseSelectable = true;
            this.UpdateButton.UseTileImage = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click_1);
            // 
            // QuarantineButton
            // 
            this.QuarantineButton.ActiveControl = null;
            this.QuarantineButton.Location = new System.Drawing.Point(515, 9);
            this.QuarantineButton.Name = "QuarantineButton";
            this.QuarantineButton.Size = new System.Drawing.Size(128, 143);
            this.QuarantineButton.TabIndex = 15;
            this.QuarantineButton.Text = "КАРАНТИН";
            this.QuarantineButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.QuarantineButton.TileImage = global::GUI.Properties.Resources.safe_96;
            this.QuarantineButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.QuarantineButton.UseSelectable = true;
            this.QuarantineButton.UseTileImage = true;
            this.QuarantineButton.Click += new System.EventHandler(this.QuarantineButton_Click_1);
            // 
            // settingsButton
            // 
            this.settingsButton.ActiveControl = null;
            this.settingsButton.Location = new System.Drawing.Point(366, 158);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(128, 151);
            this.settingsButton.TabIndex = 14;
            this.settingsButton.Text = "НАСТРОЙКИ";
            this.settingsButton.TileImage = global::GUI.Properties.Resources.settings_96;
            this.settingsButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingsButton.UseSelectable = true;
            this.settingsButton.UseTileImage = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click_1);
            // 
            // ScanButton
            // 
            this.ScanButton.ActiveControl = null;
            this.ScanButton.Location = new System.Drawing.Point(366, 9);
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Size = new System.Drawing.Size(128, 143);
            this.ScanButton.TabIndex = 13;
            this.ScanButton.Text = "СКАНИРОВАНИЕ";
            this.ScanButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ScanButton.TileImage = global::GUI.Properties.Resources.search_96;
            this.ScanButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ScanButton.UseSelectable = true;
            this.ScanButton.UseTileImage = true;
            this.ScanButton.Click += new System.EventHandler(this.ScanButton_Click_2);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(14, 9);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(320, 300);
            this.metroTile1.TabIndex = 12;
            this.metroTile1.Text = "ЗАЩИТА АКТИВНА";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImage = global::GUI.Properties.Resources.iconfinder_securityprotectlockshield04_4021479_1131371;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(896, 370);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "page_scan";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(896, 370);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "page_settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(896, 370);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "page_quarantine";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.metroListView2);
            this.tabPage5.Controls.Add(this.metroLabel3);
            this.tabPage5.Controls.Add(this.metroListView1);
            this.tabPage5.Controls.Add(this.metroLabel2);
            this.tabPage5.Controls.Add(this.metroLabel1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(896, 370);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "page_exceptions";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(896, 370);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "page_update";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(17, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(112, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Исключения";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(66, 38);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(165, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Исключаемые пути";
            // 
            // metroListView1
            // 
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(66, 66);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(732, 138);
            this.metroListView1.TabIndex = 2;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "№";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Путь";
            this.columnHeader2.Width = 667;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(66, 207);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(181, 25);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Исключаемые файлы";
            // 
            // metroListView2
            // 
            this.metroListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.metroListView2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView2.FullRowSelect = true;
            this.metroListView2.Location = new System.Drawing.Point(66, 235);
            this.metroListView2.Name = "metroListView2";
            this.metroListView2.OwnerDraw = true;
            this.metroListView2.Size = new System.Drawing.Size(732, 132);
            this.metroListView2.TabIndex = 4;
            this.metroListView2.UseCompatibleStateImageBehavior = false;
            this.metroListView2.UseSelectable = true;
            this.metroListView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "№";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Файл";
            this.columnHeader4.Width = 667;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 424);
            this.Controls.Add(this.TabControl);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private MetroFramework.Controls.MetroTile ExceptionsButton;
        private MetroFramework.Controls.MetroTile UpdateButton;
        private MetroFramework.Controls.MetroTile QuarantineButton;
        private MetroFramework.Controls.MetroTile settingsButton;
        private MetroFramework.Controls.MetroTile ScanButton;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private MetroFramework.Controls.MetroListView metroListView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

