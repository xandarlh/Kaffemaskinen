using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    public abstract class HotDrinkMachine
    {
        private string brandName;
        public string BrandName
        {
            get { return brandName; }
            protected set { brandName = value; }
        }
        private EProductType productType;
        public EProductType ProductType
        {
            get { return productType; }
            protected set { productType = value; }
        }
        private double waterAmount;
        public double WaterAmount
        {
            get { return waterAmount; }
            protected set { waterAmount = value; }
        }

        public abstract double FillWater(double cups);

        public abstract void InsertProduct();
        
        public abstract string BrewHotDrink(double cups);

        public HotDrinkMachine(string brandName)
        {
            this.brandName = brandName;
        }

    }
}
