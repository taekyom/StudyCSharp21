using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter09App
{
    class Myclass
    {
        private int ivalue; //0~120℃ 까지의 값만 입력받는 멤버변수
        private double dZeta;
        private float fPng;
        private string strVal;
        private int inCode;

        private int IValue 
        {
            get 
            {
                return this.ivalue;
            }
            set 
            {
                if (value < 0)
                    this.ivalue = 0;
                else if (value > 120)
                    this.ivalue = 120;
                else
                    this.ivalue = value;
            } 
        }

        public Myclass(int ivalue)
        {
            IValue = ivalue;
        }

        /*public int GetValue()
        {
            return this.ivalue;
        }
        
        public void SetValue(int ivalue)
        {
            if(value < 0)
            {
                this.ivalue = 0;
            }
            else if(ivalue > 120)
            {
                this.ivalue = 120;
            }
            else
            {
                this.ivalue = ivalue;
            }
        }*/

        public void printvalue()
        {
            Console.WriteLine($"값은 {IValue}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass myclass = new Myclass(1200);
            myclass.printvalue();

            /*myclass.SetValue(108);*/
            myclass.IValue = 1200;
            myclass.printvalue();
            /*Console.WriteLine($"현재 온도는 {myclass.GetValue()}℃");*/
            Console.WriteLine($"현재 온도는 {myclass.IValue}℃");
        }
    }
}
