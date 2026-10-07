using System.Collections;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class HandleInteractDoor : XRGrabInteractable
{
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        StartCoroutine(CancleInteractable(args.interactorObject.transform));
    }

    IEnumerator CancleInteractable(Transform handPosition)
    {
        while(true)
        {
            Vector3 distance = this.transform.position - handPosition.position;
            if(distance.magnitude > 0.3f)
            {
                this.enabled = false;
                this.enabled = true;
                yield break;
            }
            yield return null;  
        }
    }
}
