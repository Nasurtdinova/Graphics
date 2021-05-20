using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class FiguresData
    {
        public string Name;
        public Dictionary<string, int> Data;

        public override string ToString()
        {
            return Name;
        }
    }
    static public class FigureFab
    {
        public static Figure Make(FiguresData figData)
        {
            Figure fig = null;

            switch (figData.Name)
            {
                case "Line":
                    fig = new Line(figData.Data["X1"], figData.Data["Y1"], figData.Data["X2"], figData.Data["Y2"]);
                    break;
                case "Circle":
                    fig = new Circle(figData.Data["X"], figData.Data["Y"], figData.Data["Radius"]);
                    break;
                case "Rectangle":
                    fig = new Rectangle(figData.Data["X"], figData.Data["Y"], figData.Data["Height"], figData.Data["Width"]);
                    break;
                case "Triangle":
                    fig = new Triangle(figData.Data["X"], figData.Data["Y"], figData.Data["X1"], figData.Data["Y1"], figData.Data["X2"], figData.Data["Y2"]);
                    break;
            }

            return fig;
        }

        public static List<FiguresData> InitFiguresData()
        {
            var figuresData = new List<FiguresData>();

            figuresData.Add(new FiguresData
            {
                Name = "Circle",
                Data = new Dictionary<string, int>
                {
                    { "X", 0 },
                    { "Y", 0 },
                    { "Radius", 0 }
                }
            });

            figuresData.Add(new FiguresData
            {
                Name = "Line",
                Data = new Dictionary<string, int>
                {
                    { "X1", 0 },
                    { "Y1", 0 },
                    { "X2", 0 },
                    { "Y2", 0 }
                }
            });

            figuresData.Add(new FiguresData
            {
                Name = "Rectangle",
                Data = new Dictionary<string, int>
                {
                    { "X", 0 },
                    { "Y", 0 },
                    { "Height", 0 },
                    { "Width", 0 }
                }
            });

            figuresData.Add(new FiguresData
            {
                Name = "Triangle",
                Data = new Dictionary<string, int>
                {
                    { "X", 0 },
                    { "Y", 0 },
                    { "X1", 0 },
                    { "Y1", 0 },
                    { "X2", 0 },
                    { "Y2", 0 },
                }
            });

            return figuresData;
        }
    }
}
