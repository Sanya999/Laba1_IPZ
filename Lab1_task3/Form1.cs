using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Lab1_task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void READ_Click(object sender, EventArgs e)
        {
            string[] registy_string = (string[])Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Pryshchepa", "P5", " DEFAULT" );
            string result = "";
            for (int i = 0; i < registy_string.Length; i++)
            {
                result += registy_string[i]+"\n";
            }

            MessageBox.Show(result);

        }

        private void WRITE_Click(object sender, EventArgs e)
        {
            
            string[] arr = { "Я - студент", "кафедри КІ!" };
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Pryshchepa", "P6", arr ,RegistryValueKind.MultiString);
            MessageBox.Show( "Дані успішно внесено в реєстр!!!");
        }
    }
}
//коментар