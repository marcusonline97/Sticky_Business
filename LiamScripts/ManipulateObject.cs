using UnityEngine;

public class ManipulateObject : MonoBehaviour
{
    public bool isActive;
    public GameObject objectToManipulate;
    
    public void DeAndActivateObject()
    {
        isActive = !isActive;
        objectToManipulate.SetActive(isActive);
    }
}
