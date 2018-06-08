using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Ink;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;

namespace PaintProgram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            GenerateDoc();//function to generate text
        }
        //update the click date to the text field
        
        private void MyCalendar_SelectedDatesChanged_1(object sender, SelectionChangedEventArgs e)
        {
            var calendar = sender as Calendar;
            if (calendar.SelectedDate.HasValue)
            {
                DateTime date = calendar.SelectedDate.Value;
                try
                {
                    tbDateCalendar.Text = date.ToLongDateString();
                }
                catch (NullReferenceException)
                { }
            }
        }
        private void DrawnButton_Click(object sender, RoutedEventArgs e )
        {
            var radiobutton = sender as RadioButton;//capture the information by the sender in a variable
            string radioBPressed = radiobutton.Content.ToString();//convert the content to a string
            if(radioBPressed == "Drawn")
            {
                this.DrawingCanvas.EditingMode = InkCanvasEditingMode.Ink;

            }else if(radioBPressed == "Erase")
            {
                this.DrawingCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
            }
            else if (radioBPressed == "Select")
            {
                this.DrawingCanvas.EditingMode = InkCanvasEditingMode.Select;
            }
        }
        private void DrawPanel_KeyUp(object sender, KeyEventArgs e)
        {
            if((int)e.Key >= 35 && (int)e.Key <= 68)
            {
                switch((int)e.Key)
                {
                    case 35:
                        strokeAttr.Width = 2;
                        strokeAttr.Height = 2;
                        break;
                    case 36:
                        strokeAttr.Width = 4;
                        strokeAttr.Height = 4;
                        break;
                    case 37:
                        strokeAttr.Width = 6;
                        strokeAttr.Height = 6;
                        break;
                    case 38:
                        strokeAttr.Width = 8;
                        strokeAttr.Height = 8;
                        break;
                    case 45:
                        strokeAttr.Color =(Color) ColorConverter.ConvertFromString("Blue");
                        break;
                    case 50:
                        strokeAttr.Color = (Color)ColorConverter.ConvertFromString("Green");
                        break;
                    case 69:
                        strokeAttr.Color = (Color)ColorConverter.ConvertFromString("Yellow");
                        break;
                }
            }
        }//end of DrawnPanel_KeyUp

        private void Save(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = new FileStream("MyPicture.bin", FileMode.Create))
            {     
                this.DrawingCanvas.Strokes.Save(fs);
            }
        }//end of SaveButton_Click

        private void Open(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = new FileStream("MyPicture.bin", FileMode.Open))
            {
                StrokeCollection sc = new StrokeCollection(fs);
                this.DrawingCanvas.Strokes = sc;
            }
        }

        private void GenerateDoc()
        {
            FlowDocument doc = new FlowDocument();

            Paragraph para = new Paragraph(new Run("Game of Thrones is an American fantasy" +
                " drama television series created by David Benioff and D. B. Weiss. It is an adaptation" +
                " of A Song of Ice and Fire, George R. R. Martin's series of fantasy novels, the first of" +
                " which is A Game of Thrones. It is filmed in Belfast and elsewhere in the United Kingdom," +
                " Canada, Croatia, Iceland, Malta, Morocco, Spain, and the United States. The series premiered" +
                " on HBO in the United States on April 17, 2011, and its seventh season ended on August 27, 2017." +
                " The series will conclude with its eighth season premiering in 2019"));

            doc.Blocks.Add(para);

            para = new Paragraph(new Run("Set on the fictional continents of Westeros and Essos, Game of Thrones has" +
                " several plot lines and a large ensemble cast but centers on three primary story arcs. The first story" +
                " arc centers on the Iron Throne of the Seven Kingdoms and follows a web of alliances and conflicts among" +
                " the dynastic noble families either vying to claim the throne or fighting for independence from the throne." +
                " The second story arc focuses on the last descendant of the realm's deposed ruling dynasty, exiled and plotting" +
                " a return to the throne. The third story arc centers on the longstanding brotherhood charged with defending the" +
                " realm against the ancient threats of the fierce peoples and legendary creatures that lie far north, and an impending" +
                " winter that threatens the realm."))
            {
                FontSize = 14,
                FontStyle = FontStyles.Italic,
                Foreground = Brushes.Green
        };

            doc.Blocks.Add(para);
            //add the new paragraphs to the scroll document generate
            FdsScrollViewer.Document = doc;
        }//end of Generate Doc

        private void RichTb_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            RichTextBox rtb = sender as RichTextBox;
            if (rtb == null) return;

            ContextMenu contextMenu = rtb.ContextMenu;
            //make it appaer when you right click it
            contextMenu.PlacementTarget = rtb;

            contextMenu.Placement = PlacementMode.RelativePoint;

            TextPointer position = rtb.Selection.End;
            if (position == null) return;

            Rect positionRect = position.GetCharacterRect(LogicalDirection.Forward);
            contextMenu.HorizontalOffset = positionRect.X;
            contextMenu.VerticalOffset = positionRect.Y;

            contextMenu.IsOpen = true;
            e.Handled = true;

        }
        //Saving and loading the content at the RichtextBox
        private void saveRTBContent(object sender, RoutedEventArgs e)
        {
            //defines the rnge of text to save
            TextRange range = new TextRange(RichTb.Document.ContentStart, RichTb.Document.ContentEnd);
            //create a stream to write the file
            FileStream fstream = new FileStream("C:\\Users\\Diogo\\Documents\\diogo\\test.xaml", FileMode.Create);

            //Save the content
            range.Save(fstream, DataFormats.XamlPackage);
            fstream.Close();
        }
        //Load the text to the RichTextBox
        private void openRTBContent(object sender, RoutedEventArgs e)
        {
            TextRange range;
            FileStream fileStream;
            if (File.Exists("C:\\Users\\documents\\diogo\\data\\test.xaml")) 
            {
                range = new TextRange(RichTb.Document.ContentStart, RichTb.Document.ContentEnd);
                fileStream = new FileStream("C:\\Users\\diogo\\data\\test.xaml", FileMode.Create);
                range.Load(fileStream, DataFormats.XamlPackage);
                fileStream.Close();
            }
        }
    }
}
