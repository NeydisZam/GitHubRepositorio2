﻿//programa que permita visualizar los departamentos de nicaragua con
//su cantidad poblacional.
//Encuentra el mayor, menor y ordene los datos
using Departamentos;
//Lista de departamentos
List<depto>LstDeptos= new List <depto>()
{
    new depto ("Boaco",185013),
    new depto ("Carazo",197139),
    new depto ("Chinandega",439906),
    new depto ("Chontales",190863),
    new depto ("Costa Caribe Norte",530586),
    new depto ("Costa Caribe Sur",414543),
    new depto ("Estelí",229866),
    new depto ("Granada",214317),
    new depto ("Jinotega",475630),
    new depto ("León",421050),
    new depto ("Madriz",174744),
    new depto ("Managua",1546939),
    new depto ("Masaya",391903),
    new depto ("Matagalpa",593503),
    new depto ("Nueva segovia",271581),
    new depto ("Río San Juan",135446),
    new depto ("Rivas",182645);
}

//Encontrar el mayor y el menor (poblacion)
depto minDepto=LstDeptos.Orderby(d=>d.population).First;
depto maxDepto= LstDeptos.Orderby(d=>d.population).Last;
//Ordenar los departamentos
var DeptoOrdenado =LstDeptos.Orderby(d=>d.population);
//Mostrar departamentos ordenados
foreach (var item in DeptoOrdenado)
   System.Console.WriteLine($"{item.Name,-20}==>{item.population,10:NO}");
//Mostrar el mayor y el menor
System.Console.WriteLine($"Dpto con menor población:{minDepto.Name}");
System.Console.WriteLine($"Dpto con mayor población:{maxDepto.Name}");
//sumar todas las poblaciones con SUM de LINQ
int total = LstDeptos.Select(d=>d.population).Sum();
System.Console.WriteLine($"Poblacion general:{total:NO}");