using System;
using System.Linq;
using System.Collections.Generic;

class Person {
  private static int count = 0;

  private string name;
  private int age;
  
  public string Name
  {
    get => this.name; 
    set => this.name = value;
  }

  public int Age
  {
    get { return this.age; } 
    set 
    { 
      if (value < 0) 
        throw new ArgumentException("Invalid age");
      this.age = value; 
    }
  }  

  public static int Count { get => count; }

  public Person(string name, int age)
  {
    this.name = name;
    this.age = age;
  }

  public void IntroduceMyself(string text = "") {
    Console.WriteLine(text + "Здравейте! Аз съм" +	" {0} и съм на {1} години.", Name, Age);
  }

  public override string ToString() {
    // TODO да връща информацията за нашия обект
    return base.ToString() + " Name " + Name;
  }
}

class Family
{
    // композиция
    public Person father;
    public Person mother;

    public List<Person> children;

    public Family() {
      father = new Person();
      mother = new Person();
      children = new List<Person>();
    }
    // делегиране
    public void IntroduceFamily() {
      // TODO представете всички членове на семейството
      father.IntroduceMyself("Баща: ");
    }
}

// наследяване
class Student: Person {
  public int Grade { get; set; }
}

public class Start {
  public static void Demo() {
    Person firstPerson = new Person();
    firstPerson.Name = "Гошо";
    firstPerson.Age = 15;
    firstPerson.IntroduceMyself();
    
    // TODO създайте обект от тип семейство, попълнете данните за него и накрая представете всички членове от семейството
    myFamily.father.Age = 25;
    myFamily.children.Add(child);
  }
}

