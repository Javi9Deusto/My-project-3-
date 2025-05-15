using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class ConfigureEvent : MonoBehaviour
{
    public bool duplicable = true;
    public void CallDuplicate()
    {
        if (!duplicable) return;
        FindFirstObjectByType<DuplicateObject>().DuplicateObjctFunction();
        duplicable = false;
    }
}
