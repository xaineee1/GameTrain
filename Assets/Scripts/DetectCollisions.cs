using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        ScoreCount.scoreValue += 1;
        Destroy(other.gameObject);
    }
}
