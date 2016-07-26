﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class csScreenPointTouch : MonoBehaviour
{

    public LayerMask ignoreUI;
    public static bool rDrag;
    public GameObject SQLManager;


    void Start()
    {
        rDrag = false;
    }

    public void dragTrue()
    {
        rDrag = true;
    }

    public void dragFalse()
    {
        Debug.Log("dragFalse");
        rDrag = false;
    }
    void Update()
    {
        if (rDrag == false)
        {
            if (Input.GetButtonUp("Fire1"))                                     // Debug Mode
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);    // Debug Mode
                RaycastHit hit;                                                 // Debug Mode
                Debug.Log(Input.mousePosition);
                //foreach (Touch touch in Input.touches)                        // Build Mode
                //{
                //    Ray ray = Camera.main.ScreenPointToRay(touch.position);   // Build Mode
                //    RaycastHit hit;                                           // Build Mode

                if (Physics.Raycast(ray, out hit))
                    {
                    Debug.Log(hit.point);
                    Debug.Log(hit.transform.position);

                        if (hit.transform.tag.Equals("Finish"))
                        {
                            Debug.Log("panal");
                        }

                        if (hit.transform.tag.Equals("Food"))
                        {
                            Debug.Log("ray hit food") ;
                        //MainSingleTon.Instance.getFood(Input.mousePosition); //touch.point로 바꿔야함
                        MainSingleTon.Instance.getFood(hit.transform.position);


                        }

                        if (hit.transform.tag.Equals("Titanium"))
                        {
                            Debug.Log("ray hit titanium");
                        MainSingleTon.Instance.getTitanium(hit.point);
                        }

                        if (hit.transform.tag.Equals("Ship"))
                        {
                            //ExploreState에 관련 로직 처리 
                            MainSingleTon.Instance.shipTouch = true;
                        }
                        if (hit.transform.tag.Equals("Energy"))
                        {
                            Debug.Log("Ray hit Energy");
                        MainSingleTon.Instance.getEnergy();
                        }
                        if (hit.transform.tag.Equals("PostBox"))
                        {
                            Debug.Log("Ray hit PostBOX");
                        }

                    }
                //}                                                             // Build mode
            }                                                                   // Debug mode 
        }
        rDrag = false;

    }


}

