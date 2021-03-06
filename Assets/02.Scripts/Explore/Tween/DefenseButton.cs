﻿using UnityEngine;
using System.Collections;

public class DefenseButton : MonoBehaviour {

    bool initDef;
    bool initRet;

    void Awake()
    {
        initDef = false;
        initRet = false;
    }

    void Update()
    {
        if (initRet == false && gameObject.name == "home")
        {
            initRet = true;
            Hashtable hash = new Hashtable();
            hash.Add("x", 100);
            //hash.Add("looktime", 1.0f);
            hash.Add("time", 1.0f);
            //hash.Add("easetype", iTween.EaseType.easeInOutExpo);

            iTween.MoveTo(gameObject, hash);
        }
        if (GameObject.Find("PlanetManager").GetComponent<PlanetManager>().attackStat == true && initDef == false && gameObject.name == "Def")
        {
            initDef = true;
            Hashtable hash = new Hashtable();
            hash.Add("x", 100);
            //hash.Add("looktime", 1.0f);
            hash.Add("time", 1.0f);
            //hash.Add("easetype", iTween.EaseType.easeInOutExpo);

            iTween.MoveTo(gameObject, hash);
        }
    }
}
