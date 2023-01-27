class Circle
    {
        private Point centre;
        private int radius;


        public Circle(Point c, int r)
        {
            centre = c;
            radius = r;
        }

        public void Area()
        {
            Console.WriteLine(Math.PI * radius * radius);
        }

        public void Circumference()
        {
            Console.WriteLine(2 * Math.PI * radius);
        }

        public void Display()
        {
            Console.WriteLine($"Point: ");
            centre.Display();
            Console.WriteLine($"Radius: {radius}");
        }
    }

class Point
    {
        private int x;
        private int y;
       


        public Point(int xarg, int yarg)
        {
            x = xarg;
            y = yarg;

        }

        public Point(int xarg)
        {
            x = xarg;
            y = 0;
        }

        public void Display()
        {
            Console.WriteLine($"[{x}, {y}]");
        }
    }
   Class Program
   {
        static void Main(string[] args)
        {     
        
            //Point p9 = new Point(9, 10);
            //int r5 = 10;

            Console.WriteLine("What is the value for x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the value for y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Point p9 = new Point(x, y);
            Console.WriteLine("What is the value of the radius: ");
            int r5 = Convert.ToInt32(Console.ReadLine());

            Circle c1 = new Circle(p9, r5);
            
       
            c1.Display();
            Console.WriteLine($"Area: ");
            c1.Area();
            Console.WriteLine("Circumference: ");
            c1.Circumference();
            
        }
   }
