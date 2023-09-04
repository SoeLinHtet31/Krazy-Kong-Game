using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT39Main : MonoBehaviour
{
    public static int NFt39Amount;

    private void Awake()
    {
        NFt39Amount = PlayerPrefs.GetInt("NFt39Amount", 0);
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
