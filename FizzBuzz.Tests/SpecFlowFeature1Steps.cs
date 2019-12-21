using FizzBuzz.Common;
using FizzBuzz.Logic;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using System;
using TechTalk.SpecFlow;

namespace FizzBuzz.Tests
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IServiceProvider _serviceProvider;

        private IFizzBuzzLogic FizzBuzzLogic => _serviceProvider.GetRequiredService<IFizzBuzzLogic>();

        public int Input
        {
            get
            {
                if (!_scenarioContext.ContainsKey("FizzBuzzInput"))
                    return 0;
                return (int)_scenarioContext["FizzBuzzInput"];
            }
            set
            {
                _scenarioContext["FizzBuzzInput"] = value;
            }
        }

        public string Response
        {
            get
            {
                if (!_scenarioContext.ContainsKey("FizzBuzzResponse"))
                    return null;
                return _scenarioContext["FizzBuzzResponse"] as string;
            }
            set
            {
                _scenarioContext["FizzBuzzResponse"] = value;
            }
        }

        public SpecFlowFeature1Steps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;

            var services = new ServiceCollection();
            services.AddFizzBuzzLogic();
            _serviceProvider = services.BuildServiceProvider(true).CreateScope().ServiceProvider;
        }

        [Given(@"I have a '(.*)'")]
        public void GivenIHaveA(int value)
        {
            Input = value;
        }

        [When(@"I execute Fizbuzz")]
        public void WhenIExecuteFizbuzz()
        {
            Response = FizzBuzzLogic.ExecuteFizzBuzzValue(Input);
        }

        [Then(@"the assert the Fizbuzz result to be '(.*)'")]
        public void ThenTheAssertTheResultToBe(string Expected)
        {
            Response.Should().Be(Expected);
        }
    }
}
