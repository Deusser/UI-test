using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class CalcScript : MonoBehaviour
{
    public Text Answer;
    public InputField Afield;
    public InputField Bfield;
    double c = 0;

    void Start()
    {
        Answer.text = "Answer...";
    }
    public void Plus()
    {
        double a = Convert.ToDouble(Afield.text.Replace(".", ","));
        double b = Convert.ToDouble(Bfield.text.Replace(".", ","));
        c = a + b;
        Answer.text = Convert.ToString(c); 
    }
    public void Minus()
    {
        double a = Convert.ToDouble(Afield.text.Replace(".", ","));
        double b = Convert.ToDouble(Bfield.text.Replace(".", ","));
        c = a - b;
        Answer.text = Convert.ToString(c);
    }
    public void Multi()
    {
        double a = Convert.ToDouble(Afield.text.Replace(".", ","));
        double b = Convert.ToDouble(Bfield.text.Replace(".", ","));
        c = a * b;
        Answer.text = Convert.ToString(c);
    }
    public void Divi()
    {
        double a = Convert.ToDouble(Afield.text.Replace(".", ","));
        double b = Convert.ToDouble(Bfield.text.Replace(".", ","));

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
