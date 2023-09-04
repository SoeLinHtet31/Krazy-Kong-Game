using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT67Main : MonoBehaviour
{
    public static int NFt67Amount;

    private void Awake()
    {
        NFt67Amount = PlayerPrefs.GetInt("NFt67Amount", 0);
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
