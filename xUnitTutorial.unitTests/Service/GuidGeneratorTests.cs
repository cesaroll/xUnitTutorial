using System;
using Xunit;
using Xunit.Abstractions;
using xUnitTutorial.Service;

namespace xUnitTutorial.unitTests.Service
{
    [CollectionDefinition("Guid generator")]
    public class GuidGeneratorDefinition : IClassFixture<GuidGenerator>{}
    
    [Collection("Guid generator")]
    public class GuidGeneratorTestsOne
    {
        private readonly GuidGenerator _guidGenerator;
        private readonly ITestOutputHelper _output;

        public GuidGeneratorTestsOne(ITestOutputHelper output, GuidGenerator guidGenerator)
        {
            _output = output;
            _guidGenerator = guidGenerator;
        }

        [Fact]
        public void GuidTestOne()
        {
            var guid = _guidGenerator.RandomGuid;
            _output.WriteLine($"The guid was: {guid}");
        }
        
        [Fact]
        public void GuidTestTwo()
        {
            var guid = _guidGenerator.RandomGuid;
            _output.WriteLine($"The guid was: {guid}");
        }

    }
    
    [Collection("Guid generator")]
    public class GuidGeneratorTestsTwo
    {
        private readonly GuidGenerator _guidGenerator;
        private readonly ITestOutputHelper _output;

        public GuidGeneratorTestsTwo(ITestOutputHelper output, GuidGenerator guidGenerator)
        {
            _output = output;
            _guidGenerator = guidGenerator;
        }

        [Fact]
        public void GuidTestOne()
        {
            var guid = _guidGenerator.RandomGuid;
            _output.WriteLine($"The guid was: {guid}");
        }
        
        [Fact]
        public void GuidTestTwo()
        {
            var guid = _guidGenerator.RandomGuid;
            _output.WriteLine($"The guid was: {guid}");
        }

    }
}