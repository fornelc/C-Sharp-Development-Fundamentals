using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			string filePath = FileHelper.GetParentFile();
			CsvReader reader = new CsvReader(filePath);

			Country[] countries = reader.ReadFirstNCountries(10);

			foreach (Country country in countries)
			{
				Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
			}
		}
	}
}
