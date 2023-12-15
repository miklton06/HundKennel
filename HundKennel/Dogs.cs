class Dogs
{
    double age;
    double height;
    string name;
    double weight;
    double speed;
    double accelerationTime;





    public Dogs(double age, double height, double weight, string name, double speed, double accelerationTime)
    {
        this.age = age;
        this.height = height;
        this.weight = weight;
        this.name = name;
        this.speed = speed;
        this.accelerationTime = accelerationTime;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Name " + name);
        Console.WriteLine("Age " + age);
        Console.WriteLine("Weight " + weight);
        Console.WriteLine("Height " + height);
        Console.WriteLine("speed " + speed);
        Console.WriteLine("10 meter time " + accelerationTime);
    }

    public double calculateLapTime(int trackLenght)
    {


        double lapTime = (trackLenght - 10)/speed + accelerationTime;

        return lapTime;
    }


}