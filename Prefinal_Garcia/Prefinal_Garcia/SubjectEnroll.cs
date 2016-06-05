using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prefinal_Garcia
{
    public class SubjectEnroll
    {
        private int _stud_id;
        private int _sub_id;
        private DateTime _date_enroll;
        private int _subjOffer_id;

        public int StudentID
        {
            get
            {
                return _stud_id;
            }
            set
            {
                _stud_id = value;
            }
        }

        public int SubjectID
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

        public DateTime Date_Enroll
        {
            get
            {
                return _date_enroll;
            }
            set
            {
                _date_enroll = value;
            }
        }

        public int SubjectOfferID
        {
            get
            {
                return _subjOffer_id;
            }
            set
            {
                _subjOffer_id = value;
            }
        }
    }
}
