using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using VideoLibrary;
using MediaToolkit;
using System.Text.RegularExpressions;
using System.Net;

namespace Downloader___mp3_mp4
{
    public partial class MainMenu : Form
    {
        string saveWayMain = string.Empty;

        Dictionary<string, string> songs = new Dictionary<string, string>();
        Stack<string> songsName = new Stack<string>();
        bool isDownloaded = false;
        int failed = 0;
        int saves = 0;

        public MainMenu()
        {
            InitializeComponent();
        }


        //Изтегляне на един клип(началната функция)
        private async void download_Button_Click(object sender, EventArgs e)
        {
            if (URLvalidator(URL_input.Text))
            {
                status_display.Text = "Приготвя се...";
                status_display.ForeColor = Color.Orange;
                try
                {
                    download_Button.Cursor = Cursors.WaitCursor;
                    header.Text = GetTitle();
                    var youtube = YouTube.Default;
                    var video = await youtube.GetVideoAsync(URL_input.Text);
                    status_display.Text = "Изтегля се...";
                    status_display.ForeColor = Color.Orange;
                    File.WriteAllBytes(saveWayMain + @"\" + video.FullName, await video.GetBytesAsync());

                    if (MP3_Button.Checked)
                    {
                        var inputFile = new MediaToolkit.Model.MediaFile { Filename = saveWayMain + @"\" + video.FullName };
                        string remakedName = video.FullName.Substring(0, video.FullName.Length - 4);
                        var OutputFile = new MediaToolkit.Model.MediaFile { Filename = $"{saveWayMain + @"\" + remakedName}.mp3" };

                        using (var enging = new Engine())
                        {
                            enging.GetMetadata(inputFile);
                            enging.Convert(inputFile, OutputFile);
                        }

                        File.Delete(saveWayMain + @"\" + video.FullName);
                    }

                    download_Button.Cursor = Cursors.Default;
                    status_display.Text = "Изтеглено!";
                    status_display.ForeColor = Color.Green;

                    URL_input.Text = string.Empty;
                }
                catch (Exception)
                {
                    download_Button.Cursor = Cursors.Default;
                    status_display.Text = "ГРЕШКА!";
                    status_display.ForeColor = Color.Red;
                    MessageBox.Show("Несъществуващ URL адрес!\nМоля, опитайте пак.", "ГРЕШКА!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Моля въведете валиден URL адрес (програмата работи само със линкове от Youtube)!", "ВНИМАНИЕ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //Добавя името като Key и URL адреса като Value в речника, и също така добавя и името в стака;
        private void add_Button_Click(object sender, EventArgs e)
        {
            if (URLvalidator(URL_input.Text))
            {
                string currentSongName = GetTitle();
                
                string URL = URL_input.Text;

                if (currentSongName != string.Empty)
                {
                    header.Text = currentSongName;
                    if (!songs.ContainsKey(currentSongName))
                    {
                        songs.Add(currentSongName, URL);
                        songsName.Push(currentSongName);
                        URL_input.Text = string.Empty;
                        status_display.Text = songsName.Count().ToString();
                        lastAddedSongName.Text = $"Последен елемент: {songsName.Peek()}";
                        downloading_Text.Visible = false;
                        isDownloaded = false;

                        if (deleteLastElement_Button.Enabled == false)
                        {
                            deleteLastElement_Button.Enabled = true;
                        }

                        if (songsName.Count > 1)
                        {
                            downloadAddedElements_Button.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Елементът \"{currentSongName}\" вече е добавен.\nМоля, опитайте друг!", "ВЪЗНИКНА ПОВТОРЕНИЕ!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        URL_input.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Несъществуващ URL адрес!\nПесента няма да бъде добавена!\nМоля опитайте пак с друг URL адрес.", "ГРЕШКА!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    URL_input.Text = string.Empty;
                }

                
            }
            else
            {
                MessageBox.Show("Моля въведете валиден URL адрес (програмата работи само със линкове от Youtube)!", "ВНИМАНИЕ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                URL_input.Text = string.Empty;
                header.Text = "YouTube MP3/MP4 Downloader By Emr3";
            }
        }


        //Използвайки вградената функция на стака(Last-In-First-Out) попвам последния елемент, и според резултата
        //премахвам и елемета от речника;
        private void deleteLastElement_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Искате ли да изтриете елемент \"{songsName.Peek()}\" от списъка?", "ВНИМАНИЕ!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                songs.Remove(songsName.Pop());
                status_display.Text = songsName.Count().ToString();
                if (songsName.Count > 0)
                {
                    lastAddedSongName.Text = $"Последен елемент: {songsName.Peek()}";
                }
                else if (songsName.Count == 0)
                {
                    deleteLastElement_Button.Enabled = false;
                    status_display.Text = "0";
                    lastAddedSongName.Text = "Последен елемент: ---";
                }

            }

            if (songsName.Count <= 1)
            {
                downloadAddedElements_Button.Enabled = false;
            }
        }


        /*
        Изтегля добавените елементи в стака(songsName) направен по-горе, като подава имеанта им в опашка, речникът(songs) 
        направен по-горе подава URL адресите на всеки клип съвпадащ със стойността си (key-value pair) и for цикъл;
        взима информацията от опашките и ги изтегля;
        Също проверява дали има текст на URL инпута, ако има и не е добавен пита дали да го добави, а ако има URL адрес, но 
        е добавен преди, нищо не прави;
        */
        private async void downloadAddedElements_Button_Click(object sender, EventArgs e)
        {
            string lastDownloadedElement = "---";

            if (URL_input.Text != string.Empty && !songs.ContainsValue(URL_input.Text))
            {
                if (MessageBox.Show("Забравихте да добавите линкът към видеото!\nИскате ли да го добавите?", "ВНИМАНИЕ!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    add_Button_Click(sender, e);
                }
                else
                {
                    URL_input.Text = string.Empty;
                }
                if (saveWayMain == string.Empty)
                {
                    return;
                }               
            }
            else
            {
                URL_input.Text = string.Empty;
            }

            if (videoSaveWay.Text == "Кликнете тук, за да изберете къде да запишете!")
            {
                MessageBox.Show($"Изберете мястото, където желаете да се запишат избраните от вас {songsName.Count} елемента!", "ГРЕШКА ПРИ ЗАПИСВАНЕТО!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Queue<string> songsname = new Queue<string>(songsName.Reverse());
                Queue<string> URLs = new Queue<string>();
                downloading_Text.Visible = true;
                willDownload_Text.Visible = true;

                foreach (var pair in songs)
                {
                    URLs.Enqueue(pair.Value);
                }

                int songsSize = songsname.Count;

                for (int i = 0; i < songsSize; i++)
                {
                    downloadAddedElements_Button.Cursor = Cursors.WaitCursor;
                    isDownloaded = true;
                    saves = i;
                    willDownload_Text.Text = songsname.Peek();
                    lastAddedSongName.Text = $"Последно изтеглен: {lastDownloadedElement}";
                    downloading_Text.ForeColor = Color.Black;
                    downloading_Text.Text = $"Изтегля се: ";

                    try
                    {
                        header.Text = $"Изтеглени {saves} елемента от {songsSize}";
                        var youtube = YouTube.Default;
                        string currentSongName = songsname.Dequeue();
                        var video = await youtube.GetVideoAsync(URLs.Dequeue());
                        downloading_Text.Text = $"Изтегля се: {currentSongName}";

                        if (songsname.Count > 0)
                        {
                            willDownload_Text.Text = $"Ще се изтегли: {songsname.Peek()}";
                        }
                        else
                        {
                            willDownload_Text.Text = "Ще се изтегли: ---";
                        }

                        File.WriteAllBytes(saveWayMain + @"\" + video.FullName, await video.GetBytesAsync());

                        if (MP3_Button.Checked)
                        {
                            var inputFile = new MediaToolkit.Model.MediaFile { Filename = saveWayMain + @"\" + video.FullName };
                            string remakedName = video.FullName.Substring(0, video.FullName.Length - 4);
                            var OutputFile = new MediaToolkit.Model.MediaFile { Filename = $"{saveWayMain + @"\" + remakedName}.mp3" };

                            using (var enging = new Engine())
                            {
                                enging.GetMetadata(inputFile);
                                enging.Convert(inputFile, OutputFile);
                            }

                            File.Delete(saveWayMain + @"\" + video.FullName);
                        }

                        lastDownloadedElement = currentSongName;
                        
                    }
                    catch (Exception)
                    {
                        //MessageBox.Show("Несъществуващ URL адрес!\nПесента няма да бъде записана!", "ГРЕШКА!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        saves--;
                        failed++;
                        continue;
                    }
                }

                downloadAddedElements_Button.Cursor = Cursors.Default;
                downloading_Text.Text = $"Изтегля се: ---";
                header.Text = "YouTube MP3/MP4 Downloader By Emr3";
                downloading_Text.ForeColor = Color.Green;
                downloading_Text.Text = $"Изтеглени {saves + 1 - failed} елементи от {songsSize} - неуспешни {failed}";
                willDownload_Text.Visible = false;
                downloadAddedElements_Button.Enabled = false;
                deleteLastElement_Button.Enabled = false;
                songsname.Clear();
                songsName.Clear();
                songs.Clear();
                status_display.Text = songsName.Count().ToString();
            }
        }


        //Подаване към програмата избраният път за запазване;
        public void videoSaveWay_Click(object sender, EventArgs e)
        {
            string result = saveWay(videoSaveWay.Text);
            videoSaveWay.Text = result;

            if (videoSaveWay.Text == "")
            {
                videoSaveWay.Text = "Кликнете тук, за да изберете къде да запишете!";
                download_Button.Enabled = false;
                MP3_Button.Checked = true;
            }
            else
            {
                saveWayMain = videoSaveWay.Text;
                download_Button.Enabled = true;
            }
        }


        //Избиране на пътят за запазване на песните;
        public string saveWay(string text)
        {
            //string result = string.Empty;
            //Кликнете тук, за да изберете къде да запишете!

            using (FolderBrowserDialog fdb = new FolderBrowserDialog() { Description = "Моля изберете път за записване!" })
            {
                if (fdb.ShowDialog() == DialogResult.OK)
                {
                    text = fdb.SelectedPath;
                }
                else if (text == "Кликнете тук, за да изберете къде да запишете!")
                {
                    MessageBox.Show("Моля изберете път за записване!", "ВНИМАНИЕ!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return text;
            }
        }


        //Изпраща WEB заявка в Application слоят на OSI модела и извлича името на песента добавена за изтегляне;
        public string GetTitle()
        {
            WebRequest nameRequest = HttpWebRequest.Create(URL_input.Text);
            WebResponse currentResponse;
            currentResponse = nameRequest.GetResponse();
            StreamReader datas = new StreamReader(currentResponse.GetResponseStream());
            string comingData = datas.ReadToEnd();
            int begining = comingData.IndexOf("<title>") + 7;
            int end = comingData.Substring(begining).IndexOf("</title>") - 10;
            string result = comingData.Substring(begining, end);
            return result;
        }


        //Съдържа регулярен израз(Regex), който проверява дали добавеният линк е валиден или не според добавените от мен правила;
        public bool URLvalidator(string URL)
        {
            bool URL_Validator = false;

            Regex youtubeURL_Validator = new Regex(@"^https?\:\/\/?(www\.?youtube\.com|youtu\.?be)\/.+$");

            if (youtubeURL_Validator.IsMatch(URL))
            {
                URL_Validator = true;
            }

            if (URL_Validator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //Активира функцията за изтегляне едно по едно с приготвени елементи от по-долния метод;
        private void buttonActivateSecondElements_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Ще се активират други функции в програмата!\nСъгласни ли сте?", "ВНИМАНИЕ!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                deactivate_First_And_Activate_Seconnd_Elements();
            }

        }


        //Приготвя елементите за функцията за добавяне на много линкове и изтеглянето им;
        public void deactivate_First_And_Activate_Seconnd_Elements()
        {
            header.Text = "YouTube MP3/MP4 Downloader By Emr3";
            URL_input.Text = string.Empty;
            buttonActivateManyVersion.Visible = false;
            download_Button.Visible = false;
            willDownload_Text.Visible = false;
            deleteLastElement_Button.Visible = true;
            add_Button.Visible = true;
            lastAddedSongName.Visible = true;
            downloadAddedElements_Button.Visible = true;
            buttonActivateOneVersion.Visible = true;
            if (isDownloaded)
            {
                downloading_Text.Visible = true;
            }
            add_Button.BringToFront();
            header.Location = new Point(2, 7);
            saveIn_Text.Location = new Point(5, 246);
            videoSaveWay.Location = new Point(96, 246);
            status.Text = "Добавени:";
            status_display.Location = new Point(90, 117);
            status_display.Text = songsName.Count().ToString();
            status_display.ForeColor = Color.Black;
        }


        //Активира функцията за добавяне на много линкове и изтеглянето им с приготвени елементи от по-долния метод;
        private void buttonActivateFirstElements_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ще се активират други функции в програмата!\nСъгласни ли сте?", "ВНИМАНИЕ!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                deactivate_Second_And_Activate_First_Elements();
            }
        }


        //Приготвя елементите за функцията за изтегляне едно по едно;        
        public void deactivate_Second_And_Activate_First_Elements()
        {
            header.Text = "YouTube MP3/MP4 Downloader By Emr3";
            URL_input.Text = string.Empty;
            buttonActivateOneVersion.Visible = false;
            buttonActivateManyVersion.Visible = true;
            download_Button.Visible = true;
            deleteLastElement_Button.Visible = false;
            add_Button.Visible = false;
            lastAddedSongName.Visible = false;
            downloadAddedElements_Button.Visible = false;
            willDownload_Text.Visible = false;
            downloading_Text.Visible = false;
            header.Location = new Point(2, 23);
            saveIn_Text.Location = new Point(5, 155);
            videoSaveWay.Location = new Point(96, 155);
            status.Text = "Статус: ";
            status_display.Location = new Point(67, 117);
            status_display.Text = "-";
            header.Text = "YouTube MP3/MP4 Downloader";

        }
    }
}
