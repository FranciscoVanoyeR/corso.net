﻿using Humanizer;

Console.WriteLine("Por favor ingrese nombre: ");
var nombre = Console.ReadLine();

Console.WriteLine("Por favor ingrese su cargo: ");
var cargo = Console.ReadLine();

Console.WriteLine("Por favor ingrese su edad: ");
var edad = int.Parse(Console.ReadLine());

Console.WriteLine($"Hola, mi nombre es {nombre}, tengo {edad.ToWords(new System.Globalization.CultureInfo("es"))} años y soy {cargo}");
