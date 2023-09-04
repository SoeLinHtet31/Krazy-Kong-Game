using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT73Main : MonoBehaviour
{
    public static int NFt73Amount;

    private void Awake()
    {
        NFt73Amount = PlayerPrefs.GetInt("NFt73Amount", 0);
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
