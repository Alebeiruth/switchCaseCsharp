
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "Sweat shirt";
string color = "Maroon";
string size = "Large";


switch (type)
{
    case "Sweat shirt":
        product[0] = "01";
        break;
    case "T-Shirt":
        product[0] = "02";
        break;
    case "Sweat pants":
        product[0] = "03";
        break;
    default:
        product[0] = "Other";
        break;
}

switch(color)
{
    case "BL":
        product[1] = "Black";
        break;
    case "MN":
        product[1] = "Maroon";
        break;
    default:
        product[1] = "White";
        break;
}

switch(size)
{
    case "S":
        product[2] = "Small";
        break;
    case "M":
        product[2] = "Medium";
        break;
    case "L":
        product[2] = "Large";
        break;
    default:
        product[2] = "One Size Fits All";
        break;
}
Console.WriteLine($"Product: {size} {color} {type}");
