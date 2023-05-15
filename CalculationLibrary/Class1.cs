using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CalculationLibrary
{
    public class Class1
    {
        // Variable Declarations 
        double tvLicenseResedential = 35;
        double tvLicenseComercial = 60;
        double ElectricityDutyResedential = 1.5;
        double ElectricityDutyComercial = 2;

        double unitCost;

        //Unit Charges Calculation
        private double UnitChargeResidential(double units)
        {
            if (units < 100 || units > 1)
            {
                unitCost = 5.79;
            }
            else if (units < 200 || units > 100)
            {
                unitCost = 8.11;
            }
            else if(units < 300 || units > 200)
            {
                unitCost = 10.2;
            }
            else if(units < 700 || units > 300)
            {
                unitCost = 19.25;
            }
            else if(units > 700)
            {
                unitCost = 22.35;
            }
            return units * unitCost;
        }
        private double UnitChargeCommercial(double units)
        {
            if (units < 400)
            {
                unitCost = 20.66;
            }
            else if(units >= 100)
            {
                unitCost = 24.14;
            }
            return units * unitCost;
        }

        //Income Tax 
        private double IncomeTaxCommercial(double amount)
        {
            double totalBillingAmt;
            double IncomeTaxCommercial = 7.5;
            if (amount >= 25000)
            {
                totalBillingAmt = (amount * IncomeTaxCommercial) / 100;
                return totalBillingAmt;
            }
            else
            {
                return amount;
            }
        }
        private double IncomeTaxResidential(double amount)
        {
            double totalBillingAmt;
            double IncomeTaxResidential = 0;
            double plusCharge = 0;

            if (amount > 500 || amount <20000)
            {
                IncomeTaxResidential = 10;
            }
            else if (amount >20000)
            {
                IncomeTaxResidential = 12;
                plusCharge = 1950;

            }
            totalBillingAmt = (amount * IncomeTaxResidential) / 100;
            return totalBillingAmt+plusCharge;
        }

        //Electricity Duty
        private double ElectricityDutyCommercial(double amount)
        {
            return (amount * ElectricityDutyComercial) / 100;
        }
        private double ElectricityDutyResidential(double amount)
        {
            return (amount * ElectricityDutyResedential) / 100;
        }


        //Final Billing Amount Calculations
        public double BillingAmt(bool consumerType, double units)
        {
            double finalBillingAmtount = 0;
            if (consumerType == true)
            {
                //Commercial
                finalBillingAmtount = UnitChargeCommercial(units);
                finalBillingAmtount += tvLicenseComercial;
                finalBillingAmtount += ElectricityDutyCommercial(finalBillingAmtount);
                finalBillingAmtount += IncomeTaxCommercial(finalBillingAmtount);
            }
            else if (consumerType == false)
            {
                //Residential
                finalBillingAmtount = UnitChargeResidential(units);
                finalBillingAmtount += tvLicenseResedential;
                finalBillingAmtount += ElectricityDutyResidential(finalBillingAmtount);
                finalBillingAmtount += IncomeTaxResidential(finalBillingAmtount);
            }
            return finalBillingAmtount;
        }
    }
}
