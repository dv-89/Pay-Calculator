using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_Calculator
{
    internal class Employee
    {
        
        private string firstName;
        private string lastName;
        private string empId;
        private double hoursWorked;
        private double payRate;
        private double monthlyPay;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string EmpId { get {  return empId; } set {  empId = value; } }
        public double PayRate { get { return payRate; } set {
                if (value < 0) {
                    
                    MessageBox.Show("Can't enter negative value in payrate", "Warning");
                }
                payRate = value; } }
        public double HoursWorked { get { return hoursWorked; } set {

                if (value < 0)
                {

                    MessageBox.Show("Can't enter negative value in hours worked", "Warning");
                }

                hoursWorked = value; } }

        //result is MonthlyPay
        public double MonthlyPay { set { monthlyPay = value; } }

        public double computePay()
        {
            double overtimePay = 0;
            double normalpay = 0;
            if (hoursWorked > 40)
            {
                overtimePay = 1.5 * (hoursWorked - 40) * payRate;
                normalpay = 40 * payRate;
            }
            else
            {
                overtimePay = 0;
                normalpay = hoursWorked * payRate;
            }
            

            return overtimePay+normalpay;
        }
    }
}
