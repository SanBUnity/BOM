using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;
using UnityEngine.UI;

public class NavigationBar : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject groundedGreen;
    public GameObject MaskLine;
    public GameObject Rounded;

    public GameObject[] naviBut;
    GameObject Gu;
    void Start()
    {
        Gu = naviBut[0]; 
    }

    public void OnNaviClick()
    {
        Gu.SetActive(true);
        Gu = EventSystem.current.currentSelectedGameObject;
        Rounded.transform.GetChild(0).transform.GetChild(0).GetComponent<Image>().sprite =
        Gu.transform.GetChild(0).GetComponent<Image>().sprite;
        Gu.SetActive(false);

        //Debug.Log(Gu.name+""+Gu.GetComponent<RectTransform>().anchoredPosition);
        //groundedGreen.GetComponent<RectTransform>().anchoredPosition = 
        //    new Vector2(
        //    Gu.GetComponent<RectTransform>().anchoredPosition.x,
        //    groundedGreen.GetComponent<RectTransform>().anchoredPosition.y);

        groundedGreen.GetComponent<RectTransform>().DOAnchorPosX(
            Gu.GetComponent<RectTransform>().anchoredPosition.x, 0.25f, true);
        MaskLine.GetComponent<RectTransform>().DOAnchorPosX(
            Gu.GetComponent<RectTransform>().anchoredPosition.x - 160, 0.25f, true);
        Rounded.transform.GetChild(0).transform.localScale = Vector3.zero;
        Rounded.GetComponent<RectTransform>().DOAnchorPosX(
            Gu.GetComponent<RectTransform>().anchoredPosition.x - 160, 0.25f, true).
            OnComplete(() => { OnenEnd();});
    }

    void OnenEnd()
    {
        //Rounded.transform.GetChild(0).GetComponent<RectTransform>().anchoredPosition = new Vector2(0,21);
        //Rounded.transform.GetChild(0).GetComponent<RectTransform>().DOAnchorPosY(85,0.15f);
        Rounded.transform.GetChild(0).transform.DOScale(Vector3.one,0.25f);
    }

    void sendDow(GameObject doe)
    {
        
    }
}
