using NUnit.Framework;
using System;
using UnityEngine;

public class CombropanteEscena : MonoBehaviour
{
    public GameObject ventBien;
    public GameObject ventMal;
    public GameObject ventSizeMal;
    public GameObject ventJointsMal;

    public GameObject BotonSiguiente;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*public void ComprobanteUnionesObjetos()
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
    }*/

    public void comprobanteLeccion1()
    {
        GameObject[] listaTag = GameObject.FindGameObjectsWithTag("Iman");
        int count = 0;

        Boolean compSize = false;
        Boolean compJoints = false;

        if (listaTag.Length == 4)
        {
            compSize = true;
        }

        foreach (GameObject tag in listaTag)
        {
            if (tag.GetComponent<FixedJoint>().connectedBody != null )
            {
                count++;
                if (count > 1)
                {
                    break;
                }
            }
        }

        if (count == 1)
        {
            compJoints = true;
        }

        if (!compSize && compJoints)
        {
            ventSizeMal.SetActive(true);
        }
        else if (compSize && !compJoints)
        {
            ventJointsMal.SetActive(true);
        }
        else if (compSize && compJoints)
        {
            BotonSiguiente.SetActive(true);
            ventBien.SetActive(true);
        }
        else 
        {
            ventMal.SetActive(true);
        }
    }

    public void comprobanteLeccion2()
    {
        GameObject[] listaTag = GameObject.FindGameObjectsWithTag("Iman");
        int count = 0;

        Boolean compSize = false;
        Boolean compJoints = false;

        if (listaTag.Length == 7)
        {
            compSize = true;
        }

        foreach (GameObject tag in listaTag)
        {
            if (tag.GetComponent<FixedJoint>().connectedBody != null)
            {
                count++;
                if (count > 3)
                {
                    break;
                }
            }
        }

        if (count == 3)
        {
            compJoints = true;
        }

        if (!compSize && compJoints)
        {
            ventSizeMal.SetActive(true);
        }
        else if (compSize && !compJoints)
        {
            ventJointsMal.SetActive(true);
        }
        else if (compSize && compJoints)
        {
            BotonSiguiente.SetActive(true);
        }
        else
        {
            ventMal.SetActive(true);
        }
    }

    public void comprobanteLeccion3()
    {
        GameObject[] listaTag = GameObject.FindGameObjectsWithTag("Iman");
        int count = 0;

        Boolean compSize = false;
        Boolean compJoints = false;

        if (listaTag.Length == 19)
        {
            compSize = true;
        }

        foreach (GameObject tag in listaTag)
        {
            if (tag.GetComponent<FixedJoint>().connectedBody != null)
            {
                count++;
                if (count > 13)
                {
                    break;
                }
            }
        }

        if (count == 13)
        {
            compJoints = true;
        }

        if (!compSize && compJoints)
        {
            ventSizeMal.SetActive(true);
        }
        else if (compSize && !compJoints)
        {
            ventJointsMal.SetActive(true);
        }
        else if (compSize && compJoints)
        {
            BotonSiguiente.SetActive(true);
            ventBien.SetActive(true);
        }
        else
        {
            ventMal.SetActive(true);
        }
    }

    public void comprobanteNivel11()
    {
        GameObject[] listaTag = GameObject.FindGameObjectsWithTag("Iman");
        int count = 0;

        Boolean compSize = false;
        Boolean compJoints = false;

        if (listaTag.Length == 14)
        {
            compSize = true;
        }

        foreach (GameObject tag in listaTag)
        {
            if (tag.GetComponent<FixedJoint>().connectedBody != null)
            {
                count++;
                if (count > 8)
                {
                    break;
                }
            }
        }

        if (count == 8)
        {
            compJoints = true;
        }

        if (!compSize && compJoints)
        {
            ventSizeMal.SetActive(true);
        }
        else if (compSize && !compJoints)
        {
            ventJointsMal.SetActive(true);
        }
        else if (compSize && compJoints)
        {
            BotonSiguiente.SetActive(true);
            ventBien.SetActive(true);
        }
        else
        {
            ventMal.SetActive(true);
        }
    }

    public void comprobanteNivel12()
    {
        GameObject[] listaTag = GameObject.FindGameObjectsWithTag("Iman");
        int count = 0;

        Boolean compSize = false;
        Boolean compJoints = false;

        if (listaTag.Length == 26)
        {
            compSize = true;
        }

        foreach (GameObject tag in listaTag)
        {
            if (tag.GetComponent<FixedJoint>().connectedBody != null)
            {
                count++;
                if (count > 32)
                {
                    break;
                }
            }
        }

        if (count == 32)
        {
            compJoints = true;
        }

        if (!compSize && compJoints)
        {
            ventSizeMal.SetActive(true);
        }
        else if (compSize && !compJoints)
        {
            ventJointsMal.SetActive(true);
        }
        else if (compSize && compJoints)
        {
            BotonSiguiente.SetActive(true);
            ventBien.SetActive(true);
        }
        else
        {
            ventMal.SetActive(true);
        }
    }

    public void comprobanteNivel13()
    {
        GameObject[] listaTag = GameObject.FindGameObjectsWithTag("Iman");
        int count = 0;

        Boolean compSize = false;
        Boolean compJoints = false;

        if (listaTag.Length == 38)
        {
            compSize = true;
        }

        foreach (GameObject tag in listaTag)
        {
            if (tag.GetComponent<FixedJoint>().connectedBody != null)
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

        if (!compSize && compJoints)
        {
            ventSizeMal.SetActive(true);
        }
        else if (compSize && !compJoints)
        {
            ventJointsMal.SetActive(true);
        }
        else if (compSize && compJoints)
        {
            BotonSiguiente.SetActive(true);
            ventBien.SetActive(true);
        }
        else
        {
            ventMal.SetActive(true);
        }
    }

    public void comprobanteNivel21()
    {
        GameObject[] listaTag = GameObject.FindGameObjectsWithTag("Iman");
        int count = 0;

        Boolean compSize = false;
        Boolean compJoints = false;

        if (listaTag.Length == 18)
        {
            compSize = true;
        }

        foreach (GameObject tag in listaTag)
        {
            if (tag.GetComponent<FixedJoint>().connectedBody != null)
            {
                count++;
                if (count > 12)
                {
                    break;
                }
            }
        }

        if (count == 12)
        {
            compJoints = true;
        }

        if (!compSize && compJoints)
        {
            ventSizeMal.SetActive(true);
        }
        else if (compSize && !compJoints)
        {
            ventJointsMal.SetActive(true);
        }
        else if (compSize && compJoints)
        {
            BotonSiguiente.SetActive(true);
            ventBien.SetActive(true);
        }
        else
        {
            ventMal.SetActive(true);
        }
    }
    
    public void comprobanteNivel22()
    {
        GameObject[] listaTag = GameObject.FindGameObjectsWithTag("Iman");
        int count = 0;

        Boolean compSize = false;
        Boolean compJoints = false;

        if (listaTag.Length == 30)
        {
            compSize = true;
        }

        foreach (GameObject tag in listaTag)
        {
            if (tag.GetComponent<FixedJoint>().connectedBody != null)
            {
                count++;
                if (count > 24)
                {
                    break;
                }
            }
        }

        if (count == 24)
        {
            compJoints = true;
        }

        if (!compSize && compJoints)
        {
            ventSizeMal.SetActive(true);
        }
        else if (compSize && !compJoints)
        {
            ventJointsMal.SetActive(true);
        }
        else if (compSize && compJoints)
        {
            BotonSiguiente.SetActive(true);
            ventBien.SetActive(true);
        }
        else
        {
            ventMal.SetActive(true);
        }
    }

    public void comprobanteNivel23()
    {
        GameObject[] listaTag = GameObject.FindGameObjectsWithTag("Iman");
        int count = 0;

        Boolean compSize = false;
        Boolean compJoints = false;

        if (listaTag.Length == 42)
        {
            compSize = true;
        }

        foreach (GameObject tag in listaTag)
        {
            if (tag.GetComponent<FixedJoint>().connectedBody != null)
            {
                count++;
                if (count > 36)
                {
                    break;
                }
            }
        }

        if (count == 36)
        {
            compJoints = true;
        }

        if (!compSize && compJoints)
        {
            ventSizeMal.SetActive(true);
        }
        else if (compSize && !compJoints)
        {
            ventJointsMal.SetActive(true);
        }
        else if (compSize && compJoints)
        {
            BotonSiguiente.SetActive(true);
            ventBien.SetActive(true);
        }
        else
        {
            ventMal.SetActive(true);
        }
    }

    public void comprobanteNivel31()
    {
        GameObject[] listaTag = GameObject.FindGameObjectsWithTag("Iman");
        int count = 0;

        Boolean compSize = false;
        Boolean compJoints = false;

        if (listaTag.Length == 17)
        {
            compSize = true;
        }

        foreach (GameObject tag in listaTag)
        {
            if (tag.GetComponent<FixedJoint>().connectedBody != null)
            {
                count++;
                if (count > 12)
                {
                    break;
                }
            }
        }

        if (count == 4)
        {
            compJoints = true;
        }

        if (!compSize && compJoints)
        {
            ventSizeMal.SetActive(true);
        }
        else if (compSize && !compJoints)
        {
            ventJointsMal.SetActive(true);
        }
        else if (compSize && compJoints)
        {
            BotonSiguiente.SetActive(true);
            ventBien.SetActive(true);
        }
        else
        {
            ventMal.SetActive(true);
        }
    }

    public void comprobanteNivel32()
    {
        GameObject[] listaTag = GameObject.FindGameObjectsWithTag("Iman");
        int count = 0;

        Boolean compSize = false;
        Boolean compJoints = false;

        if (listaTag.Length == 26)
        {
            compSize = true;
        }

        foreach (GameObject tag in listaTag)
        {
            if (tag.GetComponent<FixedJoint>().connectedBody != null)
            {
                count++;
                if (count > 21)
                {
                    break;
                }
            }
        }

        if (count == 21)
        {
            compJoints = true;
        }

        if (!compSize && compJoints)
        {
            ventSizeMal.SetActive(true);
        }
        else if (compSize && !compJoints)
        {
            ventJointsMal.SetActive(true);
        }
        else if (compSize && compJoints)
        {
            BotonSiguiente.SetActive(true);
            ventBien.SetActive(true);
        }
        else
        {
            ventMal.SetActive(true);
        }
    }

    public void comprobanteNivel33()
    {
        GameObject[] listaTag = GameObject.FindGameObjectsWithTag("Iman");
        int count = 0;

        Boolean compSize = false;
        Boolean compJoints = false;

        if (listaTag.Length == 33)
        {
            compSize = true;
        }

        foreach (GameObject tag in listaTag)
        {
            if (tag.GetComponent<FixedJoint>().connectedBody != null)
            {
                count++;
                if (count > 28)
                {
                    break;
                }
            }
        }

        if (count == 28)
        {
            compJoints = true;
        }

        if (!compSize && compJoints)
        {
            ventSizeMal.SetActive(true);
        }
        else if (compSize && !compJoints)
        {
            ventJointsMal.SetActive(true);
        }
        else if (compSize && compJoints)
        {
            BotonSiguiente.SetActive(true);
            ventBien.SetActive(true);
        }
        else
        {
            ventMal.SetActive(true);
        }
    }
}
