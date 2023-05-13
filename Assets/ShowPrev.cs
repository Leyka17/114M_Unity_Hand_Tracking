using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPrev : MonoBehaviour
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
        this.GetComponent<Button>().onClick.AddListener(Prev_Item);
    }


    // Update is called once per frame
    private void Prev_Item()
    {        
        // if (Object11.activeInHierarchy == true)
        // {
        //     Object10.GetComponent<Animator>().Play("Chasis_lid_Up_Down");
        //     Object11.SetActive(false);        
        // } 
        // else if (Object9.activeInHierarchy == true)
        if (Object10.activeInHierarchy == true)
        {
            Object9.GetComponent<Animator>().Play("Cooler_plate_Up_Down");
            Object10.SetActive(false);        
        } 
        else if (Object9.activeInHierarchy == true)
        {
            
            Object8.GetComponent<Animator>().Play("hdd_Up_Down");
            Object9.SetActive(false);
        }   
        else if (Object8.activeInHierarchy == true)
        {

            Object7.GetComponent<Animator>().Play("GPU_Up_Down");
            Object8.SetActive(false);
        }    
        else if (Object7.activeInHierarchy == true)
        {
            Object6.GetComponent<Animator>().Play("RAM_Up_Down");
            Object7.SetActive(false);
        }          
        else if (Object6.activeInHierarchy == true)
        {
            Object5.GetComponent<Animator>().Play("ssd_Up_Down");
            Object6.SetActive(false);
        }        
        else if (Object5.activeInHierarchy == true)
        {
            Object4.GetComponent<Animator>().Play("CPU_Up_Down");
            Object5.SetActive(false);
        }   
        else if (Object4.activeInHierarchy == true)        
        {
            Object3.GetComponent<Animator>().Play("CoolerBlock_Up_Down");
            Object4.SetActive(false);
        }           
        else if (Object3.activeInHierarchy == true)     
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
