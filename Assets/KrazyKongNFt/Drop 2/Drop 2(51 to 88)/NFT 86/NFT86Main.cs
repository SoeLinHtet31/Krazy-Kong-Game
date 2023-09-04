using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT86Main : MonoBehaviour
{
    public static int NFt86Amount;

    private void Awake()
    {
        NFt86Amount = PlayerPrefs.GetInt("NFt86Amount", 0);
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
