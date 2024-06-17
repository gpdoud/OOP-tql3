namespace OOP_tql3;

internal class Program {

    static void Main(string[] args) {

        SUV suv = new SUV();
        suv.Print();

    }
}

public class Vehicle {

    public int NbrOfWheels { get; set; } = 4;
    public bool SlidingDoor { get; set; } = true;
    public int NbrOfPassengers { get; set; } = 7;

    public void Print(int nbr, string message) {

    }
    public void Print(string message, int nbr) {

    }


}

public class SUV : Vehicle {


    public SUV() {
        Print("ABC")
    }

}
