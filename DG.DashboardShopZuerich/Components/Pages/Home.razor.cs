using DG.DashboardShopZuerich.Models;
using DG.DashboardShopZuerich.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

namespace DG.DashboardShopZuerich.Components.Pages
{
    public partial class Home
    {
        private string name;
        private string vorname;
        private DateOnly geburtstag = DateOnly.FromDateTime(DateTime.Now);
		private List<Employees> employees = new List<Employees>();


		[Inject] 
        private JsonDataService JsonDataService { get; set; }

        protected override void OnInitialized()
        {
            employees = JsonDataService.LoadEmployees();
        }
        private void AddEmployee()
        {
            List<Employees> employees = JsonDataService.LoadEmployees();

            Employees newEmployee = new Employees
            {
                Name = name,
                Vorname = vorname,
                Geburtstag = geburtstag
            };

            employees.Add(newEmployee);

            JsonDataService.SaveEmployees(employees);

            name = string.Empty;
            vorname = string.Empty;
            geburtstag = DateOnly.Parse(geburtstag.ToString());
        }
    }
}
