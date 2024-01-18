using System.ComponentModel.DataAnnotations;
public class Vehicle{

    [Key]
   public string? vehicleNumber {get;set;}
    public string? vehicleMaxSpeed {get;set;}
    
}