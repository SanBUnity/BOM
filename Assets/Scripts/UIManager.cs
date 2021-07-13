using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class UISCreen
{
    public string Name;
    public int ID;
    public GameObject UiPanel;
    public List<UIscreenCont> objectInScene;
}

[System.Serializable]
public class UIscreenCont
{
    public string id;
    public GameObject UiObj;
}
public class UIManager : MonoBehaviour
{
    public List<UISCreen> Screens;
    public GameObject MenuBar;

    // Start is called before the first frame update
    public void StartScreenscroll()
    {
        Debug.Log("Call it"+ Screens[0].objectInScene[3].UiObj.GetComponent<RectTransform>().anchoredPosition);
    }
    public void SplashtoLogin()
    {
        clearScree();
        ScreenTrans(0,1,false);
    }
    public void Logintosignup(bool swap)
    {
        ScreenTrans(1, 2, swap);
    }

    public void signuptoVerifyEmail(bool swap)
    {
        ScreenTrans(2, 3, swap);
    }
    public void forgotPassword(bool swap)
    {
        ScreenTrans(1, 4, swap);
    }
    public void VerForgotOTP(bool swap)
    {
        ScreenTrans(4, 5, swap);
    }
    public void ResetPass(bool swap)
    {
        ScreenTrans(5, 6, swap);
    }
    public void avatarSelection()
    {
        if (Screens[2].objectInScene[0].UiObj.activeInHierarchy)
        {
            Screens[2].objectInScene[0].UiObj.SetActive(false);
        }
        else
        {
            Screens[2].objectInScene[0].UiObj.SetActive(true);
        }
    }
    public void PrivateRegister()
    {
        if (Screens[8].objectInScene[0].UiObj.activeInHierarchy)
        {
            Screens[8].objectInScene[0].UiObj.SetActive(false);
        }
        else
        {
            Screens[8].objectInScene[0].UiObj.SetActive(true);
        }
    }
    public void DashBoard()
    {
        if (!Screens[7].UiPanel.activeInHierarchy)
        {
            clearScree();
            Screens[7].UiPanel.SetActive(true);
            MenuBar.SetActive(true);
        }
    }
    public void DashBoardtoTour()
    {
        if (!Screens[8].UiPanel.activeInHierarchy)
        {
            clearScree();
            Screens[8].UiPanel.SetActive(true);
            MenuBar.SetActive(true);
        }
    }
    public void rewardsScreen()
    {
        if (!Screens[9].UiPanel.activeInHierarchy)
        {
            clearScree();
            Screens[9].UiPanel.SetActive(true);
            MenuBar.SetActive(true);
        }
    }
    public void AddCoin()
    {
        if (!Screens[14].UiPanel.activeInHierarchy)
        {
            clearScree();

            Screens[14].UiPanel.SetActive(true);
            MenuBar.SetActive(false);
        }
    }
    public void LeaderScore()
    {
        if (!Screens[11].UiPanel.activeInHierarchy)
        {
            clearScree();
            
            Screens[11].UiPanel.SetActive(true);
            MenuBar.SetActive(false);
        }
        Screens[11].objectInScene[0].UiObj.SetActive(true);
        Screens[11].objectInScene[1].UiObj.SetActive(false);
    }
    public void FriendScreen()
    {
        if (!Screens[10].UiPanel.activeInHierarchy)
        {
            clearScree();
            Screens[10].UiPanel.SetActive(true);
            MenuBar.SetActive(true);
        }
    }
    public void LeaderBoard()
    {
        if (!Screens[11].objectInScene[1].UiObj.activeInHierarchy)
        {
            //clearScree();
            Screens[11].objectInScene[1].UiObj.SetActive(true);
            Screens[11].objectInScene[0].UiObj.SetActive(false);
            //MenuBar.SetActive(true);
        }
    }
    void ScreenTrans(int from, int to, bool swap)
    {
        if (!swap)
        {
            Screens[from].UiPanel.SetActive(false);
            Screens[to].UiPanel.SetActive(true);
        }
        else
        {
            Screens[to].UiPanel.SetActive(false);
            Screens[from].UiPanel.SetActive(true);
        }
    }
    void clearScree()
    {
        foreach (UISCreen n in Screens)
        {
            if (n.UiPanel.activeInHierarchy)
            {
                n.UiPanel.SetActive(false);
            }
        }
    }
}
