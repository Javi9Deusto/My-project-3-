using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DuplicateObject : MonoBehaviour
{

    public GameObject objetoDuplicado;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DuplicateObjctFunction()
    {
        GameObject duplicate = Instantiate(objetoDuplicado);
    }

    
}
