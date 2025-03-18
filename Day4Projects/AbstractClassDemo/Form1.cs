using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AbstractClassDemo.Form1;

namespace AbstractClassDemo
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
                public abstract class Polygon
                {
                    public void testFunction()
                    {

                        MessageBox.Show("*************************");

                    }

                    public abstract void Area(int x, int y);

                }
                class Triangle : Polygon
                {
                    public override void Area(int x, int y)
                    {
                         MessageBox.Show("Area of Triangle: " + 0.5 * x * y);
                    }
                }
                class Rectangle : Polygon
                {
                    public override void Area(int x, int y)
                    {
                        MessageBox.Show("The area of rectangle is " + (x * y));
                    }
                }

                private void button1_Click(object sender, EventArgs e)
                {
                    Polygon obj;
                    obj = new Triangle();
                    obj.Area(12, 34);
                    obj = new Rectangle();
                    obj.Area(12, 4);
                    obj.testFunction();

                }*/

        //now another class comes square he is asking me to implement area() in polygon class but trinalge and rectanle though they
        //dont want they have to implentn that abstarct fucntion so asked squre to implement seeprate abstarct class
        //so code is here
        
        public abstract class Polygon2
        {
            public abstract void area(int s);
        }
        public abstract class Polygon
        {
            public void testfunction()
            {
                MessageBox.Show("*************************");
            }
            public abstract void area(int x, int y);
            // public abstract void area(int s); cant put here as traingle and rectanlge 
            // have to override though they dont require it ...so seperate abstarct class 
        }
        class Traingle : Polygon
        {
            public override void area(int x, int y)
            {
                MessageBox.Show("The area of triangle is " + 0.5 * x * y);

            }


        }

        class Rectangle : Polygon
        {
            public override void area(int x, int y)
            {
                MessageBox.Show("The area of rectangle is " + (x * y));
            }
        }

        class square : Polygon2
        {
            public override void area(int s)
            {
                MessageBox.Show("The area of squre is " + (s * s));
            }
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Polygon obj;
        //    obj = new Traingle();
        //    obj.area(12, 34);
        //    obj = new Rectangle();
        //    obj.area(12, 4);
        //    Polygon2 obj2;
        //    obj2 = new square();
        //    obj2.area(12);
        //    obj.testfunction();



        //}


     

        interface A
    {
        void area(int s);


    }

    interface B
    {
        void area(int x, int y);
    }
    // here i can implement multiple interfaces can inherit only one class 
    class newshape : A, B
    {
        public void area(int s)
        {
            throw new NotImplementedException();
        }

        public void area(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
    // one abstract and one interfac  is possible 
    class newshape2 : Polygon2, B
    {
        public override void area(int s)
        {
            throw new NotImplementedException();
        }
        public void area(int x, int y)
        {
            throw new NotImplementedException();
        }

           
        }
        // another thing is one clas and one interface 
        private void button1_Click(object sender, EventArgs e)
        {
            Polygon obj;
            obj = new Traingle();
            obj.area(12, 34);
            obj = new Rectangle();
            obj.area(12, 4);
            Polygon2 obj2;
            obj2 = new square();
            obj2.area(12);
            obj.testfunction();
            A aobj;
            aobj = new newshape();
            aobj.area(12);
            B bobj;
            bobj = new newshape();
            bobj.area(12, 4);



        }
    }
}
