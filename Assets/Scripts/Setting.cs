using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
   public List<Sprite> SoundBtn;
   public List<Sprite> Musictn;
   public List<Sprite> VibBtn;
   public Image Sound;
   public Image Music;
   public Image Vib;

   private void OnEnable()
   {
      Sound.sprite = SoundBtn[PlayerPrefs.GetInt("Sound",1)];
      Vib.sprite = VibBtn[PlayerPrefs.GetInt("Vib",1)];


   }

   public void ToggleSound()
   {
      Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.buttonClick);
      int status = PlayerPrefs.GetInt("Sound", 1);
      status = Convert.ToInt16(!Convert.ToBoolean(status));
      PlayerPrefs.SetInt("Sound",status);
      PlayerPrefs.SetInt("Music",status);

      if (PlayerPrefs.GetInt("Lang", 0) == 1)
      {
         Sound.sprite = SoundBtn[status+2];

      }
      else
      {
         Sound.sprite = SoundBtn[status];

      }
      Sound_Manager.instance.ToggleMusic();

      Sound_Manager.instance.ToggleSound();

   } public void ToggleMusic()
   {
      Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.buttonClick);
      int status = PlayerPrefs.GetInt("Music", 1);
      status = Convert.ToInt16(!Convert.ToBoolean(status));
      PlayerPrefs.SetInt("Music",status);
      Music.sprite = Musictn[status];
      Sound_Manager.instance.ToggleMusic();


   } public void Vibration()
   {
      Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.buttonClick);
      int status = PlayerPrefs.GetInt("Vib", 1);
      status = Convert.ToInt16(!Convert.ToBoolean(status));
      PlayerPrefs.SetInt("Vib",status);
      Vib.sprite = VibBtn[status];

   }

   public List<Image> Flags;
   public void English()
   {
      Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.buttonClick);
      Flags.ForEach(x=>x.color=Color.gray);
      Flags[0].color = Color.white;
      PlayerPrefs.SetInt("Lang",0);
      Translation.Instance.CheckLang();

   }
   public void Russian()
   {
      Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.buttonClick);
      Flags.ForEach(x=>x.color=Color.gray);
      Flags[1].color = Color.white;

      PlayerPrefs.SetInt("Lang",1);
      Translation.Instance.CheckLang();


   }

   public void ChangeBrightness(Slider s)
   {
      Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.buttonClick);

      Screen.brightness = s.value;
   }
}
