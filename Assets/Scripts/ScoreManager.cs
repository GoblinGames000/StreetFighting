using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
   public static ScoreManager Instance;
   public List<TextMeshProUGUI> ScoreText;
   public List<TextMeshProUGUI> HighScoreText;

   private void Awake()
   {
      Instance = this;
   }
   

   public int _Score;
   public int Score
   {
      get
      {
         return _Score;
      }
      set
      {
         _Score = value;
         ScoreText.ForEach(x=>x.
            DOTextFloat(int.Parse(x.text),_Score,0.25f));
         if (_Score > _HighScore)
         {
            HighScore = _Score;
         }
         
      }
      
   }
   public int _HighScore;
   public int HighScore
   {
      get
      {
         return _HighScore;
      }
      set
      {
         _HighScore = value;
         HighScoreText.ForEach(x=>x.DOTextFloat(int.Parse(x.text),_HighScore,0.25f));

         PlayerPrefs.SetInt("HS",_HighScore);

      }
      
   }

   private void OnEnable()
   {
     HighScore=  PlayerPrefs.GetInt("HS",00);
   }
}
