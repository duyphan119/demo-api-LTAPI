﻿using System;
using System.Collections.Generic;
using System.Web.Http;
using demoAPI.Models;

namespace demoAPI.Controllers
{
    public class WeatherController : ApiController
    {
        // GET: api/Weather
        public IEnumerable<WeatherInfo> Get()
        {
            var weatherInfoList = new List<WeatherInfo>();
            for (int i = 0; i < 10; i++)
            {
                var WeatherInfo = new WeatherInfo
                {
                    Location = $"Location {i}",
                    Degree = i * 23 / 17,
                    DateTime = DateTime.Now.ToUniversalTime()
                };
                weatherInfoList.Add(WeatherInfo);
            }

            return weatherInfoList;
        }

        // GETL: api/Weather/5
        public WeatherInfo Get(int id)
        {
             return new WeatherInfo
            {
                Location = $"Location {id}",
                Degree = id * 23 / 17,
                DateTime = DateTime.Now.ToUniversalTime()
            };
        }

    }
}
