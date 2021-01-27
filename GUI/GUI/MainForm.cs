using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;
using Tulpep.NotificationWindow;
using API_Client_Library;

namespace GUI
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public static Mutex files_sync = new Mutex();
        public static Queue<ScannedFileInfo> files = new Queue<ScannedFileInfo>();

        public static Mutex viruses_sync = new Mutex();
        public static Queue<VirusFileInfo> viruses = new Queue<VirusFileInfo>();

        public static System.Windows.Forms.Timer Updater = new System.Windows.Forms.Timer();

        public MainForm()
        {
            InitializeComponent();

            {
                TabControl.Multiline = true;
                TabControl.Appearance = TabAppearance.Buttons;
                TabControl.ItemSize = new System.Drawing.Size(0, 1);
                TabControl.SizeMode = TabSizeMode.Fixed;
                TabControl.TabStop = false;
            }

            {
                API.Init();

                API.onScanCompleted += APIHandlers.OnScannedFile;
                API.onScanFound += APIHandlers.OnFoundVirus;
            }

            {
                Updater.Tick += MyTimer_Tick;
                Updater.Interval = 200;
                Updater.Enabled = true;
            }
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            if(files.Count > 0)
            {
                files_sync.WaitOne();
                {
                    var fileInfo = files.Dequeue();

                    /*
                    var popup = new PopupNotifier()
                    {
                        ContentText = $"Сканирование завершено\n{fileInfo.file}",
                        TitleText = "Antivirus"
                    };

                    popup.Popup();*/
                }
                files_sync.ReleaseMutex();
            }

            if(viruses.Count > 0)
            {
                viruses_sync.WaitOne();
                {
                    var fileInfo = viruses.Dequeue();

                    var popup = new PopupNotifier()
                    {
                        ContentText = $"Обнаружен вирус\n{fileInfo.file}",
                        TitleText = "Antivirus"
                    };

                    popup.Popup();
                }
                viruses_sync.ReleaseMutex();
            }
        }

        #region Кнопки переключения между вкладками
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

        private void page_exceptions_back_to_main_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex = 0;
        }

        /// <summary>
        /// Отмена сканирования (при настройке)
        /// </summary>
        private void metroButton9_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex = 0;
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex = 0;
        }
        #endregion
    }

    public static class APIHandlers
    {
        public static void OnScannedFile(ScannedFileInfo info)
        {
            MainForm.files.Enqueue(info);
        }

        public static void OnFoundVirus(VirusFileInfo info)
        {
            MainForm.viruses.Enqueue(info);
        }
    }
}
