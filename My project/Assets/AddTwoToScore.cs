using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTwoScore : MonoBehaviour
{
    public void AddTwoToScore()
    {
        Singleton.instance.score += 2;
        Debug.Log("The Score Is: " + Singleton.instance.score);
    }
}
