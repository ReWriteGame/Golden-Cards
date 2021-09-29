using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisualTimer : MonoBehaviour
{
    [SerializeField] private Text text; 
    [SerializeField] private Timer timer; 

    public void updateScore()
    {
    text.text = timer.currentTime + "";  

    }
}
