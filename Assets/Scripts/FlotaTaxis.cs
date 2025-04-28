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

    void Start()
    {
        cantLitroPorUnidad = kmPorUnidad / kmPorLitro;
        if (flotaCant < 0 || dias < 0)
        {
            Debug.Log("Ambos valores tienen que ser igual o mayor que 0");
            return;
        }
        if (dias < 5)
        {
            Debug.Log("La cantidad de dias no puede ser menor a 5");
            return;
        }


        cantLitrosDia = flotaCant * cantLitroPorUnidad;
        cantLitrosTotales = cantLitrosDia * dias;
        precioTotal = cantLitrosTotales * precioPorLitro;
        if (cantLitroPorUnidad % 2 != 0)
        {
            precioTotal = precioTotal - precioTotal * .8;
        }

        Debug.Log("Una flota de " + flotaCant + " unidades trabajando durante " + dias + " días implicará un gasto de " + precioTotal + " pesos en concepto de combustible");

    }

}
