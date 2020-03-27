//-----------------------------------------------------------------------
// <copyright file="CalculateModel.cs" company="Kofax Inc.">
//     Copyright (c) Kofax Inc. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Kofax.QATestTask.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class CalculateModel
    {
        public CalculateModel(DateTime birthDate)
        {
            BirthDate = birthDate;
            MakeCalculation();
        }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; }

        public double CalcResult { get; private set; }

        private void MakeCalculation()
        {
            var presPowerOn = (DateTime.Now - new DateTime(2000, 05, 07)).TotalDays;
            var userAge = (DateTime.Now - BirthDate).TotalDays;

            CalcResult = userAge > presPowerOn ? Math.Round(presPowerOn * 100 / userAge, 0) : 100;
        }
    }
}