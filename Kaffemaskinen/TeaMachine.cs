using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    //this machine is for making tea
    public class TeaMachine : HotDrinkMachine
    {

        public TeaMachine(string brandName) : base(brandName)
        {

        }
        
        public override double FillWater(double cups)
        {
            WaterAmount = 0.5 * cups;
            return WaterAmount;
        }

        public override void InsertProduct()
        {
            this.ProductType = EProductType.BlackTea;
        }
        public override string BrewHotDrink(double cups)
        {
            FillWater(cups);
            InsertProduct();

            return "You've succesfully made " + cups + " cups of tea made from " + ProductType;
        }
    }
}
