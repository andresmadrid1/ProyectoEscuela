using System;

namespace Melodias.Timbre
{
    class Melodia
    {
        /*public void Timbrar()
        {
            Console.Beep(660,100);
            System.Threading.Thread.Sleep(150);
            Console.Beep(660,100);
            System.Threading.Thread.Sleep(300);
            Console.Beep(660,100);
            System.Threading.Thread.Sleep(300);
            Console.Beep(510,100);
            System.Threading.Thread.Sleep(100);
            Console.Beep(660,100);
            System.Threading.Thread.Sleep(300);
            Console.Beep(770,100);
            System.Threading.Thread.Sleep(550);
            Console.Beep(380,100);
            System.Threading.Thread.Sleep(575);

            Console.Beep(510,100);
            System.Threading.Thread.Sleep(450);
            Console.Beep(380,100);
            System.Threading.Thread.Sleep(400);
            Console.Beep(320,100);
            System.Threading.Thread.Sleep(500);
            Console.Beep(440,100);
            System.Threading.Thread.Sleep(300);
            Console.Beep(480,80);
            System.Threading.Thread.Sleep(330);
            Console.Beep(450,100);
            System.Threading.Thread.Sleep(150);
            Console.Beep(430,100);
            System.Threading.Thread.Sleep(300);
            Console.Beep(380,100);
            System.Threading.Thread.Sleep(200);
            Console.Beep(660,80);
            System.Threading.Thread.Sleep(200);
            Console.Beep(760,50);
            System.Threading.Thread.Sleep(150);
            Console.Beep(860,100);
            System.Threading.Thread.Sleep(300);
            Console.Beep(700,80);
            System.Threading.Thread.Sleep(150);
            Console.Beep(760,50);
            System.Threading.Thread.Sleep(350);
            Console.Beep(660,80);
            System.Threading.Thread.Sleep(300);
            Console.Beep(520,80);
            System.Threading.Thread.Sleep(150);
            Console.Beep(580,80);
            System.Threading.Thread.Sleep(150);
            Console.Beep(480,80);
            System.Threading.Thread.Sleep(500);

            Console.Beep(510,100);
            System.Threading.Thread.Sleep(450);
            Console.Beep(380,100);
            System.Threading.Thread.Sleep(400);
            Console.Beep(320,100);
            System.Threading.Thread.Sleep(500);
            Console.Beep(440,100);
            System.Threading.Thread.Sleep(300);
            Console.Beep(480,80);
            System.Threading.Thread.Sleep(330);
            Console.Beep(450,100);
            System.Threading.Thread.Sleep(150);
            Console.Beep(430,100);
            System.Threading.Thread.Sleep(300);
            Console.Beep(380,100);
            System.Threading.Thread.Sleep(200);
            Console.Beep(660,80);
            System.Threading.Thread.Sleep(200);
            Console.Beep(760,50);
            System.Threading.Thread.Sleep(150);
            Console.Beep(860,100);
            System.Threading.Thread.Sleep(300);
            Console.Beep(700,80);
            System.Threading.Thread.Sleep(150);
            Console.Beep(760,50);
            System.Threading.Thread.Sleep(350);
            Console.Beep(660,80);
            System.Threading.Thread.Sleep(300);
            Console.Beep(520,80);
            System.Threading.Thread.Sleep(150);
            Console.Beep(580,80);
            System.Threading.Thread.Sleep(150);
            Console.Beep(480,80);
            System.Threading.Thread.Sleep(500);

            Console.Beep(500,100);
            System.Threading.Thread.Sleep(300);

            Console.Beep(760,100);
            System.Threading.Thread.Sleep(100);
            Console.Beep(720,100);
            System.Threading.Thread.Sleep(150);
            Console.Beep(680,100);
            System.Threading.Thread.Sleep(150);
            Console.Beep(620,150);
            System.Threading.Thread.Sleep(300);

            Console.Beep(650,150);
            System.Threading.Thread.Sleep(300);
            Console.Beep(380,100);
            System.Threading.Thread.Sleep(150);
            Console.Beep(430,100);
            System.Threading.Thread.Sleep(150);

            Console.Beep(500,100);
            System.Threading.Thread.Sleep(300);
            Console.Beep(430,100);
            System.Threading.Thread.Sleep(150);
            Console.Beep(500,100);
            System.Threading.Thread.Sleep(100);
            Console.Beep(570,100);
            System.Threading.Thread.Sleep(220);

            Console.Beep(500,100);
            System.Threading.Thread.Sleep(300);

            Console.Beep(760,100);
            System.Threading.Thread.Sleep(100);
            Console.Beep(720,100);
            System.Threading.Thread.Sleep(150);
            Console.Beep(680,100);
            System.Threading.Thread.Sleep(150);
            Console.Beep(620,150);
            System.Threading.Thread.Sleep(300);

            Console.Beep(650,200);
            System.Threading.Thread.Sleep(300);

            Console.Beep(1020,80);
            System.Threading.Thread.Sleep(300);
            Console.Beep(1020,80);
            System.Threading.Thread.Sleep(150);           
            Console.Beep(1020,80);
            System.Threading.Thread.Sleep(300);

            Console.Beep(380,100);
            System.Threading.Thread.Sleep(300);
            Console.Beep(500,100);
            System.Threading.Thread.Sleep(300);

            Console.Beep(760,100);
            System.Threading.Thread.Sleep(100);
            Console.Beep(720,100);
            System.Threading.Thread.Sleep(150);
            Console.Beep(680,100);
            System.Threading.Thread.Sleep(150);
            Console.Beep(620,150);
            System.Threading.Thread.Sleep(300);

            Console.Beep(650,150);
            System.Threading.Thread.Sleep(300);
            Console.Beep(380,100);
            System.Threading.Thread.Sleep(150);
            Console.Beep(430,100);
            System.Threading.Thread.Sleep(150);

            Console.Beep(500,100);
            System.Threading.Thread.Sleep(300);
            Console.Beep(430,100);
            System.Threading.Thread.Sleep(150);
            Console.Beep(500,100);
            System.Threading.Thread.Sleep(100);
            Console.Beep(570,100);
            System.Threading.Thread.Sleep(420);

            Console.Beep(585,100);
            System.Threading.Thread.Sleep(450);

            Console.Beep(585,100);
            System.Threading.Thread.Sleep(420);

            Console.Beep(500,100);
            System.Threading.Thread.Sleep(360);

            Console.Beep(380,100);
            System.Threading.Thread.Sleep(300);
            Console.Beep(500,100);
            System.Threading.Thread.Sleep(300); 
            Console.Beep(500,100);
            System.Threading.Thread.Sleep(150); 
            Console.Beep(500,100);
            System.Threading.Thread.Sleep(300);

            Console.Beep(500,100);
            System.Threading.Thread.Sleep(300);

            Console.Beep(760,100);
            System.Threading.Thread.Sleep(100);
            Console.Beep(720,100);
            System.Threading.Thread.Sleep(150);
            Console.Beep(680,100);
            System.Threading.Thread.Sleep(150);
            Console.Beep(620,150);
            System.Threading.Thread.Sleep(300);

            Console.Beep(650,150);
            System.Threading.Thread.Sleep(300);
            Console.Beep(380,100);
            System.Threading.Thread.Sleep(150);
            Console.Beep(430,100);
            System.Threading.Thread.Sleep(150);

            Console.Beep(500,100);
            System.Threading.Thread.Sleep(300);
            Console.Beep(430,100);
            System.Threading.Thread.Sleep(150);
            Console.Beep(500,100);
            System.Threading.Thread.Sleep(100);
            Console.Beep(570,100);
            System.Threading.Thread.Sleep(220); 

            Console.Beep(500,100);
            System.Threading.Thread.Sleep(300);

            Console.Beep(760,100);
            System.Threading.Thread.Sleep(100);
            Console.Beep(720,100);
            System.Threading.Thread.Sleep(150);
            Console.Beep(680,100);
            System.Threading.Thread.Sleep(150);
            Console.Beep(620,150);
            System.Threading.Thread.Sleep(300);

            Console.Beep(650,200);
            System.Threading.Thread.Sleep(300);

            Console.Beep(1020,80);
            System.Threading.Thread.Sleep(300);
            Console.Beep(1020,80);
            System.Threading.Thread.Sleep(150);           
            Console.Beep(1020,80);
            System.Threading.Thread.Sleep(300);

            Console.Beep(380,100);
            System.Threading.Thread.Sleep(300);
            Console.Beep(500,100);
            System.Threading.Thread.Sleep(300);

            Console.Beep(760,100);
            System.Threading.Thread.Sleep(100);
            Console.Beep(720,100);
            System.Threading.Thread.Sleep(150);
            Console.Beep(680,100);
            System.Threading.Thread.Sleep(150);
            Console.Beep(620,150);
            System.Threading.Thread.Sleep(300);

            Console.Beep(650,150);
            System.Threading.Thread.Sleep(300);
            Console.Beep(380,100);
            System.Threading.Thread.Sleep(150);
            Console.Beep(430,100);
            System.Threading.Thread.Sleep(150);

            Console.Beep(500,100);
            System.Threading.Thread.Sleep(300);
            Console.Beep(430,100);
            System.Threading.Thread.Sleep(150);
            Console.Beep(500,100);
            System.Threading.Thread.Sleep(100);
            Console.Beep(570,100);
            System.Threading.Thread.Sleep(420);

            Console.Beep(585,100);
            System.Threading.Thread.Sleep(450);

            Console.Beep(585,100);
            System.Threading.Thread.Sleep(420);

            Console.Beep(500,100);
            System.Threading.Thread.Sleep(360);

            Console.Beep(380,100);
            System.Threading.Thread.Sleep(300);
            Console.Beep(500,100);
            System.Threading.Thread.Sleep(300); 
            Console.Beep(500,100);
            System.Threading.Thread.Sleep(150); 
            Console.Beep(500,100);
            System.Threading.Thread.Sleep(300);

            Console.Beep(500,60);
            System.Threading.Thread.Sleep(150);
            Console.Beep(500,80);
            System.Threading.Thread.Sleep(300);
            Console.Beep(500,80);
            System.Threading.Thread.Sleep(350);
            Console.Beep(500,80);
            System.Threading.Thread.Sleep(150);
            Console.Beep(580,80);
            System.Threading.Thread.Sleep(350);
            Console.Beep(660,80);
            System.Threading.Thread.Sleep(150);
            Console.Beep(500,80);
            System.Threading.Thread.Sleep(300);
            Console.Beep(430,80);
            System.Threading.Thread.Sleep(150);
            Console.Beep(380,80);
            System.Threading.Thread.Sleep(600);

            Console.Beep(500,60);
            System.Threading.Thread.Sleep(150);
            Console.Beep(500,80);
            System.Threading.Thread.Sleep(300);
            Console.Beep(500,60);
            System.Threading.Thread.Sleep(350);
            Console.Beep(500,80);
            System.Threading.Thread.Sleep(150);
            Console.Beep(580,80);
            System.Threading.Thread.Sleep(150);
            Console.Beep(660,80);
            System.Threading.Thread.Sleep(550);

            Console.Beep(870,80);
            System.Threading.Thread.Sleep(150);
            Console.Beep(760,80);
            System.Threading.Thread.Sleep(600);

            Console.Beep(500,60);
            System.Threading.Thread.Sleep(150);
            Console.Beep(500,80);
            System.Threading.Thread.Sleep(300);
            Console.Beep(500,80);
            System.Threading.Thread.Sleep(350);
            Console.Beep(500,80);
            System.Threading.Thread.Sleep(150);
            Console.Beep(580,80);
            System.Threading.Thread.Sleep(350);
            Console.Beep(660,80);
            System.Threading.Thread.Sleep(150);
            Console.Beep(500,80);
            System.Threading.Thread.Sleep(300);
            Console.Beep(430,80);
            System.Threading.Thread.Sleep(150);
            Console.Beep(380,80);
            System.Threading.Thread.Sleep(600);

            Console.Beep(660,100);
            System.Threading.Thread.Sleep(150);
            Console.Beep(660,100);
            System.Threading.Thread.Sleep(300);
            Console.Beep(660,100);
            System.Threading.Thread.Sleep(300);
            Console.Beep(510,100);
            System.Threading.Thread.Sleep(100);
            Console.Beep(660,100);
            System.Threading.Thread.Sleep(300);
            Console.Beep(770,100);
            System.Threading.Thread.Sleep(550);
            Console.Beep(380,100);
            System.Threading.Thread.Sleep(575);
        }*/
    }
}