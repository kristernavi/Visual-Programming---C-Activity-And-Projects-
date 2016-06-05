using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prefinal_Garcia
{
    public class SubjectOffer
    {
        private int _id;
        private string _section;
        private Boolean _isOffer;
        private int _sub_id;
        private int _currentCapacity;
        private int _maxCapacity;

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

        public string Section
        {
            get
            {
                return _section;
            }
            set
            {
                _section = value;
            }
        }

        public bool IsOffer
        {
            get
            {
                return _isOffer;
            }
            set
            {
                _isOffer = value;
            }
        }

        public int Sub_ID
        {
            get
            {
                return _sub_id;
            }
            set
            {
                _sub_id = value;
            }
        }

        public int CurrentCapacity
        {
            get
            {
                return _currentCapacity;
            }
            set
            {
                _currentCapacity = value;
            }
        }

        public int MaxCapacity
        {
            get
            {
                return _maxCapacity;
            }
            set
            {
                _maxCapacity = value;
            }
        }
    }
}
