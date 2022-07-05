using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TranslateText : MonoBehaviour
{
    public string English;
    public string Russian;
    public string Port;
    private void OnEnable()
    {
        if (Application.systemLanguage == SystemLanguage.Russian)
        {
      
           
                GetComponent<TextMeshProUGUI>().text = Russian;
           
        }
        else  if (Application.systemLanguage == SystemLanguage.Portuguese)
        {
      
           
            GetComponent<TextMeshProUGUI>().text = Port;
           
        }
        else
        {
            GetComponent<TextMeshProUGUI>().text = English
                ;

        }
    }
}
