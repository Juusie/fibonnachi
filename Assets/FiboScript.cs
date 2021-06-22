using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FiboScript : MonoBehaviour
{
    public Text numberText; //sets text to edit

    private int counter = 0; //counter to keep the button state
    private long num1 = 0; //tracks the first number in the sequence
    private long num2 = 1; //tracks the second number in the sequence

    private long nextNum = 0; //tracks the newly generated number

    public void MakeFibo() //generates the fibonacci sequence
    {
        if (counter == 0)
        {

            numberText.text = num1.ToString();
            counter++;
        }
        else if (counter == 1)
        {
            numberText.text = num2.ToString();
            counter++;
        }
        else
        {
            //the next number in the sequence is the previous two combined
            //when the next number is generated num1 becomes previous num2 and num2 becomes previous nextNum
            nextNum = num1 + num2;
            num1 = num2;
            num2 = nextNum;
            numberText.text = nextNum.ToString();
        }

    }
}