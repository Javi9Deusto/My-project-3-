using UnityEngine;

public class InterfazMenu : MonoBehaviour
{
    public GameObject ventanaAnterior;
    public GameObject ventaPosterior;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClick()
    {
        if (ventaPosterior == null)
        {
            ventanaAnterior.SetActive(false);
        }
        else
        {
            ventanaAnterior.SetActive(false);
            ventaPosterior.SetActive(true);
        }
    }
}
