using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class CalcScript : MonoBehaviour
{
    public Text Answer;
    public InputField Afield;
    public InputField Bfield;
    double c = 0;
    int summ = 0;
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
    public void Zadanie1()
    {
        int a = Convert.ToInt32(Afield.text);
        int b = Convert.ToInt32(Bfield.text);
        for (int x = a; x <= b; x++)
        {
            if ((x % 2) == 0)
            {
                summ += x; 
            }
        }
        Answer.text = Convert.ToString(summ);
    }
    public void Zadanie2()
    {
        int[] array = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
        foreach (int x in array)
        {
            if (x % 2 == 0)
            {
                summ += x;
            }
        }
        Answer.text = Convert.ToString(summ);
    }
    public void Zadanie3()
    {
        int[] arr = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        int[] arr2 = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        int arrnumber = 34;
        int arrnumber2 = 55;
        int index1 = FindIndex(arr, arrnumber);
        int index2 = FindIndex(arr2, arrnumber2);
        Answer.text = Convert.ToString(index1);
    }
    public void Zadanie4()
    {
        int[] array = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
        var a = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            a[i] = Convert.ToInt32(array[i]);
        }
        Answer.text = Convert.ToString(("”пор€доченный массив:", string.Join(", ", SelectionSort(a))));
    }
    public static int FindIndex(int[] array, int number)
    {
        for (int i = 0; i < array.Length; i++)
            if (array[i] == number)
                return i;
        return -1;
    }
    static int IndexOfMin(int[] array, int n)
    {
        int result = n;
        for (var i = n; i < array.Length; ++i)
        {
            if (array[i] < array[result])
            {
                result = i;
            }
        }
        return result;
    }
    static void Swap(ref int x, ref int y)
    {
        var t = x;
        x = y;
        y = t;
    }
    static int[] SelectionSort(int[] array, int currentIndex = 0)
    {
        if (currentIndex == array.Length)
            return array;
        var index = IndexOfMin(array, currentIndex);
        if (index != currentIndex)
        {
            Swap(ref array[index], ref array[currentIndex]);
        }
        return SelectionSort(array, currentIndex + 1);
    }
}
