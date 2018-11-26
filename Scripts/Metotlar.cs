using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metotlar : MonoBehaviour {


	void Start ()
    {
        yazdir(23);
    }
	
	
	void Update ()
    {
		
	}



    void yazdir(int defa)
    {
        for (int i = 0; i < defa +1; i++)
        {
            Debug.Log(i);
        }

    }


}
