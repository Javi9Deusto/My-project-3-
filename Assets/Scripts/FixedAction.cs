using UnityEngine;

public class FixedAction : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public FixedAction controlActions; // Referencia al sistema Input Actions
    public GameObject collidedObject; // Objeto con el que colisionaste
    public bool isColliding = false; // Verifica si hay colisión activa

    public void OnCollisionEnter(Collision collision)
    {
        isColliding = true;
        FixedJoint joint = new FixedJoint();
        joint.connectedBody = collision.gameObject.GetComponent<Rigidbody>();
        /*collidedObject = collision.gameObject; // Captura el objeto colisionado
        Debug.Log($"Colisión detectada con: {collidedObject.name}");*/
    }

    /*public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == collidedObject)
        {
            isColliding = false;
            collidedObject = null; // Limpia el objeto colisionado
            Debug.Log("Colisión terminada.");
        }
    }*/
}

