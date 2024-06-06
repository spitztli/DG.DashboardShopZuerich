using DG.DashboardShopZuerich.Models;
using DG.DashboardShopZuerich.Services;
using Microsoft.AspNetCore.Components;

namespace DG.DashboardShopZuerich.Components.Pages
{
    public partial class Home
    {
        private string name;
        private string vorname;
        private DateOnly geburtstag = DateOnly.FromDateTime(DateTime.Now);
		private List<Employees> employees = new List<Employees>();

        private string personOne;
        private string personTwo;
        private string time;
        private List<LunchPlan> lunchPlan = new List<LunchPlan>();


        [Inject] 
        private JsonDataService JsonDataService { get; set; }

        protected override void OnInitialized()
        {
            employees = JsonDataService.LoadEmployees();
            lunchPlan = JsonDataService.LoadLunchPlan();
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

        private void AddPersonToLunchPlan()
        {
            List<LunchPlan> person = JsonDataService.LoadLunchPlan();

            LunchPlan newPerson = new LunchPlan
            {
                PersonOne = personOne,
                PersonTwo = personTwo,
                Time = time
            };

            person.Add(newPerson);

            JsonDataService.SavePersonToLuchPlan(person);

            personOne = string.Empty;
            personTwo = string.Empty;
            time = string.Empty;

            lunchPlan.Add(newPerson);
            StateHasChanged();
        }
    }
}
