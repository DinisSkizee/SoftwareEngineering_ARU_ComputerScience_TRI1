using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Query
    {
        public static String Insert = "INSERT INTO PatientDetails (FirstName, Age, Gender, LastName, Height, Weight, DiMin, " +
            "SyMin, PrMin, BrMin, TpMin, DiMax, SyMax, PrMax, BrMax, TpMax, BedNumber) VALUES (@FirstName, @Age, @Gender, @LastName, " +
            "@Height, @Weight, @DiMin, @SyMin, @PrMin, @BrMin, @TpMin, @DiMax, @SyMax, @PrMax, @BrMax, @TpMax, @BedNumber)";
    }
}
