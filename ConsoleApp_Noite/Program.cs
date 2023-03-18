// See https://aka.ms/new-console-template for more information
using ConsoleApp_Noite;
using ConsoleApp_Noite.Heranca;
using System;

/*Console.WriteLine("Hello, World!");

Produto p1 = new Produto(1, 10.90M, "Cervejinha");

Console.WriteLine(p1.getDescricao()+" "+p1.getId());

p1.setValor(11.85M);
p1.setDescricao("Cerveja Skol 1 Litrão");
Console.WriteLine(p1.getDescricao() + " " + p1.getId());

Endereco endereco1 = new Endereco(
    "Rua sobe e desce",
    "894",
    "Monte Alto",
    "14840000",
    "Guariba",
    "SP"
    );

Cliente c1 = new Cliente(1, "Alan", "998756414", endereco1);
Cliente c2 = new Cliente(2, "Bruno", "998776916", endereco1);
Cliente c3 = new Cliente(3, "Caio", "998843461", endereco1);
Cliente c4 = new Cliente(4, "Dioginis", "998759172", endereco1);
Cliente c5 = new Cliente(5, "Elton", "999341414", endereco1);

Console.WriteLine(c2.getEndereco().getRua() + " "+c2.getEndereco().getNumero());
c2.getEndereco().setNumero("135");
Console.WriteLine(c2.getEndereco().getNumero());

Endereco endereco2 = new Endereco(
    "Rua desce e sobe",
    "498",
    "Nova Pradopolis",
    "14841000",
    "Pradopolis",
    "SP"
    );
Console.WriteLine(c2.getEndereco().getRua() + " " + c2.getEndereco().getNumero());
c2.setEndereco(endereco2);
Console.WriteLine(c2.getEndereco().getRua() + " " + c2.getEndereco().getNumero());
*/
Carro gol = new Carro();
gol.temMotor = true;
gol.numeroPortas = 4;
gol.numeroAssentos = 5;
gol.fabricante = "Volkswagen";
gol.cintoSeguranca = true;
gol.arCodicionado = false;

Carro saveiro = new Carro();
saveiro.fabricante = "Volkswagen";

Carro palio = new Carro();
palio.fabricante = "Fiat";

Carro uno = new Carro();
uno.fabricante = "Fiat";

Bike caloi = new Bike();
caloi.temMotor = false;
caloi.numeroPortas = 0;
caloi.numeroAssentos = 1;

Bike speed = new Bike();
speed.temMotor = false;
speed.numeroPortas = 0;

Console.WriteLine(gol.ExibirDados());
Console.WriteLine(speed.ExibirDados());

List<Carro> listaCarros = new List<Carro>();
listaCarros.Add(gol);
listaCarros.Add(saveiro);
listaCarros.Add(palio);
listaCarros.Add(uno);

Console.WriteLine(listaCarros[0].fabricante);
listaCarros.Remove(saveiro);
for(int i=0; i<listaCarros.Count; i++)
    {
        Console.WriteLine(listaCarros[i].ExibirDados());
    }
foreach(var item in listaCarros)
    {
        Console.WriteLine(item.ExibirMarca());
    }