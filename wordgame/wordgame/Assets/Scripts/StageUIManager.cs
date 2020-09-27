using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//ステージのUI(ステージ数、next、back）

public class StageUIManager : MonoBehaviour
{
    public Text stageText;
    public GameObject nextButton;
    public GameObject toTownButton;

    public void UpdateUI(int currentStage)
    {
        stageText.text = string.Format("Stage: {0}", currentStage+1);

    }

    public void HideButtons()
    {
        nextButton.SetActive(false);
        toTownButton.SetActive(false);

    }

    public void ShowButtons()
    {
        nextButton.SetActive(true);
        toTownButton.SetActive(true);

    }

}
