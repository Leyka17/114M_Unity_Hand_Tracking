using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowNext : MonoBehaviour
{
    public GameObject Object1; //Motherboard
    public GameObject Object2; //PowerBoxes
    public GameObject Object3; //Cooler_Block

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(Next_Item);
    }


    // Update is called once per frame
    private void Next_Item()
    {
        if (Object2.activeInHierarchy == false)
        {
            Object2.SetActive(true);
            Object2.GetComponent<Animator>().Play("Power_Up_Down");
            Object1.GetComponent<Animator>().Play("MotherBoard_Static");
        }
        else if (Object3.activeInHierarchy == false)
        {
            Object3.SetActive(true);
            Object3.GetComponent<Animator>().Play("CoolerBlock_Up_Down");
            Object2.GetComponent<Animator>().Play("Power_Static");
        }
    }
}
