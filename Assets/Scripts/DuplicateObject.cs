using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DuplicateObject : MonoBehaviour
{

    public bool duplicable = true;
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
        if (!duplicable) return;
        GameObject duplicate = Instantiate(objetoDuplicado);
    }

    
}
