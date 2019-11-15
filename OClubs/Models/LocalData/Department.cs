using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OClubs.Models.LocalData
{
    public class Department
    {
        public string Name { get; set; }
        public string Detail { get; set; }
        public string ImgSource { get; set; }

    }

    public class DepartmentInfo
    {
        public static List<Department> getInfo()
        {
            List<Department> data = new List<Department>();
            data.Add(new Department
            {
                Name = "IT",
                Detail = "blah blah blah",
                ImgSource = "/Assets/LocalMedia/Images/Departments/IT.jpg" });
            data.Add(new Department
            {
                Name = "EE",
                Detail = "blah blah blah",
                ImgSource = "/Assets/LocalMedia/Images/Departments/EE.jpg"
            });
            data.Add(new Department
            {
                Name = "BT",
                Detail = "blah blah blah",
                ImgSource = "/Assets/LocalMedia/Images/Departments/BT.jpg"
            });
            data.Add(new Department
            {
                Name = "BA",
                Detail = "blah blah blah",
                ImgSource = "/Assets/LocalMedia/Images/Departments/BA.jpg"
            });
            data.Add(new Department
            {
                Name = "ISE",
                Detail = "blah blah blah",
                ImgSource = "/Assets/LocalMedia/Images/Departments/ISE.jpg"
            });
            data.Add(new Department
            {
                Name = "BME",
                Detail = "blah blah blah",
                ImgSource = "/Assets/LocalMedia/Images/Departments/BME.jpg"
            });
            return data;
        }
    }
}
