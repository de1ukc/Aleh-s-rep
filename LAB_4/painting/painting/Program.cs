using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace painting
{
    static class DLL
    {
       [DllImport("User32.dll")] public static extern IntPtr GetDC(IntPtr Window);
      
       [DllImport("User32.dll")] public static extern void ReleaseDC(IntPtr Window, IntPtr dc);
    }
    
    

    class Program
    {
        static void Main(string[] args)
        {
            IntPtr ptrOfDesktop = DLL.GetDC(IntPtr.Zero);
            Graphics graf = Graphics.FromHdc(ptrOfDesktop); // указал , где рисовать 
            
            SolidBrush myBrash = new SolidBrush(Color.Aqua); // определил цвет кисти 
            
            String myString = "This painting is so stupid"; // выходная строка
            
            Font myFont = new Font("NewTimesRoman", 60); // шрифт , размер

            StringFormat myFormat = new StringFormat();
            
            myFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft; // указываем горизонтальное выравнивание
            
            Point pnt_1 = new Point(800, 300);
            Point pnt_2 = new Point(1500, 100);

            while (true) 
            {
            graf.DrawString(myString,myFont,myBrash,pnt_2,myFormat);
            graf.DrawImage(Image.FromFile("D:/Rider_LABS/LAB_4/painting/Tom.jpg"), pnt_1); ;
                
            }
            //graf.Dispose(); // затираем объект
            //DLL.ReleaseDC(IntPtr.Zero, ptrOfDesktop); // особождаем указатель 
            // в данном примере не выполнится, поскольку мы не выходим из цикла, но нужно использовать в других случаях
        }
    }
}