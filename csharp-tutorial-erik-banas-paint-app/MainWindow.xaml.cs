using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PaintApp_continuous_education
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //define enums for the shapes
        private enum MyShape
        {
            Line, Ellipse, Rectangle
        }

        private MyShape currShape = MyShape.Line;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void LineButton_Click(object sender, RoutedEventArgs e)
        {
            currShape = MyShape.Line;
        }

        private void EllipseButton_Click(object sender, RoutedEventArgs e)
        {
            currShape = MyShape.Ellipse;
        }

        private void RectangleButton_Click(object sender, RoutedEventArgs e)
        {
            currShape = MyShape.Rectangle;
        }

        //need to define the starting point and the end point
        Point start;
        Point end;

        private void MyCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            start = e.GetPosition(this);
        }

        private void MyCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            switch(currShape)
            {
                case MyShape.Line:
                    DrawLine();
                    break;
                case MyShape.Ellipse:
                    DrawEllipse();
                    break;
                case MyShape.Rectangle:
                    DrawRectangle();
                    break;
                default:
                    return;
            }
        }

        //track changes in x y
        private void MyCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)//if the mouse buttons is pressed
            {
                end = e.GetPosition(this);
            }
              
        }

        //drawing functions

        private void DrawLine()
        {
            Line newLine = new Line()
            {
                Stroke = Brushes.Blue,
                X1 = start.X,
                Y1 = start.Y - 50,
                X2 = end.X,
                Y2 = end.Y - 50

            };
            MyCanvas.Children.Add(newLine);
        }

        private void DrawEllipse()
        {
            Ellipse newEllipse = new Ellipse()
            {
                Stroke = Brushes.Green,
                Fill = Brushes.Red,
                StrokeThickness = 4,
                Height = 10,
                Width = 10
            };
            //you have to change Left and top
            //property together with the user movement
            //otherwise you get an error

            if(end.X >= start.X)
            {
                //defines left part of the Ellipse
                newEllipse.SetValue(Canvas.LeftProperty, end.X);//set the value of the new eclipse as end of X
                newEllipse.Width = end.X - start.X;//new Eclipse begin at the end of x - star of x
            }
            else
            {
                newEllipse.SetValue(Canvas.LeftProperty, end.X);
                newEllipse.Width = start.X - end.X;//new Eclipse begin at the start of x - end of x
            }

            if(end.Y >= start.Y)
            {
                //defines the top of Ellipse
                newEllipse.SetValue(Canvas.TagProperty, start.Y - 50);
                newEllipse.Height = end.Y - start.Y;
            }else
            {
                newEllipse.SetValue(Canvas.TagProperty, end.Y - 50);
                newEllipse.Height = start.Y - end.Y;
            }

            MyCanvas.Children.Add(newEllipse);
        }

        //draws rectangle after the mouse is released
        private void DrawRectangle()
        {
            Rectangle newRectangle = new Rectangle()
            {
                Stroke = Brushes.Orange,
                Fill = Brushes.Blue,
                StrokeThickness = 4
            };

            if (end.X >= start.X)
            {
                //defines left part of rectangle
                newRectangle.SetValue(Canvas.LeftProperty, start.X);
                newRectangle.Width = end.X - start.X;
            }
            else
            {
                newRectangle.SetValue(Canvas.LeftProperty, end.X);
                newRectangle.Width = start.X - end.X;
            }

            if(end.Y >= start.Y)
            {
                //defienes top of rectangle
                newRectangle.SetValue(Canvas.TopProperty, start.Y - 50);
                newRectangle.Height = end.Y - start.Y;
             }
            else
            {
                newRectangle.SetValue(Canvas.TopProperty, end.Y - 50);
                newRectangle.Height = start.Y - end.Y;
            }

            MyCanvas.Children.Add(newRectangle);
        }
    }
}
