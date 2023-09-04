using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT14Main : MonoBehaviour
{
    public static int NFt14Amount;

    private void Awake()
    {
        NFt14Amount = PlayerPrefs.GetInt("NFt14Amount", 0);
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
