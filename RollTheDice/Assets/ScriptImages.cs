using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptImages : MonoBehaviour
{

    [SerializeField] Image img;
    [SerializeField] Sprite[] sprites;
    [SerializeField] Button[] btn;
   



    void Start()
    {

        btn[0].onClick.AddListener(K4_Click);
        btn[1].onClick.AddListener(K6_Click);
        btn[2].onClick.AddListener(K8_Click);
        btn[3].onClick.AddListener(K10_Click);
        btn[4].onClick.AddListener(K12_Click);
        btn[5].onClick.AddListener(K20_Click);
        btn[6].onClick.AddListener(K100_Click);
       

       
    }

    public void K4_Click()
    {
     img.sprite = sprites[1];

    }

    public void K6_Click()
    {
        img.sprite = sprites[2];

    }
    public void K8_Click()
    {
        img.sprite = sprites[3];

    }
    public void K10_Click()
    {
        img.sprite = sprites[4];

    }
    public void K12_Click()
    {
        img.sprite = sprites[5];

    }
    public void K20_Click()
    {
        img.sprite = sprites[6];

    }
    public void K100_Click()
    {
        img.sprite = sprites[7];

    }




}
