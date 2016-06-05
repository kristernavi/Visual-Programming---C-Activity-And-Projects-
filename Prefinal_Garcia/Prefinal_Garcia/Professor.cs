using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prefinal_Garcia
{
    public class Professor
    {
        private int _id;
        private string _fname;
        private string _lname;
        private string _field;
        private string _contact;

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

        public string Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                _contact = value;
            }
        }

        public string Field
        {
            get
            {
                return _field;
            }
            set
            {
                _field = value;
            }
        }
    }
}
