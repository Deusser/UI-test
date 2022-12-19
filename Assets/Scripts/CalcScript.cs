using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalcScript : MonoBehaviour
{
    public Text Answer;
    public InputField Afield;
    public InputField Bfield;
    int c = 0;

    void Start()
    {
        Answer.text = "Answer...";
    }
    public void Plus()
    {
        int a = int.Parse(Afield.text);
        int b = int.Parse(Bfield.text);
        c = a + b;
        Answer.text = Convert.ToString(c); 
    }
    public void Minus()
    {
        int a = int.Parse(Afield.text);
        int b = int.Parse(Bfield.text);
        c = a - b;
        Answer.text = Convert.ToString(c);
    }
    public void Multi()
    {
        int a = int.Parse(Afield.text);
        int b = int.Parse(Bfield.text);
        c = a * b;
        Answer.text = Convert.ToString(c);
    }
    public void Divi()
    {
        int a = int.Parse(Afield.text);
        int b = int.Parse(Bfield.text);

        if (b == 0)
        {
            Answer.text = "Divided by Zero!";
        }
        else
        {
            c = a / b;
            Answer.text = Convert.ToString(c);
        }
    }
}
