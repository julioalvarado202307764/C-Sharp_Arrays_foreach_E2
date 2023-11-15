/*int [] inventory = {200, 450, 700, 175, 250 }; FOREACH UTILIZANDO INT suma todos los numeros almacenados en inventory e incrementa en uno en la variable bin
 y tambien suma el primero numero por el segundo y asi hasta llegar al ultimo 200+450 = 650 -> Bin1 = 650
int sum = 0;
int bin = 0;
foreach(int items in inventory){
    sum += items;
    bin++;
    Console.WriteLine($"Bin{bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory");*/
string [] pedidos = {"B123","C234", "A345", "C15", "B177", "G3003", "C235", "B179"};//LLamar a todos los pedidos que comienzen con la letra B
foreach(string pedido in pedidos){
    if(pedido.StartsWith("B")){
        Console.WriteLine($"Los pedidos que inician con la letra B son: {pedido}");
    }
}
