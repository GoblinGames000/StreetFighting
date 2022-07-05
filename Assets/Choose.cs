using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Choose : MonoBehaviour
{
   public List<string> Names;
   public List<Sprite> Avatars;
   public List<TextMeshProUGUI> NameText;
   public List<Image> AvatarField;


   public void ChangeName(bool Left)
   {
      Image img = AvatarField[1];
      TextMeshProUGUI Field = NameText[1];
      if (Left)
      {
         Field = NameText[0];
         img = AvatarField[0];
      }

      int index = Names.IndexOf(Field.text);
      if (index == (Names.Count - 1))
      {
         index = 0;
      }
      else
      {
         index++;
      }

      Field.text = Names[index];
      img.sprite = Avatars[index];
      if (Left)
      {
         Session.Instance.SelectedCharacter = index;
      }
      else
      {
         Session.Instance.SelectedOpponent = index;
         
      }
   }

}
