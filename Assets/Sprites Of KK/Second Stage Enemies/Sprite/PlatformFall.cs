using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFall : MonoBehaviour
{
    private Rigidbody2D rb;
    Vector3 originalPos;
    public Quaternion originalRotationValue;
    float rotationResetSpeed = 0.1f;
    


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
        originalPos = new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        originalRotationValue = transform.rotation; // save the initial rotation
    }

    private IEnumerator OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            yield return new WaitForSeconds(0.5f);
            rb.constraints = RigidbodyConstraints2D.None;
            Invoke("reset", 3f);
        }
    }

    private void Update()
    {

    }

    private void reset()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
        gameObject.transform.position = originalPos;
        transform.rotation = Quaternion.Slerp(transform.rotation, originalRotationValue, Time.time * rotationResetSpeed);
    }

}
