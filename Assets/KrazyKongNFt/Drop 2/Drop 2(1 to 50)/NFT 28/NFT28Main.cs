using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT28Main : MonoBehaviour
{
    public static int NFt28Amount;

    private void Awake()
    {
        NFt28Amount = PlayerPrefs.GetInt("NFt28Amount", 0);
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
