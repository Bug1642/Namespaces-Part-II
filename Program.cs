using System;
using Exercise;
namespace Exercise {

    public class Widget{
        public int viewed;

        public Widget(){
            viewed = 0;
        }
    }
         public class Test{
            public void TestWidget(Widget widget){
                widget.viewed +=1;
            }
         }
    }
    class Program{
        static void Main(string [] args ){
            Widget myWidget = new Widget();
            Console.WriteLine($"Initial viewed count: {myWidget.viewed}");

            Test timer = new Test();
            timer.TestWidget(myWidget);
            Console.WriteLine($"My Widget Timer after increment: {myWidget.viewed}");

            timer.TestWidget(myWidget);
            Console.WriteLine($"My Widget Timer after increment: {myWidget.viewed}");

            timer.TestWidget(myWidget);
            Console.WriteLine($"My Widget Timer after increment: {myWidget.viewed}");
            
        }
    }

