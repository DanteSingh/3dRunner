using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public TMP_Text Score; 
    void Start()
    {
        
    }

    void Update()
    {
        Score.SetText(player.position.z.ToString("0"));
    }
}
