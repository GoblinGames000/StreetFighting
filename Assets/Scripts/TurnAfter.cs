using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnAfter : MonoBehaviour
{
    private void OnEnable()
    {
        this.Invoke(() =>
        {
            gameObject.SetActive(false);

        }, 3f);
    }
}
