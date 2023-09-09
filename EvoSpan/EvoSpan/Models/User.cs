using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace EvoSpan.Models
{
    internal class User
    {
        // Name and Surname
        protected readonly List<string> name;

        // Generated unique id
        protected readonly string id;

        // Emails
        protected List<string> email;

        // Telephone Number
        protected uint number;

        // Date of Birthday
        protected DateTime birthday;

        // Role
        protected string role;

        // Hourly Wage
        protected double hourly_wage;

        // Hourly Service Cost
        protected double hourly_service_cost;

        // Work Shifts
        protected List<Shifts> shifts;

        public User()
        {
            name = null;
            id = "";
            email = null;
            number = 0;
            birthday = new DateTime(0, 0, 0);
            role = "";
            hourly_wage = 0;
            hourly_service_cost = 0;
            shifts = null;
        }

        public User(List<string> name, List<string> email, DateTime date, string role, double hw, double hsc, List<Shifts> s, List<User> usrs, uint number = 0)
        {
            if (name == null) throw new ArgumentNullException("Name not specified");
            if (email == null) throw new ArgumentNullException("Email not specified");
            if (date == null) throw new ArgumentNullException("Date of Birthday not specified");
            if (role == null) throw new ArgumentNullException("Role not specified");
            if (hw < 0) throw new ArgumentOutOfRangeException("Hourly Wage not valid");
            if (hsc < 0) throw new ArgumentOutOfRangeException("Hourly Service Cost not valid");
            try
            {
                shifts = s;
                id = generateId(name, usrs);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            this.name = name;
            this.email = email;
            birthday = date;
            this.role = role;
            hourly_wage = hw;
            hourly_service_cost = hsc;

            if (number == 0)
                this.number = 0;
            else this.number = number;
        }

        /**
         * Generate Id:
         * Generates the Unique Id with Name
         * 
         * @param string
         * 
         * @return string
         */
        protected string generateId(List<string> name, List<User> usr)
        {
            // Sanitize strings
            for (int i = 0; i < name.Count; i++)
                name[i] = sanitize(name[i]);

            if (name == null || name[0] == "" || name[0] == "undefined") throw new ArgumentNullException("name");
            string id = name[0].ToLower() + "." + name[1].ToLower();
            int check = 0;
            for (int i = 0; i < usr.Count; i++)
            {
                if (usr[i].id == id)
                    check++;
            }
            id += check;
            return id;
        }

        /**
         * Sanitize String:
         * Replace all the character that are not allowed
         * 
         * @param string
         * 
         * @return string
         */
        protected string sanitize(string str)
        {
            string ret = null;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < 65 || str[i] > 90 || str[i] < 97 || str[i] > 122 || str[i] < 128 || str[i] > 165)
                    ret += "_";
                else
                    ret += str[i];
            }
            return ret;
        }
    }
}
