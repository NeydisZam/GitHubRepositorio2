﻿<<<<<<< HEAD
﻿


using System.Collections;
=======
﻿using System.Collections;
//definicion e inicializacion de los arreglos en paralelo y el diccionario
>>>>>>> VersionSimple
String[] Departamento = { "Boaco", "Carazo", "Chinandega", "Chontales", "Costa Caribe Norte", "Costa Caribe Sur", "Estelí", "Granada", "Jinotega", "León", "Madriz", "Managua", "Masaya", "Matagalpa", "Nueva Segovia", "Río San Juan", "Rivas" };
int[] Poblacion = { 185013, 197139, 439906, 190863, 530586, 414543, 229866, 214317, 475630, 421050, 174744, 1546939, 391903, 593503, 271581, 135446, 182645 };
Dictionary<string, int> diccionario = Departamento
          .Zip(Poblacion, (k, v) => new { Clave = k, Valor = v })
          .ToDictionary(x => x.Clave, x => x.Valor);
<<<<<<< HEAD

int maxDep = Poblacion.Max();
int minDep = Poblacion.Min();
string maxDepkey = "", minDepkey = "";

<<<<<<< HEAD
//mostrar el diccionario sin ordenar
Console.WriteLine($"datos Desordenados");
foreach (var item in diccionario)
Console.WriteLine($"{item.key,-20}==>{item.value,10:NO");
Console.WriteLine();
//Ordenando con LINQ OrderBy el diccionario
Console.WriteLine($"mayor Población:{maxDepkey}");
Console.WriteLine($"menor Población:{minDepkey}");
=======
Console.WriteLine($"Departamento con mayor Población:{maxDepkey}");
Console.WriteLine($"Departamento con menor Población:{minDepkey}");
//Sumar todas las pblaciones con SUM de LINQ
Console.WriteLine($"Población General:{Poblacion.Sum():N0}");
Console.WriteLine($"Departamento con mayor Población:{maxDepkey}");
Console.WriteLine($"Departamento con menor Población:{minDepkey}");
>>>>>>> versionSimple
for (var i = 0; i < Poblacion.Length; i++)
{
    if (Poblacion[i] == maxDep)
        maxDepkey = Departamento[i];
    if (Poblacion[i] == minDep)
        minDepkey = Departamento[i];
}

var ordenado = diccionario.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
Departamento = ordenado.Keys.ToArray();
Poblacion = ordenado.Values.ToArray();

for (var i = 0; i < Poblacion.Length; i++)
    Console.WriteLine($"{Departamento[i],20} ==> {Poblacion[i],10:N0}");

=======
//Ordenando el diccionario de menor a mayor
var ordenado = diccionario.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
//fijando los nombres de los departamentos con menor y mayor poblacion
string minDepkey = ordenado.First().Key;
string maxDepkey = ordenado.Last().Key;
//reasignacion de los arreglos en paralelo
Departamento = ordenado.Keys.ToArray();
Poblacion = ordenado.Values.ToArray();
//mostrar los arreglos ordenados de menor a mayor
for (var i = 0; i < Poblacion.Length; i++)
    Console.WriteLine($"{Departamento[i],20} ==> {Poblacion[i],10:N0}");
//Suma de toda la poblacion y nombre de mayor y menor
>>>>>>> VersionSimple
