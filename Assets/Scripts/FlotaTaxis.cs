using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlotaTaxis : MonoBehaviour
{
    public int flotaCant;
    public int dias;
    private int kmPorLitro = 15;
    private int kmPorUnidad = 90;
    private int precioPorLitro = 130;
    private int cantLitroPorUnidad;
    private int kmTotales;
    private int cantLitrosDia;
    private float precioTotal;
    private int cantLitrosTotales;
    private float descuento = .8f;

    void Start()
    {
        cantLitroPorUnidad = kmPorUnidad / kmPorLitro; //Consigo la relacion de cantidad de litros por lo que hace una unidad por dia, que es 6 litros
        if (flotaCant < 0 || dias < 0) // Si la flota es menor a 0 o si los dias son menores a 0
        {
            Debug.Log("Ambos valores tienen que ser igual o mayor que 0"); 
            return;
        }
        if (dias < 5)
        {
            Debug.Log("La cantidad de dias no puede ser menor a 5"); // Si los dias son menores a 5
            return;
        }
        cantLitrosDia = flotaCant * cantLitroPorUnidad; // La cantidad de litros que consume la flota por dia 
        cantLitrosTotales = cantLitrosDia * dias; // Multiplico lo que consume de litros la flota en un dia por la cantidad de dias que puso el usuario

        precioTotal = cantLitrosTotales * precioPorLitro; //El precio total son los litros totales que consumieronla flota y lo multiplico por la variable precio por litro
        if (cantLitrosTotales >= 100) // Si la cantidad de litros totales son iguales o mayores a 100 litros entonces se aplica un descuento del 20%
        {
            precioTotal = precioTotal - (precioTotal * descuento); // precio total con el descuento aplicado
            Debug.Log("Una flota de " + flotaCant + " unidades trabajando durante " + dias + " días implicará un gasto de " + precioTotal + " pesos sumado a un descuento de " + descuento + " en concepto del combustible total: " + cantLitrosTotales);
            return;
        }

        Debug.Log("Una flota de " + flotaCant + " unidades trabajando durante " + dias + " días implicará un gasto de " + precioTotal + " pesos en concepto del combustible");

    }

}
