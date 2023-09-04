using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float speed;
    private float currentPosX;
    private Vector3 velocity = Vector3.zero;

    //follow player
    [SerializeField] private Transform player;
    [SerializeField] private float aheadDistance;
    [SerializeField] private float cameraSpeed;
    private float LookAhead;


    private void Update()
    {
        transform.position = new Vector3(player.position.x + LookAhead, transform.position.y, transform.position.z);
        LookAhead = Mathf.Lerp(LookAhead, (aheadDistance * player.localScale.x), Time.deltaTime * cameraSpeed);
    }
    public void MoveToNewRoom(Transform _newRoom)
    {
        currentPosX = _newRoom.position.x;
    }

}
