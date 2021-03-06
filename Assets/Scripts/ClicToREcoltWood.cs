﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicToREcoltWood : MonoBehaviour
{
    private bool isRecolting;
    public float timeRecolting;
    public ResourceManagers resourceManagers;
    // Start is called before the first frame update
    void Start()
    {
        GameObject managers = GameObject.Find("ResourceManagers");
        resourceManagers = managers.GetComponent<ResourceManagers>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        Debug.Log("sourieEnter");
        if (Input.GetButtonDown("Fire1"))
        {
            resourceManagers.StartCoroutineBois();
            isRecolting = true;
            
        }

        if (isRecolting)
        {
            StartCoroutine(TimeToDestroy());
        }
    }




    IEnumerator TimeToDestroy()
    {
        yield return new WaitForSeconds(0.5f);
        isRecolting = false;
        Debug.Log("destroyTree");
        Destroy(gameObject);
    }



}
