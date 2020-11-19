using TMPro;
using UnityEngine;

public class PopUpWindow : MonoBehaviour
{
    public GameObject buttonCaller;
    public GameObject popUpBox;
    public Animator animator;
    public TMP_Text popUpText;

    public void PopUp()
    {
        buttonCaller.SetActive(false);
        popUpBox.SetActive(true);
        animator.SetTrigger("pop");
    }
}
