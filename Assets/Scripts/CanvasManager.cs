using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public enum Sate
{
    Main,Info,Lose,Setting,Feedback,Win,Choose,GamePlay
}

public class CanvasManager : MonoBehaviour
{
    public static CanvasManager Instance;
    public List<GameObject> All;
    public GameObject Main;
    public GameObject Info;
    public GameObject Lose;
    public GameObject Win;
    public GameObject Setting;
    public GameObject Feedback;
    public GameObject Choose;
    public GameObject GamePlay;
    public Sate _GamaState;
    private void Awake()
    {
        Instance = this;
    }

    public Sate GamaState
    {
        get { return _GamaState; }
        set
        {
            _GamaState = value;
            switch (value)
            {
                case Sate.Main:
                    TurnOfAll();
                    Main.Show();
                    break;
                case Sate.Info:
                    TurnOfAll();
                    Info.Show();
                    break;
                case Sate.Feedback:
                    TurnOfAll();
                    Feedback.Show();
                    break;
                case Sate.GamePlay:
                    TurnOfAll();
                    GamePlay.Show();

                    break;
             
                case Sate.Choose:
                    TurnOfAll();
                    Choose.Show();
                    break;
                case Sate.Lose:
                    Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.Lose);
                    TurnOfAll();
                    Lose.Show();
                    break;
                case Sate.Setting:
                    TurnOfAll();
                    Setting.Show();
                    break; 
                    case Sate.Win:
                        Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.Win);

                    this.Invoke(() =>
                    {
                        TurnOfAll();

                        Win.Show();

                    }, 1f);
                    break;
              
                default:
                    throw new ArgumentOutOfRangeException(nameof(value), value, null);
            }
        }

    }

  
    void TurnOfAll()
    {
        All.ForEach(x => x.Hide());
    }

    private void Start()
    {
        
        if (Session.Instance.Replay)
        {
            Session.Instance.Replay = false;
            GamaState = Sate.Choose;
            return;

        }
            GamaState = Sate.Main;
       
    }

    public void OnClickStart()
    {
        Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.buttonClick);
        GamaState = Sate.GamePlay;

    } 
    
    public void OnClickchoose()
    {
        Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.buttonClick);
        GamaState = Sate.GamePlay;


    }
    public void OnClickToMain()
    {
        Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.buttonClick);
        GamaState = Sate.Main;

    }public void OnClickReload()
    {
        Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.buttonClick);
      Fade.Instance.LoadScene("Game");

    }
   
    public void OnClickSetting()
    {
        Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.buttonClick);
        GamaState = Sate.Setting;

    } 
    public void OnClickInfo()
    {
        Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.buttonClick);
        GamaState = Sate.Info;

    } 
    public void OnClickFeedback()
    {
        Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.buttonClick);
        GamaState = Sate.Feedback;

    }
   
    
}
