using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diziler : MonoBehaviour {

    public string[] isimler = new string[6];


    void Start()
    {

        string[] ogrenciler = new string[6];

        ogrenciler[0] = "Ferhat";
        ogrenciler[1] = "Ali";
        ogrenciler[2] = "Cemre";
        ogrenciler[3] = "Berkay";
        ogrenciler[4] = "Nilüfer";
        ogrenciler[5] = "Eylül";


        for (int i = 0; i < ogrenciler.Length; i++)
        {
            Debug.Log(ogrenciler[i]);

        }
        


      }
	

}
