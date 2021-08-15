using PrikladyZNetu;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace SpecFlowTestyNaReseni
{
    [Binding]
    public class GlobalSteps
    {
        private readonly SheredData sheredData;
        public GlobalSteps(SheredData sheredData)
        {
            this.sheredData = sheredData;
        }

        [Then(@"dostanu (.*)")]
        public void ThenDostanuVysledek(string vysledek)
        {
            Assert.That(sheredData._vyslednyString == vysledek);
        }
    }
}
