﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManancaReputationImpact : MonoBehaviour
{

    //positions to instantiate at
    public GameObject position1;
    public GameObject position2;
    public GameObject position3;
    public GameObject position4;
    public GameObject position5;
    public GameObject position6;
    public GameObject position7;
    public GameObject position8;

    //instantiable objects
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    public GameObject object4;
    public GameObject object5;
    public GameObject object6;
    public GameObject object7;
    public GameObject object8;

    bool mapChanging = true;   

    void Update()
    {

        //grab Mananca Reputation variable
        float ManancaRep = GameObject.Find("ReputationBar").GetComponent<ReputationCalculation>().ManancaRep;

        //if Manana Reputation is in the red (sub 40), instantiate blockade on the bridge
        if (ManancaRep <= 40 & mapChanging == true)
        {

            Instantiate(object6, position6.transform.position, Quaternion.identity, this.gameObject.transform);
            Instantiate(object4, position4.transform.position, Quaternion.identity, this.gameObject.transform);

            mapChanging = false;
        }

        //if it's neutral, destroy all instantiated objects
        else if (ManancaRep > 40 && ManancaRep < 70)
        {

            int children = transform.childCount;

            //for loop to go through instantiate child objects and destroy them
            for (int i = children - 1; i >= 0; i--)
            {
                GameObject.Destroy(transform.GetChild(i).gameObject);
            }

            mapChanging = true;
        }

        //if it's positive, instantiate applause/celebration
        else if (ManancaRep >= 70 && ManancaRep < 100 & mapChanging == true)
        {

            Instantiate(object8, position8.transform.position, Quaternion.identity, this.gameObject.transform);

            mapChanging = false;
        }
    }
}
