using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class ConfigureEvent : MonoBehaviour
{
    public void CallDuplicate()
    {
        FindFirstObjectByType<DuplicateObject>().DuplicateObjctFunction();
    }
}
