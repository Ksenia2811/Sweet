using System;
using System.Collections.Generic;
using System.Linq;

 public class Ingredient
{
    public Ingredient(string name, double cost, int quantity){
        this._Name=name;
        this._CostPer100g=cost;
        this._Quantity=quantity;

    }
    public string _Name;
    public double _CostPer100g;
    public int _Quantity;

    public double GetCost()
    {
        return _CostPer100g * _Quantity / 100;
    }
}

public class Salad : List<Ingredient>
{
    public double GetCost()
    {
        return this.Sum(ingredient => ingredient.GetCost());
    }

    public override string ToString()
    {
        string ingredients = string.Join(", ", this.Select(ingredient => ingredient._Name));
        double cost = GetCost();

        return $"{ingredients}, {cost}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем список ингредиентов для салата
        Salad saladd = new Salad();
         {
             new Ingredient("Помидор",10,200),
            new Ingredient {"Огурец",8,150 },
            new Ingredient {"Перец",15,100 },
            new Ingredient {"Лук",5,50 },
            new Ingredient {"Зелень",3,20 }
         };

        // // Выводим информацию о салате в консоль
        Console.WriteLine(salad.ToString());
    }
}
