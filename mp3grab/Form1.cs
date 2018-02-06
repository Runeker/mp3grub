using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Data;
using System.Collections.Generic;

namespace mp3grab
{
    public partial class Form1 : Form
    {
        string folerStr;
        string artist;
        public Form1()
        {
            InitializeComponent();
            files_listbox.SelectedValueChanged += new EventHandler(files_listbox_SelectedValueChanged);
        }

        //выбрать папку для сканирования.
        private void open_Button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                path_Textbox.Text = fbd.SelectedPath;
            }
        }

        //сканировать. Ошибка, если херовый путь.
        private void scan_Button_Click(object sender, EventArgs e)
        {
            try
            {
                //находим все мп3 и запихиваем в массив
                files_listbox.Items.Clear();
                var files = Directory.EnumerateFiles(path_Textbox.Text, "*.mp3", SearchOption.TopDirectoryOnly);
                foreach (string dir in files)
                {
                    files_listbox.Items.Add(dir);
                }
            }

            catch (Exception ex)
            {
                status_label.Text = ex.Message;
            }
        }

        //создаем папки, тегируем.
        private void go_to_folder_button_Click(object sender, EventArgs e)
        {
            try
            {
                //сначала создаем папку
                string directory = path_Textbox.Text + "\\new\\" + artist + " (" + genge_textbox.Text + ")" + "\\" + Convert.ToUInt16(year_textbox.Text.ToString()) + " - "
                                                            + album_textBox2.Text.ToString() + "\\";
                Directory.CreateDirectory(directory);

                //лист треков
                List<FileInfo> songs = new List<FileInfo>();

                //добавим выделенные
                foreach (var song in files_listbox.SelectedItems)
                {
                    songs.Add(new FileInfo(song.ToString()));
                }

                //отсортируем по дате
                List<FileInfo> sortedSongs = songs.OrderBy(o => o.CreationTime).ToList();

                for (int i = 0; i < sortedSongs.Count; i++)
                {
                    //реализуем библиотеку таглиб, для работы с тегами
                    TagLib.File tagFile = TagLib.File.Create(sortedSongs[i].ToString());

                    tagFile.Tag.Performers = new string[] { artist_textBox.Text }; // исполнитель
                    tagFile.Tag.Album = album_textBox2.Text; // альбом
                    tagFile.Tag.Year = Convert.ToUInt16(year_textbox.Text.ToString()); // год
                    string title = sortedSongs[i].ToString().Substring(sortedSongs[i].ToString().LastIndexOf('-') + 2);
                    tagFile.Tag.Title = title.Remove(title.ToString().LastIndexOf('.')); // название песни
                    tagFile.Tag.Track = (uint)i + 1; //номер трека

                    tagFile.Save(); //сохраним

                    //перемещаем в нужный путь.
                    FileInfo t = new FileInfo(sortedSongs[i].ToString());
                    File.Move(sortedSongs[i].ToString(), directory + tagFile.Tag.Track + " - " + tagFile.Tag.Title + ".mp3");
                }

                status_label.Text = "done";
                scan_Button_Click(sender, e);
            }
            catch (Exception ex)
            {
                status_label.Text = ex.Message;
            }
            
        }

        private void files_listbox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (files_listbox.SelectedIndex != -1)
                {
                    string artistSong = files_listbox.SelectedItem.ToString().Substring(files_listbox.SelectedItem.ToString().LastIndexOf('\\') + 1);
                    folerStr = artistSong.Substring(0, artistSong.IndexOf('-') - 1);
                    artist_textBox.Text = folerStr;
                    artist = artist_textBox.Text;
                }
            }
            catch (Exception ex)
            {
                status_label.Text = ex.Message;
            }
        }
    }
}
