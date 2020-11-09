using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    //this machine is for making esspressos
    public class EsspressoMachine : HotDrinkMachine
    {
        public EsspressoMachine(string brandName) : base(brandName)
        {

        }

        public override double FillWater(double cups)
        {
            WaterAmount = 0.1 * cups;
            return WaterAmount;
        }

        public override void InsertProduct()
        {
            this.ProductType = EProductType.Esspresso;
        }
        public override string BrewHotDrink(double cups)
        {
            FillWater(cups);
            InsertProduct();

            return "You've succesfully made " + cups + " cups of esspresso";
        }
    }
}
