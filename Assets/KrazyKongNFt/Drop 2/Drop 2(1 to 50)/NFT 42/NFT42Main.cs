using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT42Main : MonoBehaviour
{
    public static int NFt42Amount;

    private void Awake()
    {
        NFt42Amount = PlayerPrefs.GetInt("NFt42Amount", 0);
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
