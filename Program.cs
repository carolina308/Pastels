using Pasteles;

Pastel pastelC=new Pastel("pastel de chocolate",20);
pastelC.agregar_ingrediente(new Ingrediente("Azucar",4,2500));
pastelC.agregar_ingrediente(new Ingrediente("Harina",2,4000));
pastelC.agregar_ingrediente(new Ingrediente("polvo para hornaear",1,5000));
pastelC.agregar_ingrediente(new Ingrediente("crema de chocolate",2,2000));
pastelC.agregar_ingrediente(new Ingrediente("chicpas de chocolate",2,2000));


Console.WriteLine("Cantidad de Ingredientes del pastelito: "+pastelC.cantidad_ingredientes());
Console.WriteLine(pastelC.listar_ingredientes());
Console.WriteLine("Costo Total pastelito: "+pastelC.calcular_costo());
