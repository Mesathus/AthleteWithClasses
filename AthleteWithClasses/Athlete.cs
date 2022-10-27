using System;

namespace AthleteWithClasses
{
    public class Athlete
    {
        private string _name;
        private decimal _salary;
        private decimal _owed;
        private SinglyLinkedList _profList;

        #region Constructors
        public Athlete(decimal salary)
        {
            _name = null;
            _salary = salary;
            _owed = 0;
            _profList = new SinglyLinkedList();
        }

        public Athlete(string name, decimal salary)
        {
            _name = name.Trim();
            _salary = salary;
            _owed = 0;
            _profList = new SinglyLinkedList();
        }
        #endregion

        #region Getters/Setters
        public string Name
        {
            get { return _name;}
            set { _name = value; }
        }
        public decimal Salary
        {
            get { return _salary; }
        }
        public decimal Owed
        {
            get { return _owed; }
        }
        public Professional[] Professionals
        {
            get
            {
                Professional[] hires = new Professional[_profList.Length];
                for(int i = 0; i < hires.Length; i++)
                {
                    hires[i] = (Professional)_profList.GetValueAtIndex(i);
                }
                return hires;
            }
        }
        #endregion

        public override string ToString()
        {
            return string.Format("Athlete: {0}\nSalary: {1}", _name, _salary.ToString("c"));
        }

        public bool Hire(Professional p)
        {
            try
            {
                _profList.Insert(p);
                _owed += p.Salary;
                return true;
            }
            catch(Exception ex)
            {
                Logger.LogEvent(ex);
                return false;
            }
        }

        public bool Fire(Professional p)
        {
            try
            {
                _profList.Delete(p);
                _owed -= p.Salary;
                return true;
            }
            catch (Exception ex)
            {
                Logger.LogEvent(ex);
                return false;
            }
        }
    }
}
