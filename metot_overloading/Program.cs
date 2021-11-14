using System;

namespace metot_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** TryParse kullanımı****");
            string a="1012";
            bool sonuc=int.TryParse(a, out int yenia);
            if(sonuc)
            Console.WriteLine("eski a string 1012 ydi yeni a int 1012 oldu "+yenia);
            else
            Console.WriteLine("islem basarısız oldu");

            Console.WriteLine("Metotlarda alt parametre kullanımı");
            int d1=3,d2=2,result=0;
            Metotlar volki=new Metotlar();
            volki.topla(d1,d2,out result);
            Console.WriteLine(result);
            
            Console.WriteLine("Metotlarda asiri yukeleme kullanımı");
            volki.ekranayazdir(a);
            volki.ekranayazdir(d1,d2);
            volki.ekranayazdir(d1);

        }
    }
    class Metotlar{
        public void topla(int a,int b,out int c){
            c=a+b;
        }
        public void ekranayazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void ekranayazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void ekranayazdir(int veri1,int veri2)
        {
            Console.WriteLine(veri1+""+veri2);
        }
        
    }
}
