using UnityEngine;

public class EnterExitMenu : MonoBehaviour
{
    public bool MenuActive;
    public GameObject Menu;

    void Start()
    {
        Menu.SetActive(false);
    }
    void Update()
    {
        InsideStore();
    }

    public void OnClickEnter()
    {
        if (!MenuActive)
        {
            MenuActive = true;
        }
    }

    public void OnClickExit()
    {
        if (MenuActive)
        {
            MenuActive = false;
        }
    }

    void InsideStore()
    {
        if (MenuActive)
        {
            Menu.SetActive(true);
        }
        else
        {
            Menu.SetActive(false);

        }
    }
}
