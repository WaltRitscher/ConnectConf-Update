using System;
using System.Collections.Generic;
using System.Text;

namespace Tours.Standard.BizNew
{
  public class Tours
  {
    private static Tours current;

    public static Tours Current => current ?? (current = new Tours());

    private static List<Tour> _tourList;
    static Tours()
    {
      _tourList = new List<Tour>();
      Tour tour;
      tour = new Tour
      {
        TourName = "Wine Country",
        SeniorDiscountAvailable = true,
        KidFriendly = false,
        MultiDay = false,
        Region = "North",
        MaxPeoplePerTour = 24,
        TourImage = "/Content/Images/abstract01.png",
        Description= "Taste of California immerses you in the serene, romantic lifestyle of the California wine country and olive groves."
      };
      _tourList.Add(tour);
      tour = new Tour
      {
        TourName = "Gold Country",
        SeniorDiscountAvailable = true,
        KidFriendly = true,
        MultiDay = false,
        Region = "Central",
        MaxPeoplePerTour = 20,
        TourImage = "/Content/Images/abstract02.png",
        Description = "Relive the age of the gold rush pioneers."
      };
      _tourList.Add(tour);
      tour = new Tour
      {
        TourName = "Theme Parks",
        SeniorDiscountAvailable = true,
        KidFriendly = true,
        MultiDay = true,
        Region = "South",
        MaxPeoplePerTour = 6,
        TourImage = "/Content/Images/abstract03.png",
        Description = "California is an amazing playground for everyone and should be experienced by all. From amazing museums, outstanding parks, Disney, and kid-centered nature experiences, Kids California truly has it all! learn more!"
      };
     
      _tourList.Add(tour);

      tour = new Tour
      {
        TourName = "Sailing the Coast",
        SeniorDiscountAvailable = true,
        KidFriendly = false,
        MultiDay = false,
        Region = "Coast",
        MaxPeoplePerTour = 14,
        TourImage = "/Content/Images/abstract04.png",
        Description= "Come explore California from the stunning deserts all the way to our beautiful coast."
      };
      _tourList.Add(tour);

      tour = new Tour
      {
        TourName = "Bike the Sierras",
        SeniorDiscountAvailable = true,
        KidFriendly = false,
        MultiDay = true,
        Region = "North",
        MaxPeoplePerTour = 6,
        TourImage = "/Content/Images/abstract05.png",
        Description= "Packages range from bring-your-own bike to full bike rental and travel days. learn more!"
      };
      _tourList.Add(tour);

      tour = new Tour
      {
        TourName = "Bike the Redwoods",
        SeniorDiscountAvailable = true,
        KidFriendly = false,
        MultiDay = true,
        Region = "North",
        MaxPeoplePerTour = 6,
        TourImage = "/Content/Images/abstract06.png",
        Description = "Explore the thousand of miles of biking trails from Big Sur all the way to the Southern California coast."
      };
      _tourList.Add(tour);

      tour = new Tour
      {
        TourName = "Bike the Valley",
        SeniorDiscountAvailable = true,
        KidFriendly = false,
        MultiDay = true,
        Region = "North",
        MaxPeoplePerTour = 6,
        TourImage = "/Content/Images/abstract07.png",
        Description= "Whether you are a hard-core mountain biking enthusiast, or just looking for a cool way to see the many scenic towns and vistas of our great state, Cycle California has a package for you!"
      };
     

      _tourList.Add(tour);
      tour = new Tour
      {
        TourName = "Political Encounters",
        SeniorDiscountAvailable = true,
        KidFriendly = true,
        MultiDay = false,
        Region = "Sacramento",
        MaxPeoplePerTour = 60,
        TourImage = "/Content/Images/abstract08.png" ,
        Description= "Are you a political junkie, is so come see where the action happens at the California state capital."
      };
      _tourList.Add(tour);

      tour = new Tour
      {
        TourName = "Eco Tour-Farmlands",
        SeniorDiscountAvailable = false,
        KidFriendly = false,
        MultiDay = true,
        Region = "Central",
        MaxPeoplePerTour = 42,
        TourImage = "/Content/Images/abstract09.png",
        Description= "We offer packages that range from all-inclusive hot spring resorts to camping opportunities next to some of the country's last remaining primitive springs. Learn more!"
      };
      _tourList.Add(tour);

      tour = new Tour
      {
        TourName = "Surf Culture",
        SeniorDiscountAvailable = false,
        KidFriendly = false,
        MultiDay = false,
        Region = "Coast",
        MaxPeoplePerTour = 8,
        TourImage = "/Content/Images/abstract01.png",
        Description= "If you love the outdoors, nature, and the environment, California is the place for you!"
      };
      _tourList.Add(tour);

      tour = new Tour
      {
        TourName = "Whale Watching",
        SeniorDiscountAvailable = false,
        KidFriendly = false,
        MultiDay = true,
        Region = "Coast",
        MaxPeoplePerTour = 12,
        TourImage = "/Content/Images/abstract03.png" ,
        Description= "Our eco-tours range from watching seals and whales to deep forest excursions."
      };
      _tourList.Add(tour);
    }
    public List<Tour> GetTours()
    {
      return _tourList;
    }
  }
  public class Tour
  {
    public string TourName { get; set; }
    public bool SeniorDiscountAvailable { get; set; }
    public bool KidFriendly { get; set; }
    public bool MultiDay { get; set; }
    public int MaxPeoplePerTour { get; set; }
    public string Region { get; set; }
    public string TourImage { get; set; }
    public string Description { get; set; }
  }

  // a helper class is used for grouping the data by Region
  public class RegionGroup
  {
    public string RegionName { get; set; }
    public IList<Tour> Tours { get; set; }
  }
}
