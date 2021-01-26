using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tictactoecontroller : MonoBehaviour
{


    public string turn = "x";


    public ATile a1;
    public ATile a2;
    public ATile a3;
    public ATile b1;
    public ATile b2;
    public ATile b3;
    public ATile c1;
    public ATile c2;
    public ATile c3;

    public void nextPlayer()
    {

        //check win conditions

        checkWinConditions();


        if (turn == "x")
        {
            turn = "o";
        } else if(turn == "o")
        {
            turn = "x";
        }


    }


    public void checkWinConditions()
    {


        string winner = "";

        if (checkWinCondition(a1, a2, a3))
        {
            winner = a1.myState;
        }
        if (checkWinCondition(b1, b2, b3))
        {
            winner = b1.myState;
        }
        if (checkWinCondition(c1, c2, c3))
        {
            winner = c1.myState;
        }


        if (checkWinCondition(a1, b1, c1))
        {
            winner = a1.myState;
        }
        if (checkWinCondition(a2, b2, c2))
        {
            winner = a2.myState;
        }
        if (checkWinCondition(a3, b3, c3))
        {
            winner = a3.myState;
        }


        if (checkWinCondition(a1, b2, c3))
        {
            winner = a1.myState;
        }

        if (checkWinCondition(a3, b2, c1))
        {
            winner = a3.myState;
        }




        if(winner == "")
        {

            if(a1.myState != ""
                && a2.myState != ""
                && a3.myState != ""
                && b1.myState != ""
                && b2.myState != ""
                && b3.myState != ""
                && c1.myState != ""
                && c2.myState != ""
                && c3.myState != "")
            {
                winner = "tie";
                disableAllInput();
                GetComponent<Animator>().SetTrigger("tie");
            }

        }
        else
        {



            if(winner == "x")
            {
                disableAllInput();

                GetComponent<Animator>().SetTrigger("win_x");

            }
            else if(winner == "o")
            {
                disableAllInput();

                GetComponent<Animator>().SetTrigger("win_o");


            }


        }


    }

    void disableAllInput()
    {

        foreach (ATile tile in GetComponentsInChildren<ATile>())
        {

            tile.reset();
            tile.GetComponent<Button>().interactable = false;


        }



    }


    public void enableAllInput()
    {

        foreach(ATile tile in GetComponentsInChildren<ATile>())
        {
        
            tile.reset();
           tile.GetComponent<Button>().interactable = true;


        }



    }


    public bool checkWinCondition(ATile a, ATile b, ATile c)
    {

        Debug.Log(a.myState+", "+b.myState+", "+c.myState);

        if(a.myState != "" && b.myState != "" && c.myState != "" && a.myState == b.myState && b.myState == c.myState)
        {

            return true;



        }
        return false;


    }

   


}
