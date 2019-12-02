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
        public string Icon { get; set; }

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
                ImgSource = "ms-appx:///Assets/LocalMedia/Images/Departments/IT.jpg",
                Icon = "\uF0B9"
            });
            data.Add(new Department
            {
                Name = "EE",
                Detail = "blah blah blah",
                ImgSource = "ms-appx:///Assets/LocalMedia/Images/Departments/EE.jpg",
                Icon = "\uE950"
            });
            data.Add(new Department
            {
                Name = "BT",
                Detail = "blah blah blah",
                ImgSource = "ms-appx:///Assets/LocalMedia/Images/Departments/BT.jpg",
                Icon = "\uEE94"
            });
            data.Add(new Department
            {
                Name = "BA",
                Detail = "blah blah blah",
                ImgSource = "ms-appx:///Assets/LocalMedia/Images/Departments/BA.jpg",
                Icon = "\uEAFC"
            });
            data.Add(new Department
            {
                Name = "ISE",
                Detail = "blah blah blah",
                ImgSource = "ms-appx:///Assets/LocalMedia/Images/Departments/ISE.jpg",
                Icon = "\uE115"
            });
            data.Add(new Department
            {
                Name = "BME",
                Detail = "blah blah blah",
                ImgSource = "ms-appx:///Assets/LocalMedia/Images/Departments/BME.jpg",
                Icon = "\uE95E"
            });
            return data;
        }
    }
}
