using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT81Main : MonoBehaviour
{
    public static int NFt81Amount;

    private void Awake()
    {
        NFt81Amount = PlayerPrefs.GetInt("NFt81Amount", 0);
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
