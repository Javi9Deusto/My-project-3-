using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class ConfigureEvent : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<XRGrabInteractable>().selectEntered.AddListener(FindFirstObjectByType<DuplicateObject>().DuplicateObjctFunction);
    }
}
