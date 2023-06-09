using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMusic : MonoBehaviour
{
    private static bool musicExists = false; // Houdt bij of er al een muziekobject bestaat

    void Awake()
    {
        if (!musicExists)
        {
            DontDestroyOnLoad(transform.gameObject);
            musicExists = true;
        }
        else
        {
            Destroy(gameObject); // Vernietig het duplicaatmuziekobject
        }
    }
}
