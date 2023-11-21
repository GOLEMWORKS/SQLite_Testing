using SQLite.MainApp.Data;
using Microsoft.EntityFrameworkCore;

namespace SQLite.MainApp.Pages
{
    public partial class Index
    {
        public bool ShowCreate { get; set; }
        public bool ShowEdit { get; set; }
        public int EditingId { get; set; }
        private EmployeeDbContext? _context;
        public Employee? NewEmployee { get; set; }
        public Employee? EmployeeToUpdate { get; set; }
        public List<Employee>? OurEmployees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ShowCreate = false;
            await ShowEmployees();
        }

        public void ShowCreateForm()
        {
            NewEmployee = new Employee();
            ShowCreate = true;
        }

        public async Task CreateNewEmployee()
        {
            _context ??= await EmployeeDbContextFactory.CreateDbContextAsync();

            if (NewEmployee is not null)
            {
                _context?.Employees.Add(NewEmployee);
                _context?.SaveChangesAsync();
            }
            ShowCreate = false;
            await ShowEmployees();
        }


        public async Task ShowEmployees()
        {
            _context ??= await EmployeeDbContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                OurEmployees = await _context.Employees.ToListAsync();
            }
        }

        public async Task ShowEditForm(Employee ourEmployee)
        {

            _context ??= await EmployeeDbContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                EmployeeToUpdate = _context.Employees.FirstOrDefault(x => x.Id == ourEmployee.Id);
                ShowEdit = true;
                EditingId = ourEmployee.Id;
            }
        }

        public async Task UpdateEmployee()
        {
            _context ??= await EmployeeDbContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                if (EmployeeToUpdate is not null) _context.Employees.Update(EmployeeToUpdate);
                await _context.SaveChangesAsync();
            }
            ShowEdit = false;
        }

        //------------------ Delete! ----------------///

        public async Task DeleteEmployee(Employee ourEmployee)
        {
            _context ??= await EmployeeDbContextFactory.CreateDbContextAsync();
            if (_context is not null)
            {
                if (ourEmployee is not null) _context.Employees.Remove(ourEmployee);
                await _context.SaveChangesAsync();
            }
            await ShowEmployees();
        }
    }
}
