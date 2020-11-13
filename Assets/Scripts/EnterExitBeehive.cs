using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnterExitBeehive : MonoBehaviour
{
    public bool BeehiveMenuActive;
    public GameObject BeehiveMenu;

    void Start()
    {
        BeehiveMenu.SetActive(false);
    }
    void Update()
    {
        InsideBeehive();
    }

   public void OnClickEnterBeehive()
    {
        if (!BeehiveMenuActive)
        {
            BeehiveMenuActive = true;
        }
    }

   public  void OnClickExitBeehive()
    {
        if (BeehiveMenuActive)
        {
            BeehiveMenuActive = false;
        }
    }

    void InsideBeehive()
    {
        if (BeehiveMenuActive)
        {
            BeehiveMenu.SetActive(true);
        }
        else
        {
            BeehiveMenu.SetActive(false);

        }
    }
}
