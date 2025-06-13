using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class ConfigureEvent : MonoBehaviour
{
    public bool duplicable = true;
    public void CallDuplicateSphere()
    {
        if (!duplicable) return;
        GameObject.Find("DuplicateSphere").GetComponent<DuplicateObject>().DuplicateObjctFunction();
        duplicable = false;
    }

    public void CallDuplicateCube()
    {
        if (!duplicable) return;
        GameObject.Find("DuplicateCube").GetComponent<DuplicateObject>().DuplicateObjctFunction();
        duplicable = false;
    }
}
