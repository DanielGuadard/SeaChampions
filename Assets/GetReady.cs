using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetReady : MonoBehaviour
{
    [SerializeField]
    private float Timer;
    private GameObject TimerTxt;
    // Start is called before the first frame update
    void Start()
    {
        Timer = 3.5f;
        TimerTxt = GameObject.Find("TimeForBattle");
    }

    // Update is called once per frame
    void Update()
    {
        UpdateDisplay(TimerTxt);
        Timer -= Time.deltaTime;
        if (Timer <= 0) { this.gameObject.SetActive(false);GameObject.Find("ScriptHolder").GetComponent<TrainingMode>().Started = true; }
    }
    private void UpdateDisplay(GameObject Display)
    {
        float seconds = Mathf.FloorToInt(Timer % 60);

        string secondsText = seconds.ToString();
        if (seconds < 0) secondsText = ("0");
        Display.GetComponent<Text>().text = secondsText;
        if (seconds >= 3) { Display.GetComponent<Text>().color = Color.green; }
        if (seconds > 2 & seconds < 30) { Display.GetComponent<Text>().color = Color.yellow; }
        if (seconds <= 1) { Display.GetComponent<Text>().color = Color.red; }

    }

}
