using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT6Main : MonoBehaviour
{
    public static int NFt6Amount;

    private void Awake()
    {
        NFt6Amount = PlayerPrefs.GetInt("NFt6Amount", 0);
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
