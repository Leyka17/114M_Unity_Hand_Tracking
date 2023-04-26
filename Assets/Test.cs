using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Test : MonoBehaviour
{
    public TMP_Text text;
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(Check);
    }

    private void Check()
    {
        text.text = GameResources.GetOk() ? "Всё отлично!" : "Обнаружены ошибки!";
        text.color = GameResources.GetOk() ? new Color(0,1,0) : new Color(1,0,0);
    }
}
