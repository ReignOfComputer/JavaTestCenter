using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace JavaTestCenter
{
    public partial class JavaTestCenter : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();

        public JavaTestCenter()
        {
            InitializeComponent();
        }

        private void Button_Run_Click(object sender, EventArgs e)
        {
            TextBox_Process.Text = "";
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.WorkingDirectory = TextBox_Directory.Text;

            p.StartInfo.FileName = "javac";
            p.StartInfo.Arguments = ((RadioButton_CP.Checked) ? "-cp . " + TextBox_JavaFile.Text : (RadioButton_D.Checked) ? "-d . *.java" : TextBox_JavaFile.Text);
            TextBox_Process.Text += "javac " + ((RadioButton_CP.Checked) ? "-cp . " + TextBox_JavaFile.Text : (RadioButton_D.Checked) ? "-d . *.java" : TextBox_JavaFile.Text) + " [Compiling...]";
            try
            {
                p.Start();
                p.WaitForExit();

                p.StartInfo.FileName = "java";
                p.StartInfo.Arguments = TextBox_JavaFile.Text.Replace(".java", "");
                TextBox_Process.Text += Environment.NewLine + "java " + TextBox_JavaFile.Text.Replace(".java", "") + " [Running...]";
                p.Start();

                StreamWriter sw = p.StandardInput;
                foreach (string line in TextBox_Input.Lines)
                {
                    sw.WriteLine(line);
                }
                sw.Close();

                p.WaitForExit();

                string error = p.StandardError.ReadToEnd();

                if (error.Length > 0)
                {
                    MessageBox.Show("Error occurred: " + Environment.NewLine + error);
                }

                string output = p.StandardOutput.ReadToEnd();
                TextBox_OutputActual.Text = output.Trim();

                if (TextBox_Output.Text.Length > 0)
                {
                    if (TextBox_OutputActual.Lines.Length != TextBox_Output.Lines.Length)
                    {
                        TextBox_OutputActual.Text += Environment.NewLine + "Match: NO - Line count different.";
                        return;
                    }
                    else
                    {
                        int count = 0;
                        int compareCount = TextBox_OutputActual.Lines.Length;
                        TextBox_OutputActual.Text += Environment.NewLine + Environment.NewLine;
                        for (int i = 0; i < compareCount; i++)
                        {
                            if (!TextBox_OutputActual.Lines[i].Equals(TextBox_Output.Lines[i]))
                            {
                                count++;
                                TextBox_OutputActual.Text += "Line " + i + ":" + Environment.NewLine + "Expected \"" + TextBox_Output.Lines[i] + "\" got \"" + TextBox_OutputActual.Lines[i] + "\"." + Environment.NewLine;
                            }
                        }
                        if (count == 0)
                        {
                            TextBox_OutputActual.Text += Environment.NewLine + "Match: YES";
                        }
                        else
                        {
                            TextBox_OutputActual.Text += Environment.NewLine + "Match: NO - " + count + " lines different.";
                        }
                    }
                }
                TextBox_Process.Text += " [Done.]";
            }
            catch (Exception)
            {
                TextBox_Process.Text += " [Error.]";
                MessageBox.Show("Error: Verify Java is in PATH.");
            }
        }

        private void Button_JavaFile_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "JAVA (*.java)|*.java";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TextBox_JavaFile.Text = Path.GetFileName(ofd.FileName);
                TextBox_Directory.Text = ofd.FileName.Substring(0, ofd.FileName.LastIndexOf("\\") + 1);
            }
        }

        private void Button_Input_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(ofd.FileName);
                TextBox_Input.Text = String.Join(Environment.NewLine, lines);
            }
        }

        private void Button_Output_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(ofd.FileName);
                TextBox_Output.Text = String.Join(Environment.NewLine, lines);
            }
        }
    }
}
