using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//ステージのUI(ステージ数、next、back）

public class StageUIManager : MonoBehaviour
{
    public Text stageText;

    public void UpdateUI(int currentStage)
    {
        stageText.text = string.Format("Stage: {0}", currentStage+1);


    }
    
   
}
