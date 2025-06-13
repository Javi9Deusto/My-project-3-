using NUnit.Framework;
using System;
using UnityEngine;

public class CombropanteEscena : MonoBehaviour
{
    public GameObject ventaBien;
    public GameObject ventMal;
    public GameObject ventPeor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ComprobanteUnionesObjetos()
    {
        GameObject[] listaTag = GameObject.FindGameObjectsWithTag("Iman");
        int count = 0;

        Boolean compSize = false;
        Boolean compJoints = false;

        if (listaTag.Length == 6)
        {
            compSize = true;
        }

        foreach (GameObject tag in listaTag)
        {
            if (tag.GetComponent<FixedJoint>() != null)
            {
                count++;
                if (count > 4)
                {
                    break;
                }
            }
        }

        if (count == 4)
        {
            compJoints = true;
        }

        if (compJoints && compSize)
        {
            //Activar Bien
            ventaBien.SetActive(true);
        }
        else if (compJoints && !compSize)
        {
            //Activar Mal
            ventMal.SetActive(true);
        }
        else if (!compJoints && compSize)
        {
            //Activar Peor
            ventPeor.SetActive(true);
        }
        else
        {
            //Activar Peor
            ventPeor.SetActive(true);
        }
    }

    public void OkDeVentana()
    {
        ventaBien.SetActive(false);
        ventMal.SetActive(false);
        ventPeor.SetActive(false);
    }
}
