using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowNext : MonoBehaviour
{
    public GameObject Object1; //Motherboard
    public GameObject Object2; //PowerBoxes
    public GameObject Object3; //Cooler_Block
    public GameObject Object4; //CPU
    public GameObject Object5; //SSD
    public GameObject Object6; //RAM    
    public GameObject Object7; //GPU
    public GameObject Object8; //HDD
    public GameObject Object9; //PlastinCooler_plate
    public GameObject Object10; //Cooler_fan
    //public GameObject Object11;//chasis_lid

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(Next_Item);
    }


    // Update is called once per frame
    private void Next_Item()
    {
        if (Object1.activeInHierarchy == false)
        {
            Object1.SetActive(true);
            Object1.GetComponent<Animator>().Play("MotherBoard_Up_Down");
        }
        else if (Object2.activeInHierarchy == false)
        {
            Object2.SetActive(true);
            Object2.GetComponent<Animator>().Play("Power_Up_Down");
            Object1.GetComponent<Animator>().Play("Static");
        }
        else if (Object3.activeInHierarchy == false)
        {
            Object3.SetActive(true);
            Object3.GetComponent<Animator>().Play("CoolerBlock_Up_Down");
            Object2.GetComponent<Animator>().Play("Static");
        }
        else if (Object4.activeInHierarchy == false)
        {
            Object4.SetActive(true);
            Object4.GetComponent<Animator>().Play("CPU_Up_Down");
            Object3.GetComponent<Animator>().Play("Static");
        }        
        else if (Object5.activeInHierarchy == false)
        {
            Object5.SetActive(true);
            Object5.GetComponent<Animator>().Play("ssd_Up_Down");
            Object4.GetComponent<Animator>().Play("Static");
        }        
        else if (Object6.activeInHierarchy == false)
        {
            Object6.SetActive(true);
            Object6.GetComponent<Animator>().Play("RAM_Up_Down");
            Object5.GetComponent<Animator>().Play("Static");
        }        
        else if (Object7.activeInHierarchy == false)
        {
            Object7.SetActive(true);
            Object7.GetComponent<Animator>().Play("GPU_Up_Down");
            Object6.GetComponent<Animator>().Play("Static");
        }        
        else if (Object8.activeInHierarchy == false)
        {
            Object8.SetActive(true);
            Object8.GetComponent<Animator>().Play("hdd_baked_Up_Down");
            Object7.GetComponent<Animator>().Play("Static");
        }        
        else if (Object9.activeInHierarchy == false)
        {
            Object9.SetActive(true);
            Object9.GetComponent<Animator>().Play("Cooler_plate_Up_Down");
            Object8.GetComponent<Animator>().Play("Static");
        }        
        else if (Object10.activeInHierarchy == false)
        {
            Object10.SetActive(true);
            Object10.GetComponent<Animator>().Play("Cooler_Fan_Up_Down");
            Object9.GetComponent<Animator>().Play("Static");
        }        
        else //if (Object11.activeInHierarchy == false)
        {
            // Object11.SetActive(true);
            // Object11.GetComponent<Animator>().Play("Chasis_lid_Up_Down");
            Object10.GetComponent<Animator>().Play("Static");
        }
        // else
        // {
        //     Object11.GetComponent<Animator>().Play("Static");
        // }
    }
}
