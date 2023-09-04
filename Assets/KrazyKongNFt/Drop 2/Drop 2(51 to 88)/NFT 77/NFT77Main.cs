using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT77Main : MonoBehaviour
{
    public static int NFt77Amount;

    private void Awake()
    {
        NFt77Amount = PlayerPrefs.GetInt("NFt77Amount", 0);
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
