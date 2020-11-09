using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    //this machine makes coffee from beans
    public class GenericCoffeeMachine : HotDrinkMachine
    {
       
        public GenericCoffeeMachine(string brandName) : base(brandName)
        {
            this.ProductType = EProductType.CoffeeBeans;
        }
        private bool filterInserted;
        public bool FilterInserted
        {
            get { return filterInserted; }
            set { filterInserted = value; }
        }
        public void InsertFilter()
        {
            this.filterInserted = true;
        }
        public override double FillWater(double cups)
        {
            WaterAmount = 0.3 * cups;
            return WaterAmount;
        }

        public override void InsertProduct()
        {
            this.ProductType = EProductType.CoffeeBeans;
        }
        public override string BrewHotDrink(double cups)
        {            
            InsertFilter();
            FillWater(cups);
            InsertProduct();
            return "You've succesfully made " + cups + " of coffee made from " + ProductType;         
        }

        
    }
}
