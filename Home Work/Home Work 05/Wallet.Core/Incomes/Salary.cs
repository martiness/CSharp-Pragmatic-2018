using System;
using System.Collections.Generic;
using System.Text;

namespace MyWalletProject02

{
    public class Salary : Income
    {
        private string _user = String.Empty;
        private double _salary = 0;

        public string User { get { return _user; } set { _user = value; } }
        public double UserSalary { get { return _salary; } set { _salary = value; } }
    }
}
