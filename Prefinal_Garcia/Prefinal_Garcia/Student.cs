using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prefinal_Garcia
{
    public class Student
    {
        private int _id;
        private string _fname;
        private string _lname;
        private int _yrLevel;
        private int _currentCredits;
        private int _maxCredits;
        private int _age;

        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Firstname
        {
            get
            {
                return _fname;
            }
            set
            {
                _fname = value;
            }
        }

        public int YrLevel
        {
            get
            {
                return _yrLevel;
            }
            set
            {
                _yrLevel = value;
            }
        }

        public string Lastname
        {
            get
            {
                return _lname;
            }
            set
            {
                _lname = value;
            }
        }

        public int CurrentCredits
        {
            get
            {
                return _currentCredits;
            }
            set
            {
                _currentCredits = value;
            }
        }

        public int MaxCredits
        {
            get
            {
                return _maxCredits;
            }
            set
            {
                _maxCredits = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
    }
}
