using AutoMapper;
using CarsService.Profiles;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsService.Tests
{
    [TestFixture]
    public class MappingsTests
    {
        [Test]
        public void MappingTest()
        {
            Mapper.Initialize(m => m.AddProfile<MainProfile>());
            Mapper.AssertConfigurationIsValid();
        }
    }
}
