using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;
using Tulpep.NotificationWindow;
using API_Client_Library;

namespace GUI
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();

            TabControl.Multiline = true;
            TabControl.Appearance = TabAppearance.Buttons;
            TabControl.ItemSize = new System.Drawing.Size(0, 1);
            TabControl.SizeMode = TabSizeMode.Fixed;
            TabControl.TabStop = false;

            //MetroFramework.MetroMessageBox.Show(this, "Подключение к апи....");
            API.Init();
            //MetroFramework.MetroMessageBox.Show(this, "Апи подключен....");

            API.onScanCompleted += APIHandlers.OnScannedFile;
            API.onScanFound += APIHandlers.OnFoundVirus;
        }

        private void ScanButton_Click_2(object sender, EventArgs e)
        {
            this.TabControl.SelectTab(1);
        }

        private void settingsButton_Click_1(object sender, EventArgs e)
        {
            this.TabControl.SelectTab(2);
        }

        private void QuarantineButton_Click_1(object sender, EventArgs e)
        {
            this.TabControl.SelectTab(3);
        }

        private void ExceptionsButton_Click_1(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex = 4;
        }

        private void UpdateButton_Click_1(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex = 5;

        }
    }

    public static class APIHandlers
    {
        public static void OnScannedFile(ScannedFileInfo info)
        {
            Console.WriteLine("OnScannedFile");

            var popup = new PopupNotifier()
            {
                ContentText = $"Сканирование завершено\n{info.file}",
                TitleText = "Antivirus"
            };

            popup.Popup();
        }

        public static void OnFoundVirus(VirusFileInfo info)
        {
            Console.WriteLine("OnFoundVirus");

            var popup = new PopupNotifier() { 
                ContentText = $"Обнаружен вирус\n{info.file}",
                TitleText = "Antivirus"
            };

            popup.Popup();
        }
    }
}
