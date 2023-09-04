using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT11Main : MonoBehaviour
{
    public static int NFt11Amount;

    private void Awake()
    {
        NFt11Amount = PlayerPrefs.GetInt("NFt11Amount", 0);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
