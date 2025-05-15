using UnityEngine;

public class FixedAction : MonoBehaviour
{
    FixedJoint joint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public FixedAction controlActions = null; 
    public GameObject collidedObject;

    public void OnCollisionEnter(Collision collision)
    {
        joint = gameObject.AddComponent<FixedJoint>();
        joint.connectedBody = collision.gameObject.GetComponent<Rigidbody>();
    }

    public void OnCollisionExit(Collision collision)
    {
        joint = collision.gameObject.GetComponent<FixedJoint>();
        if (joint != null)
        {
            Destroy(joint);
        }
    }
}

