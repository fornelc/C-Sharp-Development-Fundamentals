﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Linq
{
	class Program
	{
		static void Main(string[] args)
		{
			string filePath = FileHelper.GetParentFile();
			CsvReader reader = new CsvReader(filePath);

			List<Country> countries = reader.ReadAllCountries();

			// listing the first 20 countries with commas in their names
			foreach (Country country in countries.Where(x=>x.Name.Contains(',')).Take(20))
			{
				Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
			}

			Console.WriteLine();

			// listing the 10 highest population countries in alphabetical order.
			// Reverse Where() and Take() to see the impact of swapping chaining order round
			foreach (Country country in countries.Take(10).OrderBy(x=>x.Name))
			{
				Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
			}
		}
	}
}
