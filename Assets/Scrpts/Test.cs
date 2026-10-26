using UnityEditor.Timeline;
using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class Test : MonoBehaviour
{
    public Transform end;
    private void Start()
    {
        StartCoroutine(CheckDistance());
    }
    public IEnumerator CheckDistance()
    {
        while(true)
        {
            if(Vector3.Distance(transform.position, end.position) < 0.3f)
            {
                Debug.Log("END!");
                yield break;
            }
            else
            {
                yield return null;
            }
        }
    }
}
