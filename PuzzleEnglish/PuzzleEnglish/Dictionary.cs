using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PuzzleEnglish
{
    class Dictionary
    {
        int total = 0;
        string[] english; // apple
        string[] russian; // яблоко
        string[] audio_eng; // аудио на англ.
        string[] audio_rus; // аудио на русс.
        string[] images;
        string[] video;

        public Dictionary()
        {
            Init();
        }

        public string English(int  nr)
        {
            if (nr < 0 || nr > total) return "";
            return english[nr];
        }
        public string Russian(int nr)
        {
            if (nr < 0 || nr > total) return "";
            return russian[nr];
        }



        private void Init()
        {
            total = 0;
            DirectoryInfo di = new DirectoryInfo("Data\\text\\");
            FileInfo[] info = di.GetFiles("*.txt", SearchOption.TopDirectoryOnly);
            total = info.Length;

            english = new string[total];
            russian = new string[total];
            audio_eng = new string[total];
            audio_rus = new string[total];
            images = new string[total];
            video = new string[total];
            int j = 0;
            foreach (FileInfo file in info)
            {
                string filename = file.FullName;
                string name = file.Name.Replace(".txt", "");
                string[] lines = File.ReadAllLines(filename);
                english[j] = lines[0];
                russian[j] = lines[1];
                audio_eng[j] = "Data\\english\\" + name + ".mp3";
                audio_rus[j] = "Data\\russian\\" + name + ".mp3";
                if (!File.Exists(audio_eng[j])) audio_eng[j] = "";
                if (!File.Exists(audio_rus[j])) audio_rus[j] = "";

                images[j] = "Data\\images\\" + name + ".jpg";
                video[j] = "Data\\video\\" + name + ".mp4";

                if (!File.Exists(images[j])) audio_eng[j]= "";
                if (!File.Exists(video[j])) audio_rus[j] = "";
                j++;

            }


        }

    }
}
