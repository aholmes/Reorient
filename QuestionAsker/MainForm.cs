using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionAsker
{
    public partial class MainForm : Form
    {
        private static object writeLock = new object();

        private static string ResponsesFileName
        {
            get
            {
                var now = DateTime.Now;
                return "Responses_" + now.ToString("MMMM-dd-yyyy") + ".txt";
            }
        }

        private DateTime QuestionAskTime;
        private DateTime QuestionAnswerTime;

        public MainForm()
        {
            InitializeComponent();

            questionLabel.Text = Question.Get();
            QuestionAskTime = DateTime.Now;
        }

        private void responseText_TextChanged(object sender, EventArgs e)
        {

        }

        private async void responseSaveButton_Click(object sender, EventArgs e)
        {
            QuestionAnswerTime = DateTime.Now;

            var response = new string[]
            {
                "Asked at: " + QuestionAskTime.ToString("MMMM dd, yyyy H:mm:ss"),
                "Answered at: " + QuestionAnswerTime.ToString("MMMM dd, yyyy H:mm:ss"),
                responseText.Text
            };


            var filePath = Path.Combine(new string[]
            {
                Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                ResponsesFileName
            });

            using(var file = new StreamWriter(filePath, true))
            {
                await Task.Run(() =>
                {
                    lock (writeLock)
                    {
                        foreach(var line in response)
                        {
                            file.WriteLine(line);
                        }

                        file.WriteLine();
                    }
                });
            }
        }
    }
}
