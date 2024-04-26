//switch-case

string sku = "01-MN-L";
string[] produto = sku.Split('-');

string tipo ="";
string cor = "";
string tamanho ="";

switch (produto[0])
{
    case "01":
        tipo ="Swet Shirt";
        break;
    case "02":
        tipo ="T-Shirt";
        break;
    case "03":
        tipo ="Sweat pants";
        break;
    default:
        tipo ="Other";
        break;
}
switch (produto[1])
{
    case "BL":
        cor ="Black";
        break;
    case "MN":
        cor ="Maroom";
        break;
    default:
        cor ="White";
        break;
}
switch (produto[2])
{
    case "S":
        tamanho ="Small";
        break;
    case "M":
        tamanho ="Medium";
        break;
    case "L":
        tamanho ="Large";
        break;
    default:
        tamanho ="One size fits all";
        break;
}
Console.WriteLine($"Produto: {tipo} {cor} {tamanho}");
