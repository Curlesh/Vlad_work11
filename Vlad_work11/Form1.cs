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

namespace Alina_work10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ввод()
        {
            using (StreamReader file = new StreamReader("file.txt"))
            {
                textBox1.Text = file.ReadToEnd();
                file.Close();
            }
            return "";
        }
        string вывод()
        {
            using (StreamWriter file = new StreamWriter("file.txt"))
            {
                file.WriteLine(textBox2.Text);
            }
            return "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ввод();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            button1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            this.Size = new System.Drawing.Size(425, 357);
            int Index = listBox1.SelectedIndex + 1;
            // label3.Text = Convert.ToString(Index);
            string line = textBox1.Text;
            string[] str_arr = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            switch (Index)
            {
                case 1:
                    textBox2.Text = "";
                    int schet = 0;
                    for (int i = 0; i < str_arr.Length; i++)
                    {
                        schet++;
                    }
                    int[] mas = new int[schet];
                    for (int i = 0; i < str_arr.Length; i++)
                    {
                        mas[i] = str_arr[i].Length;
                    }
                    Array.Sort(mas, str_arr);
                    for (int i = 0; i < str_arr.Length; i++)
                    {
                        textBox2.Text += str_arr[i] + " ";
                    }
                    вывод();
                    break;
                case 2:
                    textBox2.Text = "";
                    textBox3.Visible = true;
                    label2.Visible = true;

                    break;
                case 3:
                    textBox2.Text = "";
                    textBox3.Visible = true;
                    label2.Visible = true;

                    break;
                case 4:
                    textBox2.Text = "";
                    textBox3.Visible = true;
                    label2.Visible = true;


                    break;
                case 5:

                    textBox2.Text = "";
                    textBox3.Visible = true;
                    label2.Visible = true;
                    button1.Visible = true;
                    button1.Text = "Удалить введеную подстроку";
                    break;

                case 6:
                    textBox2.Text = "";
                    textBox3.Visible = true;
                    label2.Visible = true;
                    button1.Visible = true;
                    textBox4.Visible = true;
                    button1.Text = "Заменить подстроку";
                    break;
                case 7:
                    textBox2.Text = "";
                    textBox3.Visible = true;
                    label2.Visible = true;
                    break;
                case 8:
                    textBox2.Text = "";
                    textBox3.Visible = true;
                    label2.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    this.Size = new System.Drawing.Size(425, 480);
                    for (int i = 0; i < str_arr.Length; i++)
                    {
                        if (str_arr[i].Length%2==0)
                        {
                            textBox5.Text += str_arr[i]+" ";
                        }
                        else
                        {
                            textBox6.Text += str_arr[i]+" ";
                        }
                    }
                    break;

            }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string line = textBox1.Text;
            string[] str_arr = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int Index = listBox1.SelectedIndex + 1;
            switch (Index)
            {
                case 2:
                    textBox2.Text = "";
                    textBox3.Visible = true;
                    label2.Visible = true;
                    if (textBox3.Text != "")
                    {

                        string l = textBox3.Text;
                        for (int i = 0; i < str_arr.Length; i++)
                        {

                            if (str_arr[i].IndexOf(l) == 0)
                            {
                                textBox2.Text += str_arr[i] + " ";
                            }
                        }
                        вывод();
                    }
                    break;
                case 3:

                    textBox2.Text = "";
                    textBox3.Visible = true;
                    label2.Visible = true;
                    if (textBox3.Text != "")
                    {

                        string l = textBox3.Text;
                        for (int i = 0; i < str_arr.Length; i++)
                        {

                            if (str_arr[i].IndexOf(l) > -1)
                            {
                                textBox2.Text += str_arr[i] + " ";
                            }
                        }
                        вывод();
                    }
                    break;
                case 4:
                    textBox2.Text = "";
                    textBox3.Visible = true;
                    label2.Visible = true;
                    if (textBox3.Text != "")
                    {

                        string l = textBox3.Text;
                        for (int i = 0; i < str_arr.Length; i++)
                        {

                            if (str_arr[i].LastIndexOf(l) == str_arr[i].Length - 1)
                            {
                                textBox2.Text += str_arr[i] + " ";
                            }
                        }
                        вывод();
                    }
                    break;
                case 7:
                    textBox2.Text = "";
                    textBox3.Visible = true;
                    label2.Visible = true;
                    if (textBox3.Text != "")
                        {
                        for (int i = 0; i < str_arr.Length; i++)
                        {
                            if ((str_arr[i].IndexOf(textBox3.Text) == 0) && (str_arr[i].LastIndexOf(textBox3.Text) == str_arr[i].Length - 1))
                            {
                                textBox2.Text += str_arr[i] + " ";
                            }
                        }
                        вывод();
                    }
                 
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string line = textBox1.Text;
            string[] str_arr = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int Index = listBox1.SelectedIndex + 1;
            string ind = textBox3.Text;
            string ind2 = textBox4.Text;
            textBox2.Text = "";
            switch (Index)
            {
                case 5:
                    for (int i = 0; i < str_arr.Length; i++)
                    {
                        if (str_arr[i].IndexOf(textBox3.Text) > -1)
                        {
                            str_arr[i] = str_arr[i].Remove(str_arr[i].IndexOf(textBox3.Text), textBox3.Text.Length);
                            textBox2.Text += str_arr[i] + " ";
                        }
                    }
                    вывод();
                    break;
                case 6:
                    for (int i = 0; i < str_arr[i].Length; i++)
                    {
                        if (str_arr[i].IndexOf(textBox3.Text) > -1)
                        {
                            str_arr[i] = str_arr[i].Replace(textBox3.Text, textBox4.Text);
                            textBox2.Text += str_arr[i]+" ";
                        }
                    }
                    break;
                    вывод();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ввод();
        }
    }
}
