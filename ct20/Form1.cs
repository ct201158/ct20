using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ct20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static byte[] ConvertToByteArray(string str, Encoding encoding)
        {
            return encoding.GetBytes(str);
        }

        public static String ToBinary(Byte[] data)
        {
            return string.Join(" ", data.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = ToBinary(ConvertToByteArray(richTextBox1.Text, Encoding.ASCII));
            richTextBox1.Text = Regex.Replace(richTextBox1.Text, " ", "");
            richTextBox1.Text = Reverse(richTextBox1.Text);
            richTextBox1.Text = Regex.Replace(richTextBox1.Text, "0", "0xPRC");
            richTextBox1.Text = Regex.Replace(richTextBox1.Text, "1", "0xEUK");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //code the decryptor yourself u little skid
        }
    }
}
