using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   public void AddToScore()
    {
        Singleton.instance.score++;
        Debug.Log("The Score Is: " + Singleton.instance.score);
    }
}
