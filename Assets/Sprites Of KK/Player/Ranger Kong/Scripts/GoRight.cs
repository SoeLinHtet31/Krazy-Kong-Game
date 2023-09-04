using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoRight : MonoBehaviour
{
    public Transform Player;

    private void OnMouseDown()
    {


        Player.transform.position += new Vector3(10, 0, 0) * Time.deltaTime;

    }
}
