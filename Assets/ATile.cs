using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ATile : MonoBehaviour
{

    public string myState = "";
    tictactoecontroller controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponentInParent<tictactoecontroller>();
    }

   

    public void reset()
    {

        myState = "";
        GetComponent<Button>().interactable = true;
        GetComponent<Animator>().SetTrigger("reset");

    }

    public void click()
    {

        GetComponent<Animator>().ResetTrigger("reset");

        GetComponent<Button>().interactable = false;

        myState = controller.turn;
        controller.nextPlayer();

        GetComponent<Animator>().SetTrigger(myState);
 

    }
}
