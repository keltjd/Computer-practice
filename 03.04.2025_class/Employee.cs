using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _03._04._2025_class
{
    internal class Employee
    {
        public Employee(string name, decimal selary, DateTime date) {
            this._name = name;
            this._selary = selary;
            this._date_of_emp = date;
            count++;
            SetId();
        }
        public Employee(string name, decimal selary) {
            this._name = name;
            this._selary = selary;
            this._date_of_emp = DateTime.Now;
            count++;
            SetId();
        }

        public Employee(string name, DateTime date) {
            this._name = name;
            this._selary = start_selary;
            this._date_of_emp = date;
            count++;
            SetId();
        }

        public void GetSelary(decimal selary) {
            this._selary = selary;
        }
        
        public override string ToString() {

            return $"{this._id}: {this._name} {this._selary} {DateOnly.FromDateTime(this._date_of_emp.Date)} ";
        }
        public TimeSpan GetWorkingTime() {
            TimeSpan working_days = DateTime.Today - this._date_of_emp;
            return  (working_days);
        }

        private string _name;
        private decimal _selary;
        private DateTime _date_of_emp;
        private string _id;
        private static int count = 0;
        private static decimal start_selary = 1000;
        private void SetId() {
            this._id = this._name[0].ToString() + count;

        }
    }

}
