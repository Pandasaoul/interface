using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Openclosetdroite : MonoBehaviour, IUsableObject
{
    public GameObject portegauche;
    Animator porte;
    public bool _click;
    private void Start()
    {
        porte = portegauche.GetComponent<Animator>();
        _click = porte.GetBool("click");
        
    }

    public void UseObject()
    {
        Open();
    }

    private void Open()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_click == false)
            {
                porte.SetBool("click", true);
                _click = true;
            }
            else
            {
                porte.SetBool("click", false);
                _click = false;
            }
        }
    }
}
