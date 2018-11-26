using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donguler : MonoBehaviour {


	void Start ()
    {

        int sayac = 0;

         while (sayac < 10)
       {
            Debug.Log("Sayac şu an = " + sayac);


            int v = sayac % 2;
            if (v == 0)
            {
                Debug.Log("Sayaç şu an bir çift sayı tutuyor.");
            }

            sayac++;
        }

    
        Debug.Log("Sayaç Sonlandırıldı!");

        for (int i = 0; i < 14; i++)
        {
            Debug.Log("For döngüsü şu an " + i + ".ci döngüde beybi");
        }

	}
	
}
