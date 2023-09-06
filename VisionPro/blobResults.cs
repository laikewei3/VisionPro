using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionPro
{
    public class blobResults
    {
        public int N { get; set; }
        public int ID { get; set; }
        public double Area { get; set; }
        public double CenterMassX { get; set; }
        public double CenterMassY { get; set; }
        public String ConnectivityLabel { get; set; }
        public double Angle { get; set; }
        public double BoundaryPixelLength { get; set; }
        public double Perimeter { get; set; }
        public double NumChildren { get; set; }
        public double InertiaX { get; set; }
        public double InertiaY { get; set; }
        public double InertiaMin { get; set; }
        public double InertiaMax { get; set; }
        public double Elongation { get; set; }
        public double Acircularity { get; set; }
        public double AcircularityRms { get; set; }
        public double ImageBoundCenterX { get; set; }
        public double ImageBoundCenterY { get; set; }
        public double ImageBoundMinX { get; set; }
        public double ImageBoundMaxX { get; set; }
        public double ImageBoundMinY { get; set; }
        public double ImageBoundMaxY { get; set; }
        public double ImageBoundWidth { get; set; }
        public double ImageBoundHeight { get; set; }
        public double ImageBoundAspect { get; set; }
        public double MedianX { get; set; }
        public double MedianY { get; set; }
        public double BoundCenterX { get; set; }
        public double BoundCenterY { get; set; }
        public double BoundMinX { get; set; }
        public double BoundMaxX { get; set; }
        public double BoundMinY { get; set; }
        public double BoundMaxY { get; set; }
        public double BoundWidth { get; set; }
        public double BoundHeight { get; set; }
        public double BoundAspect { get; set; }
        public double BoundPrincipalMinX { get; set; }
        public double BoundPrincipalMaxX { get; set; }
        public double BoundPrincipalMinY { get; set; }
        public double BoundPrincipalMaxY { get; set; }
        public double BoundPrincipalWidth { get; set; }
        public double BoundPrincipalHeight { get; set; }
        public double BoundPrincipalAspect { get; set; }
        public double NotClipped { get; set; }

        public blobResults(int n, int Id, double area, double centerMassX, double centerMassY, String connectivityLabel, double angle, double boundaryPixelLength, double perimeter, double numChildren, double inertiaX, double inertiaY, double inertiaMin, double inertiaMax, double elongation, double acircularity, double acircularityRms, double imageBoundCenterX, double imageBoundCenterY, double imageBoundMinX, double imageBoundMaxX, double imageBoundMinY, double imageBoundMaxY, double imageBoundWidth, double imageBoundHeight, double imageBoundAspect, double medianX, double medianY, double boundCenterX, double boundCenterY, double boundMinX, double boundMaxX, double boundMinY, double boundMaxY, double boundWidth, double boundHeight, double boundAspect, double boundPrincipalMinX, double boundPrincipalMaxX, double boundPrincipalMinY, double boundPrincipalMaxY, double boundPrincipalWidth, double boundPrincipalHeight, double boundPrincipalAspect, double notClipped)
        {
            N = n;
            ID = Id;
            Area = area;
            CenterMassX = centerMassX;
            CenterMassY = centerMassY;
            ConnectivityLabel = connectivityLabel;
            Angle = angle;
            BoundaryPixelLength = boundaryPixelLength;
            Perimeter = perimeter;
            NumChildren = numChildren;
            InertiaX = inertiaX;
            InertiaY = inertiaY;
            InertiaMin = inertiaMin;
            InertiaMax = inertiaMax;
            Elongation = elongation;
            Acircularity = acircularity;
            AcircularityRms = acircularityRms;
            ImageBoundCenterX = imageBoundCenterX;
            ImageBoundCenterY = imageBoundCenterY;
            ImageBoundMinX = imageBoundMinX;
            ImageBoundMaxX = imageBoundMaxX;
            ImageBoundMinY = imageBoundMinY;
            ImageBoundMaxY = imageBoundMaxY;
            ImageBoundWidth = imageBoundWidth;
            ImageBoundHeight = imageBoundHeight;
            ImageBoundAspect = imageBoundAspect;
            MedianX = medianX;
            MedianY = medianY;
            BoundCenterX = boundCenterX;
            BoundCenterY = boundCenterY;
            BoundMinX = boundMinX;
            BoundMaxX = boundMaxX;
            BoundMinY = boundMinY;
            BoundMaxY = boundMaxY;
            BoundWidth = boundWidth;
            BoundHeight = boundHeight;
            BoundAspect = boundAspect;
            BoundPrincipalMinX = boundPrincipalMinX;
            BoundPrincipalMaxX = boundPrincipalMaxX;
            BoundPrincipalMinY = boundPrincipalMinY;
            BoundPrincipalMaxY = boundPrincipalMaxY;
            BoundPrincipalWidth = boundPrincipalWidth;
            BoundPrincipalHeight = boundPrincipalHeight;
            BoundPrincipalAspect = boundPrincipalAspect;
            NotClipped = notClipped;
        }
    }
}
