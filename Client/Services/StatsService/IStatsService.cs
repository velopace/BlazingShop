﻿using System;
namespace BlazingShop.Client.Services.StatsService
{
	public interface IStatsService
	{
		Task GetVisits();

		Task IncrementVisits();
	}
}

