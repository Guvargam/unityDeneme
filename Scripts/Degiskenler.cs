using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Degiskenler : MonoBehaviour {
    
	void Start ()
    {

        int tamsayi;
        float ondalikli;
        bool truefalse;
        string kelime;
        float kesirli;
        float toplam;
        int baskaSayi = 23*(2+5);



        tamsayi = 27;
        ondalikli = 12.4f;
        kesirli = 54.8f;


       // Debug.Log(tamsayi);
       //Debug.Log(ondalikli);
       //Debug.Log(kesirli);


        kesirli = 43.4f;
        ondalikli = 34.96f;
        toplam = kesirli + ondalikli;

        kelime = "Bu sayıların toplamı = " + toplam.ToString();


        //Debug.Log(kesirli);
        //Debug.Log(ondalikli);

        Debug.Log(kelime);
    }


}
