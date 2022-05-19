using System;

public class Person
{
    public string Name { get; set; }
    public Address Address { get; set; }
    public Person()
    {

    }

    public Person(string name,  Address address)
    {
        Name = name;
        Address = address;
    }
}