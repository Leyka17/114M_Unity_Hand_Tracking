using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class XRPokeFinisher : MonoBehaviour
{
    public Transform visualTarget;
    public Vector3 localAxis;

    private Vector3 initialLocalPos;
    private Vector3 finishLocalPos;
    private XRBaseInteractable interactable;
    private bool isFollowing = false;
    private XRSocketInteractorWithStatCheck Socket;
    private bool isEntered;
    // Start is called before the first frame update
    void Start()
    {
        Socket = transform.parent.GetComponent<XRSocketInteractorWithStatCheck>();

        initialLocalPos = visualTarget.localPosition;
        finishLocalPos = initialLocalPos - new Vector3(0,0.05f,0);
        interactable = GetComponent<XRBaseInteractable>();
        interactable.hoverEntered.AddListener(Follow);
        //interactable.selectExited.AddListener(Reset);
    }

    public void Follow(BaseInteractionEventArgs hover)
    {
        if(hover.interactorObject is XRPokeInteractor && isEntered)
        {
            isFollowing = true;
        }
    }

    public void Reset(BaseInteractionEventArgs hover)
    {
        if(hover.interactorObject is XRPokeInteractor)
        {
            visualTarget.localPosition = Vector3.Lerp(visualTarget.localPosition, initialLocalPos, Time.deltaTime * 5);
        }
    }

    // Update is called once per frame
    void Update()
    {
        isEntered = Socket.isEntered;
        if (isEntered == false) 
        {
            isFollowing = false;
            visualTarget.localPosition = Vector3.Lerp(visualTarget.localPosition, initialLocalPos, Time.deltaTime * 5);
            
        }
        if (isFollowing)
        {
            visualTarget.localPosition = Vector3.Lerp(visualTarget.localPosition, finishLocalPos, Time.deltaTime * 3);
        }
    }
}
