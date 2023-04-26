using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRSocketInteractorWithStatCheck : XRSocketInteractor
{
    private string linkId;
    public bool isEntered = false;
    private XRBaseInteractable interactable;
    void Start()
    {
        linkId = this.GetComponent<Stats>().linkId;
        this.selectEntered.AddListener(Entered);
        this.selectExited.AddListener(Exited);
    }


    public override bool CanSelect(IXRSelectInteractable interactable)
    {
        return base.CanSelect(interactable) && !isEntered;
        //return base.CanSelect(interactable) && MatchLinkId(interactable) && !isEntered;
    }

    public override bool CanHover(IXRHoverInteractable interactable)
    {
        
        return base.CanHover(interactable) && !isEntered;
    }

    private bool MatchLinkId(IXRSelectInteractable interactable)
    {
        return interactable.transform.GetComponent<Stats>().linkId == linkId;
    }
    public void Entered(SelectEnterEventArgs arg0)
    {
        isEntered = true;
        interactable = (XRBaseInteractable)arg0.interactableObject;
        GameResources.SetOk(MatchLinkId(interactable));
    }

    public void Exited(SelectExitEventArgs arg0)
    {
        isEntered = false;
    }

}
