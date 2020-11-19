using TMPro;
using UnityEngine;

public class PopUpWindow : MonoBehaviour
{
    public GameObject popUpBox;
    public Animator animator;
    public TMP_Text popUpText;

    public void PopUp()
    {
        popUpBox.SetActive(true);
        animator.SetTrigger("pop");
    }
    
    public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        popUpBox.SetActive(false);
    }
}
