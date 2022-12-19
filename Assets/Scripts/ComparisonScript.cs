using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComparisonScript : MonoBehaviour
{
    public Text Answer;
    public InputField Afield;
    public InputField Bfield;
    void Start()
    {
        Answer.text = "Answer...";
    }

    public void Comparison()
    {
        int a = int.Parse(Afield.text);
        int b = int.Parse(Bfield.text);
        if (a == b)
            {
                Answer.text = Convert.ToString("Числа Равны!");
            }
        else
        {
            if (b > a)
            {
                Answer.text = Convert.ToString(b + " Больше!");
            }
            else
            {
                Answer.text = Convert.ToString(a + " Больше!");
            }

        }
    }
}
