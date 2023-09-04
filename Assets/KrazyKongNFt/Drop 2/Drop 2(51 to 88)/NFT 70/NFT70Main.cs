using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT70Main : MonoBehaviour
{
    public static int NFt70Amount;

    private void Awake()
    {
        NFt70Amount = PlayerPrefs.GetInt("NFt70Amount", 0);
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
