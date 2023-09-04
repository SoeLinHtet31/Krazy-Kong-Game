using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT66Main : MonoBehaviour
{
    public static int NFt66Amount;

    private void Awake()
    {
        NFt66Amount = PlayerPrefs.GetInt("NFt66Amount", 0);
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
