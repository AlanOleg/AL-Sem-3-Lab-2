using System;

public class Vehicle
{
    // Поля базового класса
    protected int x; // Координаты
    protected int y;
    protected double price; // Цена
    protected double speed; // Скорость
    protected int year; // Год выпуска

    // Конструктор базового класса
    public Vehicle(int x, int y, double price, double speed, int year)
    {
        this.x = x;
        this.y = y;
        this.price = price;
        this.speed = speed;
        this.year = year;
    }

    // Метод для вывода информации о транспортном средстве
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Координаты: ({x}, {y}), Цена: {price}, Скорость: {speed}, Год выпуска: {year}");
    }
}

public class Plane : Vehicle
{
    // Поля производного класса Plane
    private int altitude; // Высота
    private int passengers; // Количество пассажиров

    // Конструктор производного класса Plane
    public Plane(int x, int y, double price, double speed, int year, int altitude, int passengers)
        : base(x, y, price, speed, year)
    {
        this.altitude = altitude;
        this.passengers = passengers;
    }

    // Переопределение метода ShowInfo
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Высота: {altitude}, Количество пассажиров: {passengers}");
    }
}

public class Car : Vehicle
{
    // Поля производного класса Car
    private int passengers; // Количество пассажиров

    // Конструктор производного класса Car
    public Car(int x, int y, double price, double speed, int year, int passengers)
        : base(x, y, price, speed, year)
    {
        this.passengers = passengers;
    }

    // Переопределение метода ShowInfo
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Количество пассажиров: {passengers}");
    }
}

public class Ship : Vehicle
{
    // Поля производного класса Ship
    private int passengers; // Количество пассажиров
    private string homePort; // Порт приписки

    // Конструктор производного класса Ship
    public Ship(int x, int y, double price, double speed, int year, int passengers, string homePort)
        : base(x, y, price, speed, year)
    {
        this.passengers = passengers;
        this.homePort = homePort;
    }

    // Переопределение метода ShowInfo
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Количество пассажиров: {passengers}, Порт приписки: {homePort}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем экземпляры транспортных средств
        Vehicle plane = new Plane(100, 200, 1500000, 300, 2020, 10000, 200);
        Vehicle car = new Car(10, 20, 30000, 150, 2019, 5);
        Vehicle ship = new Ship(50, 75, 200000, 40, 2022, 500, "Санкт-Петербург");

        // Вывод информации о каждом транспортном средстве
        Console.WriteLine("Информация о транспортных средствах:");
        plane.ShowInfo();
        Console.WriteLine();
        car.ShowInfo();
        Console.WriteLine();
        ship.ShowInfo();
    }
}