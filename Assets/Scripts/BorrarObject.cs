using UnityEngine;

public class BorrarObject : MonoBehaviour
{

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject); // Esto elimina el objeto con el que colisiona
    }
}
