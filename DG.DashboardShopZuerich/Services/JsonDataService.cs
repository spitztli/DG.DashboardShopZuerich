using DG.DashboardShopZuerich.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace DG.DashboardShopZuerich.Services
{
    public class JsonDataService
    {
        private readonly string filePath = Path.Combine(FileSystem.AppDataDirectory, "employeeList.json");

		public List<Employees> LoadEmployees()
		{
			if (File.Exists(filePath))
			{
				string jsonString = File.ReadAllText(filePath);
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
            File.WriteAllText(filePath, jsonString);
        }
    }
}