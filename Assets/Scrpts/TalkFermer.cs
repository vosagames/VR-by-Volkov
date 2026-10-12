using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class TalkFermer : MonoBehaviour
{
    [SerializeField] private FermerTrigger fermerTrigger;
    [SerializeField] private List <string> fermerMessage = new List<string>();
    [SerializeField] private TMP_Text messageText;
    [SerializeField] private TextView messagePanel;

    private int numPage = 0;

    private void OnEnable()
    {
        fermerTrigger.isTalk += ShowMessage;
        fermerTrigger.isExit += HideMessage;
    }
   private void ShowMessage()
   {
        messagePanel.gameObject.SetActive(true);
        messagePanel.OnShow();
        switch (numPage)
        {
            case 0:
            {
                    messageText.text = fermerMessage[numPage];
                    numPage++;
            }
                break;
            case 1:
            {
                    messageText.text = fermerMessage[numPage];
                    numPage++;
                }
                break;
            case 2:
            {
                    messageText.text = fermerMessage[numPage];
                    numPage = 0;
                }
                break;
        }
   }
   private void HideMessage()
   {
        messagePanel.OnHide();
        numPage = 0;
    }
}
