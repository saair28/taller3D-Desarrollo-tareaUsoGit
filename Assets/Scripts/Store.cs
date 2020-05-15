using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
    static string next;
    static float totalDeCompra;
    // Start is called before the first frame update
    void Start()
    {
        Main();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    void Main()
    {

        bool loop = true;

        while (loop)
        {
            //Debug.Log.Clear();

            CreateProducLimpieza();

            if (!(next.ToUpper() == "Y"))
                loop = false;
            loop = (next.ToUpper() == "Y");
            Debug.Log("El total de su compra es: " + totalDeCompra);

        }


    }
    static void CreateProducLimpieza()
    {
        float total = 0;
        float preAsp = 50.2f, preVen = 41.2f, prePlan = 35.3f, preAA = 53.1f;

        Debug.Log("Select Product");
        Debug.Log("   1 - Aspiradora   - Precio: " + preAsp);
        Debug.Log("   2 - Ventiladores - Precio: " + preVen);
        Debug.Log("   3 - Planchadoras - Precio: " + prePlan);
        Debug.Log("   4 - Aire_Acondicionado - Precio: " + preAA);
        Debug.Log("Por favor escriba el numero del producto que desee comprar\n");
        int codPro = Int32.Parse(Console.ReadLine());

        switch (codPro)
        {
            case 1:
                Console.WriteLine("USTED A COMPRADO LA ASPIRADORA");
                total = preAsp + total;
                Console.WriteLine("EL TOTAL DE SU COMPRA ES: " + total);
                totalDeCompra = total;
                break;

            case 2:
                Console.WriteLine("USTED A COMPRADO EL VENTILADOR");
                total = preVen + total;
                Console.WriteLine("EL TOTAL DE SU COMPRA ES: " + total);
                totalDeCompra = total;
                break;

            case 3:
                Console.WriteLine("USTED A COMPRADO EL PLANCHADOR");
                total = prePlan + total;
                Console.WriteLine("EL TOTAL DE SU COMPRA ES: " + total);
                totalDeCompra = total;
                break;

            case 4:
                Console.WriteLine("USTED A COMPRADO EL AIRE ACONDICIONADO");
                total = preAA + total;
                Console.WriteLine("EL TOTAL DE SU COMPRA ES: " + total);
                totalDeCompra = total;
                break;
            default:
                Console.WriteLine("EL TOTAL DE SU COMPRA ES: " + total);
                break;

        }




        Console.WriteLine("Seguir comprando (Y/N?");
        next = Console.ReadLine();



    }
}
