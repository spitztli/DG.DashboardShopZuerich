using DG.DashboardShopZuerich.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace DG.DashboardShopZuerich.Services
{
	public class JsonDataService
	{
		private readonly string filePathOne = Path.Combine(FileSystem.AppDataDirectory, "employeeList.json");
		private readonly string filePathTwo = Path.Combine(FileSystem.AppDataDirectory, "Lunchplan.json");
		public List<Employees> LoadEmployees()
		{
			if (File.Exists(filePathOne))
			{
				string jsonString = File.ReadAllText(filePathOne);
				if (string.IsNullOrWhiteSpace(jsonString))
				{
					return new List<Employees>();
				}
				return JsonSerializer.Deserialize<List<Employees>>(jsonString);
			}
			return new List<Employees>();
		}

		public void SaveEmployees(List<Employees> employeesList)
		{
			string jsonString = JsonSerializer.Serialize(employeesList);
			File.WriteAllText(filePathOne, jsonString);
		}

		public List<LunchPlan> LoadLunchPlan()
		{
			if (File.Exists(filePathTwo))
			{
				string jsonString = File.ReadAllText(filePathTwo);
				if (string.IsNullOrWhiteSpace(jsonString))
				{
					return new List<LunchPlan>();
				}
				return JsonSerializer.Deserialize<List<LunchPlan>>(jsonString);
			}
			return new List<LunchPlan>();
		}

		public void	SavePersonToLuchPlan(List<LunchPlan> person)
		{
			string jsonString = JsonSerializer.Serialize(person);
			File.WriteAllText(filePathTwo, jsonString);
		}
	}
}