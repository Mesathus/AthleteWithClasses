using System;

namespace AthleteWithClasses
{
    public class Professional
    {
        private string _name;
        private string _job;
        private decimal _salary;

        //constructor
        public Professional(string name, string job, decimal salary)
        {
            try
            {
                _name = name.Trim();
                _job = job.Trim();
                switch (job.ToLower().Trim())
                {
                    case "lawyer": _salary = salary * .1m; break;
                    case "trainer": _salary = salary * .07m; break;
                    case "personal assistant": _salary = salary * .03m; break;
                    case "agent": _salary = salary * .05m; break;
                    default: throw new FormatException();
                }
            }
            catch(Exception e)
            {
                Logger.LogEvent(e);
            }
        }

        #region Getters
        public string Name { get { return _name; } }
        public string Job { get { return _job; } }
        public decimal Salary { get { return _salary; } }
        #endregion

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", this.Name, this.Job, this.Salary.ToString("c"));
        }
    }
}
