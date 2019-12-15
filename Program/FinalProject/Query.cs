using System;

namespace FinalProject
{
    class Query
    {
        public static String Insert = "INSERT INTO PatientDetails (FirstName, Age, Gender, LastName, Height, Weight, DiMin, " +
            "SyMin, PrMin, BrMin, TpMin, DiMax, SyMax, PrMax, BrMax, TpMax, BedNumber) VALUES (@FirstName, @Age, @Gender, @LastName, " +
            "@Height, @Weight, @DiMin, @SyMin, @PrMin, @BrMin, @TpMin, @DiMax, @SyMax, @PrMax, @BrMax, @TpMax, @BedNumber)";

        public static String Update = "UPDATE PatientDetails " +
            "SET DiMin = @DiMin, SyMin = @SyMin, PrMin = @PrMin, BrMin = @BrMin, TpMin = @TpMin, DiMax = @DiMax, " +
            "SyMax = @SyMax, PrMax = @PrMax, BrMax = @BrMax, TpMax = @TpMax " +
            "WHERE firstName = @FirstName AND lastName = @LastName AND age = @Age AND height = @Height AND weight = @Weight";
    }
}
