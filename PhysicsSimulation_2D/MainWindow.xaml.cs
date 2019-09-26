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

namespace PhysicsSimulation_2D
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const double G = 1; //Gravitational Constant
        public List<PhysicsObject> Objects { get; private set; }
        public float SimulationSpeed { get; set; } = 0.001f;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void Next()
        {
            foreach (PhysicsObject o in Objects)
            {
                //something
            }
            throw new NotImplementedException();
        }

        private void CalculateGravityVector(int index)
        {
            for (int i = 0; i < Objects.Count; i++)
            {
                if (i != index)
                {
                    double distanceSquared = Math.Pow(Objects[index].X - Objects[i].X, 2) + Math.Pow(Objects[index].Y - Objects[i].Y, 2);
                    double force = G * Objects[index].Mass * Objects[i].Mass / distanceSquared;

                    Objects[index].VX += (Objects[index].X - Objects[i].X) / Math.Sqrt(distanceSquared) * force;
                    Objects[index].VY += (Objects[index].Y - Objects[i].Y) / Math.Sqrt(distanceSquared) * force;
                }
            }
        }

        private void RenderEllipseButton_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            int size = r.Next(20, 300);
            Ellipse el = new Ellipse()
            {
                VerticalAlignment = VerticalAlignment.Top,
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(r.NextDouble() * (CanvasGrid.ActualWidth - size), r.NextDouble() * (CanvasGrid.ActualHeight - size), 0, 0),
                Height = size,
                Width = size,
                Fill = Brushes.LightYellow,
                Stroke = Brushes.Black,
                Visibility = Visibility.Visible
            };
            CanvasGrid.Children.Add(el);
        }
    }
}
