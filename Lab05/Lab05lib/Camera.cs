namespace Lab05Lib
{
    public class Camera
    {
        public string Brand;
        public string Model;
        public string Type;
        public double Megapixels;
        public double Price;
        public double Weight;
        public bool HasWiFi;
        public bool Has4KVideo;

        // Нова властивість
        public bool IsProfessional
        {
            get { return HasWiFi && Has4KVideo && Megapixels >= 20; }
        }

        public double PricePerMegapixel
        {
            get { return GetPricePerMegapixel(); }
        }

        public double GetPricePerMegapixel()
        {
            return Megapixels > 0 ? Price / Megapixels : 0;
        }
    }
}
