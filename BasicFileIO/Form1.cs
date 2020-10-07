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
using System.Xml.Serialization;

namespace BasicFileIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitVariables();
        }

        private void InitVariables()
        {
            textBoxDisplay.Text = "Hi, Hello,Good,\r\nNext line.";
        }
         /*
         * 
         * ----------------------------
         * 이름           |     성별     |   나이   | 전공
         * varchar(MaX)   |     int      |   int    |varchar(Max)//int로 다른테이블의 id를 갖고올수도 있
         * ----------------------------------------------------------
         * 쨔잔나미 쥰           0           24      컴퓨터
         * 독사 요기바라         1           24      모바일 
         *보통바이너리로 다 처리를 하게된대 그래서 int도 tinyint bigint 등 다양한 자료형을 제공하기도 함
         *일단은 int로 정의 
         * 
         */  
        private void buttonBinaryWriter_Click(object sender, EventArgs e)
        {
            //long someValue = 0x123456789ABCDEF0;
            //long someValue = 123456789;

            BinaryWriter bw=new BinaryWriter(new FileStream("a.dat", FileMode.Create));
            bw.Write(2);
            bw.Write("Mr. Jun");
            bw.Write(0);
            bw.Write(24);
            bw.Write("Computer");

            bw.Write("Ms.rosy");//너 이자식
            bw.Write(1);
            bw.Write(24);
            bw.Write("Mobile");
            /* bw.Write(1234);
             bw.Write("Hello World");*/

            bw.Close();
            //function_bad();
        }
        /*
         * 위 파일은 헤더와 데이터로 구성이 된다.
         * 헤더는 첫 4바이트 값으로 아래의 내용을 포함한다.
         *           *4바이트:전체학생의 수(정수형)
         * 
         * 데이터는 헤더 이후에 바로 기록되어 있으며 데이터 형식은 다음의 형식에 맞게
         * 헤더에 기록된 학생 수 만큼 기록되어 있다.
         * 
         * -학생 데이터 형식-
         * 위데이터의 파일 포맷은
         * 1바이트:문자열의 길이(바이트형,N1)
         * N1 바이트:문자열(ASCII,이름)
         * 4바이트:성별(정수형,0-남자,1-여자)
         * 4바이트:나이(정수형)
         * 1바이트:문자열의 길이(바이트형,N1)
         * N1 바이트:문자열(ASCII,전공)
         */
        private void buttonBinaryReader_Click(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(new FileStream("a.dat", FileMode.Open));
            int num1 = br.ReadInt32();
            String str = br.ReadString();
            Console.WriteLine("Rad Int = "+num1);
            Console.WriteLine("Read str=" + str);
            br.Close();
        }
        
        private void buttonStreamWriter_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(new FileStream("a.txt",FileMode.Create));//bin debug에 생김
            sw.WriteLine(int.MaxValue);//WriteLine쓰면 랑니단위로 enter쳐짐 
            sw.WriteLine("Good Morning");
            sw.WriteLine(uint.MaxValue);
            sw.WriteLine("안녕하세요");
            sw.WriteLine(double.MaxValue);
            sw.Close();
        }

        private void ButtonStreamReader_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(new FileStream("a.txt", FileMode.Open));
            textBoxDisplay.Text = "";//있던글씨를 지운다는 얘기
            while (sr.EndOfStream == false)
            {
                textBoxDisplay.Text += sr.ReadLine();/*
                string text="1"
                test=test+"2"+"3";->test=123;요런 얘기
                */
                //Console.WriteLine(sr.ReadLine());
                textBoxDisplay.Text += "\r\n";
            }
            sr.Close();
        }

        private void textBoxDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
