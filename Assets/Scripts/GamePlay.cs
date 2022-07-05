using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GamePlay : MonoBehaviour
{
   public static GamePlay Instance;

   private void Awake()
   {
      Instance = this;
   }
}
