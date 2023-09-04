using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    private Transform player;
    public float speed;
    public float MinModifier = 7;
    public float MaxModifier = 11;
    Vector3 _velocity = Vector3.zero;
    bool _isFollowing = false;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void Starfollowing()
    {
        _isFollowing = true;
    }

    void Update()
    {
        if (_isFollowing)
        {
            transform.position = Vector3.SmoothDamp(transform.position,player.position,ref _velocity, Time.deltaTime * Random.Range(MinModifier, MaxModifier));
        }
    }
}
