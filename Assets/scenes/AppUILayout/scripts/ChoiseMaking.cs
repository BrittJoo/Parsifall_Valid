using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiseMaking : MonoBehaviour
{

    enum choises { eens, oneens, beetje_eens, beetje_oneens }
    int buttonchoise = 0;
    public void choisebutton()
    {
        switch (buttonchoise)
        {
            case 1:
                Debug.Log("give a charecter a point");

                break;
            case 2:

                break;

            case 3:

                break;

            case 4:

                break;


        }

    }

    public void choiseëens()
    {
        buttonchoise = 1;
    }

    public void choiseoneens()
    {
        buttonchoise = 2;
    }

    public void choisebeetjeëens()
    {
        buttonchoise = 3;
    }

    public void choisebeetjeoneens()
    {
        buttonchoise = 4;
    }

}
