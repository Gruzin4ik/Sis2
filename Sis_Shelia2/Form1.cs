using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;

namespace Sis_Shelia2
{
    public partial class Form1 : Form
    {
        public string str { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string partBookTitle = textBox1.Text;
            string insertText = textBox2.Text;
            string bookTitle = partBookTitle.Insert(7, insertText);
            listBox1.Items.Add(bookTitle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bookTitle = textBox1.Text;
            
            bookTitle = bookTitle.Remove(6);
            listBox1.Items.Add(bookTitle);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string bookTitle = textBox1.Text;
            
            bookTitle = bookTitle.Substring(0, 3);
            listBox1.Items.Add(bookTitle);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str1 = textBox2.Text;
            string str2 = textBox1.Text;
            int i = str2.IndexOf(str1);

            if (i >= 0) listBox1.Items.Add(str1 + " входит в строку " + str2);
            else
            {
                listBox1.Items.Add(str1 + " не входит в строку " + str2);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string tankman = "4";
            string dog = "1";
            listBox1.Items.Add(tankman + dog); 
            int all = int.Parse(tankman) + int.Parse(dog);
            listBox1.Items.Add(Environment.NewLine + all.ToString());  
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int charCode = 169;
            char specialChar = Convert.ToChar(charCode);
            listBox1.Items.Add(specialChar.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            int charCode = 0x00AE;
            char specialChar = Convert.ToChar(charCode);
            listBox1.Items.Add(specialChar.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.String FiveStars = new System.String('*', 5);
            listBox1.Items.Add(FiveStars);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string AutoName;
            AutoName = "MERCEDES";
            listBox1.Items.Add(String.Format("Стоимость {0} равна {1:0.0;c}", AutoName, 23.6));
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            Color clr = Color.DarkRed;

            listBox1.Items.Add(TypeDescriptor.GetConverter(clr).ConvertToString(clr));
            
            clr = (Color)TypeDescriptor.GetConverter(
            typeof(Color)).ConvertFromString("DarkRed");
            
            this.BackColor = clr;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name))
                throw new ArgumentNullException("name");
            listBox1.Items.Add(string.Concat("Hello, ", Name));
        }

        private void button12_Click(object sender, EventArgs e)
        {

          
            
        }
        public static string ReverseString(string str)
        {
            
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }
            
            StringBuilder revStr = new StringBuilder(str.Length);
            
            for (int count = str.Length - 1; count > -1; count--)
            {
                revStr.Append(str[count]);
            }
            // Возвращаем перевернутую строку
            return revStr.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = ReverseString(textBox1.Text);


        }
        [DllImport("shlwapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool PathCompactPathEx(System.Text.StringBuilder pszOut,string pszSrc,Int32 cchMax, Int32 dwFlags);


        private void button14_Click(object sender, EventArgs e)
        {
            // длинный путь к файлу
            string strPathFile = "c:/program files/My SuperProgram/skins/sample.txt";
            StringBuilder sb = new StringBuilder(260);
            // оставляем 20 символов, остальное заменяем многоточием
            bool b = PathCompactPathEx(sb, strPathFile, 20 + 1, 0);
            // Выводим результат в текстовое поле
            textBox1.Text = sb.ToString();
        }

        public static int counter = 0;
       
        

        private void timer2_Tick(object sender, EventArgs e)
        {
            string typingText = textBox1.Text;

            textBox1.Text = typingText.Substring(0, counter);
            counter++;
            if (counter > typingText.Length)
                counter = 0;
        }

            private void button15_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Старт")
            {
                timer2.Enabled = true;
                button1.Text = "Стоп";
            }
            else
            {
                timer2.Enabled = false;
                button1.Text = "Старт";
            }

        }
    }
}
