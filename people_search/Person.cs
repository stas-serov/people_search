using System;

namespace people_search
{
    public class Person
    {
        public string id { get; set; }
        public string ovd { get; set; }
        public string category { get; set; }
        public string first_name_u { get; set; }
        public string last_name_u { get; set; }
        public string middle_name_u { get; set; }
        public string first_name_r { get; set; }
        public string last_name_r { get; set; }
        public string middle_name_r { get; set; }
        public string first_name_e { get; set; }
        public string last_name_e { get; set; }
        public string middle_name_e { get; set; }
        public DateTime birth_date { get; set; }
        public string sex { get; set; }
        public DateTime lost_date { get; set; }
        public string lost_place { get; set; }
        public string article_crim { get; set; }
        public string restraint { get; set; }
        public string contact { get; set; }
        public string photoid { get; set; }
    }
}
