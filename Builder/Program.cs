using Builder.Class;

var builder = new CPreparedAlcoholDrinkConcrateBuilder();
var barManDirector = new CBarmanDirector(builder);

barManDirector.PrepareMargarita();

var prepareDrink = builder.GetPreparedDrink();

Console.WriteLine(prepareDrink.Result);