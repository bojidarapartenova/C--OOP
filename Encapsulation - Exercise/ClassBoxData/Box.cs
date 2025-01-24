namespace ClassBoxData
{
    public class Box
    {
        public Box(double length, double width, double height)
        {
            if(length<=0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }

            if(width<=0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }

            if(height<=0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }

            Length = length;
            Width = width;
            Height = height;
        }

        public double Length { get; private set; }
        public double Width { get; private set; }
        public double Height { get; private set; }
        public double SurfaceArea()
        {
            double surfaceArea = 2 * (Length * Width + Width * Height + Height * Length);
            return surfaceArea;
        }

        public double LateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * (Length * Height + Width * Height);
            return lateralSurfaceArea;
        }

        public double Volume()
        {
            double volume = Length * Width * Height;
            return volume;
        }
    }
}
