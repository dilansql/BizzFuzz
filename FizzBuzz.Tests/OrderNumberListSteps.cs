using FizzBuzz.Common;
using FizzBuzz.Logic;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace FizzBuzz.Tests
{
    [Binding]
    public class OrderNumberListSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IServiceProvider _serviceProvider;

        private IOrderListOfNumber OrderListOfNumber => _serviceProvider.GetRequiredService<IOrderListOfNumber>();


        public List<int> Response
        {
            get
            {
                if (!_scenarioContext.ContainsKey("OrderListOfNumberResponse"))
                    return null;
                return _scenarioContext["OrderListOfNumberResponse"] as List<int>;
            }
            set
            {
                _scenarioContext["OrderListOfNumberResponse"] = value;
            }
        }

        public OrderNumberListSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;

            var services = new ServiceCollection();
            services.AddFizzBuzzLogic();
            _serviceProvider = services.BuildServiceProvider(true).CreateScope().ServiceProvider;
        }
        [When(@"I execute OrderListOfNUmber and I have '(.*)' and '(.*)'")]
        public void WhenIExecuteOrderListOfNUmberAndIHaveAnd(int maxValue, int minValue)
        {
            Response = OrderListOfNumber.orderListOfNUmber(maxValue, minValue);
        }
        [Then(@"the assert the OrderListOfNUmber result to be '(.*)'")]
        public void ThenTheAssertTheOrderListOfNUmberResultToBe(string expectedResponseAsString)
        {
            var responseAsStringList = Response.Select(x => x.ToString()).ToList();
            var responseAsString = string.Join(",", responseAsStringList);
            responseAsString.Should().Be(expectedResponseAsString);
        }

    }
}
