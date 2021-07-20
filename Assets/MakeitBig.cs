using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class MakeitBig : MonoBehaviour
{
    public RectTransform ImageLarge;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 SiD = ImageLarge.sizeDelta;
        ImageLarge.DOSizeDelta(new Vector2(SiD.x*5,SiD.y*5),1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
