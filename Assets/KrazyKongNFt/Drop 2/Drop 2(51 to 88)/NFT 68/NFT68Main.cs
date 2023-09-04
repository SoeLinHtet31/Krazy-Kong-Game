using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT68Main : MonoBehaviour
{
    public static int NFt68Amount;

    private void Awake()
    {
        NFt68Amount = PlayerPrefs.GetInt("NFt68Amount", 0);
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
