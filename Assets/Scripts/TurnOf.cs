using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnOf : MonoBehaviour
{
    public Sprite Open;
    public Sprite Close;
    public Image top;
    
    private void OnEnable()
    {
        top.sprite = Open;
        top.SetNativeSize();
        top.rectTransform.pivot= new Vector2(0.558f,1);

        this.Invoke(() =>
        {

            if (gameObject.activeSelf)
            {
                gameObject.SetActive(false);
            }
        }, 0.2f);
    }

    private void OnDisable()

    {

        top.sprite = Close;
        top.SetNativeSize();
        top.rectTransform.pivot= new Vector2(0.5f,1);


    }
}
