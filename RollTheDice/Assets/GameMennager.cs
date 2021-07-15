using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMennager : MonoBehaviour 
{
    [SerializeField] Button[] btn;
    [SerializeField] Button roll;
    [SerializeField] Text lblShowResult;

    private int theResult;
    private int theChoosenDice;
    private bool isDiceChoosen = false;
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
    private void Update()
    {
        if(isDiceChoosen) roll.onClick.AddListener(Roll);
    }

    void Roll()
    {
        TheLogicBehindTheRoll(theChoosenDice, isDiceChoosen);
    }
    public void TheLogicBehindTheRoll(int theChoosenDice, bool isDiceChoosen)
    {
        if (isDiceChoosen)
        {
            switch (theChoosenDice)
            {

                case 0:
                    theResult = Random.Range(1, 4);
                    ShowTheResult();
                    break;
                case 1:
                    theResult = Random.Range(1, 6);
                    ShowTheResult();
                    break;
                case 2:
                    theResult = Random.Range(1, 8);
                    ShowTheResult();
                    break;
                case 3:
                    theResult = Random.Range(1, 10);
                    ShowTheResult();
                    break;
                case 4:
                    theResult = Random.Range(1, 12);
                    ShowTheResult();
                    break;
                case 5:
                    theResult = Random.Range(1, 20);
                    ShowTheResult();
                    break;
                case 6:
                    theResult = Random.Range(1, 100);
                    ShowTheResult();
                    break;
              

                  


            }
        }

    }


    //Those two functions allow user to know which dice he has choosen (feedback)
    void MakeButtonBold(int whichButton)
    {
        MakeAllButtonsNormal();
        btn[whichButton].GetComponentInChildren<Text>().fontStyle = FontStyle.Bold;

    }
    void MakeAllButtonsNormal()
    {
        for (int i = 0; i < btn.Length; i++)
        {
            btn[i].GetComponentInChildren<Text>().fontStyle = FontStyle.Normal;
        }
    }



    void ShowTheResult()
    {
        lblShowResult.text = "Twój wynik to: " + theResult;
    }

    public void K4_Click()
    {
        MakeButtonBold(0);
        theChoosenDice = 0;
        isDiceChoosen = true;
       // TheLogicBehindTheRoll(0, true);

    }

    public void K6_Click()
    {    
        MakeButtonBold(1);
        theChoosenDice = 1;
        isDiceChoosen = true;
        //TheLogicBehindTheRoll(1, true);
    }
    public void K8_Click()
    {       
        MakeButtonBold(2);
        theChoosenDice = 2;
        isDiceChoosen = true;
      //  TheLogicBehindTheRoll(2, true);
    }
    public void K10_Click()
    {
        MakeButtonBold(3);
        theChoosenDice = 3;
        isDiceChoosen = true;
       // TheLogicBehindTheRoll(3, true);
    }
    public void K12_Click()
    {
        MakeButtonBold(4);
        theChoosenDice = 4;
        isDiceChoosen = true;
       // TheLogicBehindTheRoll(4, true);
    }
    public void K20_Click()
    {
        MakeButtonBold(5);
        theChoosenDice = 5;
        isDiceChoosen = true;
      //  TheLogicBehindTheRoll(5, true);
    }
    public void K100_Click()
    {
        MakeButtonBold(6);
        theChoosenDice = 6;
        isDiceChoosen = true;
       // TheLogicBehindTheRoll(6, true);
     
    }
}
