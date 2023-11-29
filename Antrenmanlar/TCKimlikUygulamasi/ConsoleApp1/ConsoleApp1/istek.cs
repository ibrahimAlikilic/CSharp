using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class istek
    {
        private string tc;

        public bool ab;

        public string tckimlikno
        {
            get
            {
                return tc.Substring(0,5);
            }
            set
            {
                bool kontrol=false;

                if (value.Length == 11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool sayimi = char.IsNumber(value[i]);
                        if (sayimi)
                        {
                            kontrol = false;
                        }
                        else
                        {
                            kontrol=true;
                            break;
                        }
                    }
                    if (kontrol)
                    {
                        Console.WriteLine("tc'nin tamamı sayısal karakter olmalı !");
                        ab = false;
                    }
                    else
                    {
                        tc = value;
                        ab = true;
                    }
                }
                else
                {
                    ab = false;
                }
            }
        }
    }
}
