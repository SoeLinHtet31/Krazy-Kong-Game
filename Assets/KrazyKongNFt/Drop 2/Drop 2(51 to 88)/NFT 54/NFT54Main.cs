using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT54Main : MonoBehaviour
{
    public static int NFt54Amount;

    private void Awake()
    {
        NFt54Amount = PlayerPrefs.GetInt("NFt54Amount", 0);
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
