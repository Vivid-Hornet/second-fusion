using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Rail rail;

    private int currentSeq;
    private float transition;
    private bool isCompleted;

    private void Update()
     {
         if (!rail)
         return;

         if(!isCompleted)
         Play();
    }
    private void Play()
    {
        transition += Time.deltaTime * 1 / 2.5f;
        if (transition > 1)
        {
            transition = 0;
            currentSeq++;
        }
        else if(transition < 0)
        {
            transition = 1;
            currentSeq--;
        }
        
        transform.position = rail.LinearPosition(currentSeq, transition);
        transform.rotation = rail.Orientation(currentSeq, transition);

        }
    }

