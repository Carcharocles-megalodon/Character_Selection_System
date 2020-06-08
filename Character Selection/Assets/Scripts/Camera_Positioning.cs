using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]

public class Camera_Positioning : MonoBehaviour
{


    [SerializeField]
    private Transform[] waypoints;

    IEnumerator moveCoroutine;
    /*[SerializeField]
    [Range(0f, 1f)]
    private float LerpPct = 0f;*/

    private void Start()
    {
        StartCoroutine(FollowPath());
    }
    IEnumerator FollowPath()
    {
        foreach (Transform waypoint in waypoints)
        {
            yield return StartCoroutine(moveCamara(waypoint.position, 8));
        }
    }
    IEnumerator moveCamara(Vector3 destination, float speed)
    {
        while (transform.position != destination)
        {
            int i = 0;
            i++;
            transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
            //LerpPct++;
            //transform.rotation = Quaternion.Lerp(transform.rotation, waypoints[i].rotation,LerpPct );
            yield return null;
        }
    }
    private void Update()
    {/*
        if (moveCoroutine != null)
        {
            StopCoroutine(moveCoroutine);
        }
        for (int i = 0; i < waypoints.Length; i++)
        {
            moveCoroutine = moveCamara(waypoints[i].position, 2);
            nextPos(waypoints[i + 1]);
            StartCoroutine(moveCoroutine);
        }

    }*/
        
        /*private Transform nextPos(Transform pos)
        {
            if (pos != )
            {
                pos = ;
            }
            else pos = ;
            return pos;
        }*/

        
        //transform.position = Vector3.Lerp(StartPos.position, FinalPos.position, LerpPct);
        //transform.rotation = Quaternion.Lerp(StartPos.rotation, FinalPos.rotation, LerpPct);
    }
}
