
namespace GUI
{
    partial class Form1
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.settingsButton = new MetroFramework.Controls.MetroTile();
            this.ScanButton = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(32, 63);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(303, 282);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(536, 217);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(128, 128);
            this.metroTile4.TabIndex = 5;
            this.metroTile4.TileImage = global::GUI.Properties.Resources.close_96;
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseTileImage = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(700, 135);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(128, 128);
            this.metroTile3.TabIndex = 4;
            this.metroTile3.TileImage = global::GUI.Properties.Resources.reload_96;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(536, 63);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(128, 128);
            this.metroTile2.TabIndex = 3;
            this.metroTile2.TileImage = global::GUI.Properties.Resources.safe_96;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            // 
            // settingsButton
            // 
            this.settingsButton.ActiveControl = null;
            this.settingsButton.Location = new System.Drawing.Point(384, 217);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(128, 128);
            this.settingsButton.TabIndex = 2;
            this.settingsButton.TileImage = global::GUI.Properties.Resources.settings_96;
            this.settingsButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingsButton.UseSelectable = true;
            this.settingsButton.UseTileImage = true;
            // 
            // ScanButton
            // 
            this.ScanButton.ActiveControl = null;
            this.ScanButton.Location = new System.Drawing.Point(384, 63);
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Size = new System.Drawing.Size(128, 128);
            this.ScanButton.TabIndex = 1;
            this.ScanButton.TileImage = global::GUI.Properties.Resources.search_96;
            this.ScanButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ScanButton.UseSelectable = true;
            this.ScanButton.UseTileImage = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 397);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.ScanButton);
            this.Controls.Add(this.metroTile1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile ScanButton;
        private MetroFramework.Controls.MetroTile settingsButton;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
    }
}

