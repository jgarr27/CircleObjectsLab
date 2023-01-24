using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjectsLab
{
    public class Circle
    {
        //Properties
        public double Radius { get; set; }
        public double Pi = Math.PI;
        
        

        //Constructor
        public Circle(double _radius, double _area, double Pi)
        {
            Radius = _radius;
            
        }
        
        
            
        
        //methods
        public double CalculateArea(decimal pi, double _radius)
        {
            return Math.PI * _radius * _radius;
        }
    
        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }
        
    }
}
