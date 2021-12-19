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

/* Strategy:
 * Save the file in this format:
 * - Each line ends with a space
 * - There's an extra new line at the end
 * So that the count of spaces == the number of words
 * and the count of new line == the number of lines
 * 
 * Takes one loop to count newlines, words, and chars.
 */

namespace FileIO
{
    public partial class Form1 : Form
    {

        public static string Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\FileIO.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void create_file_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Path))
            {
                using (FileStream file = File.Create(Path));
            }
        }

        private void read_file_Click(object sender, EventArgs e)
        {
            textbox.Text = read();
        }

        private void write_to_file_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path))
            {
                using (StreamWriter file = File.CreateText(Path))
                {
                    string str = "";
                    try
                    {
                        foreach (string s in textbox.Lines)
                        {
                            if (s[s.Length-1] != ' ')
                            {
                                str += s + " ";
                            }
                        }
                        if (str[str.Length-1] != '\n')
                        {
                            str += '\n';
                        }
                        file.Write(str);
                    } 
                    catch
                    {

                    }
                }
            }
        }

        private string read()
        {
            if (File.Exists(Path))
            {
                using (StreamReader file = File.OpenText(Path))
                {
                    return file.ReadToEnd();
                }
            }

            return "";
        }

        private void display_meta_data_Click(object sender, EventArgs e)
        {
            string data = read();

            int no_lines = 0;
            int no_words = 0;
            int no_chars = 0;

            foreach (char c in data)
            {
                if (c == '\n')
                {
                    no_lines++;
                }
                if (c == ' ')
                {
                    no_words++;
                }
                no_chars++;
            }

            textbox.Text = String.Format("#Lines: {0}.{1}#Words: {2}.{3}#Chars: {4}.{5}", no_lines, Environment.NewLine, no_words, Environment.NewLine, no_chars, Environment.NewLine);
        }
    }
}
