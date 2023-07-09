﻿using System;
using Blazored.LocalStorage;

namespace BlazingShop.Client.Services.StatsService
{
	public class StatsService : IStatsService
	{
        private readonly HttpClient _http;
        private readonly ILocalStorageService _localStorage;

		public StatsService(HttpClient http, ILocalStorageService localStorage)
		{
            _http = http;
            _localStorage = localStorage;
		}

        public async Task GetVisits()
        {
            int visits = int.Parse(await _http.GetStringAsync("api/Stats"));
            Console.WriteLine($"Visits: {visits}");
        }

        public async Task IncrementVisits()
        {
            DateTime? lastVisit = await _localStorage.GetItemAsync<DateTime?>("lastVisit");
            if (lastVisit == null || ((DateTime)lastVisit).Date != DateTime.Now.Date)
            {
                await _localStorage.SetItemAsync("lastVisit", lastVisit);
                await _http.PostAsync("api/Stats", null);
            }
        }
    }
}

