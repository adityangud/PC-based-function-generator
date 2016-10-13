using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace project
{
    public partial class Form1 : Form
    {
        byte[] b =new byte[1];
        byte[] temp = new byte[1];
        int count = 0;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            count++;
          //  if (count > 1)
            //    serialPort1.Write(temp, 0, 1);
            if (count > 1)
                serialPort1.Write(temp, 0, 1);
            else
                serialPort1.Write(b, 0, 1);
            Square.Checked =false;
            Sine.Checked =false;
            Sawtooth.Checked = false;
            Triangular.Checked =false;

            b[0] = (byte)0x80; 
        }


        private void Square_CheckedChanged(object sender, EventArgs e)
        {

            if (Square.Checked == true)
            {
                
                b[0] = (byte)0x80;
                temp[0] = b[0];
                
            }
            

        }

        private void Sine_CheckedChanged(object sender, EventArgs e)
        {

            if (Sine.Checked == true)
            {
                
                b[0] = (byte)0xA0;
                temp[0] = b[0];
                count = 0;
            }
            
            
        }

        private void Sawtooth_CheckedChanged(object sender, EventArgs e)
        {
            if (Sawtooth.Checked== true)
            {
                
                b[0] = (byte)0xC0;
                temp[0] = b[0];
                count = 0;
              
            }
            
        }

        private void Triangular_CheckedChanged(object sender, EventArgs e)
        {  

            if (Triangular.Checked == true)
            {
                
                b[0] = (byte)0xE0;
                temp[0] = b[0];
                count = 0;
            }
           
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0; 
        for (i = 0; i <= 7; i++)
        {
            if (listBox1.GetSelected(i) == true)
            {
                
                count = 0;
                
                switch (i)
                {
                    case 0: b[0] = (byte)((int)b[0] | 0x00); break;
                    case 1: b[0] = (byte)((int)b[0] | 0x01); break;
                    case 2: b[0] = (byte)((int)b[0] | 0x02); break;
                    case 3: b[0] = (byte)((int)b[0] | 0x03); break;
                    case 4: b[0] = (byte)((int)b[0] | 0x04); break;
                    case 5: b[0] = (byte)((int)b[0] | 0x05); break;
                    case 6: b[0] = (byte)((int)b[0] | 0x06); break;
                    case 7: b[0] = (byte)((int)b[0] | 0x07); break;

                }
                temp[0] = b[0];
            }
           
        }
       

        }

       
    }
}