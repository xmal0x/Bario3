using System;

namespace bario3
{
    internal class mathBario
    {
        internal static float Calculate(Bottle bottle, int weightScan)
        {
            float result = (bottle.capacityFull * (weightScan - bottle.weightEmpty)) / (bottle.weightFull - bottle.weightEmpty);
            return result;
        }

        internal static float FullPriceCalculate(Bottle bottle)
        {
            //Считаем стоимость остатка в бутылке
            float fullPrice = (bottle.capacityNow / bottle.portion) * bottle.price;
            return fullPrice;
            
        }
    }
}