using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prefinal_Garcia
{
    public class Subject
    {
        private int _id;
        private string _code;
        private string _name;
        private string _desc;
        private int _units;
        private int _prof_id;

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

        public string Code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Description
        {
            get
            {
                return _desc;
            }
            set
            {
                _desc = value;
            }
        }

        public int Units
        {
            get
            {
                return _units;
            }
            set
            {
                _units = value;
            }
        }

        public int Prof_ID
        {
            get
            {
                return _prof_id;
            }
            set
            {
                _prof_id = value;
            }
        }
    }
}
