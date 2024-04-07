using System;
using System.Collections.Generic;

class MyProgram
{
    static void Main()
    {
        Item holod = new Item();
        holod.name = "холодильник";

        Client ivan = new Client();
        ivan.lastname = "Ivanov";
        ivan.firstname = "ivan";
        //ivan.age = 21;

        Order zakaz050424 = new Order();
        zakaz050424.client = ivan;
        zakaz050424.orderNumber = 4;
        zakaz050424.cost = 2300;
        zakaz050424.item = holod;

        Console.WriteLine("HW");

        List<Client> listClient = new List<Client> {

            new Client()
            {
                lastname = "Smith",
                firstname = "John",
                Age  = 35,
                passport = "abadabac",
                height = 175,
                Netto = 50000

            },
            new Client() {
                lastname = "Johnson",
                firstname = "Emily",
                Age  = 60,
                passport = "CDabadabac",
                height = 150,
                Netto = 6666


            }

        };
       


        listClient.Add(new Client
        {
            lastname = "somename",
            firstname = "someFirstname",
            Age = 60,
            passport = "CDabadabac",
            height = 150,
            Netto = 6666



        }); 
        
        foreach (var v  in listClient) { // просто вывод по именам
            Console.WriteLine(v.firstname);
        }
        foreach (var v in listClient) // редактирование полей класса 
        {
            if (v.lastname == "somename")
            {
                v.lastname = "1234";
            }
            Console.WriteLine(v.lastname);
        }
        foreach (var v in listClient) {
            if (v.lastname == "1234") {
                v.firstname = "empty";
                v.lastname = "empty";
                v.Age = "empty";

            
            } ;

        
        
        }

    }
}

class Client
{
    public string lastname;
    public string firstname;
    private int age = 0;
    public string passport;
    public decimal height;
    public decimal Netto;

    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Возраст должен быть больше 0");
            }
            else
            {
                age = value;
            }
        }
    }
}

class Order
{
    public int orderNumber;
    public Client client;
    public int cost;
    public Item item;
}

class Item
{
    public string name;
}