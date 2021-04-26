using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Match
{
    public partial class Form1 : Form
    {
        public class Temp
        {
            public static ButtonValue value;
        }

        public class ButtonValue
        {
            public Button button;
            public int number;

            public ButtonValue(Button btn, int num)
            {
                button = btn;
                number = num;

                
            }

            public void OnClickButtonValue(object sender, EventArgs e)
            {
                this.button.Text = this.number.ToString();
                
                if (Temp.value == null)
                {
                    Temp.value = this;
                } else
                {
                    if(this.number != Temp.value.number)
                    {
                        Task.Delay(700).Wait();
                        this.button.Text = "#";
                        Temp.value.button.Text = "#";
                    }
                    Temp.value = null;
                }

            }
        }



        private void generateNumbers(Button[] btnList)
        {
            Random rnd = new Random();
            for (int i = 1; i <= btnList.Length / 2; i++)
            {
                int randomNumber = rnd.Next(1, btnList.Length / 2 + 1);

                int index = 0;
                while (index < 2)
                {
                    int randomIndex = rnd.Next(0, btnList.Length);
                    if (btnList[randomIndex] != null)
                    {
                        ButtonValue self = new ButtonValue(btnList[randomIndex], randomNumber);
                        self.button.Click += new EventHandler(self.OnClickButtonValue);
                        btnList[randomIndex] = null;
                        index++;
                    }

                }
            }

        }
        public Form1()
        {
            InitializeComponent();

            Button[] btnList = new Button[] {
                                            this.button1,
                                            this.button2,
                                            this.button3,
                                            this.button4,
                                            this.button5,
                                            this.button6,
                                            this.button7,
                                            this.button8,
                                            this.button9,
                                            this.button10,
                                            this.button11,
                                            this.button12,
                                            this.button13,
                                            this.button14,
                                            this.button15,
                                            this.button16
                                        };
            generateNumbers(btnList);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
