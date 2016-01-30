using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmachy
{
    class LoginSession
    {
        public static string UserID = "";
        public static string UserName = "";
        public static string Designation = "";
        public static string Department = "";
        public static string LogInTime = "";
        public static string JoinDate = "";
        public static string UserPrevilage = "";

        public static string CashInHand = "";

        public static DateTime FinancialYearStart = DateTime.Now;
        public static DateTime FinancialYearEnd = DateTime.Now;
        public static int CurrentFinancialYear = 999;


    }
}
