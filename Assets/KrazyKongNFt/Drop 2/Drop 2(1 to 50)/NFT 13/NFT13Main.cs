using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT13Main : MonoBehaviour
{
    public static int NFt13Amount;

    private void Awake()
    {
        NFt13Amount = PlayerPrefs.GetInt("NFt13Amount", 0);
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
