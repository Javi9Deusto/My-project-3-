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

    public FixedAction controlActions = null; // Referencia al sistema Input Actions
    public GameObject collidedObject; // Objeto con el que colisionaste

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hola");
        FixedJoint joint = gameObject.AddComponent<FixedJoint>();
        joint.connectedBody = collision.gameObject.GetComponent<Rigidbody>();
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

