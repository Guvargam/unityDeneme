using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KontrolMekanizmasiKullanim : MonoBehaviour {



    public bool kontrol;
    int tamsayi = 100;
    float paymentTotal;

    void Start()
    {

        int x = 15;
        int y = 44;


        if (x == 5 && y == 4 )
        {
            Debug.Log(" İki Koşul da sağlandı");

        }

        if (x == 5 || y == 7)
        {
            Debug.Log("Koşullardan herhangi biri sağlandı. Hangisi oldugunu burdan bilemiyoruz malesef");
        }
        else
        {
            Debug.Log("Her iki koşul da SAĞLANAMADI");
        }

    }



    void Update ()
    {


        // && oparatörü tanımladık ve farede basılma durumuna göre işlem yaptırdık.

        /* if (Input.GetMouseButtonDown(0) && tamsayi > 0 )
        {
            tamsayi -= 10;
            Debug.Log("Fareye tıklandı agaa puan =" + tamsayi);
            
           
        }

        if (tamsayi == 0)
        {
            Debug.Log("Oyun bitti kardeş");
        }

        */


	}
}
