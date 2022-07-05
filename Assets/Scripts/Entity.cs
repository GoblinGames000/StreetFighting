using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using MoreMountains.NiceVibrations;
public class Entity : MonoBehaviour

{
   public List<Sprite> Players;
   private void OnEnable()
   {
      GetComponent<BoxCollider2D>().enabled = true;

      if (Random.Range(0, 11) > 7)
      {
         GetComponent<Image>().sprite = Players[1];
      }
      else
      {
         GetComponent<Image>().sprite = Players[0];
      }
      transform.DOScale(Vector3.one, 0.15f).SetEase(Ease.InOutSine);
      this.Invoke(() => { Kill(false); }, 2.5f);
   }

  public void Kill(bool hit)
   {
      
      if (hit&&GetComponent<Image>().sprite.name == "1")
      {
         MMVibrationManager.Haptic (HapticTypes.Success);

         ScoreManager.Instance.Score += 10;
      }
      if (hit&&GetComponent<Image>().sprite.name == "0")
      {
         MMVibrationManager.Haptic (HapticTypes.Failure);
Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.Lose);
         CanvasManager.Instance.GamaState = Sate.Lose;
      }
      GetComponent<BoxCollider2D>().enabled = false;
      transform.DOScale(Vector3.zero, 0.15f).SetEase(Ease.InOutSine).OnComplete(()=>gameObject.SetActive(false));
      
   }
}
