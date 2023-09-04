using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrowerAttackSystem : MonoBehaviour
{
    [SerializeField] private Transform FirePoint;
    [SerializeField] public GameObject Flame;

    public bool isPressed = false;
    public AudioSource FlameSound;

    public static int PCMode;
    public int CheckPCmode;

    private void Start()
    {
        PCMode = 0;
    }
    private void Awake()
    {
    }

    private void Update()
    {
        CheckPCmode = PCMode;
        if (isPressed)
        {

            Attack();
        }


        if (Input.GetMouseButtonDown(0) && PCMode >= 1)
        {
            isPressed = true;
            FlameSound.Play();
        }
        else if (Input.GetMouseButtonUp(0) && PCMode >= 1)
        {
            isPressed = false;
            FlameSound.Stop();
        }
    }

    public void Attack()
    {
        Flame.transform.position = FirePoint.position;
    }

    public void OnKeyPressDown()
    {
        isPressed = true;
        FlameSound.Play();
    }

    public void OnKeyPressUp()
    {
        isPressed = false;
        FlameSound.Stop();
    }
}
