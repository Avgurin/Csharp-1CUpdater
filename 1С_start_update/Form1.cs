using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace _1С_start_update
{
    public partial class Form1 : Form
    {
        public static string pathEnv = @"%userprofile%\Appdata\Roaming\1C\1CEStart\ibases.v8i";
        public static string path = Environment.ExpandEnvironmentVariables(pathEnv);
        public string readText;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                infoTB.Text = "Файл существует - " + path + "\r\n";
            }
            else
            {
                infoTB.Text = "Файла меню не существует\r\n";
                updateBtn.Enabled = false;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                readText = File.ReadAllText(path);
                if (readText.Contains(oldAddressTB.Text))
                {
                    readText = readText.Replace(oldAddressTB.Text, newAddressTB.Text);
                    infoTB.AppendText("Идет замена " + oldAddressTB.Text + " на " + newAddressTB.Text + "\r\n\r\n");
                    File.Delete(path + "_");
                    File.Move(path, path + "_");
                    File.WriteAllText(path, readText);
                    infoTB.AppendText("Значение " + oldAddressTB.Text + " заменено на " + newAddressTB.Text + " успешно!\r\n");
                }
                else
                {
                    infoTB.AppendText("В файле строка " + oldAddressTB.Text + " не найдена!\r\n");
                }
            }
            else
            {
                infoTB.Text = "Файла меню не существует\r\n";
                updateBtn.Enabled = false;
            }
                
        }
    }
}
