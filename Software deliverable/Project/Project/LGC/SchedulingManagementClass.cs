using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAL;

namespace Project.LGC
{
    class SchedulingManagement: IObjectList
    {
        private List<Employee> employees;
        private List<Employee> shoppersonal;
        private List<Availability> availabilities;
        private EmployeeManagementDAL emd;
        private List<Schedule> schedules;
        private SchedulingManagementDAL smd;

        public SchedulingManagement()
        {
            employees = new List<Employee>();
            availabilities = new List<Availability>();
            shoppersonal = new List<Employee>();
            emd = new EmployeeManagementDAL();
            schedules = new List<Schedule>();
            smd = new SchedulingManagementDAL();
            InitializeListOfClasses();
        }

        public void InitializeListOfClasses()
        {
            smd.AddToDtbListOfSchedules();
            foreach (var item in smd.GetListOfAllSchedulesFromDataBase())
            {
                schedules.Add(item);
            }
            smd.AddToDtbListOfAvailability();
            foreach (var item in smd.GetListOfAllAvailabilitiesFromDatabase())
            {
                availabilities.Add(item);
            }
            emd.AddToDtbListOfEmployees();
            foreach (var item in emd.GetListOfAllEmployeesFromDatabase())
            {
                employees.Add(item);
            }
            foreach (Employee employee in employees)
            {
                if (employee.RoleID == 4)
                {
                    shoppersonal.Add(employee);
                }
            }
        }

        public List<Schedule> GetSchedules()
        {
            return schedules;
        }
        public List<Employee> GetShoppersonal()
        {
            return shoppersonal;
        }

        public void GenerateSchedule(DateTime beginDate, DateTime endDate, int PeopleAShift)
        {
            Dictionary<Employee, int> dictionaryAvailableEmployees = new Dictionary<Employee, int>();
            List<Employee> PlannedEmployees = new List<Employee>();
            int shiftDayCounter = 0;
            string shift = "Morning";
            endDate = endDate.AddDays(1);

            foreach (Employee employee in employees)
            {
                if (employee.RoleID == 4)
                {
                    dictionaryAvailableEmployees.Add(employee, 0);
                }
            }

            while (beginDate < endDate)
            {
                foreach (Employee employee in dictionaryAvailableEmployees.Keys)
                {
                    if (shiftDayCounter != PeopleAShift)
                    {
                        if (PlannedEmployees.Contains(employee))
                        {
                            continue;
                        }
                        else if (!availabilities.Any(x => x.UserId == employee.UserID && x.Date == beginDate.Date.ToString("dd-MM-yyyy") && x.Shift == shift))
                        {
                            AddSchedule(employee.UserID, beginDate.Date.ToString("dd-MM-yyyy"), shift);
                            dictionaryAvailableEmployees[employee] += 1;
                            shiftDayCounter += 1;
                            dictionaryAvailableEmployees = dictionaryAvailableEmployees.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                            PlannedEmployees.Add(employee);
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        PlannedEmployees.Clear();
                        shiftDayCounter = 0;
                        switch (shift)
                        {
                            case "Morning":
                                shift = "Afternoon";
                                break;
                            case "Afternoon":
                                shift = "Evening";
                                break;
                            case "Evening":
                                shift = "Morning";
                                beginDate = beginDate.AddDays(1);
                                break;
                        }
                        break;
                    }
                }
            }
        }

        public void AddSchedule(int UserID, string Date, string Shift)
        {
            smd.AddSchedule(UserID, Date, Shift);
        }

        public void RemoveSchedule(int UserID, string Date, string Shift)
        {
            smd.RemoveSchedule(UserID, Date, Shift);
        }

        public string GetName(int userID)
        {
            foreach (Employee employee in shoppersonal)
            {
                if (employee.UserID == userID)
                {
                    string result = $"{employee.FirstName} {employee.LastName}";
                    return result;
                }
            }
            return null;
        }
    }
}
