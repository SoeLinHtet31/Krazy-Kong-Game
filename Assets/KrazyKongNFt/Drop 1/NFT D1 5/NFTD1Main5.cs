using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFTD1Main5 : MonoBehaviour
{
    public static int NFt5D1Amount;

    private void Awake()
    {
        NFt5D1Amount = PlayerPrefs.GetInt("NFt5D1Amount", 0);
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
