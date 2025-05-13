using UnityEngine;

public class DuplicateObject : MonoBehaviour
{

    public bool duplicable = true;

    public GameObject objetoDuplicado; // Asigna el prefab del objeto duplicado

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
        Instantiate(objetoDuplicado);
        this.gameObject.GetComponent<DuplicateObject>().duplicable = false;
    }

    
}
