using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT43Main : MonoBehaviour
{
    public static int NFt43Amount;

    private void Awake()
    {
        NFt43Amount = PlayerPrefs.GetInt("NFt43Amount", 0);
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
