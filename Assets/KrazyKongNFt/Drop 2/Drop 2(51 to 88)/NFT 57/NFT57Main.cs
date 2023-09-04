using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT57Main : MonoBehaviour
{
    public static int NFt57Amount;

    private void Awake()
    {
        NFt57Amount = PlayerPrefs.GetInt("NFt57Amount", 0);
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
