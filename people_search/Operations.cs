using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using System.Drawing;

namespace people_search
{
    public class Operations
    {
        public static List<Person> searching_ukr(string surname, string name, string patronomic, string path)
        {
            string json = File.ReadAllText(path);
            List<Person> persons = JsonConvert.DeserializeObject<List<Person>>(json);
            List<Person> selected_persons = persons.Where(p => p.first_name_u == surname && p.last_name_u == name && p.middle_name_u == patronomic).ToList();
            return selected_persons;
        }
        public static List<Person> searching_rus(string surname, string name, string patronomic, string path)
        {
            string json = File.ReadAllText(path);
            List<Person> persons = JsonConvert.DeserializeObject<List<Person>>(json);
            List<Person> selected_persons = persons.Where(p => p.first_name_r == surname && p.last_name_r == name && p.middle_name_r == patronomic).ToList();
            return selected_persons;
        }
        public static List<Person> searching_eng(string surname, string name, string patronomic, string path)
        {
            string json = File.ReadAllText(path);
            List<Person> persons = JsonConvert.DeserializeObject<List<Person>>(json);
            List<Person> selected_persons = persons.Where(p => p.first_name_e == surname && p.last_name_e == name && p.middle_name_e == patronomic).ToList();
            return selected_persons;
        }
        public static void update_db(string link_person, string path_person, string link_photo1, string path_photo1, string link_photo2, string path_photo2)
        {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                WebClient wb = new WebClient();
                wb.DownloadFile(link_person, path_person);
                wb.DownloadFile(link_photo1, path_photo1);
                wb.DownloadFile(link_photo2, path_photo2);
        }
        public static Image person_photo(string id, string path1, string path2)
        {
            Photo selected_photo = null;
            string json = File.ReadAllText(path1);
            List<Photo> photos = JsonConvert.DeserializeObject<List<Photo>>(json);
            if(photos != null)
            {
                foreach (Photo p in photos)
                {
                    if (p.id == id) selected_photo = p;
                }
            }
            json = File.ReadAllText(path2);
            photos = JsonConvert.DeserializeObject<List<Photo>>(json);
            if (photos != null)
            {
                foreach (Photo p in photos)
                {
                    if (p.id == id) selected_photo = p;
                }
            }
            if (selected_photo != null)
            {
                var pic = Convert.FromBase64String(selected_photo.photo1base64encode);
                Image im = Image.FromStream(new MemoryStream(pic));
                return im;
            }
            else return null;
        }
        public static void write_results(string surname, string name, string patronomic, string path, bool flag)
        {
            if(flag)
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    string str = "Successful search for a person by name: " + surname + " " + name + " " + patronomic;
                    sw.WriteLine(str);
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    string str = "Unsuccessful search for a person by name: " + surname + " " + name + " " + patronomic;
                    sw.WriteLine(str);
                }
            }
        }
    } 
}
