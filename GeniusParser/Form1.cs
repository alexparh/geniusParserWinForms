using GeniusParser.Core;
using GeniusParser.Core.Genius;
using System;
using System.Windows.Forms;

namespace GeniusParser
{
    public partial class Form : System.Windows.Forms.Form
    {
        ParserWorker<string[]> parser;

        public Form()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(
                     new Core.Genius.GeniusParser()
            );

            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            try
            {
                listBox.Items.AddRange(arg2);
            }
            catch
            {
                listBox.Items.Add("Sorry, I can not find this song");
            }
        }

        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("All works done!");
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            parser.Settings = new GeniusSettings(artist_textBox.Text, song_textBox.Text);
            parser.Start();
        }

        private void abort_button_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }
    }
}
