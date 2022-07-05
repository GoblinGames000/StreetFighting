using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session : Singletion<Session>
{
   public bool Replay;
   public int  SelectedCharacter;
   public int  SelectedOpponent;
   public int  _SelectedScene;

   public int SelectedScene
   {
      get
      {
         return _SelectedScene;
         
      }
      set
      {
         _SelectedScene = value;
         
      }
   }
  
  
 
}
