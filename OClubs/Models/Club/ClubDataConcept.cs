using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OClubs.Models.Club
{

    public class ClubDataConcept
    {
        public string ClubId { get; set; }
        public string ClubName { get; set; }
        public string ClubLogoURL { get; set; }
        public string ClubCoverImageURL { get; set; }
        public string Color { get; set; }
        public DateTime DateStarted { get; set; }
        public string Location { get; set; }
        public string PhoneNumbers { get; set; }
        public string Email { get; set; }
        public string ClubInfoURL { get; set; }
        public string Intro { get; set; }
        public string Detail { get; set; }
        public int Rating { get; set; }
        public int Members { get; set; }
        public int Projects { get; set; }
        public string Requirement { get; set; }
        public decimal Price { get; set; }
    }
    public class TestData
    {
        public static List<ClubDataConcept> GetData()
        {
            List<ClubDataConcept> data = new List<ClubDataConcept>();
            data.Add(new ClubDataConcept
            {
                ClubId = "FDC55T4290123",
                ClubName = "Vision",
                ClubLogoURL = "/Assets/LocalMedia/Images/Logos/Vision.png",
                ClubCoverImageURL = "/Assets/LocalMedia/Images/Wallpaper/Triangle.jpg",
                Color = "",
                DateStarted = new DateTime(2008, 5, 1, 8, 30, 52),
                Location = "Online",
                PhoneNumbers = "0348164682",
                Email = "FutureWingsStrypper@outlook.com",
                ClubInfoURL = "",
                Intro = "",
                Detail = "",
                Rating = 5,
                Members = 20,
                Projects = 5,
                Requirement = "",
                Price = 0
            });
            return data; 
        }
    }
}
