using FizzBuzz.Common;
using FizzBuzz.Logic;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using FluentAssertions;
using System.Linq;

namespace FizzBuzz.Tests
{
    [Binding]
    public class FizzBuzzIteratorSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IServiceProvider _serviceProvider;

        private IFizzBuzzIterator FizzBuzzIterator => _serviceProvider.GetRequiredService<IFizzBuzzIterator>();


        public List<FizzBuzzResult> Response
        {
            get
            {
                if (!_scenarioContext.ContainsKey("FizzBuzzResult"))
                    return null;
                return _scenarioContext["FizzBuzzResult"] as List<FizzBuzzResult>;
            }
            set
            {
                _scenarioContext["FizzBuzzResult"] = value;
            }
        }

        public FizzBuzzIteratorSteps (ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;

            var services = new ServiceCollection();
            services.AddFizzBuzzLogic();
            _serviceProvider = services.BuildServiceProvider(true).CreateScope().ServiceProvider;
        }
        [When(@"I execute the FizzBuzzIterator for the lower range of '(.*)' and a higher range of '(.*)'")]
        public void WhenIExecuteTheFizzBuzzIteratorForTheLowerRangeOfAndAHigherRangeOf(int lowerRange, int higherRange)
        {
            Response = FizzBuzzIterator.GetFizzBuzzResult(lowerRange, higherRange);
            
            
        }

        
        [Then(@"I assert the result to be:")]
        public void ThenIAssertTheResultToBe(Table table)
        {
            var expectedResult = table.CreateSet<FizzBuzzResult>().ToList();
            Response.Should().BeEquivalentTo(expectedResult);
        }
    }
}
