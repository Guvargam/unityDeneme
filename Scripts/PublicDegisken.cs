using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicDegisken : MonoBehaviour {

    int x;
    int y;



	// Use this for initialization
	void Start ()
    {

        x = 34;
        y = 78;


        Debug.Log(x + y);


        // Arttırma oparatorleri

        int sayi = 5;

        for (sayi =5; sayi < 14; sayi++)
        {
            Debug.Log(sayi);
        }
        

    }
	
	// Update is called once per frame
	void Update ()
    {

        

        
    }
}
