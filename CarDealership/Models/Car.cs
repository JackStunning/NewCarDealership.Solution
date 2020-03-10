namespace CarDealership.Models {
  public class Car
  {
    public int Id{get;}
    public string Description {get;set;}
    public string MakeModel {get; set;}
    public int Price {get;set;}
    public int Miles {get;set;}
    private static List<Car> _cars = new List<Car>();
    private static int CarId {get;} = 0;
    public Car(string description, string makeModel, int price, int miles)
    {
      
      Description = description;
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      ++CarId;
      Id = CarId;
      _cars.Add(this);
    }
    public bool WorthBuying(int maxPrice, int miles)
    {
      if((Price < maxPrice) && (Miles < miles)) {
        return true;
      } else {
        return false;
      }
    }
    public List<Car> GetAll(){
        return _cars;
    }

    public bool RemoveCar(){

    }
  }
}