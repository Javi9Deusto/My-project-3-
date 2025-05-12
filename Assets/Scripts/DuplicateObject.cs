using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject objetoDuplicado; // Asigna el prefab del objeto duplicado

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DuplicateObjctFunction(Collider other)
    {
        GameObject nuevoObjeto = Instantiate(objetoDuplicado);
        this.enabled = false;
    }

    
}
