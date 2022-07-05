using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class Box : MonoBehaviour
{
   private void OnEnable()
   {
      GetComponent<Button>()
         .onClick.RemoveAllListeners();
      
      GetComponent<Button>()
         .onClick.AddListener(OnBoxClick);

      
   }

   public bool Moving;
   public void OnBoxClick()
   {
      Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.Stone);
      //if(Moving) return;
    //  transform.DOLocalRotate(new Vector3(0, 0, (transform.rotation.eulerAngles.z + 90)), 0.01f).OnStart(()=>Moving=true).OnComplete(()=>Moving=false);
     transform.localRotation=Quaternion.Euler(0,0,(transform.rotation.eulerAngles.z+90));
   }
}
