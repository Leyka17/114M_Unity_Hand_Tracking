using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPrev : MonoBehaviour
{
    public GameObject Object1; //Motherboard
    public GameObject Object2; //PowerBoxes
    public GameObject Object3; //Cooler_Block

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(Prev_Item);
    }


    // Update is called once per frame
    private void Prev_Item()
    {
        if (Object3.activeInHierarchy == true)
        {
            Object2.GetComponent<Animator>().Play("Power_Up_Down");
            Object3.SetActive(false);
        }
        else if (Object2.activeInHierarchy == true)
        {
            Object1.GetComponent<Animator>().Play("MotherBoard_Up_Down");
            Object2.SetActive(false);
        }
    }
}
