using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;


public class GameMAnager : MonoBehaviour
{
    public static GameMAnager Instance;
    private void Awake()
    {
        Instance = this;
    }

  
}
