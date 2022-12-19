using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statemachine : MonoBehaviour
{
    [SerializeField] private GameObject Mainscreen;
    [SerializeField] private GameObject Cybermantscreen;
    [SerializeField] private GameObject Calcscreen;
    private GameObject Currentscreen;
    void Start()
    {
        Mainscreen.SetActive(true);
        Currentscreen = Mainscreen;

    }

    public void ChangeGame(GameObject state)
    {
        if (Currentscreen != null)
        {
            Currentscreen.SetActive(false);
            state.SetActive(true);
            Currentscreen = state;
        }

    }


}
