using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BusinessLayer
{
    public class BLAge
    {
        public int age(DateTime dob)
        {
            int age = (int)(DateTime.Now.Subtract(dob).TotalDays) / 365;
            if (age < 18 )
            {
                throw new CustomException("age should be greator than 18");
            }
            else if(age>60)
            {

                throw new CustomException("age should  not be  grator than 60");
            }
            else
                return age;
        }
       
    }
    public class CustomException : Exception
    {
        public CustomException(string s) : base(s)
        {

        }
    }
}
