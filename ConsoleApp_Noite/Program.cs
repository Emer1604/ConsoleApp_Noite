﻿// See https://aka.ms/new-console-template for more information
using ConsoleApp_Noite;
using System;

Console.WriteLine("Hello, World!");

Produto p1 = new Produto(1, 10.90M, "Cervejinha");

Console.WriteLine(p1.getDescricao()+" "+p1.getId());

p1.setValor(11.85M);
p1.setDescricao("Cerveja Skol 1 Litrão");
Console.WriteLine(p1.getDescricao() + " " + p1.getId());
