using DesignPatterns.Creational.Builder.Concrets;

Console.WriteLine("Builder Pattern With Director");
Console.WriteLine("\n");

#region Builder Pattern With Director

var director = new Director();
var regularFoodBuilder = new RegularFoodBuilder();

director.Builder = regularFoodBuilder;
director.MakeFoodWithPepperAndSalt(122.12m, 100.48m);

Console.WriteLine("Regular Food Builder");
Console.WriteLine(regularFoodBuilder.Build());

var rareFoodBuilder = new RareFoodBuilder();
director.Builder = rareFoodBuilder;

director.MakeFoodWithPepperSaltAndWater(90.12m, 120.32m, 220.98m);

Console.WriteLine("Rare Food Builder");
Console.WriteLine(rareFoodBuilder.Build());

#endregion

Console.WriteLine("\n\n");
Console.WriteLine("Builder Pattern WithOut Director");
Console.WriteLine("\n");

#region Builder Pattern WithOut Director

var regularFoodBuilderv2 = new RegularFoodBuilder();

var regularFood = regularFoodBuilderv2
                     .AddSalt(122.12m)
                     .AddWater(322.12m)
                     .Build();

Console.WriteLine("Regular Food Builder");
Console.WriteLine(regularFood);

Console.WriteLine("------------------");

var rareFoodBuilderv2 = new RareFoodBuilder();

var rareFood = rareFoodBuilderv2
                    .AddPepper(122.12m)
                    .AddWater(222.12m)
                    .Build();

Console.WriteLine("Rare Food Builder");
Console.WriteLine(rareFood);

#endregion